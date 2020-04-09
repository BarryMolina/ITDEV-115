namespace Molina_SportingEventApp
{
    partial class Form2
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
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblRegisteredName = new System.Windows.Forms.Label();
            this.lblRegisteredSport = new System.Windows.Forms.Label();
            this.lstBxName = new System.Windows.Forms.ListBox();
            this.lstBxSport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(118, 34);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(248, 29);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Registered Children";
            // 
            // lblRegisteredName
            // 
            this.lblRegisteredName.AutoSize = true;
            this.lblRegisteredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredName.Location = new System.Drawing.Point(109, 117);
            this.lblRegisteredName.Name = "lblRegisteredName";
            this.lblRegisteredName.Size = new System.Drawing.Size(52, 18);
            this.lblRegisteredName.TabIndex = 1;
            this.lblRegisteredName.Text = "Name";
            // 
            // lblRegisteredSport
            // 
            this.lblRegisteredSport.AutoSize = true;
            this.lblRegisteredSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredSport.Location = new System.Drawing.Point(325, 117);
            this.lblRegisteredSport.Name = "lblRegisteredSport";
            this.lblRegisteredSport.Size = new System.Drawing.Size(49, 18);
            this.lblRegisteredSport.TabIndex = 2;
            this.lblRegisteredSport.Text = "Sport";
            // 
            // lstBxName
            // 
            this.lstBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxName.FormattingEnabled = true;
            this.lstBxName.ItemHeight = 18;
            this.lstBxName.Location = new System.Drawing.Point(44, 149);
            this.lstBxName.Name = "lstBxName";
            this.lstBxName.Size = new System.Drawing.Size(183, 130);
            this.lstBxName.TabIndex = 5;
            // 
            // lstBxSport
            // 
            this.lstBxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxSport.FormattingEnabled = true;
            this.lstBxSport.ItemHeight = 18;
            this.lstBxSport.Location = new System.Drawing.Point(258, 149);
            this.lstBxSport.Name = "lstBxSport";
            this.lstBxSport.Size = new System.Drawing.Size(183, 130);
            this.lstBxSport.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(485, 425);
            this.Controls.Add(this.lstBxSport);
            this.Controls.Add(this.lstBxName);
            this.Controls.Add(this.lblRegisteredSport);
            this.Controls.Add(this.lblRegisteredName);
            this.Controls.Add(this.lblTitle2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblRegisteredName;
        private System.Windows.Forms.Label lblRegisteredSport;
        private System.Windows.Forms.ListBox lstBxName;
        private System.Windows.Forms.ListBox lstBxSport;
    }
}