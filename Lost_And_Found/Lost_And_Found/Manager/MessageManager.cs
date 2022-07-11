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
                Message tblmsg = new Message();
                tblmsg.Message_ID = mm.Message_Id;
                tblmsg.Product_ID = mm.Product_Id;
                tblmsg.Message_Date = mm.Meassage_Date;
                tblmsg.Sent_By = mm.Sent_By;
                tblmsg.Messages = mm.Message;
                
                db.Messages.Add(tblmsg);
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