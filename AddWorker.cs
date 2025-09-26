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
            ds.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

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

            // гарантирование единого формата даты
            if (dob_month.Text.Length == 1)
            {
                dob_month.Text = "0" + dob_month.Text;
            }
            if (dob_day.Text.Length == 1)
            {
                dob_day.Text = "0" + dob_day.Text;
            }

            string fullname = full_name.Text;
            string dob = dob_day.Text + "-" + dob_month.Text + "-" + dob_year.Text;
            string inn = INN.Text;
            string snils = SNILS.Text;
            string pasport = pasport1.Text + " " + pasport2.Text;

            if (fullname.Any(char.IsDigit))
            {
                MessageBox.Show("ФИО не может содержать цифры");
                return;
            }

            if (!(inn.All(char.IsDigit) & snils.All(char.IsDigit) & pasport1.Text.All(char.IsDigit) & pasport2.Text.All(char.IsDigit)))
            {
                MessageBox.Show("ИНН, СНИЛС и паспорт могут содержать только цифры");
                return;
            }

            if (!EditWorker.CheckDataCorrect(dob_day.Text, dob_month.Text, dob_year.Text, true))
            {
                //MessageBox.Show($"{dob_day.Text} {dob_month.Text} {dob_year.Text}");
                MessageBox.Show("Некорректная дата");
                return;
            }

            if (pasport.Length != 10 && snils.Length != 11 && inn.Length != 12)
            {
                MessageBox.Show("Ошибка: не доконца введённые даннные");
                return;
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

                    ds.WriteXml("dataset.xml", XmlWriteMode.IgnoreSchema);

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
