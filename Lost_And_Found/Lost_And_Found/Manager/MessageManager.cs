using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lost_And_Found.Models;


namespace Lost_And_Found.Manager
{
    public class MessageManager
    {
        LostandFoundEntities db = new LostandFoundEntities();
        long msgid = 0;

        public long addmsg(MessageModel mm)
        {
            try
            {
                Messages_Details tblmsg = new Messages_Details();
                tblmsg.Message_ID = mm.Message_Id;
                tblmsg.Product_ID = mm.Product_Id;
                tblmsg.Message_Date = mm.Meassage_Date;
                tblmsg.Sent_By = mm.Sent_By;
                tblmsg.User_Messages = mm.User_Message;
                
                db.Messages_Details.Add(tblmsg);
                db.SaveChanges();
                msgid = tblmsg.Message_ID;
                return msgid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}