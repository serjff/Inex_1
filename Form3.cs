using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Inex_1
{
    public partial class income_form : Form
    {
        public income_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Определяем переменную для сохранения введенной суммы доходов
            string sum_inc = textBox1.Text;
            // Определяем переменную для сохранения выбранного даты-время дохода
            //DateTime date_inc = dateTimePicker1.Value;
            // Сразу конвертируем дату в формат гггг-мм--дд:

            String date_inc = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd");

            //Выводим на экран сообщение 
            MessageBox.Show("Добавляется сумма: " + sum_inc + " Дата: " + date_inc);
            //ПОдключаемся к файлу базы данных
            SQLiteConnection con = new SQLiteConnection(@"data source=D:\SQLite_base\enex_1.db");
            con.Open();
            // Формируем SQL запрос в нашу БД для добавления в  таблицу "inc_operation" полей: дата, сумма (my_date, my_currency)
            string cmdText = "INSERT INTO inc_operation(date_inc, sum_inc) VALUES (@date_inc, @sum_inc)";
            SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@date_inc", date_inc);
            cmd.Parameters.AddWithValue("@sum_inc", sum_inc);
            cmd.ExecuteNonQuery();
            // Прячем окно формы для добавления доходов
            this.Hide();
        }
    }
}
