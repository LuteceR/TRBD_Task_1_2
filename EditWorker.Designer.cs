namespace TRBD_Task_1_2
{
    partial class EditWorker
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
            this.ds = new TRBD_Task_1_2.ds();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.newFull_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.newDob_day = new System.Windows.Forms.TextBox();
            this.newDob_month = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.newDob_year = new System.Windows.Forms.TextBox();
            this.newINN = new System.Windows.Forms.TextBox();
            this.newSNILS = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.newPasport2 = new System.Windows.Forms.TextBox();
            this.newPasport1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(48, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО работника";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(34, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Паспортные данные";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(145, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "СНИС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(155, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Дата рождения";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(336, 377);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(143, 32);
            this.cancel.TabIndex = 24;
            this.cancel.Text = "отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(65, 377);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(209, 32);
            this.save.TabIndex = 23;
            this.save.Text = "применить изменения";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(246, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Изменение данных";
            // 
            // newFull_name
            // 
            this.newFull_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newFull_name.Location = new System.Drawing.Point(214, 65);
            this.newFull_name.MaxLength = 32;
            this.newFull_name.Name = "newFull_name";
            this.newFull_name.Size = new System.Drawing.Size(253, 26);
            this.newFull_name.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(352, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "ДД";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(296, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "ММ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "ГГ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label18.Location = new System.Drawing.Point(332, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = ".";
            // 
            // newDob_day
            // 
            this.newDob_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newDob_day.Location = new System.Drawing.Point(348, 127);
            this.newDob_day.MaxLength = 2;
            this.newDob_day.Name = "newDob_day";
            this.newDob_day.Size = new System.Drawing.Size(34, 26);
            this.newDob_day.TabIndex = 49;
            // 
            // newDob_month
            // 
            this.newDob_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newDob_month.Location = new System.Drawing.Point(292, 127);
            this.newDob_month.MaxLength = 2;
            this.newDob_month.Name = "newDob_month";
            this.newDob_month.Size = new System.Drawing.Size(34, 26);
            this.newDob_month.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label19.Location = new System.Drawing.Point(276, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 20);
            this.label19.TabIndex = 47;
            this.label19.Text = ".";
            // 
            // newDob_year
            // 
            this.newDob_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newDob_year.Location = new System.Drawing.Point(214, 127);
            this.newDob_year.MaxLength = 4;
            this.newDob_year.Name = "newDob_year";
            this.newDob_year.Size = new System.Drawing.Size(56, 26);
            this.newDob_year.TabIndex = 46;
            // 
            // newINN
            // 
            this.newINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newINN.Location = new System.Drawing.Point(214, 197);
            this.newINN.MaxLength = 12;
            this.newINN.Name = "newINN";
            this.newINN.Size = new System.Drawing.Size(174, 26);
            this.newINN.TabIndex = 54;
            // 
            // newSNILS
            // 
            this.newSNILS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newSNILS.Location = new System.Drawing.Point(214, 257);
            this.newSNILS.MaxLength = 11;
            this.newSNILS.Name = "newSNILS";
            this.newSNILS.Size = new System.Drawing.Size(174, 26);
            this.newSNILS.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(311, 293);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 20);
            this.label20.TabIndex = 59;
            this.label20.Text = "номер";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(217, 293);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 20);
            this.label21.TabIndex = 58;
            this.label21.Text = "серия";
            // 
            // newPasport2
            // 
            this.newPasport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newPasport2.Location = new System.Drawing.Point(299, 316);
            this.newPasport2.MaxLength = 6;
            this.newPasport2.Name = "newPasport2";
            this.newPasport2.Size = new System.Drawing.Size(89, 26);
            this.newPasport2.TabIndex = 57;
            // 
            // newPasport1
            // 
            this.newPasport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.newPasport1.Location = new System.Drawing.Point(214, 316);
            this.newPasport1.MaxLength = 4;
            this.newPasport1.Name = "newPasport1";
            this.newPasport1.Size = new System.Drawing.Size(65, 26);
            this.newPasport1.TabIndex = 56;
            // 
            // EditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.newPasport2);
            this.Controls.Add(this.newPasport1);
            this.Controls.Add(this.newSNILS);
            this.Controls.Add(this.newINN);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.newDob_day);
            this.Controls.Add(this.newDob_month);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.newDob_year);
            this.Controls.Add(this.newFull_name);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Name = "EditWorker";
            this.Text = "Редактирование работника";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ds ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox newFull_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox newDob_day;
        private System.Windows.Forms.TextBox newDob_month;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox newDob_year;
        private System.Windows.Forms.TextBox newINN;
        private System.Windows.Forms.TextBox newSNILS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox newPasport2;
        private System.Windows.Forms.TextBox newPasport1;
    }
}