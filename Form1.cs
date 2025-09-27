using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRBD_Task_1_2
{
    public partial class Form1 : Form
    {

        // обновление данных таблицах
        public void updateDataGridViews()
        {
            ds ds = new ds();

            try
            {
                ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
            }
            catch
            {
                ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);
            }

            // вывод БД на экран с переименованными столбцами
            string[] namesForWorkers = new string[5] { "ФИО работника", "Дата рождения", "ИНН", "СНИЛС", "Паспортные данные" };
            dataGridView1.DataSource = ds.Worker.DefaultView.ToTable(false, "full_name", "date_of_birth", "INN", "SNILS", "pasport_data");

            for (int i = 0; i < namesForWorkers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = namesForWorkers[i];
            }

            // заполнение оставшегося места столбцом "full_name"
            dataGridView1.Columns["full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // заполнение оставшегося места столбцом "full_name"
            dataGridView1.Columns["full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string[] namesForJobs = new string[4] { "рабочий", "Начало работы", "Конец работы", "Описание" };
            dataGridView2.DataSource = ds.Job.DefaultView.ToTable(false, "ID_Worker", "start_date", "end_date", "description");
            dataGridView2.Columns["ID_Worker"].Visible = false;

            for (int i = 0; i < namesForJobs.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = namesForJobs[i];
            }
            dataGridView2.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public Form1()
        {
            InitializeComponent();

            updateDataGridViews();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addworkerbtn_Click(object sender, EventArgs e)
        {
            AddWorker addworker = new AddWorker();
            addworker.ShowDialog();

            // обновление данных в datagridview1
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            updateDataGridViews();
        }

        private void editworkerbtn_Click(object sender, EventArgs e)
        {
            // проверка на существование выбранной строки
            try
            {
                DataGridViewCellCollection rows = dataGridView1.SelectedRows[0].Cells;

                EditWorker editworker = new EditWorker(sender, e, rows);
                editworker.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Не выбран работник");
            }

            // обновление данных в datagridview1
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
            
            updateDataGridViews();
        }

        private void deleteworkerbtn_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            try
            {
                ds.Worker.Rows.RemoveAt(selectedRow.Index);
            }
            catch
            {
                MessageBox.Show("Нельзя удалить из-за ограничений на отношении");
            }

            // обновление id
            // отключаю ограничения, чтобы можно было выставить id без ошибок об уникальности
            ds.EnforceConstraints = false;

            int id = 0;

            foreach (DataRow row in ds.Worker.Rows)
            {
                row["ID_Worker"] = id;
                id++;
            }

            ds.EnforceConstraints = true;

            ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);

            updateDataGridViews();
        }

        private void addjobbtn_Click(object sender, EventArgs e)
        {
            AddJob addjob = new AddJob();
            addjob.ShowDialog();

            // обновление данных в datagridview2
            var ds = new ds();

            updateDataGridViews();

            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
        }

        private void editjobbtn_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            try
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                DataRow row = ds.Job.Rows[selectedRow.Index];
                EditJob editjob = new EditJob(sender, e, row);
                editjob.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Не выбрана работа");
            }

            updateDataGridViews();
            //// обновление данных в datagridview2
            //ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
        }

        private void deletejobbtn_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
            ds.Job.Rows.RemoveAt(selectedRow.Index);

            // обновление id
            // отключаю ограничения, чтобы можно было выставить id без ошибок об уникальности
            ds.EnforceConstraints = false;

            int id = 0;

            foreach (DataRow row in ds.Job.Rows)
            {
                row["ID_Job"] = id;
                id++;
            }

            ds.EnforceConstraints = true;

            ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);

            updateDataGridViews();
        }
    }
}
