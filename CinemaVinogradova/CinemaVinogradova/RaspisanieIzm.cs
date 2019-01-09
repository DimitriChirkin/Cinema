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
    public partial class RaspisanieIzm : Form
    {

        public RaspisanieIzm()
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
            string[] Rows3 = qb.GetData("SELECT name_film FROM (timetable t join seance s on t.id_seance=s.id_seance) join film f on s.id_film=f.id_film where id_timetable='" + Raspisanie.ind + " '   ;");
            foreach (string line in Rows3)
            {
                string[] columns = line.Split(';');
                comboBox1.Text = line;
            }
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows4 = qb.GetData("SELECT name_hall FROM(timetable t join seance s on t.id_seance = s.id_seance) join hall h on s.id_hall = h.id_hall where id_timetable = '" + Raspisanie.ind + " '   ;");
            foreach (string line in Rows4)
            {
                string[] columns = line.Split(';');
                comboBox2.Text = line;
            }
            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows5 = qb.GetData("SELECT time_seance FROM (timetable t join seance s on t.id_seance=s.id_seance)  where id_timetable='" + Raspisanie.ind + " '   ;");
            foreach (string line in Rows5)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }
            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows6 = qb.GetData("SELECT price FROM (timetable t join seance s on t.id_seance=s.id_seance)  where id_timetable='" + Raspisanie.ind + " '   ;");
            foreach (string line in Rows6)
            {
                string[] columns = line.Split(';');
                textBox2.Text = line;
            }
            QueryDataBase qb4 = new QueryDataBase();
            string[] Rows7 = qb.GetData("SELECT date_timetable FROM cinema.timetable where id_timetable='" + Raspisanie.ind + " '   ;");
            foreach (string line in Rows7)
            {
                string[] columns = line.Split(';');
                maskedTextBox1.Text = line;
            }
            string[] Rows8 = qb.GetData("SELECT s.id_seance  FROM (timetable t join seance s on t.id_seance=s.id_seance)  where id_timetable='" + Raspisanie.ind + " '   ;");
            foreach (string line in Rows8)
            {
                string[] columns = line.Split(';');
                textBox3.Text = line;
            }

        }

        private void RaspisanieIzm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raspisanie R = new Raspisanie();
            R.Show();
            this.Hide();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {

            string d = "";
            string d1 = "";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (comboBox1.Text == dataGridView1[1, i].Value.ToString())
                { d = dataGridView1[0, i].Value.ToString(); }
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (comboBox2.Text == dataGridView2[1, i].Value.ToString())
                { d1 = dataGridView2[0, i].Value.ToString(); }
            }

            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0 && comboBox1.Text.Length != 0 && comboBox2.Text.Length != 0)
            {

                QueryDataBase qb = new QueryDataBase();


                qb.GetData("UPDATE `cinema`.`seance` SET `id_film`='" + d + "', `id_hall`='" + d1 + "', `time_seance`='" + textBox1.Text + "', `price`='" + textBox2.Text + "' WHERE `id_seance`='" + textBox3.Text + "';");
                MessageBox.Show("Изменение Прошло успешно");
                qb.GetData("UPDATE `cinema`.`timetable` SET `date_timetable`='" + maskedTextBox1.Text + "' WHERE `id_timetable`='" + Raspisanie.ind + "';");
                MessageBox.Show("Изменение Прошло успешно");
            }
            else
            {
                MessageBox.Show("Изменение не выполнено");
            }
        }

    
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
