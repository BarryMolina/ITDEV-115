namespace Molina_Assignment11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBxNames = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBxState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBxZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pctrBxPhone = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(223, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Address Book";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(113, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Last Name";
            // 
            // cmbBxNames
            // 
            this.cmbBxNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxNames.FormattingEnabled = true;
            this.cmbBxNames.Location = new System.Drawing.Point(43, 179);
            this.cmbBxNames.Name = "cmbBxNames";
            this.cmbBxNames.Size = new System.Drawing.Size(244, 28);
            this.cmbBxNames.Sorted = true;
            this.cmbBxNames.TabIndex = 2;
            this.cmbBxNames.SelectedIndexChanged += new System.EventHandler(this.cmbBxNames_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(266, 223);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(55, 20);
            this.lblContactName.TabIndex = 5;
            this.lblContactName.Text = "Name:";
            this.lblContactName.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(344, 221);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(207, 24);
            this.txtBxName.TabIndex = 6;
            this.txtBxName.Visible = false;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAddress.Location = new System.Drawing.Point(344, 251);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(207, 24);
            this.txtBxAddress.TabIndex = 8;
            this.txtBxAddress.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(249, 253);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            this.lblAddress.Visible = false;
            // 
            // txtBxCity
            // 
            this.txtBxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCity.Location = new System.Drawing.Point(344, 281);
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(207, 24);
            this.txtBxCity.TabIndex = 10;
            this.txtBxCity.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(282, 283);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City:";
            this.lblCity.Visible = false;
            // 
            // txtBxState
            // 
            this.txtBxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxState.Location = new System.Drawing.Point(344, 311);
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(207, 24);
            this.txtBxState.TabIndex = 12;
            this.txtBxState.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(269, 313);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 20);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "State:";
            this.lblState.Visible = false;
            // 
            // txtBxZip
            // 
            this.txtBxZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxZip.Location = new System.Drawing.Point(344, 341);
            this.txtBxZip.Name = "txtBxZip";
            this.txtBxZip.Size = new System.Drawing.Size(207, 24);
            this.txtBxZip.TabIndex = 14;
            this.txtBxZip.Visible = false;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(244, 343);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(77, 20);
            this.lblZip.TabIndex = 13;
            this.lblZip.Text = "Zip Code:";
            this.lblZip.Visible = false;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPhone.Location = new System.Drawing.Point(344, 371);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(207, 24);
            this.txtBxPhone.TabIndex = 16;
            this.txtBxPhone.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(202, 373);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(119, 20);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.Visible = false;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxEmail.Location = new System.Drawing.Point(344, 401);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(207, 24);
            this.txtBxEmail.TabIndex = 18;
            this.txtBxEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(206, 403);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 20);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.Visible = false;
            // 
            // pctrBxPhone
            // 
            this.pctrBxPhone.ErrorImage = null;
            this.pctrBxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pctrBxPhone.Image")));
            this.pctrBxPhone.InitialImage = null;
            this.pctrBxPhone.Location = new System.Drawing.Point(308, 179);
            this.pctrBxPhone.Name = "pctrBxPhone";
            this.pctrBxPhone.Size = new System.Drawing.Size(303, 282);
            this.pctrBxPhone.TabIndex = 4;
            this.pctrBxPhone.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(623, 486);
            this.Controls.Add(this.pctrBxPhone);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBxZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtBxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtBxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.cmbBxNames);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Molina Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBxNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBxState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtBxZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pctrBxPhone;
    }
}

