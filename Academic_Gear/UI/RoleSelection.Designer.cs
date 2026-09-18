namespace UI
{
    partial class RoleSelection
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
            this.lblPleaseSelect = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAcademicGear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPleaseSelect
            // 
            this.lblPleaseSelect.AutoSize = true;
            this.lblPleaseSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelect.Location = new System.Drawing.Point(181, 131);
            this.lblPleaseSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPleaseSelect.Name = "lblPleaseSelect";
            this.lblPleaseSelect.Size = new System.Drawing.Size(229, 16);
            this.lblPleaseSelect.TabIndex = 1;
            this.lblPleaseSelect.Text = "Please select your role to continue.";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(172, 159);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(116, 61);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCashier.Location = new System.Drawing.Point(304, 159);
            this.btnCashier.Margin = new System.Windows.Forms.Padding(2);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(116, 61);
            this.btnCashier.TabIndex = 3;
            this.btnCashier.Text = "CASHIER";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(242, 241);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(109, 20);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue ->";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(151, 93);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(130, 24);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to ";
            // 
            // lblAcademicGear
            // 
            this.lblAcademicGear.AutoSize = true;
            this.lblAcademicGear.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademicGear.Font = new System.Drawing.Font("Segoe UI Symbol", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicGear.Location = new System.Drawing.Point(272, 86);
            this.lblAcademicGear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicGear.Name = "lblAcademicGear";
            this.lblAcademicGear.Size = new System.Drawing.Size(182, 31);
            this.lblAcademicGear.TabIndex = 6;
            this.lblAcademicGear.Text = "Academic Gear";
            // 
            // RoleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblAcademicGear);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblPleaseSelect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoleSelection";
            this.Text = "RoleSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPleaseSelect;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAcademicGear;
    }
}