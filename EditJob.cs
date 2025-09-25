using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRBD_Task_1_2
{
    public partial class EditJob : Form
    {
        public DataGridViewCellCollection selectedRowCollection;

        public EditJob(object sender, EventArgs e, DataGridViewCellCollection selectedRowCollection)
        {
            InitializeComponent();

            this.selectedRowCollection = selectedRowCollection;

            //MessageBox.Show(this.selectedRowCollection[0].Value.ToString());

            ds ds = new ds();
            string ps;

            //MessageBox.Show($"{this.selectedRowCollection[0].Value}");

            try
            {
                ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
                DataRow[] rows = ds.Worker.Select($"ID_Worker = '{this.selectedRowCollection[0].Value}'");
                string pasport_data = (String)rows[0]["pasport_data"];
                newPasport1.Text = pasport_data.Substring(0, 4);
                newPasport2.Text = pasport_data.Substring(5, 6);
            }
            catch
            {
                MessageBox.Show("Не удалось найти ответственного работника");
            }

            newStart_yy.Text = this.selectedRowCollection[1].Value.ToString().Substring(0, 4);
            newStart_mm.Text = this.selectedRowCollection[1].Value.ToString().Substring(5, 2);
            newStart_dd.Text = this.selectedRowCollection[1].Value.ToString().Substring(8, 2);
            newEnd_yy.Text = this.selectedRowCollection[2].Value.ToString().Substring(1, 4);
            newEnd_mm.Text = this.selectedRowCollection[2].Value.ToString().Substring(5, 2);
            newEnd_dd.Text = this.selectedRowCollection[2].Value.ToString().Substring(8, 2);
            newDescription.Text = this.selectedRowCollection[3].Value.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            // чтение данных, введённых пользователем

            try
            {
                ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
                DataRow[] rows = ds.Worker.Select($"ID_Worker = '{this.selectedRowCollection[0].Value}'");
                string pasport_data = (String)rows[0]["pasport_data"];
                newPasport1.Text = pasport_data.Substring(0, 4);
                newPasport2.Text = pasport_data.Substring(5, 6);
            }
            catch
            {
                MessageBox.Show("Не удалось найти ответственного работника");
            }

            string start_date = this.selectedRowCollection[1].Value.ToString().Substring(0, 4) + "." + this.selectedRowCollection[1].Value.ToString().Substring(5, 2) + "." + this.selectedRowCollection[1].Value.ToString().Substring(8, 2);
            string end_date = this.selectedRowCollection[2].Value.ToString().Substring(1, 4) + "." + this.selectedRowCollection[2].Value.ToString().Substring(5, 2) + "." + this.selectedRowCollection[2].Value.ToString().Substring(8, 2);
            string desc = this.selectedRowCollection[3].Value.ToString();

            string newPasport = newPasport1.Text + " " + newPasport2.Text;
            string newStart_date = newStart_yy.Text + "." + newStart_mm.Text + "." + newStart_dd.Text;
            string newEnd_date = newEnd_yy.Text + "." + newEnd_mm.Text + "." + newEnd_dd.Text;
            string newDesc = newDescription.Text;

            if (!EditWorker.CheckDataCorrect(newStart_dd.Text, newStart_mm.Text, newStart_yy.Text))
            {
                MessageBox.Show("Некорректная дата");
                return;
            }

            // нахождение рабочих с заданными паспортными данными
            DataRow[] oldWorkers = ds.Worker.Select($"pasport_data = '{this.selectedRowCollection[0].Value.ToString().Substring(0, 4)} {this.selectedRowCollection[1].Value.ToString().Substring(5, 6)}'");
            DataRow[] newWorkers = ds.Worker.Select($"pasport_data = '{newPasport}'");

            if (oldWorkers.Length != 1 && newWorkers.Length != 1)
            {
                MessageBox.Show("Ошибка: сотрудник с такими паспортными данными не найден");
            }
            else
            {
                int oldID_Worker = Convert.ToInt32(oldWorkers[0]["ID_Worker"].ToString());
                int newID_Worker = Convert.ToInt32(newWorkers[0]["ID_Worker"].ToString());

                // проверка на существование работы с заданными атрибутами
                DataRow[] oldJobs = ds.Job.Select($"ID_Worker = '{oldID_Worker}' AND start_date = '{start_date}' AND end_date = '{end_date}' AND description = '{desc}'");

                if (oldJobs.Length != 1)
                {
                    MessageBox.Show("Ошибка: работ с такими параметрами не найдено");
                }
                else
                {
                    oldJobs[0]["ID_Job"] = ds.Job.Rows.Count + 1;
                    oldJobs[0]["ID_Worker"] = newID_Worker;
                    oldJobs[0]["start_date"] = newStart_date;
                    oldJobs[0]["end_date"] = newEnd_date;
                    oldJobs[0]["description"] = newDesc;

                    ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);
                }
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
