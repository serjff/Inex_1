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
    public partial class expense_form : Form
    {
        public expense_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Определяем переменную для сохранения введенной суммы затраченных средств
            string sum_exp = textBox1.Text;
            // Определяем переменную для сохранения выбранного даты-время траты средств
            //DateTime date_exp = dateTimePicker1.Value;
            // Сразу конвертируем дату в формат гггг-мм--дд:

            String date_exp = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd");
            
            //Выводим на экран сообщение 
            MessageBox.Show("Добавляется сумма: " + sum_exp + " Дата: " + date_exp);
            //ПОдключаемся к файлу базы данных
            SQLiteConnection con = new SQLiteConnection(@"data source=D:\SQLite_base\enex_1.db");
            con.Open();
            // Формируем SQL запрос в нашу БД для добавления в  таблицу "exp_operation" полей: дата, сумма (date_exp, sum_exp)
            string cmdText = "INSERT INTO exp_operation(date_exp, sum_exp) VALUES (@date_exp, @sum_exp)";
            SQLiteCommand cmd = new SQLiteCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@date_exp", date_exp);
            cmd.Parameters.AddWithValue("@sum_exp", sum_exp);
            cmd.ExecuteNonQuery();
            // Прячем окно формы для добавления траты денег
            this.Hide();
        }
    }
}
