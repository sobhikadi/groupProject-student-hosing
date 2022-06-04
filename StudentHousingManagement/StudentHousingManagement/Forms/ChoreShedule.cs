using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StudentHousingManagementForms
{
    public partial class ChoreShedule : Form
    {
        int month, year;

        public ChoreShedule()
        {
            InitializeComponent();
        }

        private void ChoreShedule_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays() 
        {
            DateTime currentDate = DateTime.Now;

            month = currentDate.Month;
            year = currentDate.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthyear.Text = $"{monthName} - {year}";

            DateTime startOfMonth = new DateTime(year, month, 1);
            
            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++) 
            {
               UserControlBlank ucBlank = new UserControlBlank();
               daysContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++) 
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                daysContainer.Controls.Add(ucDays);
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();

            month++;

            if (month > 12) 
            {
                month = 1;
                year++;
            }

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthyear.Text = $"{monthName} - {year}";

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daysContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                daysContainer.Controls.Add(ucDays);
            }

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();

            month--;

            if (month < 1)
            {
                month = 12;
                year--;
            }

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthyear.Text = $"{monthName} - {year}";

            DateTime startOfMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daysContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                daysContainer.Controls.Add(ucDays);
            }
        }
    }
}
