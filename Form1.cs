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
        public Form1()
        {
            InitializeComponent();

            // объявление dataset'а
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            //// создание базовых записей
            //
            //var newRowWorker = ds.Worker.NewWorkerRow();
            //newRowWorker.full_name = "Иванов Иван Иванович";
            //newRowWorker.date_of_birth = "1998.06.23";
            //newRowWorker.INN = "123456789101";
            //newRowWorker.SNILS = "12345678911";
            //newRowWorker.pasport_data = "1234 567890";
            //ds.Worker.AddWorkerRow(newRowWorker);

            //var newRowJob = ds.Job.NewJobRow();
            //newRowJob.ID_Worker = 1;
            //newRowJob.start_date = "2023.07.22";
            //newRowJob.end_date = "2023.08.12";
            //newRowJob.description = "проектировании и создание базы данных";
            //ds.Job.AddJobRow(newRowJob);

            //// файл dataset.xml храниться в bin\debug\ вместе с .exe файлом
            //// запись изменений в xml файл с данными
            //ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);

            // вывод БД на экран с переименованными столбцами
            string[] namesForWorkers = new string[5] {"ФИО работника", "Дата рождения", "ИНН", "СНИЛС", "Паспортные данные"};
            dataGridView1.DataSource = ds.Worker.DefaultView.ToTable(false, "full_name", "date_of_birth", "INN", "SNILS", "pasport_data");
            
            for (int i = 0; i < namesForWorkers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = namesForWorkers[i];
            }

            // заполнение оставшегося места столбцом "full_name"
            dataGridView1.Columns["full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string[] namesForJobs = new string[3] {"Начало работы", "Конец работы", "Описание"};
            dataGridView2.DataSource = ds.Job.DefaultView.ToTable(false, "start_date", "end_date", "description");

            for (int i = 0; i < namesForJobs.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = namesForJobs[i];
            }
            dataGridView2.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addworkerbtn_Click(object sender, EventArgs e)
        {
            AddWorker addworker = new AddWorker();
            addworker.ShowDialog();

            // обновление данных в datagridview1
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            string[] namesForWorkers = new string[5] { "ФИО работника", "Дата рождения", "ИНН", "СНИЛС", "Паспортные данные" };
            dataGridView1.DataSource = ds.Worker.DefaultView.ToTable(false, "full_name", "date_of_birth", "INN", "SNILS", "pasport_data");

            for (int i = 0; i < namesForWorkers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = namesForWorkers[i];
            }

            dataGridView1.Columns["full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void editworkerbtn_Click(object sender, EventArgs e)
        {
            EditWorker editworker = new EditWorker();
            editworker.ShowDialog();

            // обновление данных в datagridview1
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            string[] namesForWorkers = new string[5] { "ФИО работника", "Дата рождения", "ИНН", "СНИЛС", "Паспортные данные" };
            dataGridView1.DataSource = ds.Worker.DefaultView.ToTable(false, "full_name", "date_of_birth", "INN", "SNILS", "pasport_data");

            for (int i = 0; i < namesForWorkers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = namesForWorkers[i];
            }

            dataGridView1.Columns["full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void deleteworkerbtn_Click(object sender, EventArgs e)
        {
            DeleteWorker deleteworker = new DeleteWorker();
            deleteworker.ShowDialog();

            // обновление данных в datagridview1
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            string[] namesForWorkers = new string[5] { "ФИО работника", "Дата рождения", "ИНН", "СНИЛС", "Паспортные данные" };
            dataGridView1.DataSource = ds.Worker.DefaultView.ToTable(false, "full_name", "date_of_birth", "INN", "SNILS", "pasport_data");

            for (int i = 0; i < namesForWorkers.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = namesForWorkers[i];
            }

            dataGridView1.Columns["full_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void addjobbtn_Click(object sender, EventArgs e)
        {
            AddJob addjob = new AddJob();
            addjob.ShowDialog();

            // обновление данных в datagridview1
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            string[] namesForJobs = new string[3] { "Начало работы", "Конец работы", "Описание" };
            dataGridView2.DataSource = ds.Job.DefaultView.ToTable(false, "start_date", "end_date", "description");

            for (int i = 0; i < namesForJobs.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = namesForJobs[i];
            }
            dataGridView2.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void editjobbtn_Click(object sender, EventArgs e)
        {
            EditJob editjob = new EditJob();
            editjob.ShowDialog();

            // обновление данных в datagridview1
            var ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            string[] namesForJobs = new string[3] { "Начало работы", "Конец работы", "Описание" };
            dataGridView2.DataSource = ds.Job.DefaultView.ToTable(false, "start_date", "end_date", "description");

            for (int i = 0; i < namesForJobs.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = namesForJobs[i];
            }
            dataGridView2.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void deletejobbtn_Click(object sender, EventArgs e)
        {
            DeleteJob deletejob = new DeleteJob();
            deletejob.ShowDialog();

            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);


            string[] namesForJobs = new string[3] { "Начало работы", "Конец работы", "Описание" };
            dataGridView2.DataSource = ds.Job.DefaultView.ToTable(false, "start_date", "end_date", "description");

            for (int i = 0; i < namesForJobs.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = namesForJobs[i];
            }
            dataGridView2.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
