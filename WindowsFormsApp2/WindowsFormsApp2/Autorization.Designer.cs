
namespace WindowsFormsApp2
{
    partial class Autorization
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
            this.Log = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.RegBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log.Location = new System.Drawing.Point(12, 9);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(38, 13);
            this.Log.TabIndex = 0;
            this.Log.Text = "Логин";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(9, 44);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(45, 13);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Пароль";
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogBox.Location = new System.Drawing.Point(58, 6);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(186, 20);
            this.LogBox.TabIndex = 2;
            this.LogBox.Text = "2";
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassBox.Location = new System.Drawing.Point(58, 41);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(186, 20);
            this.PassBox.TabIndex = 3;
            this.PassBox.Text = "2";
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBtn.Location = new System.Drawing.Point(147, 79);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(98, 43);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.Location = new System.Drawing.Point(12, 79);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(129, 43);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Зарегистрироваться";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 135);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Log);
            this.Name = "Autorization";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autorization_FormClosing);
            this.Load += new System.EventHandler(this.Autorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button RegBtn;
    }
}