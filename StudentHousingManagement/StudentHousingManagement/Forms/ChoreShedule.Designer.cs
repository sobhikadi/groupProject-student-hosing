namespace StudentHousingManagementForms
{
    partial class ChoreShedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.daysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonthyear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(797, 668);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(677, 668);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(94, 29);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(163, 44);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(63, 20);
            this.lblMonday.TabIndex = 3;
            this.lblMonday.Text = "Monday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(37, 44);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(57, 20);
            this.lblSunday.TabIndex = 4;
            this.lblSunday.Text = "Sunday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(287, 44);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(63, 20);
            this.lblTuesday.TabIndex = 5;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(797, 44);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(67, 20);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(679, 44);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(49, 20);
            this.lblFriday.TabIndex = 7;
            this.lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(543, 44);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(68, 20);
            this.lblThursday.TabIndex = 8;
            this.lblThursday.Text = "Thursday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(407, 44);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(85, 20);
            this.lblWednesday.TabIndex = 9;
            this.lblWednesday.Text = "Wednesday";
            // 
            // daysContainer
            // 
            this.daysContainer.Location = new System.Drawing.Point(2, 70);
            this.daysContainer.Name = "daysContainer";
            this.daysContainer.Size = new System.Drawing.Size(901, 592);
            this.daysContainer.TabIndex = 10;
            // 
            // lblMonthyear
            // 
            this.lblMonthyear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonthyear.Location = new System.Drawing.Point(261, 9);
            this.lblMonthyear.Name = "lblMonthyear";
            this.lblMonthyear.Size = new System.Drawing.Size(378, 24);
            this.lblMonthyear.TabIndex = 11;
            this.lblMonthyear.Text = "MONTH YEAR";
            this.lblMonthyear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoreShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 699);
            this.Controls.Add(this.lblMonthyear);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.lblSunday);
            this.Controls.Add(this.daysContainer);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.lblSaturday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChoreShedule";
            this.Text = "ChoreShedule";
            this.Load += new System.EventHandler(this.ChoreShedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnNext;
        private Button btnPrevious;
        private Label lblMonday;
        private Label lblSunday;
        private Label lblTuesday;
        private Label lblSaturday;
        private Label lblFriday;
        private Label lblThursday;
        private Label lblWednesday;
        private FlowLayoutPanel daysContainer;
        private Label lblMonthyear;
    }
}