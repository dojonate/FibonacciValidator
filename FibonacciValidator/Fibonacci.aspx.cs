using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FibonacciValidator.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            output.Text = "The Fibonacci series for your" + "<br />" + "input integer will be placed here";
        }

        protected void userInput_TextChanged(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                uint lastNum = 1;
                uint twoNumsAgo = 1;
                uint currentNum = 1;
                output.Text = "The Fibonacci series is: ";
                for (int i = 0; i < uint.Parse(userInput.Text) + 1; i++)
                {
                    if (Trace.IsEnabled)
                    {
                        Trace.Write("Iteration " + (i + 1).ToString() + ": i=" + i.ToString() + "; f(i)=" + currentNum.ToString());
                    }
                    if (i > 1)
                    {
                        currentNum = lastNum + twoNumsAgo;
                        output.Text += ", " + (currentNum).ToString();

                        twoNumsAgo = lastNum;
                        lastNum = currentNum;
                    }
                    else
                    {
                        if (i == 1)
                            output.Text += ", ";
                        output.Text += "1";
                    }
                }
            }
        }

        protected void checkRange(object source, ServerValidateEventArgs args)
        {
            int test = 0;
            if (int.Parse(userInput.Text) < 0)
            {
                inputValidator.Text = "Please enter a " + "<b>" + "positive" + "</b>" + "integer";
                args.IsValid = false;
            }
            else if (int.Parse(userInput.Text) > 30)
            {
                args.IsValid = false;
                inputValidator.Text = "That will take too long to calculate." + "<br />" + "Please enter a smaller integer.";
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}