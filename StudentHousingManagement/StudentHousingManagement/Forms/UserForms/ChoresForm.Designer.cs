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
            this.btnAddChore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxChores
            // 
            this.lboxChores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxChores.FormattingEnabled = true;
            this.lboxChores.ItemHeight = 23;
            this.lboxChores.Location = new System.Drawing.Point(38, 46);
            this.lboxChores.Name = "lboxChores";
            this.lboxChores.Size = new System.Drawing.Size(374, 234);
            this.lboxChores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chores Scheduled";
            // 
            // btnDeleteChores
            // 
            this.btnDeleteChores.BackColor = System.Drawing.Color.Red;
            this.btnDeleteChores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteChores.Location = new System.Drawing.Point(239, 299);
            this.btnDeleteChores.Name = "btnDeleteChores";
            this.btnDeleteChores.Size = new System.Drawing.Size(173, 42);
            this.btnDeleteChores.TabIndex = 2;
            this.btnDeleteChores.Text = "Delete Chore";
            this.btnDeleteChores.UseVisualStyleBackColor = false;
            // 
            // btnAddChore
            // 
            this.btnAddChore.BackColor = System.Drawing.Color.Lime;
            this.btnAddChore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddChore.Location = new System.Drawing.Point(38, 299);
            this.btnAddChore.Name = "btnAddChore";
            this.btnAddChore.Size = new System.Drawing.Size(173, 42);
            this.btnAddChore.TabIndex = 3;
            this.btnAddChore.Text = "Add Chore";
            this.btnAddChore.UseVisualStyleBackColor = false;
            // 
            // ChoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 364);
            this.Controls.Add(this.btnAddChore);
            this.Controls.Add(this.btnDeleteChores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxChores);
            this.Name = "ChoresForm";
            this.Text = "ChoresForm";
            this.Load += new System.EventHandler(this.ChoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxChores;
        private Label label1;
        private Button btnDeleteChores;
        private Button btnAddChore;
    }
}