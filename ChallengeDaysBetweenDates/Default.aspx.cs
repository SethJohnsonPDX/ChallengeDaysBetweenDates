using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // http://is.gd/timespan


            DateTime selectedDateOne = calOne.SelectedDate;
            DateTime selectedDateTwo = calTwo.SelectedDate;

            TimeSpan DayDifference = selectedDateTwo - selectedDateOne;
            int DayDiffDateTime = DayDifference.Days;

            if (DayDiffDateTime > 0)
            {
                resultLabel.Text = DayDiffDateTime.ToString() + " days have elapsed.";
            }
            
            else
            {
                resultLabel.Text = "Second date must be after the first...please select again.";
            }


        }
    }
}