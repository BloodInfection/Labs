namespace WindowsFormsApp1
{
    partial class Клиенты
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchbutton = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientid = new System.Windows.Forms.TextBox();
            this.clientpassport = new System.Windows.Forms.TextBox();
            this.clientfio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updateinfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashtaken = new System.Windows.Forms.TextBox();
            this.accountid = new System.Windows.Forms.TextBox();
            this.cashgiven = new System.Windows.Forms.TextBox();
            this.saveac = new System.Windows.Forms.Button();
            this.deleteac = new System.Windows.Forms.Button();
            this.updateac = new System.Windows.Forms.Button();
            this.client = new System.Windows.Forms.ComboBox();
            this.bankDataSet = new WindowsFormsApp1.BankDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WindowsFormsApp1.BankDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Baron Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(12, 340);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(91, 36);
            this.searchbutton.TabIndex = 1;
            this.searchbutton.Text = "найти";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(12, 314);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(378, 20);
            this.fio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "введите фио:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Baron Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatebutton.Location = new System.Drawing.Point(109, 340);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(163, 35);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.Text = "обновить";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Baron Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(278, 340);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 36);
            this.back.TabIndex = 5;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Клиенты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "аккаунт:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(378, 55);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // clientid
            // 
            this.clientid.Location = new System.Drawing.Point(530, 42);
            this.clientid.Name = "clientid";
            this.clientid.Size = new System.Drawing.Size(189, 20);
            this.clientid.TabIndex = 9;
            // 
            // clientpassport
            // 
            this.clientpassport.Location = new System.Drawing.Point(530, 140);
            this.clientpassport.Name = "clientpassport";
            this.clientpassport.Size = new System.Drawing.Size(189, 20);
            this.clientpassport.TabIndex = 10;
            // 
            // clientfio
            // 
            this.clientfio.Location = new System.Drawing.Point(530, 92);
            this.clientfio.Name = "clientfio";
            this.clientfio.Size = new System.Drawing.Size(189, 20);
            this.clientfio.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "фио:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "паспорт:";
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Baron Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(727, 41);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(116, 32);
            this.savebutton.TabIndex = 15;
            this.savebutton.Text = "сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Baron Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(727, 80);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(116, 32);
            this.deletebutton.TabIndex = 16;
            this.deletebutton.Text = "удалить";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updateinfo
            // 
            this.updateinfo.Font = new System.Drawing.Font("Baron Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinfo.Location = new System.Drawing.Point(727, 122);
            this.updateinfo.Name = "updateinfo";
            this.updateinfo.Size = new System.Drawing.Size(116, 40);
            this.updateinfo.TabIndex = 17;
            this.updateinfo.Text = "обновить информацию";
            this.updateinfo.UseVisualStyleBackColor = true;
            this.updateinfo.Click += new System.EventHandler(this.updateinfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Клиент:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Получено:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Baron Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "отдано:";
            // 
            // cashtaken
            // 
            this.cashtaken.Location = new System.Drawing.Point(530, 312);
            this.cashtaken.Name = "cashtaken";
            this.cashtaken.Size = new System.Drawing.Size(189, 20);
            this.cashtaken.TabIndex = 23;
            // 
            // accountid
            // 
            this.accountid.Location = new System.Drawing.Point(530, 223);
            this.accountid.Name = "accountid";
            this.accountid.Size = new System.Drawing.Size(189, 20);
            this.accountid.TabIndex = 22;
            // 
            // cashgiven
            // 
            this.cashgiven.Location = new System.Drawing.Point(530, 356);
            this.cashgiven.Name = "cashgiven";
            this.cashgiven.Size = new System.Drawing.Size(189, 20);
            this.cashgiven.TabIndex = 25;
            // 
            // saveac
            // 
            this.saveac.Font = new System.Drawing.Font("Baron Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveac.Location = new System.Drawing.Point(728, 223);
            this.saveac.Name = "saveac";
            this.saveac.Size = new System.Drawing.Size(116, 32);
            this.saveac.TabIndex = 26;
            this.saveac.Text = "сохранить";
            this.saveac.UseVisualStyleBackColor = true;
            this.saveac.Click += new System.EventHandler(this.saveac_Click);
            // 
            // deleteac
            // 
            this.deleteac.Font = new System.Drawing.Font("Baron Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteac.Location = new System.Drawing.Point(728, 278);
            this.deleteac.Name = "deleteac";
            this.deleteac.Size = new System.Drawing.Size(116, 32);
            this.deleteac.TabIndex = 27;
            this.deleteac.Text = "удалить";
            this.deleteac.UseVisualStyleBackColor = true;
            this.deleteac.Click += new System.EventHandler(this.deleteac_Click);
            // 
            // updateac
            // 
            this.updateac.Font = new System.Drawing.Font("Baron Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateac.Location = new System.Drawing.Point(728, 335);
            this.updateac.Name = "updateac";
            this.updateac.Size = new System.Drawing.Size(116, 40);
            this.updateac.TabIndex = 28;
            this.updateac.Text = "обновить информацию";
            this.updateac.UseVisualStyleBackColor = true;
            this.updateac.Click += new System.EventHandler(this.updateac_Click);
            // 
            // client
            // 
            this.client.DataSource = this.clientBindingSource;
            this.client.DisplayMember = "ClientFIO";
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(530, 264);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(189, 21);
            this.client.TabIndex = 29;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bankDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Клиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.client);
            this.Controls.Add(this.updateac);
            this.Controls.Add(this.deleteac);
            this.Controls.Add(this.saveac);
            this.Controls.Add(this.cashgiven);
            this.Controls.Add(this.cashtaken);
            this.Controls.Add(this.accountid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateinfo);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientfio);
            this.Controls.Add(this.clientpassport);
            this.Controls.Add(this.clientid);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Клиенты";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Клиенты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox clientid;
        private System.Windows.Forms.TextBox clientpassport;
        private System.Windows.Forms.TextBox clientfio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updateinfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cashtaken;
        private System.Windows.Forms.TextBox accountid;
        private System.Windows.Forms.TextBox cashgiven;
        private System.Windows.Forms.Button saveac;
        private System.Windows.Forms.Button deleteac;
        private System.Windows.Forms.Button updateac;
        private System.Windows.Forms.ComboBox client;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BankDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}