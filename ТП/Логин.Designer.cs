
namespace ТП
{
    partial class Логин
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Логин));
            this.Ввод = new System.Windows.Forms.Button();
            this.Имя = new System.Windows.Forms.Label();
            this.Имя_ввод = new System.Windows.Forms.TextBox();
            this.Фамилия = new System.Windows.Forms.Label();
            this.Фамилия_ввод = new System.Windows.Forms.TextBox();
            this.Назад = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ввод
            // 
            this.Ввод.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Ввод.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ввод.FlatAppearance.BorderSize = 0;
            this.Ввод.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ввод.Location = new System.Drawing.Point(250, 380);
            this.Ввод.Margin = new System.Windows.Forms.Padding(7);
            this.Ввод.Name = "Ввод";
            this.Ввод.Size = new System.Drawing.Size(300, 60);
            this.Ввод.TabIndex = 4;
            this.Ввод.Text = "Ввод";
            this.Ввод.UseVisualStyleBackColor = false;
            this.Ввод.Click += new System.EventHandler(this.Ввод_Click);
            // 
            // Имя
            // 
            this.Имя.Location = new System.Drawing.Point(250, 110);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(300, 32);
            this.Имя.TabIndex = 0;
            this.Имя.Text = "Введите Имя";
            this.Имя.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Имя_ввод
            // 
            this.Имя_ввод.BackColor = System.Drawing.Color.White;
            this.Имя_ввод.Location = new System.Drawing.Point(250, 145);
            this.Имя_ввод.Name = "Имя_ввод";
            this.Имя_ввод.Size = new System.Drawing.Size(300, 39);
            this.Имя_ввод.TabIndex = 1;
            // 
            // Фамилия
            // 
            this.Фамилия.Location = new System.Drawing.Point(250, 220);
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Size = new System.Drawing.Size(300, 32);
            this.Фамилия.TabIndex = 2;
            this.Фамилия.Text = "Введите Фамилию";
            this.Фамилия.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Фамилия_ввод
            // 
            this.Фамилия_ввод.BackColor = System.Drawing.Color.White;
            this.Фамилия_ввод.Location = new System.Drawing.Point(250, 255);
            this.Фамилия_ввод.Name = "Фамилия_ввод";
            this.Фамилия_ввод.Size = new System.Drawing.Size(300, 39);
            this.Фамилия_ввод.TabIndex = 3;
            // 
            // Назад
            // 
            this.Назад.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Назад.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Назад.FlatAppearance.BorderSize = 0;
            this.Назад.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Назад.Location = new System.Drawing.Point(250, 490);
            this.Назад.Margin = new System.Windows.Forms.Padding(7);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(300, 60);
            this.Назад.TabIndex = 5;
            this.Назад.Text = "Назад";
            this.Назад.UseVisualStyleBackColor = false;
            this.Назад.Click += new System.EventHandler(this.Назад_Click);
            // 
            // Логин
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.Фамилия_ввод);
            this.Controls.Add(this.Фамилия);
            this.Controls.Add(this.Имя_ввод);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.Ввод);
            this.Font = new System.Drawing.Font("Segoe UI", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Логин";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логин";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Логин_Close);
            this.Load += new System.EventHandler(this.Логин_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ввод;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.TextBox Имя_ввод;
        private System.Windows.Forms.Label Фамилия;
        private System.Windows.Forms.TextBox Фамилия_ввод;
        private System.Windows.Forms.Button Назад;
    }
}