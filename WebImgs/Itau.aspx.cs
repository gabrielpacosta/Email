using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebImgs
{
    public partial class Itau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var messageId = Request.QueryString["msg_id"];

            if (!string.IsNullOrEmpty(messageId))
            {
                // do something.. like update the database that the message 
                // is read by the recipient.
            }

            Response.ContentType = "image/JPEG";
            Response.WriteFile("https://image.ibb.co/bvExQR/Itau.jpg");
            Response.End();
        }
    }
}