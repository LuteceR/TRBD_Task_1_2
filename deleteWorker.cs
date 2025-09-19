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
    public partial class DeleteWorker : Form
    {
        public DeleteWorker()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // чтение данных, введённых пользователем
            string fullname = full_name.Text;
            string dob = dob_year.Text + "." + dob_month.Text + "." + dob_day.Text;
            string inn = INN.Text;
            string snils = SNILS.Text;
            string pasport = pasport1.Text + " " + pasport2.Text;

            ds ds = new ds();
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            DataRow[] rows = ds.Worker.Select($"INN = '{inn}' AND SNILS = '{snils}' AND pasport_data = '{pasport}'");

            if (rows.Length != 1)
            {
                MessageBox.Show("Ошибка: было найдено более одной записи или ни одной");
            }
            else
            {
                rows[0].Delete();
            }

            // обновление ID_Worker
            int id = 1;

            // отключаю ограничения, чтобы можно было выставить id без ошибок об уникальности
            ds.EnforceConstraints = false;

            foreach (DataRow row in ds.Worker.Rows)
            {
                row["ID_Worker"] = id;
                id++;
            }

            ds.EnforceConstraints = true;

            ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
