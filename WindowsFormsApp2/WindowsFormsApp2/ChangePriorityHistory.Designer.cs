namespace WindowsFormsApp2
{
    partial class ChangePriorityHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePriorityHistory));
            this.HistoryBox = new System.Windows.Forms.DataGridView();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryBox
            // 
            this.HistoryBox.AllowUserToAddRows = false;
            this.HistoryBox.AllowUserToDeleteRows = false;
            this.HistoryBox.AllowUserToOrderColumns = true;
            this.HistoryBox.AllowUserToResizeRows = false;
            this.HistoryBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryBox.Location = new System.Drawing.Point(12, 98);
            this.HistoryBox.MultiSelect = false;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.ReadOnly = true;
            this.HistoryBox.RowHeadersVisible = false;
            this.HistoryBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryBox.Size = new System.Drawing.Size(526, 397);
            this.HistoryBox.TabIndex = 0;
            // 
            // LogoPic
            // 
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoPic.InitialImage")));
            this.LogoPic.Location = new System.Drawing.Point(12, 12);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(526, 80);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 30;
            this.LogoPic.TabStop = false;
            // 
            // ChangePriorityHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 507);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.HistoryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(566, 460);
            this.Name = "ChangePriorityHistory";
            this.Text = "История изменения приоритета агентов";
            this.Load += new System.EventHandler(this.ChangePriorityHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryBox;
        private System.Windows.Forms.PictureBox LogoPic;
    }
}