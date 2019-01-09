using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaVinogradova
{
    public partial class Form3 : Form
    {
        public int i;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Введите Фамилию")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите Фамилию";
                textBox1.ForeColor = Color.Silver;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите Имя")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите Имя";
                textBox2.ForeColor = Color.Silver;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите Отчество")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Введите Отчество";
                textBox3.ForeColor = Color.Silver;
            }


        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Выберете Должность")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Выберете Должность";
                comboBox1.ForeColor = Color.Silver;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }

        private void comboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Кассир")
                i = 1;
            if (comboBox1.Text == "Администратор")
                i = 2;
            if (comboBox1.Text == "Старший администратор")
                i = 3;
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && comboBox1.Text.Length != 0 && maskedTextBox1.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `cinema`.`employees` ( `surname`, `name_employees`, `patronicym`, `id_position`, `phone`) VALUES  ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + i + "','" + maskedTextBox1.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }

            }
            else
            { MessageBox.Show("Заполните поля"); }
        }
    }
}
