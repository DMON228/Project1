
namespace WindowsFormsApp2
{
    partial class AgentsPriority
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
            this.button1 = new System.Windows.Forms.Button();
            this.PriorityValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriorityValue
            // 
            this.PriorityValue.Location = new System.Drawing.Point(12, 12);
            this.PriorityValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriorityValue.Name = "PriorityValue";
            this.PriorityValue.Size = new System.Drawing.Size(234, 20);
            this.PriorityValue.TabIndex = 1;
            // 
            // ChangeAgentsPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 83);
            this.Controls.Add(this.PriorityValue);
            this.Controls.Add(this.button1);
            this.Name = "ChangeAgentsPriority";
            this.Text = "Изменить приоритет";
            this.Load += new System.EventHandler(this.ChangeAgentsPriority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriorityValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown PriorityValue;
    }
}