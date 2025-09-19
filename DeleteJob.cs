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
    public partial class DeleteJob : Form
    {
        public DeleteJob()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            // чтение данных, введённых пользователем
            string pasport = pasport1.Text + " " + pasport2.Text;
            string start_date = start_yy.Text + "." + start_mm.Text + "." + start_dd.Text;
            string end_date = end_yy.Text + "." + end_mm.Text + "." + end_dd.Text;
            string desc = description.Text;

            DataRow[] workers = ds.Worker.Select($"pasport_data = '{pasport}'");
            if (workers.Length != 1)
            {
                MessageBox.Show("Ошибка: рабочих с таким паспортом нет");
            }
            else 
            {
                DataRow[] jobs = ds.Job.Select($"ID_Worker = {workers[0]["ID_Worker"]} AND start_date = '{start_date}' AND end_date = '{end_date}' AND description = '{desc}'");
                if (jobs.Length != 1)
                {
                    MessageBox.Show("Ошибка: работа с такими параметрами не найдена");
                } else
                {
                    jobs[0].Delete();
                }

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
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
