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
    public partial class Raspisanie : Form
    {
        public static int ind;
        public Raspisanie()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT t.id_timetable , f.name_film , h.name_hall , m.Measuring ,s.time_seance,s.price, t.date_timetable FROM ((((timetable t  join seance s on t.id_seance=s.id_seance) join hall h on s.id_hall=h.id_hall)  join measuring m on h.id_measuring=m.id_measuring) join film f on s.id_film=f.id_film);");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите название фильма")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите название фильма";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT t.id_timetable , f.name_film , h.name_hall , m.Measuring ,s.time_seance,s.price, t.date_timetable FROM ((((timetable t  join seance s on t.id_seance=s.id_seance) join hall h on s.id_hall=h.id_hall)  join measuring m on h.id_measuring=m.id_measuring) join film f on s.id_film=f.id_film);");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QueryDataBase qb1 = new QueryDataBase();
            try
            {

                string[] Rows = qb1.GetData("DELETE FROM `cinema`.`timetable` WHERE `id_timetable`=" + dataGridView1.CurrentRow.Cells[0].Value + ";");
                dataGridView1.Rows.Clear();
                MessageBox.Show("Пользователь удален");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            { MessageBox.Show("Нельзя удалить пользователя"); }
            dataGridView1.Rows.Clear();
            string[] Rows1 = qb1.GetData("SELECT t.id_timetable , f.name_film , h.name_hall , m.Measuring ,s.time_seance,s.price, t.date_timetable FROM ((((timetable t  join seance s on t.id_seance=s.id_seance) join hall h on s.id_hall=h.id_hall)  join measuring m on h.id_measuring=m.id_measuring) join film f on s.id_film=f.id_film);");
            foreach (string line in Rows1)
            {
                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            RaspisanieDob R = new RaspisanieDob();
            R.Show();
            this.Hide();
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

        private void Изменить_Click(object sender, EventArgs e)
        {
            ind = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            RaspisanieIzm R = new RaspisanieIzm();
            R.Show();
            this.Hide();

        }

        private void Raspisanie_Load(object sender, EventArgs e)
        {

        }

        private void Назад_Click(object sender, EventArgs e)
        {
           Form1 R = new Form1();
            R.Show();
            this.Hide();
        }
    }
}
