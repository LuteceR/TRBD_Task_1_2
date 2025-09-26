namespace TRBD_Task_1_2
{
    partial class AddWorker
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
            this.full_name = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dob_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dob_month = new System.Windows.Forms.TextBox();
            this.dob_day = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SNILS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pasport1 = new System.Windows.Forms.TextBox();
            this.pasport2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ds = new TRBD_Task_1_2.ds();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // full_name
            // 
            this.full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.full_name.Location = new System.Drawing.Point(212, 52);
            this.full_name.MaxLength = 32;
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(343, 26);
            this.full_name.TabIndex = 0;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(221, 371);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(132, 32);
            this.save.TabIndex = 1;
            this.save.Text = "сохранение";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(385, 371);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(132, 32);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата рождения";
            // 
            // dob_year
            // 
            this.dob_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dob_year.Location = new System.Drawing.Point(330, 119);
            this.dob_year.MaxLength = 4;
            this.dob_year.Name = "dob_year";
            this.dob_year.Size = new System.Drawing.Size(56, 26);
            this.dob_year.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(255, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            // 
            // dob_month
            // 
            this.dob_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dob_month.Location = new System.Drawing.Point(271, 119);
            this.dob_month.MaxLength = 2;
            this.dob_month.Name = "dob_month";
            this.dob_month.Size = new System.Drawing.Size(34, 26);
            this.dob_month.TabIndex = 8;
            // 
            // dob_day
            // 
            this.dob_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dob_day.Location = new System.Drawing.Point(215, 119);
            this.dob_day.MaxLength = 2;
            this.dob_day.Name = "dob_day";
            this.dob_day.Size = new System.Drawing.Size(34, 26);
            this.dob_day.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(311, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ГГ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ММ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ДД";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(152, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "ИНН";
            // 
            // INN
            // 
            this.INN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.INN.Location = new System.Drawing.Point(212, 194);
            this.INN.MaxLength = 12;
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(174, 26);
            this.INN.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(142, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "СНИС";
            // 
            // SNILS
            // 
            this.SNILS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SNILS.Location = new System.Drawing.Point(212, 254);
            this.SNILS.MaxLength = 11;
            this.SNILS.Name = "SNILS";
            this.SNILS.Size = new System.Drawing.Size(174, 26);
            this.SNILS.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(31, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Паспортные данные";
            // 
            // pasport1
            // 
            this.pasport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pasport1.Location = new System.Drawing.Point(212, 310);
            this.pasport1.MaxLength = 4;
            this.pasport1.Name = "pasport1";
            this.pasport1.Size = new System.Drawing.Size(65, 26);
            this.pasport1.TabIndex = 19;
            // 
            // pasport2
            // 
            this.pasport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pasport2.Location = new System.Drawing.Point(297, 310);
            this.pasport2.MaxLength = 6;
            this.pasport2.Name = "pasport2";
            this.pasport2.Size = new System.Drawing.Size(89, 26);
            this.pasport2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(215, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "серия";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(309, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "номер";
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pasport2);
            this.Controls.Add(this.pasport1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SNILS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dob_day);
            this.Controls.Add(this.dob_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dob_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.full_name);
            this.Name = "AddWorker";
            this.Text = "Добавление  работника";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dob_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dob_month;
        private System.Windows.Forms.TextBox dob_day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SNILS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pasport1;
        private System.Windows.Forms.TextBox pasport2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private ds ds;
    }
}