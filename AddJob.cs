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
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            // чтение данных, введённых пользователем
            string pasport = pasport1.Text + " " + pasport2.Text;
            string start_date = start_yy.Text + "." + start_mm.Text + "." + start_dd.Text;
            string end_date = end_yy.Text + "." + end_mm.Text + "." + end_dd.Text;
            string desc = description.Text;

            if (!EditWorker.CheckDataCorrect(start_yy.Text, start_mm.Text, start_dd.Text) || !EditWorker.CheckDataCorrect(end_yy.Text, end_mm.Text, end_dd.Text))
            {
                MessageBox.Show("Некорректная дата");
                return;
            }

            if (!(pasport1.Text.All(char.IsDigit) & pasport2.Text.All(char.IsDigit)))
            {
                MessageBox.Show("Паспорт может содержать только цифры");
                return;
            }

            // поиск работника по его паспортным данным и сохранение его id
            DataRow[] rows = ds.Worker.Select($"pasport_data = '{pasport}'");

            if (rows.Length != 1 )
            {
                MessageBox.Show("Ошибка: рабочего с такими данными нет");
            } else
            {
                var newRowJob = ds.Job.NewJobRow();

                newRowJob.ID_Worker = Convert.ToInt32(rows[0]["ID_Worker"]);
                newRowJob.start_date = start_date;
                newRowJob.end_date = end_date;
                newRowJob.description = desc;

                ds.Job.AddJobRow(newRowJob);

                ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);
                Close();
            }
        }
    }
}
