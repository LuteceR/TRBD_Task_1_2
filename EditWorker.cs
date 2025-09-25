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
        public DataGridViewCellCollection selectedRowCollection;

        public EditWorker(object sender, EventArgs e, DataGridViewCellCollection selectedRowCollection)
        {
            InitializeComponent();
            this.selectedRowCollection = selectedRowCollection;

            newFull_name.Text = this.selectedRowCollection[0].Value.ToString();
            newDob_year.Text = this.selectedRowCollection[1].Value.ToString().Substring(0, 4);
            newDob_month.Text = this.selectedRowCollection[1].Value.ToString().Substring(5, 2);
            newDob_day.Text = this.selectedRowCollection[1].Value.ToString().Substring(8, 2);
            newINN.Text = this.selectedRowCollection[2].Value.ToString();
            newSNILS.Text = this.selectedRowCollection[3].Value.ToString();
            newPasport1.Text = this.selectedRowCollection[3].Value.ToString().Substring(0, 4);
            newPasport2.Text = this.selectedRowCollection[3].Value.ToString().Substring(5, 6);
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

        public static bool CheckDataCorrect(string dayText, string monthText, string yearText)
        {
            int day;
            int month;
            int year;

            Int32.TryParse(dayText, out day);
            Int32.TryParse(monthText, out month);
            Int32.TryParse(yearText, out year);

            // проверка корректности дат
            if ((day < 1 || day > 31) || (month < 1 || month > 12) || (year < 1900 || year > 2025))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            ds dataset = new ds();

            // чтение данных, введённых пользователем
            string fullname = this.selectedRowCollection[0].Value.ToString();
            string dob = this.selectedRowCollection[1].Value.ToString();
            string inn = this.selectedRowCollection[2].Value.ToString();
            string snils = this.selectedRowCollection[3].Value.ToString();
            string pasport = this.selectedRowCollection[4].Value.ToString();

            string new_fullname = newFull_name.Text;
            string new_dob = newDob_year.Text + "." + newDob_month.Text + "." + newDob_day.Text;
            string new_inn = newINN.Text;
            string new_snils = newSNILS.Text;
            string new_pasport = newPasport1.Text + " " + newPasport2.Text;

            // чтение данных из dataset.xml
            dataset.ReadXml("dataset.xml", XmlReadMode.IgnoreSchema);

            if (!CheckDataCorrect(newDob_day.Text, newDob_month.Text, newDob_year.Text))
            {
                MessageBox.Show("Некорректная дата");
                return;
            }

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
            }
            else
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
