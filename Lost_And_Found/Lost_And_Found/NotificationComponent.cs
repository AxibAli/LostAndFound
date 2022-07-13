using Lost_And_Found.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lost_And_Found
{
    public class NotificationComponent
    {
        //Here we will add a function for register notification (will add sql dependency)
        public void RegisterNotification(DateTime currentTime)
        {
            string conStr = ConfigurationManager.ConnectionStrings["sqlConString"].ConnectionString;
            string sqlCommand = @"SELECT [Message_Id],[Product_Id],[Message_Date],[User_Messages] from [dbo].[Messages_Details] where [Message_Date] > @Message_Date";
            //you can notice here I have added table name like this [dbo].[Contacts] with [dbo], its mendatory when you use Sql Dependency
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand, con);
                cmd.Parameters.AddWithValue("@Message_Date", currentTime);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                cmd.Notification = null;
                SqlDependency sqlDep = new SqlDependency(cmd);
                sqlDep.OnChange += sqlDep_OnChange;
                //we must have to execute the command here
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // nothing need to add here now
                }
            }
        }

        void sqlDep_OnChange(object sender, SqlNotificationEventArgs e)
        {
            //or you can also check => if (e.Info == SqlNotificationInfo.Insert) , if you want notification only for inserted record
            if (e.Type == SqlNotificationType.Change)
            {
                SqlDependency sqlDep = sender as SqlDependency;
                sqlDep.OnChange -= sqlDep_OnChange;

                //from here we will send notification message to client
                var notificationHub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                notificationHub.Clients.All.notify("added");
                //re-register notification
                RegisterNotification(DateTime.Now);
            }
        }

        LostandFoundEntities db = new LostandFoundEntities();
        public List<MessageModel> GetMessages(DateTime afterDate ,long id )
        {
            //return dc.contacts.Where(a => a.AddedOn > afterDate).OrderByDescending(a => a.AddedOn).ToList();

            try
            {
                var request = (from pd in db.Products
                               join m in db.Messages_Details on pd.Product_ID equals m.Product_ID into msg
                               from msgdata in msg.DefaultIfEmpty()
                               join u in db.App_User on msgdata.Sent_By equals u.User_ID
                               where (pd.Product_IsActive == true && pd.Postedby == id )
                               select new
                               {
                                   pd.Product_ID,
                                   pd.Product_Name,
                                   pd.Product_Category,
                                   pd.Product_Location,
                                   pd.Product_Description,
                                   pd.Product_IsActive,
                                   u.User_FullName,
                                   u.User_Contact,
                                   msgdata.Message_ID,
                                   msgdata.User_Messages,
                                   msgdata.Message_Date,
                               }).OrderByDescending(x => x.Message_ID).ToList();


                List<MessageModel> List = request.Select(x => new MessageModel
                {
                    Product_Id = x.Product_ID,
                    User_Message=x.User_Messages,
                    From =x.User_FullName,
                    Contact=x.User_Contact,
                }).ToList();
                return List;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}