namespace StudentHousingManagementForms
{
    partial class ChoresForm
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
            this.lboxChores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteChores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lboxChores
            // 
            this.lboxChores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxChores.FormattingEnabled = true;
            this.lboxChores.ItemHeight = 23;
            this.lboxChores.Location = new System.Drawing.Point(38, 92);
            this.lboxChores.Name = "lboxChores";
            this.lboxChores.Size = new System.Drawing.Size(374, 188);
            this.lboxChores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chores:";
            // 
            // btnDeleteChores
            // 
            this.btnDeleteChores.BackColor = System.Drawing.Color.Red;
            this.btnDeleteChores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteChores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteChores.Location = new System.Drawing.Point(197, 299);
            this.btnDeleteChores.Name = "btnDeleteChores";
            this.btnDeleteChores.Size = new System.Drawing.Size(215, 53);
            this.btnDeleteChores.TabIndex = 2;
            this.btnDeleteChores.Text = "Delete Chore";
            this.btnDeleteChores.UseVisualStyleBackColor = false;
            this.btnDeleteChores.Click += new System.EventHandler(this.btnDeleteChores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDate.Location = new System.Drawing.Point(110, 25);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(302, 30);
            this.tbDate.TabIndex = 4;
            // 
            // ChoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 364);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteChores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxChores);
            this.Name = "ChoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoresForm";
            this.Load += new System.EventHandler(this.ChoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxChores;
        private Label label1;
        private Button btnDeleteChores;
        private Label label2;
        private TextBox tbDate;
    }
}