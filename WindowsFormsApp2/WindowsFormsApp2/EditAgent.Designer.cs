
namespace WindowsFormsApp2
{
    partial class EditAgent
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
            this.label1 = new System.Windows.Forms.Label();
            this.AgentLogoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AgentDirectorLabel = new System.Windows.Forms.Label();
            this.AgentKPPLabel = new System.Windows.Forms.Label();
            this.AgentINNLabel = new System.Windows.Forms.Label();
            this.PriorityBox = new System.Windows.Forms.NumericUpDown();
            this.AddLogo = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AgentDirectorBox = new System.Windows.Forms.TextBox();
            this.AgentKPPBox = new System.Windows.Forms.TextBox();
            this.AgentINNBox = new System.Windows.Forms.TextBox();
            this.AgentAddressBox = new System.Windows.Forms.RichTextBox();
            this.AgentAddressLabel = new System.Windows.Forms.Label();
            this.AgentTypeBox = new System.Windows.Forms.ComboBox();
            this.AgentTypeLabel = new System.Windows.Forms.Label();
            this.TitleAgentBox = new System.Windows.Forms.TextBox();
            this.TitleAgentLabel = new System.Windows.Forms.Label();
            this.EditAgentBtn = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Приоритет Агента";
            // 
            // AgentLogoLabel
            // 
            this.AgentLogoLabel.AutoSize = true;
            this.AgentLogoLabel.Location = new System.Drawing.Point(278, 175);
            this.AgentLogoLabel.Name = "AgentLogoLabel";
            this.AgentLogoLabel.Size = new System.Drawing.Size(87, 13);
            this.AgentLogoLabel.TabIndex = 42;
            this.AgentLogoLabel.Text = "Логотип Агента";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(278, 115);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 13);
            this.EmailLabel.TabIndex = 41;
            this.EmailLabel.Text = "Эл. Почта";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(272, 71);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneLabel.TabIndex = 40;
            this.PhoneLabel.Text = "Номер телефона";
            // 
            // AgentDirectorLabel
            // 
            this.AgentDirectorLabel.AutoSize = true;
            this.AgentDirectorLabel.Location = new System.Drawing.Point(278, 16);
            this.AgentDirectorLabel.Name = "AgentDirectorLabel";
            this.AgentDirectorLabel.Size = new System.Drawing.Size(57, 13);
            this.AgentDirectorLabel.TabIndex = 39;
            this.AgentDirectorLabel.Text = "Директор";
            // 
            // AgentKPPLabel
            // 
            this.AgentKPPLabel.AutoSize = true;
            this.AgentKPPLabel.Location = new System.Drawing.Point(63, 339);
            this.AgentKPPLabel.Name = "AgentKPPLabel";
            this.AgentKPPLabel.Size = new System.Drawing.Size(68, 13);
            this.AgentKPPLabel.TabIndex = 38;
            this.AgentKPPLabel.Text = "КПП Агента";
            // 
            // AgentINNLabel
            // 
            this.AgentINNLabel.AutoSize = true;
            this.AgentINNLabel.Location = new System.Drawing.Point(63, 267);
            this.AgentINNLabel.Name = "AgentINNLabel";
            this.AgentINNLabel.Size = new System.Drawing.Size(69, 13);
            this.AgentINNLabel.TabIndex = 37;
            this.AgentINNLabel.Text = "ИНН Агента";
            // 
            // PriorityBox
            // 
            this.PriorityBox.Location = new System.Drawing.Point(275, 317);
            this.PriorityBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(120, 20);
            this.PriorityBox.TabIndex = 36;
            // 
            // AddLogo
            // 
            this.AddLogo.Location = new System.Drawing.Point(275, 247);
            this.AddLogo.Name = "AddLogo";
            this.AddLogo.Size = new System.Drawing.Size(100, 34);
            this.AddLogo.TabIndex = 34;
            this.AddLogo.Text = "Указать логотип";
            this.AddLogo.UseVisualStyleBackColor = true;
            this.AddLogo.Click += new System.EventHandler(this.AddLogo_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(275, 131);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 33;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(275, 87);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 32;
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // AgentDirectorBox
            // 
            this.AgentDirectorBox.Location = new System.Drawing.Point(278, 32);
            this.AgentDirectorBox.Name = "AgentDirectorBox";
            this.AgentDirectorBox.Size = new System.Drawing.Size(100, 20);
            this.AgentDirectorBox.TabIndex = 31;
            // 
            // AgentKPPBox
            // 
            this.AgentKPPBox.Location = new System.Drawing.Point(66, 355);
            this.AgentKPPBox.Name = "AgentKPPBox";
            this.AgentKPPBox.Size = new System.Drawing.Size(100, 20);
            this.AgentKPPBox.TabIndex = 30;
            this.AgentKPPBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgentKPPBox_KeyPress);
            // 
            // AgentINNBox
            // 
            this.AgentINNBox.Location = new System.Drawing.Point(66, 283);
            this.AgentINNBox.Name = "AgentINNBox";
            this.AgentINNBox.Size = new System.Drawing.Size(100, 20);
            this.AgentINNBox.TabIndex = 29;
            this.AgentINNBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgentINNBox_KeyPress);
            // 
            // AgentAddressBox
            // 
            this.AgentAddressBox.Location = new System.Drawing.Point(66, 145);
            this.AgentAddressBox.Name = "AgentAddressBox";
            this.AgentAddressBox.Size = new System.Drawing.Size(100, 96);
            this.AgentAddressBox.TabIndex = 28;
            this.AgentAddressBox.Text = "";
            // 
            // AgentAddressLabel
            // 
            this.AgentAddressLabel.AutoSize = true;
            this.AgentAddressLabel.Location = new System.Drawing.Point(63, 117);
            this.AgentAddressLabel.Name = "AgentAddressLabel";
            this.AgentAddressLabel.Size = new System.Drawing.Size(82, 13);
            this.AgentAddressLabel.TabIndex = 27;
            this.AgentAddressLabel.Text = "Адресс Агента";
            // 
            // AgentTypeBox
            // 
            this.AgentTypeBox.FormattingEnabled = true;
            this.AgentTypeBox.Location = new System.Drawing.Point(62, 82);
            this.AgentTypeBox.Name = "AgentTypeBox";
            this.AgentTypeBox.Size = new System.Drawing.Size(121, 21);
            this.AgentTypeBox.TabIndex = 26;
            // 
            // AgentTypeLabel
            // 
            this.AgentTypeLabel.AutoSize = true;
            this.AgentTypeLabel.Location = new System.Drawing.Point(60, 65);
            this.AgentTypeLabel.Name = "AgentTypeLabel";
            this.AgentTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.AgentTypeLabel.TabIndex = 25;
            this.AgentTypeLabel.Text = "Тип Агента";
            // 
            // TitleAgentBox
            // 
            this.TitleAgentBox.Location = new System.Drawing.Point(62, 32);
            this.TitleAgentBox.Name = "TitleAgentBox";
            this.TitleAgentBox.Size = new System.Drawing.Size(100, 20);
            this.TitleAgentBox.TabIndex = 24;
            // 
            // TitleAgentLabel
            // 
            this.TitleAgentLabel.AutoSize = true;
            this.TitleAgentLabel.Location = new System.Drawing.Point(59, 16);
            this.TitleAgentLabel.Name = "TitleAgentLabel";
            this.TitleAgentLabel.Size = new System.Drawing.Size(95, 13);
            this.TitleAgentLabel.TabIndex = 23;
            this.TitleAgentLabel.Text = "Название Агента";
            // 
            // EditAgentBtn
            // 
            this.EditAgentBtn.Location = new System.Drawing.Point(22, 816);
            this.EditAgentBtn.Name = "EditAgentBtn";
            this.EditAgentBtn.Size = new System.Drawing.Size(140, 53);
            this.EditAgentBtn.TabIndex = 22;
            this.EditAgentBtn.Text = "Изменить данные агента";
            this.EditAgentBtn.UseVisualStyleBackColor = true;
            this.EditAgentBtn.Click += new System.EventHandler(this.EditAgentBtn_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Location = new System.Drawing.Point(275, 191);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(100, 50);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 35;
            this.LogoBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Изменить данные";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgentLogoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AgentDirectorLabel);
            this.Controls.Add(this.AgentKPPLabel);
            this.Controls.Add(this.AgentINNLabel);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.AddLogo);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AgentDirectorBox);
            this.Controls.Add(this.AgentKPPBox);
            this.Controls.Add(this.AgentINNBox);
            this.Controls.Add(this.AgentAddressBox);
            this.Controls.Add(this.AgentAddressLabel);
            this.Controls.Add(this.AgentTypeBox);
            this.Controls.Add(this.AgentTypeLabel);
            this.Controls.Add(this.TitleAgentBox);
            this.Controls.Add(this.TitleAgentLabel);
            this.Controls.Add(this.EditAgentBtn);
            this.Name = "EditAgent";
            this.Text = " EditAgent";
            this.Load += new System.EventHandler(this.EditAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriorityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AgentLogoLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AgentDirectorLabel;
        private System.Windows.Forms.Label AgentKPPLabel;
        private System.Windows.Forms.Label AgentINNLabel;
        private System.Windows.Forms.NumericUpDown PriorityBox;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button AddLogo;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AgentDirectorBox;
        private System.Windows.Forms.TextBox AgentKPPBox;
        private System.Windows.Forms.TextBox AgentINNBox;
        private System.Windows.Forms.RichTextBox AgentAddressBox;
        private System.Windows.Forms.Label AgentAddressLabel;
        private System.Windows.Forms.ComboBox AgentTypeBox;
        private System.Windows.Forms.Label AgentTypeLabel;
        private System.Windows.Forms.TextBox TitleAgentBox;
        private System.Windows.Forms.Label TitleAgentLabel;
        private System.Windows.Forms.Button EditAgentBtn;
        private System.Windows.Forms.Button button1;
    }
}