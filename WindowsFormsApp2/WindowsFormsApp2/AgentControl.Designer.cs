
namespace WindowsFormsApp2
{
    partial class AgentControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgentNameLabel = new System.Windows.Forms.Label();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.EditBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ForChangePriority = new System.Windows.Forms.CheckBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentNameLabel
            // 
            this.AgentNameLabel.AutoSize = true;
            this.AgentNameLabel.Location = new System.Drawing.Point(231, 13);
            this.AgentNameLabel.Name = "AgentNameLabel";
            this.AgentNameLabel.Size = new System.Drawing.Size(63, 13);
            this.AgentNameLabel.TabIndex = 1;
            this.AgentNameLabel.Text = "AgentName";
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Location = new System.Drawing.Point(231, 41);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(33, 13);
            this.SalesLabel.TabIndex = 2;
            this.SalesLabel.Text = "Sales";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(231, 69);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(231, 97);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(38, 13);
            this.PriorityLabel.TabIndex = 4;
            this.PriorityLabel.Text = "Priority";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(231, 125);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(49, 13);
            this.DiscountLabel.TabIndex = 5;
            this.DiscountLabel.Text = "Discount";
            this.DiscountLabel.Click += new System.EventHandler(this.DiscountLabel_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.Location = new System.Drawing.Point(433, 120);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(138, 23);
            this.EditBTN.TabIndex = 7;
            this.EditBTN.Text = "Редактировать";
            this.EditBTN.UseVisualStyleBackColor = true;
            this.EditBTN.Visible = false;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // ForChangePriority
            // 
            this.ForChangePriority.AutoSize = true;
            this.ForChangePriority.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ForChangePriority.Location = new System.Drawing.Point(433, 97);
            this.ForChangePriority.Name = "ForChangePriority";
            this.ForChangePriority.Size = new System.Drawing.Size(138, 17);
            this.ForChangePriority.TabIndex = 8;
            this.ForChangePriority.Text = "Изменить приоритет?";
            this.ForChangePriority.UseVisualStyleBackColor = true;
            this.ForChangePriority.Visible = false;
            // 
            // ImageBox
            // 
            this.ImageBox.ErrorImage = null;
            this.ImageBox.Image = global::WindowsFormsApp2.Properties.Resources.picture;
            this.ImageBox.Location = new System.Drawing.Point(3, 3);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(212, 137);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // AgentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ForChangePriority);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.AgentNameLabel);
            this.Controls.Add(this.ImageBox);
            this.Name = "AgentControl";
            this.Size = new System.Drawing.Size(574, 146);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button EditBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.CheckBox ForChangePriority;
        public System.Windows.Forms.Label AgentNameLabel;
        public System.Windows.Forms.Label SalesLabel;
        public System.Windows.Forms.Label PhoneLabel;
        public System.Windows.Forms.Label PriorityLabel;
        public System.Windows.Forms.Label DiscountLabel;
    }
}
