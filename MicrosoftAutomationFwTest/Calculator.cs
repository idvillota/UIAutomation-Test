using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftAutomationFwTest
{
    //public class Calculator
    //{
    //    private Process _calculatorProcess;

    //    public Calculator()
    //    {
    //        _calculatorProcess = Process.Start("Calc.exe");
    //        int ct = 0;

    //        do
    //        {
    //            _calculatorAutomationElement = AutomationElement.RootElement.FindFirst
    //        (TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty,
    //        "Calculator"));

    //            ++ct;
    //            Thread.Sleep(100);
    //        }
    //        while (_calculatorAutomationElement == null && ct < 50);


    //        if (_calculatorAutomationElement == null)
    //        {
    //            throw new InvalidOperationException("Calculator must be running");
    //        }

    //        _resultTextBoxAutomationElement = _calculatorAutomationElement.FindFirst
    //        (TreeScope.Descendants, new PropertyCondition
    //        (AutomationElement.AutomationIdProperty, "150"));

    //        if (_resultTextBoxAutomationElement == null)
    //        {
    //            throw new InvalidOperationException("Could not find result box");
    //        }

    //        GetInvokePattern(GetFunctionButton(Functions.Clear)).Invoke();
    //    }
    //}
}
