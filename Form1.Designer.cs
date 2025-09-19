using System.Windows.Forms;

namespace TRBD_Task_1_2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addworkerbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.editworkerbtn = new System.Windows.Forms.Button();
            this.deleteworkerbtn = new System.Windows.Forms.Button();
            this.addjobbtn = new System.Windows.Forms.Button();
            this.editjobbtn = new System.Windows.Forms.Button();
            this.deletejobbtn = new System.Windows.Forms.Button();
            this.ds = new TRBD_Task_1_2.ds();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // addworkerbtn
            // 
            this.addworkerbtn.Location = new System.Drawing.Point(604, 30);
            this.addworkerbtn.Name = "addworkerbtn";
            this.addworkerbtn.Size = new System.Drawing.Size(128, 50);
            this.addworkerbtn.TabIndex = 1;
            this.addworkerbtn.Text = "добавление нового работника";
            this.addworkerbtn.UseVisualStyleBackColor = true;
            this.addworkerbtn.Click += new System.EventHandler(this.addworkerbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(569, 215);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(569, 215);
            this.dataGridView2.TabIndex = 7;
            // 
            // editworkerbtn
            // 
            this.editworkerbtn.Location = new System.Drawing.Point(604, 100);
            this.editworkerbtn.Name = "editworkerbtn";
            this.editworkerbtn.Size = new System.Drawing.Size(128, 50);
            this.editworkerbtn.TabIndex = 2;
            this.editworkerbtn.Text = "редактировать работника";
            this.editworkerbtn.UseVisualStyleBackColor = true;
            this.editworkerbtn.Click += new System.EventHandler(this.editworkerbtn_Click);
            // 
            // deleteworkerbtn
            // 
            this.deleteworkerbtn.Location = new System.Drawing.Point(604, 170);
            this.deleteworkerbtn.Name = "deleteworkerbtn";
            this.deleteworkerbtn.Size = new System.Drawing.Size(128, 50);
            this.deleteworkerbtn.TabIndex = 3;
            this.deleteworkerbtn.Text = "удалить работника";
            this.deleteworkerbtn.UseVisualStyleBackColor = true;
            this.deleteworkerbtn.Click += new System.EventHandler(this.deleteworkerbtn_Click);
            // 
            // addjobbtn
            // 
            this.addjobbtn.Location = new System.Drawing.Point(604, 246);
            this.addjobbtn.Name = "addjobbtn";
            this.addjobbtn.Size = new System.Drawing.Size(128, 50);
            this.addjobbtn.TabIndex = 4;
            this.addjobbtn.Text = "добавить работу";
            this.addjobbtn.UseVisualStyleBackColor = true;
            this.addjobbtn.Click += new System.EventHandler(this.addjobbtn_Click);
            // 
            // editjobbtn
            // 
            this.editjobbtn.Location = new System.Drawing.Point(604, 316);
            this.editjobbtn.Name = "editjobbtn";
            this.editjobbtn.Size = new System.Drawing.Size(128, 50);
            this.editjobbtn.TabIndex = 5;
            this.editjobbtn.Text = "редактировать работу";
            this.editjobbtn.UseVisualStyleBackColor = true;
            this.editjobbtn.Click += new System.EventHandler(this.editjobbtn_Click);
            // 
            // deletejobbtn
            // 
            this.deletejobbtn.Location = new System.Drawing.Point(604, 386);
            this.deletejobbtn.Name = "deletejobbtn";
            this.deletejobbtn.Size = new System.Drawing.Size(128, 50);
            this.deletejobbtn.TabIndex = 6;
            this.deletejobbtn.Text = "удалить работу";
            this.deletejobbtn.UseVisualStyleBackColor = true;
            this.deletejobbtn.Click += new System.EventHandler(this.deletejobbtn_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(753, 461);
            this.Controls.Add(this.deletejobbtn);
            this.Controls.Add(this.editjobbtn);
            this.Controls.Add(this.addjobbtn);
            this.Controls.Add(this.deleteworkerbtn);
            this.Controls.Add(this.editworkerbtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addworkerbtn);
            this.Name = "Form1";
            this.Text = "Практическая работа 1_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addworkerbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button editworkerbtn;
        private System.Windows.Forms.Button deleteworkerbtn;
        private System.Windows.Forms.Button addjobbtn;
        private System.Windows.Forms.Button editjobbtn;
        private System.Windows.Forms.Button deletejobbtn;
        private ds ds;
    }
}

