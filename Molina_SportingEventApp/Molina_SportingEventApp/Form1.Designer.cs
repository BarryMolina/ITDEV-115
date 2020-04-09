namespace Molina_SportingEventApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmBxState = new System.Windows.Forms.ComboBox();
            this.rdBtnRugby = new System.Windows.Forms.RadioButton();
            this.rdBtnLacrosse = new System.Windows.Forms.RadioButton();
            this.rdBtnPolo = new System.Windows.Forms.RadioButton();
            this.rdButtonFrisbee = new System.Windows.Forms.RadioButton();
            this.rdBtnCurling = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.picBxRugby = new System.Windows.Forms.PictureBox();
            this.sportSelected = new System.Windows.Forms.TextBox();
            this.picBxPolo = new System.Windows.Forms.PictureBox();
            this.picBxLacrosse = new System.Windows.Forms.PictureBox();
            this.picBxFrisbee = new System.Windows.Forms.PictureBox();
            this.picBxCurling = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRugby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLacrosse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFrisbee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCurling)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(43, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Midwest Intramural Sports Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(48, 147);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(109, 18);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(48, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 18);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(375, 178);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 18);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 24);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(158, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(158, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 24);
            this.textBox3.TabIndex = 8;
            // 
            // cmBxState
            // 
            this.cmBxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxState.FormattingEnabled = true;
            this.cmBxState.Items.AddRange(new object[] {
            "AK",
            "AR",
            "AZ",
            "GA",
            "IL",
            "MN",
            "NC",
            "WI"});
            this.cmBxState.Location = new System.Drawing.Point(423, 176);
            this.cmBxState.Name = "cmBxState";
            this.cmBxState.Size = new System.Drawing.Size(76, 26);
            this.cmBxState.Sorted = true;
            this.cmBxState.TabIndex = 9;
            // 
            // rdBtnRugby
            // 
            this.rdBtnRugby.AutoSize = true;
            this.rdBtnRugby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnRugby.Location = new System.Drawing.Point(6, 23);
            this.rdBtnRugby.Name = "rdBtnRugby";
            this.rdBtnRugby.Size = new System.Drawing.Size(68, 22);
            this.rdBtnRugby.TabIndex = 10;
            this.rdBtnRugby.TabStop = true;
            this.rdBtnRugby.Text = "Rugby";
            this.rdBtnRugby.UseVisualStyleBackColor = true;
            this.rdBtnRugby.CheckedChanged += new System.EventHandler(this.rdBtnRugby_CheckedChanged);
            // 
            // rdBtnLacrosse
            // 
            this.rdBtnLacrosse.AutoSize = true;
            this.rdBtnLacrosse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnLacrosse.Location = new System.Drawing.Point(6, 51);
            this.rdBtnLacrosse.Name = "rdBtnLacrosse";
            this.rdBtnLacrosse.Size = new System.Drawing.Size(88, 22);
            this.rdBtnLacrosse.TabIndex = 11;
            this.rdBtnLacrosse.TabStop = true;
            this.rdBtnLacrosse.Text = "Lacrosse";
            this.rdBtnLacrosse.UseVisualStyleBackColor = true;
            this.rdBtnLacrosse.CheckedChanged += new System.EventHandler(this.rdBtnLacrosse_CheckedChanged);
            // 
            // rdBtnPolo
            // 
            this.rdBtnPolo.AutoSize = true;
            this.rdBtnPolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnPolo.Location = new System.Drawing.Point(6, 79);
            this.rdBtnPolo.Name = "rdBtnPolo";
            this.rdBtnPolo.Size = new System.Drawing.Size(57, 22);
            this.rdBtnPolo.TabIndex = 12;
            this.rdBtnPolo.TabStop = true;
            this.rdBtnPolo.Text = "Polo";
            this.rdBtnPolo.UseVisualStyleBackColor = true;
            this.rdBtnPolo.CheckedChanged += new System.EventHandler(this.rdBtnPolo_CheckedChanged);
            // 
            // rdButtonFrisbee
            // 
            this.rdButtonFrisbee.AutoSize = true;
            this.rdButtonFrisbee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdButtonFrisbee.Location = new System.Drawing.Point(6, 107);
            this.rdButtonFrisbee.Name = "rdButtonFrisbee";
            this.rdButtonFrisbee.Size = new System.Drawing.Size(133, 22);
            this.rdButtonFrisbee.TabIndex = 13;
            this.rdButtonFrisbee.TabStop = true;
            this.rdButtonFrisbee.Text = "Ultimate Frisbee";
            this.rdButtonFrisbee.UseVisualStyleBackColor = true;
            this.rdButtonFrisbee.CheckedChanged += new System.EventHandler(this.rdButtonFrisbee_CheckedChanged);
            // 
            // rdBtnCurling
            // 
            this.rdBtnCurling.AutoSize = true;
            this.rdBtnCurling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCurling.Location = new System.Drawing.Point(6, 135);
            this.rdBtnCurling.Name = "rdBtnCurling";
            this.rdBtnCurling.Size = new System.Drawing.Size(72, 22);
            this.rdBtnCurling.TabIndex = 14;
            this.rdBtnCurling.TabStop = true;
            this.rdBtnCurling.Text = "Curling";
            this.rdBtnCurling.UseVisualStyleBackColor = true;
            this.rdBtnCurling.CheckedChanged += new System.EventHandler(this.rdBtnCurling_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnPolo);
            this.groupBox1.Controls.Add(this.rdBtnCurling);
            this.groupBox1.Controls.Add(this.rdBtnRugby);
            this.groupBox1.Controls.Add(this.rdButtonFrisbee);
            this.groupBox1.Controls.Add(this.rdBtnLacrosse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sporting Events";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Red;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Yellow;
            this.btnRegister.Location = new System.Drawing.Point(217, 440);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 32);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // picBxRugby
            // 
            this.picBxRugby.Image = ((System.Drawing.Image)(resources.GetObject("picBxRugby.Image")));
            this.picBxRugby.Location = new System.Drawing.Point(290, 233);
            this.picBxRugby.Name = "picBxRugby";
            this.picBxRugby.Size = new System.Drawing.Size(209, 139);
            this.picBxRugby.TabIndex = 17;
            this.picBxRugby.TabStop = false;
            this.picBxRugby.Visible = false;
            // 
            // sportSelected
            // 
            this.sportSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportSelected.Location = new System.Drawing.Point(290, 378);
            this.sportSelected.Name = "sportSelected";
            this.sportSelected.Size = new System.Drawing.Size(209, 24);
            this.sportSelected.TabIndex = 18;
            this.sportSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sportSelected.Visible = false;
            // 
            // picBxPolo
            // 
            this.picBxPolo.BackColor = System.Drawing.Color.Black;
            this.picBxPolo.Image = ((System.Drawing.Image)(resources.GetObject("picBxPolo.Image")));
            this.picBxPolo.Location = new System.Drawing.Point(290, 233);
            this.picBxPolo.Name = "picBxPolo";
            this.picBxPolo.Size = new System.Drawing.Size(209, 139);
            this.picBxPolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxPolo.TabIndex = 19;
            this.picBxPolo.TabStop = false;
            this.picBxPolo.Visible = false;
            // 
            // picBxLacrosse
            // 
            this.picBxLacrosse.Image = ((System.Drawing.Image)(resources.GetObject("picBxLacrosse.Image")));
            this.picBxLacrosse.Location = new System.Drawing.Point(290, 233);
            this.picBxLacrosse.Name = "picBxLacrosse";
            this.picBxLacrosse.Size = new System.Drawing.Size(209, 139);
            this.picBxLacrosse.TabIndex = 20;
            this.picBxLacrosse.TabStop = false;
            this.picBxLacrosse.Visible = false;
            // 
            // picBxFrisbee
            // 
            this.picBxFrisbee.Image = ((System.Drawing.Image)(resources.GetObject("picBxFrisbee.Image")));
            this.picBxFrisbee.Location = new System.Drawing.Point(290, 233);
            this.picBxFrisbee.Name = "picBxFrisbee";
            this.picBxFrisbee.Size = new System.Drawing.Size(209, 139);
            this.picBxFrisbee.TabIndex = 21;
            this.picBxFrisbee.TabStop = false;
            this.picBxFrisbee.Visible = false;
            // 
            // picBxCurling
            // 
            this.picBxCurling.Image = ((System.Drawing.Image)(resources.GetObject("picBxCurling.Image")));
            this.picBxCurling.Location = new System.Drawing.Point(290, 233);
            this.picBxCurling.Name = "picBxCurling";
            this.picBxCurling.Size = new System.Drawing.Size(209, 139);
            this.picBxCurling.TabIndex = 22;
            this.picBxCurling.TabStop = false;
            this.picBxCurling.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(551, 484);
            this.Controls.Add(this.picBxCurling);
            this.Controls.Add(this.picBxFrisbee);
            this.Controls.Add(this.picBxLacrosse);
            this.Controls.Add(this.picBxPolo);
            this.Controls.Add(this.sportSelected);
            this.Controls.Add(this.picBxRugby);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmBxState);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sporting Event Sign Up Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRugby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLacrosse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxFrisbee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCurling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmBxState;
        private System.Windows.Forms.RadioButton rdBtnRugby;
        private System.Windows.Forms.RadioButton rdBtnLacrosse;
        private System.Windows.Forms.RadioButton rdBtnPolo;
        private System.Windows.Forms.RadioButton rdButtonFrisbee;
        private System.Windows.Forms.RadioButton rdBtnCurling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox picBxRugby;
        private System.Windows.Forms.TextBox sportSelected;
        private System.Windows.Forms.PictureBox picBxPolo;
        private System.Windows.Forms.PictureBox picBxLacrosse;
        private System.Windows.Forms.PictureBox picBxFrisbee;
        private System.Windows.Forms.PictureBox picBxCurling;
    }
}

