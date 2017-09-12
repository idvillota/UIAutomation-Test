using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace MicrosoftAutomationFwTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.txtUrl.Text = "file:///C:/Users/ivan/Desktop/Index.html";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var url = this.txtUrl.Text;
            this.webBrowser1.Navigate(url);

        }

        private void btnSetValue_Click(object sender, EventArgs e)
        {
            HtmlDocument document = this.webBrowser1.Document;

            //mshtml.IHTMLDocument2 iDoc = (mshtml.IHTMLDocument2)webBrowser1.Document.DomDocument;

            //var x = iDoc.ge

            //System.Web.UI.HtmlControls.HtmlInputFile myFile = new System.Web.UI.HtmlControls.HtmlInputFile();
            //myFile.Value = @"C:\Users\ivan\Desktop\87061027.jpg";
            //myFile.PostedFile


            var file = document.GetElementById("fileToUpload");
            //var value = file.GetAttribute("value");
            //file.SetAttribute("value", myFile.ToString());

            //HtmlInputFile x = (HtmlInputFile)document.GetElementById("fileToUpload");

            //System.Windows.Forms.HtmlElement

            //var x =file.GetAttribute("type");

            //foreach (HtmlElement elem in document.GetElementsByTagName("input"))
            //{
            //    //elem.Focus();
            //    //SendKeys.SendWait(@"C:\Users\ivan\Desktop\87061027.jpg");
            //    if (elem.GetAttribute("type") == "file")
            //    {
            //        //elem.Focus();
            //        //SendKeys.SendWait(@"C:\Users\ivan\Desktop\87061027.jpg");
            //        //elem.SetAttribute("value", @"C:\Users\ivan\Desktop\87061027.jpg");
            //        webBrowser1.Document.GetElementById("fileToUpload").InvokeMember("click");
            //        //SendKeys.SendWait(@"C:\Users\ivan\Desktop\87061027.jpg");
            //        SendKeys.Send(@"C:\Users\ivan\Desktop\87061027.jpg");
            //    }
            //}


            //var txtName = document.GetElementById("txtName");
            //txtName.SetAttribute("Value", "idv...");
            //var file = document.GetElementById("fileToUpload");

            //file.SetAttribute("InnerText",@"C:\Users\ivan\Desktop\87061027.jpg");
            //file.SetAttribute("innertext", @"C:\Users\ivan\Desktop\87061027.jpg");
            //file.OuterHtml = @"< INPUT id = fileToUpload type = file value = C:\Users\ivan\Desktop\87061027.jpg name = fileToUpload >";
            //file.OuterText = @"< INPUT id = fileToUpload type = file value = C:\Users\ivan\Desktop\87061027.jpg name = fileToUpload >";
            //file.SetAttribute("Value", @"C:\Users\ivan\Desktop\87061027.jpg");

        }
    }
}
