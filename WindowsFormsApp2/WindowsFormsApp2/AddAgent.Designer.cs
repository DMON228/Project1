
namespace WindowsFormsApp2
{
    partial class AddAgent
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
            this.AddAgentBtn = new System.Windows.Forms.Button();
            this.TitleAgentLabel = new System.Windows.Forms.Label();
            this.TitleAgentBox = new System.Windows.Forms.TextBox();
            this.AgentTypeLabel = new System.Windows.Forms.Label();
            this.AgentTypeBox = new System.Windows.Forms.ComboBox();
            this.AgentAddressLabel = new System.Windows.Forms.Label();
            this.AgentAddressBox = new System.Windows.Forms.RichTextBox();
            this.AgentINNBox = new System.Windows.Forms.TextBox();
            this.AgentKPPBox = new System.Windows.Forms.TextBox();
            this.AgentDirectorBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.AddLogo = new System.Windows.Forms.Button();
            this.PriorityBox = new System.Windows.Forms.NumericUpDown();
            this.AgentINNLabel = new System.Windows.Forms.Label();
            this.AgentKPPLabel = new System.Windows.Forms.Label();
            this.AgentDirectorLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AgentLogoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAgentBtn
            // 
            this.AddAgentBtn.Location = new System.Drawing.Point(203, 322);
            this.AddAgentBtn.Name = "AddAgentBtn";
            this.AddAgentBtn.Size = new System.Drawing.Size(143, 46);
            this.AddAgentBtn.TabIndex = 0;
            this.AddAgentBtn.Text = "Добавить агента";
            this.AddAgentBtn.UseVisualStyleBackColor = true;
            this.AddAgentBtn.Click += new System.EventHandler(this.AddAgentBtn_Click);
            // 
            // TitleAgentLabel
            // 
            this.TitleAgentLabel.AutoSize = true;
            this.TitleAgentLabel.Location = new System.Drawing.Point(8, 9);
            this.TitleAgentLabel.Name = "TitleAgentLabel";
            this.TitleAgentLabel.Size = new System.Drawing.Size(95, 13);
            this.TitleAgentLabel.TabIndex = 1;
            this.TitleAgentLabel.Text = "Название Агента";
            // 
            // TitleAgentBox
            // 
            this.TitleAgentBox.Location = new System.Drawing.Point(11, 25);
            this.TitleAgentBox.Name = "TitleAgentBox";
            this.TitleAgentBox.Size = new System.Drawing.Size(100, 20);
            this.TitleAgentBox.TabIndex = 2;
            // 
            // AgentTypeLabel
            // 
            this.AgentTypeLabel.AutoSize = true;
            this.AgentTypeLabel.Location = new System.Drawing.Point(9, 58);
            this.AgentTypeLabel.Name = "AgentTypeLabel";
            this.AgentTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.AgentTypeLabel.TabIndex = 3;
            this.AgentTypeLabel.Text = "Тип Агента";
            // 
            // AgentTypeBox
            // 
            this.AgentTypeBox.FormattingEnabled = true;
            this.AgentTypeBox.Location = new System.Drawing.Point(11, 75);
            this.AgentTypeBox.Name = "AgentTypeBox";
            this.AgentTypeBox.Size = new System.Drawing.Size(121, 21);
            this.AgentTypeBox.TabIndex = 4;
            // 
            // AgentAddressLabel
            // 
            this.AgentAddressLabel.AutoSize = true;
            this.AgentAddressLabel.Location = new System.Drawing.Point(12, 110);
            this.AgentAddressLabel.Name = "AgentAddressLabel";
            this.AgentAddressLabel.Size = new System.Drawing.Size(82, 13);
            this.AgentAddressLabel.TabIndex = 5;
            this.AgentAddressLabel.Text = "Адресс Агента";
            // 
            // AgentAddressBox
            // 
            this.AgentAddressBox.Location = new System.Drawing.Point(15, 138);
            this.AgentAddressBox.Name = "AgentAddressBox";
            this.AgentAddressBox.Size = new System.Drawing.Size(100, 96);
            this.AgentAddressBox.TabIndex = 6;
            this.AgentAddressBox.Text = "";
            // 
            // AgentINNBox
            // 
            this.AgentINNBox.Location = new System.Drawing.Point(15, 276);
            this.AgentINNBox.Name = "AgentINNBox";
            this.AgentINNBox.Size = new System.Drawing.Size(100, 20);
            this.AgentINNBox.TabIndex = 7;
            this.AgentINNBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgentINNBox_KeyPress);
            // 
            // AgentKPPBox
            // 
            this.AgentKPPBox.Location = new System.Drawing.Point(15, 348);
            this.AgentKPPBox.Name = "AgentKPPBox";
            this.AgentKPPBox.Size = new System.Drawing.Size(100, 20);
            this.AgentKPPBox.TabIndex = 8;
            this.AgentKPPBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgentKPPBox_KeyPress);
            // 
            // AgentDirectorBox
            // 
            this.AgentDirectorBox.Location = new System.Drawing.Point(15, 417);
            this.AgentDirectorBox.Name = "AgentDirectorBox";
            this.AgentDirectorBox.Size = new System.Drawing.Size(100, 20);
            this.AgentDirectorBox.TabIndex = 9;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(199, 25);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(104, 20);
            this.PhoneBox.TabIndex = 10;
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(199, 78);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(104, 20);
            this.EmailBox.TabIndex = 11;
            // 
            // AddLogo
            // 
            this.AddLogo.Location = new System.Drawing.Point(199, 194);
            this.AddLogo.Name = "AddLogo";
            this.AddLogo.Size = new System.Drawing.Size(104, 34);
            this.AddLogo.TabIndex = 12;
            this.AddLogo.Text = "Указать логотип";
            this.AddLogo.UseVisualStyleBackColor = true;
            this.AddLogo.Click += new System.EventHandler(this.AddLogo_Click);
            // 
            // PriorityBox
            // 
            this.PriorityBox.Location = new System.Drawing.Point(203, 264);
            this.PriorityBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(100, 20);
            this.PriorityBox.TabIndex = 14;
            // 
            // AgentINNLabel
            // 
            this.AgentINNLabel.AutoSize = true;
            this.AgentINNLabel.Location = new System.Drawing.Point(12, 260);
            this.AgentINNLabel.Name = "AgentINNLabel";
            this.AgentINNLabel.Size = new System.Drawing.Size(69, 13);
            this.AgentINNLabel.TabIndex = 15;
            this.AgentINNLabel.Text = "ИНН Агента";
            // 
            // AgentKPPLabel
            // 
            this.AgentKPPLabel.AutoSize = true;
            this.AgentKPPLabel.Location = new System.Drawing.Point(12, 332);
            this.AgentKPPLabel.Name = "AgentKPPLabel";
            this.AgentKPPLabel.Size = new System.Drawing.Size(68, 13);
            this.AgentKPPLabel.TabIndex = 16;
            this.AgentKPPLabel.Text = "КПП Агента";
            // 
            // AgentDirectorLabel
            // 
            this.AgentDirectorLabel.AutoSize = true;
            this.AgentDirectorLabel.Location = new System.Drawing.Point(25, 401);
            this.AgentDirectorLabel.Name = "AgentDirectorLabel";
            this.AgentDirectorLabel.Size = new System.Drawing.Size(57, 13);
            this.AgentDirectorLabel.TabIndex = 17;
            this.AgentDirectorLabel.Text = "Директор";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(206, 9);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneLabel.TabIndex = 18;
            this.PhoneLabel.Text = "Номер телефона";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(206, 62);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 13);
            this.EmailLabel.TabIndex = 19;
            this.EmailLabel.Text = "Эл. Почта";
            // 
            // AgentLogoLabel
            // 
            this.AgentLogoLabel.AutoSize = true;
            this.AgentLogoLabel.Location = new System.Drawing.Point(206, 122);
            this.AgentLogoLabel.Name = "AgentLogoLabel";
            this.AgentLogoLabel.Size = new System.Drawing.Size(87, 13);
            this.AgentLogoLabel.TabIndex = 20;
            this.AgentLogoLabel.Text = "Логотип Агента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Приоритет Агента";
            // 
            // LogoBox
            // 
            this.LogoBox.Location = new System.Drawing.Point(203, 138);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(100, 50);
            this.LogoBox.TabIndex = 13;
            this.LogoBox.TabStop = false;
            // 
            // AddAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 459);
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
            this.Controls.Add(this.AddAgentBtn);
            this.Name = "AddAgent";
            this.Text = "AddAgent";
            this.Load += new System.EventHandler(this.AddAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriorityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAgentBtn;
        private System.Windows.Forms.Label TitleAgentLabel;
        private System.Windows.Forms.TextBox TitleAgentBox;
        private System.Windows.Forms.Label AgentTypeLabel;
        private System.Windows.Forms.ComboBox AgentTypeBox;
        private System.Windows.Forms.Label AgentAddressLabel;
        private System.Windows.Forms.RichTextBox AgentAddressBox;
        private System.Windows.Forms.TextBox AgentINNBox;
        private System.Windows.Forms.TextBox AgentKPPBox;
        private System.Windows.Forms.TextBox AgentDirectorBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button AddLogo;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.NumericUpDown PriorityBox;
        private System.Windows.Forms.Label AgentINNLabel;
        private System.Windows.Forms.Label AgentKPPLabel;
        private System.Windows.Forms.Label AgentDirectorLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AgentLogoLabel;
        private System.Windows.Forms.Label label1;
    }
}