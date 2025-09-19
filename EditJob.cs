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
        public EditJob()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);
            
            // чтение данных, введённых пользователем
            string pasport = oldPasport1.Text + " " + oldPasport2.Text;
            string start_date = oldStart_yy.Text + "." + oldStart_mm.Text + "." + oldStart_dd.Text;
            string end_date = oldEnd_yy.Text + "." + oldEnd_mm.Text + "." + oldEnd_dd.Text;
            string desc = oldDescription.Text;

            string newPasport = newPasport1.Text + " " + newPasport2.Text;
            string newStart_date = newStart_yy.Text + "." + newStart_mm.Text + "." + newStart_dd.Text;
            string newEnd_date = newEnd_yy.Text + "." + newEnd_mm.Text + "." + newEnd_dd.Text;
            string newDesc = newDescription.Text;

            // нахождение рабочих с заданными паспортными данными
            DataRow[] oldWorkers = ds.Worker.Select($"pasport_data = '{pasport}'");
            DataRow[] newWorkers = ds.Worker.Select($"pasport_data = '{newPasport}'");            

            if (oldWorkers.Length != 1 && newWorkers.Length != 1) 
            {
                MessageBox.Show("Ошибка: сотрудник с такими паспортными данными не найден");
            } else
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
