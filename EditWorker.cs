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
    public partial class EditWorker : Form
    {
        public EditWorker()
        {
            InitializeComponent();
        }

        public static bool CheckWorkerDataUnique(string inn, string snils, string pasport)
        {
            ds ds = new ds();
            if (ds.Worker.Select($"INN = '{inn}' OR SNILS = '{snils}' OR pasport_data = '{pasport}'").Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            ds dataset = new ds();
            
            // чтение данных, введённых пользователем
            string fullname = full_name.Text;
            string dob = dob_year.Text + "." + dob_month.Text + "." + dob_day.Text;
            string inn = INN.Text;
            string snils = SNILS.Text;
            string pasport = pasport1.Text + " " + pasport2.Text;

            string new_fullname = newFull_name.Text;
            string new_dob = newDob_year.Text + "." + newDob_month.Text + "." + newDob_day.Text;
            string new_inn = newINN.Text;
            string new_snils = newSNILS.Text;
            string new_pasport = newPasport1.Text + " " + newPasport2.Text;

            // чтение данных из dataset.xml
            dataset.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            // проверка на то, что новые данные не существуют в таблице 
            if (CheckWorkerDataUnique(new_inn, new_snils, new_pasport))
            {
                DataRow[] rows = dataset.Worker.Select($"INN = '{inn}'");
                if (rows.Length == 1)
                {
                    DataRow row = rows[0];
                    row["full_name"] = new_fullname;
                    row["date_of_birth"] = new_dob;
                    row["INN"] = new_inn;
                    row["SNILS"] = new_snils;
                    row["pasport_data"] = new_pasport;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка: не удалось найти запись с такими данными");
                }

                dataset.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);
            } else
            {
                MessageBox.Show("Ошибка: пользователь с этими данными уже существует");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
