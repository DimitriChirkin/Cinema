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
    public partial class Form5 : Form
    {
        public static int ind;
        public Form5()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT id_film, name_film, lasting, producer, limitation, Main_male_role, Main_female_role from film ; ");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }
            

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QueryDataBase qb = new QueryDataBase();
            try
            {
               
                string[] Rows1 = qb.GetData("DELETE FROM `Film` WHERE `id_film`='" + dataGridView1.CurrentRow.Cells[0].Value + "';");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Фильм удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить фильм"); }
            dataGridView1.Rows.Clear();
            string[] Rows2 = qb.GetData("SELECT id_film, name_film, lasting, producer, limitation, Main_male_role, Main_female_role from film ; ");
            foreach (string line in Rows2)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT id_film, name_film, lasting, producer, limitation, Main_male_role, Main_female_role from film ;  ");
            foreach (string line in Rows)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            Form8 F8 = new Form8();
            F8.Show();
            this.Hide();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
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
    }
}
