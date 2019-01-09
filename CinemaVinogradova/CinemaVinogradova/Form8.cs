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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            QueryDataBase qb = new QueryDataBase();
            string[] Rows = qb.GetData("SELECT name_film FROM cinema.film where id_film='" + Form5.ind + " '   ;");
            foreach (string line in Rows)
            {
                string[] columns = line.Split(';');
                textBox1.Text = line;
            }
            QueryDataBase qb1 = new QueryDataBase();
            string[] Rows1 = qb.GetData("SELECT lasting FROM cinema.film where id_film='" + Form5.ind + " '   ;");
            foreach (string line in Rows1)
            {
                string[] columns = line.Split(';');
                textBox2.Text = line;
            }
            QueryDataBase qb2 = new QueryDataBase();
            string[] Rows2 = qb.GetData("SELECT producer FROM cinema.film where id_film='" + Form5.ind + " ' ;");
            foreach (string line in Rows2)
            {
                string[] columns = line.Split(';');
                textBox3.Text = line;
            }
            QueryDataBase qb3 = new QueryDataBase();
            string[] Rows3 = qb.GetData("SELECT genre FROM cinema.film where id_film='" + Form5.ind + " ' ;");
            foreach (string line in Rows3)
            {
                string[] columns = line.Split(';');
                comboBox1.Text = line;
            }
            QueryDataBase qb4 = new QueryDataBase();
            string[] Rows4 = qb.GetData("SELECT Main_male_role FROM cinema.film where id_film='" + Form5.ind + " ' ;");
            foreach (string line in Rows4)
            {
                string[] columns = line.Split(';');
                textBox4.Text = line;
            }

            QueryDataBase qb5 = new QueryDataBase();
            string[] Rows5 = qb.GetData("SELECT Main_female_role FROM cinema.film where id_film='" + Form5.ind + " ' ;");
            foreach (string line in Rows5)
            {
                string[] columns = line.Split(';');
                textBox5.Text = line;
            }

          
            string[] Rows6 = qb.GetData("SELECT limitation FROM cinema.film where id_film='" + Form5.ind + " ' ;");
            foreach (string line in Rows6)
            {
                string[] columns = line.Split(';');
                textBox6.Text = line;
            }
            string[] Rows7 = qb.GetData("SELECT description FROM cinema.film where id_film='" + Form5.ind + " ' ;");
            foreach (string line in Rows7)
            {
                string[] columns = line.Split(';');
                textBox7.Text = line;
            }
        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && comboBox1.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0 && textBox7.Text.Length != 0)
                {

                    QueryDataBase qb = new QueryDataBase();


                    qb.GetData("UPDATE `cinema`.`film` SET `name_film`='"+textBox1.Text+ "', `lasting`='" + textBox2.Text + "', `producer`='" + textBox3.Text + "', `description`='" + textBox7.Text + "', `limitation`='" + textBox6.Text + "', `genre`='" + comboBox1.Text + "', `Main_male_role`='" + textBox4.Text + "', `Main_female_role`='" + textBox5.Text + "' WHERE `id_film`='" + Form5.ind + "';");
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
    }
}
