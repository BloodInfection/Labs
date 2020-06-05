namespace WindowsFormsApp1
{
    partial class Вход
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
            this.clients = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clients
            // 
            this.clients.Font = new System.Drawing.Font("Baron Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients.Location = new System.Drawing.Point(314, 171);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(136, 47);
            this.clients.TabIndex = 0;
            this.clients.Text = "Клиенты";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // cash
            // 
            this.cash.Font = new System.Drawing.Font("Baron Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(270, 90);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(222, 47);
            this.cash.TabIndex = 1;
            this.cash.Text = "Приход/расход";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Baron Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(331, 341);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 47);
            this.back.TabIndex = 2;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Вход
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.clients);
            this.Name = "Вход";
            this.Text = "Вход выполнен";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button back;
    }
}