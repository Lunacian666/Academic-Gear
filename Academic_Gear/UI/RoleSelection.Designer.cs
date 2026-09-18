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
            this.lblPleaseSelect.Location = new System.Drawing.Point(268, 163);
            this.lblPleaseSelect.Name = "lblPleaseSelect";
            this.lblPleaseSelect.Size = new System.Drawing.Size(270, 19);
            this.lblPleaseSelect.TabIndex = 1;
            this.lblPleaseSelect.Text = "Please select your role to continue.";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(230, 196);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(154, 75);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCashier
            // 
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCashier.Location = new System.Drawing.Point(405, 196);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(154, 75);
            this.btnCashier.TabIndex = 3;
            this.btnCashier.Text = "CASHIER";
            this.btnCashier.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(322, 297);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(145, 25);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue ->";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(175, 114);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(163, 30);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to ";
            // 
            // lblAcademicGear
            // 
            this.lblAcademicGear.AutoSize = true;
            this.lblAcademicGear.BackColor = System.Drawing.Color.Transparent;
            this.lblAcademicGear.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicGear.Location = new System.Drawing.Point(335, 110);
            this.lblAcademicGear.Name = "lblAcademicGear";
            this.lblAcademicGear.Size = new System.Drawing.Size(301, 32);
            this.lblAcademicGear.TabIndex = 6;
            this.lblAcademicGear.Text = "Academic Gear";
            // 
            // RoleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAcademicGear);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblPleaseSelect);
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