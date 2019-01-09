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
    public partial class Form2 : Form
    {
        public static int ind;

        public Form2()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT e.id_employees,e.surname,e.name_employees,e.patronicym,p.position,e.phone FROM employees e join position p on(e.id_position = p.id_position) ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int k = 0;
                    string s = dataGridView1[1, i].Value.ToString();

                    if (s.Contains(textBox1.Text))
                    {
                        k++;

                    }
                    if (k == 0)
                    { dataGridView1.Rows.RemoveAt(i); }

                }
            if (textBox1.Text != null)

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int k = 0;
                    string s = dataGridView1[1, i].Value.ToString();

                    if (s.Contains(textBox1.Text))
                    {
                        k++;

                    }
                    if (k == 0)
                    { dataGridView1.Rows.RemoveAt(i); }

                }
            if (textBox1.Text != null)

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int k = 0;
                    string s = dataGridView1[1, i].Value.ToString();

                    if (s.Contains(textBox1.Text))
                    {
                        k++;

                    }
                    if (k == 0)
                    { dataGridView1.Rows.RemoveAt(i); }

                }
            if (textBox1.Text != null)

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int k = 0;
                    string s = dataGridView1[1, i].Value.ToString();

                    if (s.Contains(textBox1.Text))
                    {
                        k++;

                    }
                    if (k == 0)
                    { dataGridView1.Rows.RemoveAt(i); }

                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите Фамилию")
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

        private void button2_Click(object sender, EventArgs e)
        {
            QueryDataBase qb = new QueryDataBase();
            try
            {

                string[] Rows = qb.GetData("DELETE FROM `cinema`.`employees` WHERE `id_employees`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Пользователь удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить пользователя"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb.GetData("Select e.id_employees,e.surname,e.name_employees,e.patronicym,p.position,e.phone FROM employees e join position p on(e.id_position = p.id_position); ");
            foreach (string line in Rows1)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("Select e.id_employees,e.surname,e.name_employees,e.patronicym,p.position,e.phone FROM employees e join position p on(e.id_position = p.id_position); ");
            foreach (string line in Rows)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
