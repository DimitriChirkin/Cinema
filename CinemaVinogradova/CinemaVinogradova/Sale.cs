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
    public partial class Sale : Form
    {
        public static string ind ="";
        public static int kolB=0;
        String[] Rows;
        String[] Places;
        public Sale()
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

            string[] Rows1 = qb.GetData("SELECT id_employees , surname FROM cinema.employees;");
            foreach (string line in Rows1)
            {

                string[] columns = line.Split(';');
                dataGridView2.Rows.Add(columns);
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            { comboBox7.Items.Add(dataGridView2[1, i].Value.ToString()); }
            textBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBox2.Text = DateTime.Now.ToLongTimeString();

           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            dataGridView4.Rows.Clear();
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            try

            {
                if (comboBox2.Text != "")
                {
                    if (comboBox2.Text == DateTime.Now.ToString("yyyy-MM-dd"))
                    {
                        QueryDataBase qb1 = new QueryDataBase();
                        string[] Rows1 = qb1.GetData("SELECT  s.time_seance FROM cinema.timetable t join seance s on t.id_seance=s.id_seance  where date_timetable = '" + comboBox2.Text + "' and time_seance>='"+ DateTime.Now.ToShortTimeString() +"';");
                        foreach (string line in Rows1)
                        {

                            string[] columns = line.Split(';');
                            dataGridView4.Rows.Add(columns);
                        }
                    }
                    else
                    {
                        QueryDataBase qb = new QueryDataBase();
                        string[] Rows = qb.GetData("SELECT  s.time_seance FROM cinema.timetable t join seance s on t.id_seance=s.id_seance  where date_timetable = '" + comboBox2.Text + "' ;");
                        foreach (string line in Rows)
                        {

                            string[] columns = line.Split(';');
                            dataGridView4.Rows.Add(columns);
                        }
                    }
                    for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                    { comboBox3.Items.Add(dataGridView4[0, i].Value.ToString()); }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { }
            catch (NullReferenceException) { }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            try

            {
              
                if (comboBox1.Text != "")
                {
                    QueryDataBase qb = new QueryDataBase();
                    string[] Rows = qb.GetData("SELECT distinct  date_timetable FROM (cinema.timetable t join seance s on t.id_seance=s.id_seance) join film f on s.id_film=f.id_film where name_film='" + comboBox1.Text + "'and  date_timetable>=CURRENT_DATE()  ;");
                    foreach (string line in Rows)
                    {

                        string[] columns = line.Split(';');
                        dataGridView3.Rows.Add(columns);
                    }
                    for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                    { comboBox2.Items.Add(dataGridView3[0, i].Value.ToString()); }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { }
            catch (NullReferenceException) { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
            comboBox4.Items.Clear();
          
            comboBox4.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            try

            {
                if (comboBox3.Text != "")
                {
                    
                    QueryDataBase qb = new QueryDataBase();
                    string[] Rows = qb.GetData("SELECT distinct  h.name_hall FROM (timetable t join seance s  on t.id_seance=s.id_seance) join hall h on s.id_hall=h.id_hall where s.time_seance='" + comboBox3.Text+"' and t.date_timetable='"+comboBox2.Text+"'   ;");
                    foreach (string line in Rows)
                    {

                        string[] columns = line.Split(';');
                        dataGridView5.Rows.Add(columns);
                    }
                    for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
                    { comboBox4.Items.Add(dataGridView5[0, i].Value.ToString()); }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { }
            catch (NullReferenceException) { }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
                QueryDataBase qb = new QueryDataBase();
                string[] Rows6 = qb.GetData("SELECT id_timetable FROM ((timetable t join seance s on t.id_seance=s.id_seance) join film f on f.id_film=s.id_film) join hall h on s.id_hall=h.id_hall where t.date_timetable='" + comboBox2.Text + "' and f.name_film='" + comboBox1.Text + "' and s.time_seance='" + comboBox3.Text + "' and h.name_hall='" + comboBox4.Text + "';");
                foreach (string line in Rows6)
                {

                    string[] columns = line.Split(';');
                    dataGridView6.Rows.Add(columns);
                }
            
       
            ind = dataGridView6[0, 0].Value.ToString();
            if (comboBox4.Text == "Gold")
            {
                Gold R = new Gold();
                R.Show();
             
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                int k;
                int j;
                int y;
                textBox3.Text = Gold.row;
            textBox4.Text = Gold.place;

             Rows = textBox3.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
             Places = textBox4.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                kolB = Rows.Length;
            QueryDataBase qb = new QueryDataBase();
            string[] Rows6 = qb.GetData("SELECT s.price FROM cinema.timetable t join seance s on t.id_seance=s.id_seance where id_timetable="+ind+";");
            foreach (string line in Rows6)
            {

                string[] columns = line.Split(';');
                dataGridView9.Rows.Add(columns);
            }
                k = Convert.ToInt32(dataGridView9[0, 0].Value.ToString());
                j = Rows.Length;
                y = k * j; 
            textBox5.Text = y.ToString();        
            Gold.row = "";
            Gold.place = "";
        }
            catch (MySql.Data.MySqlClient.MySqlException) { }
            catch (NullReferenceException) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {   if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && textBox1.Text != "" && textBox2.Text != "" && comboBox7.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try

                {
                    string d = "";
                    string d2 = "";
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        if (comboBox7.Text == dataGridView2[1, i].Value.ToString())
                        { d = dataGridView2[0, i].Value.ToString(); }
                    }

                    QueryDataBase qb = new QueryDataBase();
                    qb.InsertData("INSERT INTO `cinema`.`tab` (`id_employees`, `date_sale`, `time_sale`) VALUES ('" + d + "', '" + textBox1.Text + "', '" + textBox2.Text + "');");

                    string[] Rows6 = qb.GetData("SELECT id_tab FROM cinema.tab where date_sale ='" + textBox1.Text + "' and time_sale = '" + textBox2.Text + "';");
                    foreach (string line in Rows6)
                    {

                        string[] columns = line.Split(';');
                        dataGridView7.Rows.Add(columns);
                    }
                    d2 = dataGridView7[0, 0].Value.ToString();
                    for (int i = 0; i < Rows.Length; i++)
                    {
                        string[] Rows5 = qb.GetData("SELECT id_place FROM cinema.place p join hall h on p.id_hall=h.id_hall where h.name_hall='" + comboBox4.Text + "' and p.row_place='" + Rows[i] + "' and p.place='" + Places[i] + "';");

                        foreach (string line in Rows5)
                        {

                            string[] columns = line.Split(';');
                            dataGridView8.Rows.Add(columns);
                        }
                    }
                    for (int i = 0; i < dataGridView8.Rows.Count - 1; i++)
                    {
                        qb.InsertData("INSERT INTO `cinema`.`ticket` (`id_tab`, `id_timetable`, `id_place`) VALUES ('" + d2 + "', '" + ind + "', '" + dataGridView8[0, i].Value.ToString() + "');");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException) { }
                catch (NullReferenceException) { }
                MessageBox.Show("Продажа прошла успешно ");
                System.IO.FileStream fs = new System.IO.FileStream(@"C:\Users\PC\Desktop\Cinema\1.txt", System.IO.FileMode.Create);
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(fs);

                try
                {
                    streamWriter.WriteLine("           Чек");
                    streamWriter.WriteLine("==========================");
                    streamWriter.WriteLine("Дата продажи - " + textBox1.Text);
                    streamWriter.WriteLine("Время продажи - " + textBox2.Text);
                    streamWriter.WriteLine("Продавец - " + comboBox7.Text);
                    streamWriter.WriteLine("==========================");
                    streamWriter.WriteLine("Фильм - " + comboBox1.Text);
                    streamWriter.WriteLine("Дата Сеанса - " + comboBox2.Text);
                    streamWriter.WriteLine("Время Сеанса - " + comboBox3.Text);
                    streamWriter.WriteLine("Зал - " + comboBox4.Text);
                    streamWriter.WriteLine("Количество Билетов - " + kolB);
                    streamWriter.WriteLine("Цена - " + textBox5.Text);
                    streamWriter.WriteLine("==========================");
                    streamWriter.Close();
                    fs.Close();

                    MessageBox.Show("Чек успешно сохранен");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении файла!");
                }

                System.IO.FileStream fs1 = new System.IO.FileStream(@"C:\Users\PC\Desktop\Cinema\2.txt", System.IO.FileMode.Create);
                System.IO.StreamWriter streamWrite = new System.IO.StreamWriter(fs1);
                for (int i = 0; i < kolB; i++)
                {
                    try
                    {
                        streamWrite.WriteLine("           Билет");
                        streamWrite.WriteLine("==========================");
                        streamWrite.WriteLine("Фильм - " + comboBox1.Text);
                        streamWrite.WriteLine("Дата Сеанса - " + comboBox2.Text);
                        streamWrite.WriteLine("Время Сеанса - " + comboBox3.Text);
                        streamWrite.WriteLine("Зал - " + comboBox4.Text);
                        streamWrite.WriteLine("Ряд " + Rows[i]);
                        streamWrite.WriteLine("Место " + Places[i]);
                        streamWrite.WriteLine("Цена - " + dataGridView9[0, 0].Value.ToString());
                        streamWrite.WriteLine("==========================");


                       
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при сохранении файла!");
                    }
                }
                MessageBox.Show("Билет успешно сохранен");
                streamWrite.Close();
                fs1.Close();


            }
            else { MessageBox.Show("Заполните поля"); }
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
