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
    public partial class Form4 : Form
    {
        public int i;
        public Form4()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT surname FROM cinema.employees where id_employees='" + Form2.ind + " '   ;");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb.GetData("SELECT name_employees FROM cinema.employees where id_employees='" + Form2.ind + " '   ;");
            foreach (string line in Rows1)
            {
                string[] columns = line.Split(';');
                textBox2.Text = line;
            }
            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb.GetData("SELECT patronicym FROM cinema.employees where id_employees='" + Form2.ind + " '   ;");
            foreach (string line in Rows2)
            {
                string[] columns = line.Split(';');
                textBox3.Text = line;
            }
            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb.GetData("SELECT p.position FROM employees  e join position p on e.id_position=p.id_position  where id_employees='" + Form2.ind + " '   ;");
            foreach (string line in Rows3)
            {
                string[] columns = line.Split(';');
                comboBox1.Text = line;
            }
            QueryDataBase qb4 = new QueryDataBase();
            string[] Rows4 = qb.GetData("SELECT phone FROM cinema.employees where id_employees='" + Form2.ind + " '   ;");
            foreach (string line in Rows4)
            {
                string[] columns = line.Split(';');
                maskedTextBox1.Text = line;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Кассир")
                i = 1;
            if (comboBox1.Text == "Администратор")
                i = 2;
            if (comboBox1.Text == "Старший администратор")
                i = 3;
            
            try
            {

                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0 && textBox3.Text.Length!= 0 && comboBox1.Text.Length!=0 )
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE`cinema`.`employees` SET  `surname`='" + textBox1.Text + "', `name_employees`='" + textBox2.Text + "', `patronicym`='" + textBox3.Text + "', id_position='" +i + "', `phone`='" + maskedTextBox1.Text + "' WHERE `id_employees`='" + Form2.ind + "';");
                    MessageBox.Show("Изменение Прошло успешно");

                }
                else
                {
                    MessageBox.Show("Изменение не выполнено");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Неверны формат данных"); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

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
    }
}
