
namespace WindowsFormsApp2
{
    partial class Agents
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.AgentTypeLabel = new System.Windows.Forms.Label();
            this.AgentTypeBox = new System.Windows.Forms.ComboBox();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.AgentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectNameOfSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackPage = new System.Windows.Forms.Button();
            this.ForwardPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PageBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ChangePriority = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(176, 97);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(179, 20);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(176, 81);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(39, 13);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Поиск";
            // 
            // AgentTypeLabel
            // 
            this.AgentTypeLabel.AutoSize = true;
            this.AgentTypeLabel.Location = new System.Drawing.Point(173, 14);
            this.AgentTypeLabel.Name = "AgentTypeLabel";
            this.AgentTypeLabel.Size = new System.Drawing.Size(124, 13);
            this.AgentTypeLabel.TabIndex = 4;
            this.AgentTypeLabel.Text = "Фильтр по типу агента";
            // 
            // AgentTypeBox
            // 
            this.AgentTypeBox.FormattingEnabled = true;
            this.AgentTypeBox.Location = new System.Drawing.Point(176, 30);
            this.AgentTypeBox.Name = "AgentTypeBox";
            this.AgentTypeBox.Size = new System.Drawing.Size(169, 21);
            this.AgentTypeBox.TabIndex = 5;
            this.AgentTypeBox.SelectedIndexChanged += new System.EventHandler(this.AgentTypeBox_SelectedIndexChanged);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(582, 14);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(113, 13);
            this.SortLabel.TabIndex = 6;
            this.SortLabel.Text = "Порядок сортировки";
            // 
            // SortBox
            // 
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Location = new System.Drawing.Point(585, 30);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(180, 21);
            this.SortBox.TabIndex = 7;
            this.SortBox.SelectedIndexChanged += new System.EventHandler(this.SortBox_SelectedIndexChanged);
            // 
            // AgentPanel
            // 
            this.AgentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgentPanel.AutoScroll = true;
            this.AgentPanel.Location = new System.Drawing.Point(12, 126);
            this.AgentPanel.Name = "AgentPanel";
            this.AgentPanel.Size = new System.Drawing.Size(753, 509);
            this.AgentPanel.TabIndex = 9;
            // 
            // SelectNameOfSort
            // 
            this.SelectNameOfSort.FormattingEnabled = true;
            this.SelectNameOfSort.Location = new System.Drawing.Point(378, 30);
            this.SelectNameOfSort.Name = "SelectNameOfSort";
            this.SelectNameOfSort.Size = new System.Drawing.Size(167, 21);
            this.SelectNameOfSort.TabIndex = 11;
            this.SelectNameOfSort.SelectedIndexChanged += new System.EventHandler(this.SelectNameOfSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сортировать по";
            // 
            // BackPage
            // 
            this.BackPage.Location = new System.Drawing.Point(389, 96);
            this.BackPage.Name = "BackPage";
            this.BackPage.Size = new System.Drawing.Size(32, 20);
            this.BackPage.TabIndex = 13;
            this.BackPage.Text = "<--";
            this.BackPage.UseVisualStyleBackColor = true;
            this.BackPage.Click += new System.EventHandler(this.BackPage_Click);
            // 
            // ForwardPage
            // 
            this.ForwardPage.Location = new System.Drawing.Point(474, 96);
            this.ForwardPage.Name = "ForwardPage";
            this.ForwardPage.Size = new System.Drawing.Size(32, 20);
            this.ForwardPage.TabIndex = 14;
            this.ForwardPage.Text = "-->";
            this.ForwardPage.UseVisualStyleBackColor = true;
            this.ForwardPage.Click += new System.EventHandler(this.ForwardPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Страница";
            // 
            // PageBox
            // 
            this.PageBox.Enabled = false;
            this.PageBox.Location = new System.Drawing.Point(423, 96);
            this.PageBox.Name = "PageBox";
            this.PageBox.ReadOnly = true;
            this.PageBox.Size = new System.Drawing.Size(46, 20);
            this.PageBox.TabIndex = 16;
            this.PageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Добавить агента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangePriority
            // 
            this.ChangePriority.Location = new System.Drawing.Point(512, 81);
            this.ChangePriority.Name = "ChangePriority";
            this.ChangePriority.Size = new System.Drawing.Size(121, 35);
            this.ChangePriority.TabIndex = 20;
            this.ChangePriority.Text = "Изменить приоритет выбранных агентов";
            this.ChangePriority.UseVisualStyleBackColor = true;
            this.ChangePriority.Click += new System.EventHandler(this.ChangePriority_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 111);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 647);
            this.Controls.Add(this.ChangePriority);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForwardPage);
            this.Controls.Add(this.BackPage);
            this.Controls.Add(this.SelectNameOfSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgentPanel);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.AgentTypeBox);
            this.Controls.Add(this.AgentTypeLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.MinimumSize = new System.Drawing.Size(793, 686);
            this.Name = "Agents";
            this.Text = "Agents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label AgentTypeLabel;
        private System.Windows.Forms.Label SortLabel;
        public System.Windows.Forms.TextBox SearchBox;
        public System.Windows.Forms.ComboBox AgentTypeBox;
        public System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.FlowLayoutPanel AgentPanel;
        public System.Windows.Forms.ComboBox SelectNameOfSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackPage;
        private System.Windows.Forms.Button ForwardPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PageBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ChangePriority;
    }
}

