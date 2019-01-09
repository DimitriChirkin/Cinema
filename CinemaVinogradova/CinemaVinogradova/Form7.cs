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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `cinema`.`film` ( `name_film`, `lasting`, `producer`, `description`, `limitation`) VALUES ('"+ textBox1.Text + "',  "+ textBox2.Text + ", "+ textBox3.Text + ", '"+ textBox4.Text + "', '"+ textBox5.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }

            }
            else
            { MessageBox.Show("Заполните поля"); }
        }

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите Название")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите Название";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Введите Жанр")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Введите Жанр";
                comboBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите Время")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите Время";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Введите Фамилию и Имя")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Введите Фамилию и Имя";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите Фамилию и Имя")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                textBox4.Text = "Введите Фамилию и Имя";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Введите Фамилию и Имя")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Введите Фамилию и Имя";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Введите Ограничение")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Введите Ограничение";
                textBox6.ForeColor = Color.Silver;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Введите Описание")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Введите Описание";
                textBox7.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && comboBox1.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0 && textBox7.Text.Length != 0 && comboBox1.Text.Length != 0 )
            {
                try
                {
                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `cinema`.`film` (`name_film`, `lasting`, `producer`, `description`, `limitation`, `genre`, `Main_male_role`, `Main_female_role`) VALUES ('"+textBox1.Text+ "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "', '" + comboBox1.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "');");
                    MessageBox.Show("Добавление прошло успешно");
                }
                catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("Неправильный формат данных"); }

            }
            else
            { MessageBox.Show("Заполните поля"); }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
