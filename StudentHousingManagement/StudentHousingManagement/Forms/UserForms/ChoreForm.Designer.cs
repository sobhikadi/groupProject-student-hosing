namespace StudentHousingManagementForms
{
    partial class ChoreForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbChore = new System.Windows.Forms.TextBox();
            this.lblChore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(42, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 28);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // tbDate
            // 
            this.tbDate.Enabled = false;
            this.tbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDate.Location = new System.Drawing.Point(116, 25);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(336, 34);
            this.tbDate.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Linen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(165, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Add Chore";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbChore
            // 
            this.tbChore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbChore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbChore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbChore.Location = new System.Drawing.Point(116, 103);
            this.tbChore.Name = "tbChore";
            this.tbChore.Size = new System.Drawing.Size(336, 34);
            this.tbChore.TabIndex = 4;
            this.tbChore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChore_KeyPress);
            // 
            // lblChore
            // 
            this.lblChore.AutoSize = true;
            this.lblChore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChore.Location = new System.Drawing.Point(42, 106);
            this.lblChore.Name = "lblChore";
            this.lblChore.Size = new System.Drawing.Size(68, 28);
            this.lblChore.TabIndex = 3;
            this.lblChore.Text = "Chore:";
            // 
            // ChoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(512, 229);
            this.Controls.Add(this.tbChore);
            this.Controls.Add(this.lblChore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lblDate);
            this.Name = "ChoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoreForm";
            this.Load += new System.EventHandler(this.ChoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDate;
        private TextBox tbDate;
        private Button btnSave;
        private TextBox tbChore;
        private Label lblChore;
    }
}