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
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        // функция, проверяющая уникальность данных
        public static bool CheckWorkerDataUnique(string inn, string snils, string pasport)
        {
            ds ds = new ds();
            if (ds.Worker.Select($"INN = '{inn}' OR SNILS = '{snils}' OR pasport_data = '{pasport}'").Length == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            // чтение данных, введённых пользователем
            string fullname = full_name.Text;
            string dob = dob_year.Text + "." + dob_month.Text + "." + dob_day.Text;
            string inn = INN.Text;
            string snils = SNILS.Text;
            string pasport = pasport1.Text + " " + pasport2.Text;

            if (!EditWorker.CheckDataCorrect(dob_year.Text, dob_month.Text, dob_day.Text))
            {
                MessageBox.Show("Некорректная дата");
                return;
            }

            if (pasport.Length != 10 && snils.Length != 11 && inn.Length != 12)
            {
                MessageBox.Show("Ошибка: не доконца введённые даннные");
            }
            else
            {
                var ds = new ds();

                if (CheckWorkerDataUnique(inn, snils, pasport))
                {
                    var newRowWorker = ds.Worker.NewWorkerRow();

                    // чтение файла
                    ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

                    // autoincrement работает не корректно и из-за этого приходится либо обновлять его вручную
                    newRowWorker.ID_Worker = ds.Worker.Rows.Count + 1;
                    newRowWorker.full_name = fullname;
                    newRowWorker.date_of_birth = dob;
                    newRowWorker.INN = inn;
                    newRowWorker.SNILS = snils;
                    newRowWorker.pasport_data = pasport;

                    int i = ds.Worker.Rows.Count + 1;

                    ds.Worker.AddWorkerRow(newRowWorker);

                    ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);
                    ds.Clear();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка: работник с такими данными уже существует");
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
