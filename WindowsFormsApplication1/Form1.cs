using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AutomationElement desktopObject = AutomationElement.RootElement;

                var browserName = new PropertyCondition(AutomationElement.NameProperty, "Go");
                AutomationElement browserWindow = desktopObject.FindFirst(TreeScope.Children, browserName);

                var cfDialogName = new PropertyCondition(AutomationElement.NameProperty, "Choose File to Upload");
                AutomationElement cfDialogWindow = browserWindow.FindFirst(TreeScope.Children, cfDialogName);

                var txtFileNameCondition = new AndCondition(
                               new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit),
                               new PropertyCondition(AutomationElement.AutomationIdProperty, "1148")
                               );

                var txtFileName = cfDialogWindow.FindFirst(TreeScope.Descendants, txtFileNameCondition);
                ValuePattern value = txtFileName.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                value.SetValue(@"C:\Users\ivan\Desktop\87061027.jpg");


                var buttonCondition = new AndCondition(
                        new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Button),
                        new PropertyCondition(AutomationElement.NameProperty, "Cancel")
                    );

                var openButton = browserWindow.FindFirst(TreeScope.Descendants, buttonCondition);
                openButton.SetFocus();
                SendKeys.Send("{ENTER}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error seleccionando archivo: " + ex.Message);
            }
            

            MessageBox.Show("El archivo fue seleccionado");
        }
    }
}
