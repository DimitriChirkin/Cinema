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
    public partial class RaspisanieDob : Form
    {
        public RaspisanieDob()
        {
            InitializeComponent();
            
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT id_film,name_film FROM cinema.film;");
            foreach (string line in Rows)
            {

                string[] columns = line.Split(';');
                dataGridView1.Rows.Add(columns);
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            { comboBox1.Items.Add(dataGridView1[1, i].Value.ToString()); }

            
            string[] Rows1 = qb.GetData("SELECT id_hall,name_hall FROM cinema.hall;");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView2.Rows.Add(columns);
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            { comboBox2.Items.Add(dataGridView2[1, i].Value.ToString()); }
            
            string[] Rows2 = qb.GetData(" SELECT id_seance FROM cinema.seance;");
            foreach (string line in Rows2)
            {

                string[] columns = line.Split(';');
                dataGridView3.Rows.Add(columns);
            }
        }

        private void RaspisanieDob_Load(object sender, EventArgs e)
        {
         
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            string d="";
            string d1="";
            string d3 = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            { if (comboBox1.Text == dataGridView1[1, i].Value.ToString()) 
            { d = dataGridView1[0, i].Value.ToString(); } 
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (comboBox2.Text == dataGridView2[1, i].Value.ToString())
                { d1 = dataGridView2[0, i].Value.ToString(); }
            }
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && comboBox1.Text.Length != 0 && comboBox1.Text.Length != 0)
            {
                try
                
                    {

                        QueryDataBase qb = new QueryDataBase();
                        qb.InsertData("INSERT INTO seance ( id_film, id_hall, time_seance, price) VALUES (" + d + ", " + d1 + ",'" + textBox1.Text + "','" + textBox2.Text + "');");
                        dataGridView3.Rows.Clear();
                        QueryDataBase qb3 = new QueryDataBase();
                        string[] Rows2 = qb.GetData(" SELECT id_seance FROM cinema.seance;");
                        foreach (string line in Rows2)
                        {

                            string[] columns = line.Split(';');
                            dataGridView3.Rows.Add(columns);
                        }

                        for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                        {
                            d3 = dataGridView3[0, i].Value.ToString();
                        }
                        QueryDataBase qb2 = new QueryDataBase();
                        qb.InsertData("INSERT INTO timetable (id_seance,date_timetable)  VALUES (" + d3 + ",'" + maskedTextBox1.Text + "');");
                        MessageBox.Show("Добавление прошло успешно");
                    }
                    catch (MySql.Data.MySqlClient.MySqlException)
                { MessageBox.Show("Нельзя удалить пользователя"); }
            
               

            }
            else
            { MessageBox.Show("Заполните поля"); }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raspisanie R = new Raspisanie();
            R.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
