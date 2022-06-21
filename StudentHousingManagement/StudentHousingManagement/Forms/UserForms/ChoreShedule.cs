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
using StudentHousingManagement;

namespace StudentHousingManagementForms
{
    public partial class ChoreShedule : Form
    {
        int month, year;

        public static int Static_Month, Static_Year;

        User user;

        public ChoreShedule(User user)
        {
            InitializeComponent();
            this.user = user;
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

            Static_Month = month;
            Static_Year = year;

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
                UserControlDays ucDays = new UserControlDays(user);
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

            Static_Month = month;
            Static_Year = year;

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
                UserControlDays ucDays = new UserControlDays(user);
                ucDays.Days(i);
                daysContainer.Controls.Add(ucDays);
            }
            ChangeElementsSize();


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

            Static_Month = month;
            Static_Year = year;

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
                UserControlDays ucDays = new UserControlDays(user);
                ucDays.Days(i);
                daysContainer.Controls.Add(ucDays);
            }
            ChangeElementsSize();

        }

        public void ChangeElementsSize()
        {
            if (this.Size.Width > 1100)
            {
                foreach (Label lbl in pDaysNames.Controls)
                {
                    lbl.Margin = new Padding(105, 5, 30, 10);
                    lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
                foreach (UserControl uc in daysContainer.Controls)
                {
                    uc.Size = new Size(225, 130);
                }
            }
            else
            {
                foreach (Label lbl in pDaysNames.Controls)
                {
                    lbl.Margin = new Padding(48, 5, 3, 0);
                    lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
                foreach (UserControl uc in daysContainer.Controls)
                {
                    uc.Size = new Size(122, 93);
                }

            }
        }

        private void ChoreShedule_SizeChanged(object sender, EventArgs e)
        {
            ChangeElementsSize();
        }
    }
}
