using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Cars.xml");

            XDocument doc = new XDocument(
                new XElement("Cars", 
                    new XElement("Detail", 
                        new XElement("Name", "I20"), 
                        new XElement("Make", "Hyundai"), 
                        new XElement("Price", "700000")
                    ),
                    new XElement("Detail",
                        new XElement("Name", "I20"),
                        new XElement("Make", "Hyundai"),
                        new XElement("Price", "700000")
                    )
                )
            );

            doc.Save(file);
        }
    }
}