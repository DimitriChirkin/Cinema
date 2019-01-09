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
    public partial class Gold : Form
    { 
        public static string row="";
        public static string place="";
        public Gold()
        {   string CBi1 = "1";
            
                String CBj1 = "1";
                String CBj2 = "2";
                String CBj3 = "3";
                String CBj4 = "4";
                String CBj5 = "5";
                String CBj6 = "6";
                String CBj7 = "7";
                String CBj8 = "8";
                String CBj9 = "9";
                String CBj10 = "10";
          
            string CBi2 = "2";
            
                String CBj21 = "1";
                String CBj22 = "2";
                String CBj23 = "3";
                String CBj24 = "4";
                String CBj25 = "5";
                String CBj26 = "6";
                String CBj27 = "7";
                String CBj28 = "8";
                String CBj29 = "9";
                String CBj210 = "10";
                String CBj211 = "11";
                String CBj212 = "12";

            string CBi3 = "3";

            String CBj31 = "1";
            String CBj32 = "2";
            String CBj33 = "3";
            String CBj34 = "4";
            String CBj35 = "5";
            String CBj36 = "6";
            String CBj37 = "7";
            String CBj38 = "8";
            String CBj39 = "9";
            String CBj310 = "10";

            string CBi4 = "4";

            String CBj41 = "1";
            String CBj42 = "2";
            String CBj43 = "3";
            String CBj44 = "4";
            String CBj45 = "5";
            String CBj46 = "6";
            String CBj47 = "7";
            String CBj48 = "8";
            String CBj49 = "9";
            String CBj410 = "10";
            String CBj411 = "11";
            String CBj412 = "12";

            string CBi5 = "5";

            String CBj51 = "1";
            String CBj52 = "2";
            String CBj53 = "3";
            String CBj54 = "4";
            String CBj55 = "5";
            String CBj56 = "6";
            String CBj57 = "7";
            String CBj58 = "8";
            String CBj59 = "9";
            String CBj510 = "10";
            String CBj511 = "11";
            String CBj512 = "12";

            string CBi6 = "6";

            String CBj61 = "1";
            String CBj62 = "2";
            String CBj63 = "3";
            String CBj64 = "4";
            String CBj65 = "5";
            String CBj66 = "6";
            String CBj67 = "7";
            String CBj68 = "8";
            String CBj69 = "9";
            String CBj610 = "10";
            String CBj611 = "11";
            String CBj612 = "12";

            InitializeComponent();
            try
            {
                QueryDataBase qb = new QueryDataBase();
                string[] Rows = qb.GetData("SELECT p.row_place, p.place FROM ticket t join place p on  t.id_place=p.id_place where id_timetable='" + Sale.ind + "';");
                foreach (string line in Rows)
                {

                    string[] columns = line.Split(';');
                    dataGridView1.Rows.Add(columns);
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (CBi1 == dataGridView1[0, i].Value.ToString())
                    {

                        if (CBj1 == dataGridView1[1, i].Value.ToString())
                        { checkBox1.Enabled = false; }
                        if (CBj2 == dataGridView1[1, i].Value.ToString())
                        { checkBox2.Enabled = false; }
                        if (CBj3 == dataGridView1[1, i].Value.ToString())
                        { checkBox3.Enabled = false; }
                        if (CBj4 == dataGridView1[1, i].Value.ToString())
                        { checkBox4.Enabled = false; }
                        if (CBj5 == dataGridView1[1, i].Value.ToString())
                        { checkBox5.Enabled = false; }
                        if (CBj6 == dataGridView1[1, i].Value.ToString())
                        { checkBox6.Enabled = false; }
                        if (CBj7 == dataGridView1[1, i].Value.ToString())
                        { checkBox7.Enabled = false; }
                        if (CBj8 == dataGridView1[1, i].Value.ToString())
                        { checkBox8.Enabled = false; }
                        if (CBj9 == dataGridView1[1, i].Value.ToString())
                        { checkBox9.Enabled = false; }
                        if (CBj10 == dataGridView1[1, i].Value.ToString())
                        { checkBox10.Enabled = false; }
                    }
                    if (CBi2 == dataGridView1[0, i].Value.ToString())
                    {

                        if (CBj21 == dataGridView1[1, i].Value.ToString())
                        { checkBox20.Enabled = false; }
                        if (CBj22 == dataGridView1[1, i].Value.ToString())
                        { checkBox19.Enabled = false; }
                        if (CBj23 == dataGridView1[1, i].Value.ToString())
                        { checkBox18.Enabled = false; }
                        if (CBj24 == dataGridView1[1, i].Value.ToString())
                        { checkBox17.Enabled = false; }
                        if (CBj25 == dataGridView1[1, i].Value.ToString())
                        { checkBox16.Enabled = false; }
                        if (CBj26 == dataGridView1[1, i].Value.ToString())
                        { checkBox15.Enabled = false; }
                        if (CBj27 == dataGridView1[1, i].Value.ToString())
                        { checkBox14.Enabled = false; }
                        if (CBj28 == dataGridView1[1, i].Value.ToString())
                        { checkBox13.Enabled = false; }
                        if (CBj29 == dataGridView1[1, i].Value.ToString())
                        { checkBox12.Enabled = false; }
                        if (CBj210 == dataGridView1[1, i].Value.ToString())
                        { checkBox11.Enabled = false; }
                        if (CBj211 == dataGridView1[1, i].Value.ToString())
                        { checkBox21.Enabled = false; }
                        if (CBj212 == dataGridView1[1, i].Value.ToString())
                        { checkBox22.Enabled = false; }
                    }
                    if (CBi3 == dataGridView1[0, i].Value.ToString())
                    {

                        if (CBj31 == dataGridView1[1, i].Value.ToString())
                        { checkBox32.Enabled = false; }
                        if (CBj32 == dataGridView1[1, i].Value.ToString())
                        { checkBox31.Enabled = false; }
                        if (CBj33 == dataGridView1[1, i].Value.ToString())
                        { checkBox30.Enabled = false; }
                        if (CBj34 == dataGridView1[1, i].Value.ToString())
                        { checkBox29.Enabled = false; }
                        if (CBj35 == dataGridView1[1, i].Value.ToString())
                        { checkBox28.Enabled = false; }
                        if (CBj36 == dataGridView1[1, i].Value.ToString())
                        { checkBox27.Enabled = false; }
                        if (CBj37 == dataGridView1[1, i].Value.ToString())
                        { checkBox26.Enabled = false; }
                        if (CBj38 == dataGridView1[1, i].Value.ToString())
                        { checkBox25.Enabled = false; }
                        if (CBj39 == dataGridView1[1, i].Value.ToString())
                        { checkBox24.Enabled = false; }
                        if (CBj310 == dataGridView1[1, i].Value.ToString())
                        { checkBox23.Enabled = false; }
                    }
                    if (CBi4 == dataGridView1[0, i].Value.ToString())
                    {

                        if (CBj41 == dataGridView1[1, i].Value.ToString())
                        { checkBox44.Enabled = false; }
                        if (CBj42 == dataGridView1[1, i].Value.ToString())
                        { checkBox43.Enabled = false; }
                        if (CBj43 == dataGridView1[1, i].Value.ToString())
                        { checkBox42.Enabled = false; }
                        if (CBj44 == dataGridView1[1, i].Value.ToString())
                        { checkBox41.Enabled = false; }
                        if (CBj45 == dataGridView1[1, i].Value.ToString())
                        { checkBox40.Enabled = false; }
                        if (CBj46 == dataGridView1[1, i].Value.ToString())
                        { checkBox39.Enabled = false; }
                        if (CBj47 == dataGridView1[1, i].Value.ToString())
                        { checkBox38.Enabled = false; }
                        if (CBj48 == dataGridView1[1, i].Value.ToString())
                        { checkBox37.Enabled = false; }
                        if (CBj49 == dataGridView1[1, i].Value.ToString())
                        { checkBox36.Enabled = false; }
                        if (CBj410 == dataGridView1[1, i].Value.ToString())
                        { checkBox35.Enabled = false; }
                        if (CBj411 == dataGridView1[1, i].Value.ToString())
                        { checkBox34.Enabled = false; }
                        if (CBj412 == dataGridView1[1, i].Value.ToString())
                        { checkBox33.Enabled = false; }
                    }

                    if (CBi5 == dataGridView1[0, i].Value.ToString())
                    {

                        if (CBj51 == dataGridView1[1, i].Value.ToString())
                        { checkBox56.Enabled = false; }
                        if (CBj52 == dataGridView1[1, i].Value.ToString())
                        { checkBox55.Enabled = false; }
                        if (CBj53 == dataGridView1[1, i].Value.ToString())
                        { checkBox54.Enabled = false; }
                        if (CBj54 == dataGridView1[1, i].Value.ToString())
                        { checkBox53.Enabled = false; }
                        if (CBj55 == dataGridView1[1, i].Value.ToString())
                        { checkBox52.Enabled = false; }
                        if (CBj56 == dataGridView1[1, i].Value.ToString())
                        { checkBox51.Enabled = false; }
                        if (CBj57 == dataGridView1[1, i].Value.ToString())
                        { checkBox50.Enabled = false; }
                        if (CBj58 == dataGridView1[1, i].Value.ToString())
                        { checkBox49.Enabled = false; }
                        if (CBj59 == dataGridView1[1, i].Value.ToString())
                        { checkBox48.Enabled = false; }
                        if (CBj510 == dataGridView1[1, i].Value.ToString())
                        { checkBox47.Enabled = false; }
                        if (CBj511 == dataGridView1[1, i].Value.ToString())
                        { checkBox46.Enabled = false; }
                        if (CBj512 == dataGridView1[1, i].Value.ToString())
                        { checkBox45.Enabled = false; }
                    }

                    if (CBi6 == dataGridView1[0, i].Value.ToString())
                    {

                        if (CBj61 == dataGridView1[1, i].Value.ToString())
                        { checkBox68.Enabled = false; }
                        if (CBj62 == dataGridView1[1, i].Value.ToString())
                        { checkBox67.Enabled = false; }
                        if (CBj63 == dataGridView1[1, i].Value.ToString())
                        { checkBox66.Enabled = false; }
                        if (CBj64 == dataGridView1[1, i].Value.ToString())
                        { checkBox65.Enabled = false; }
                        if (CBj65 == dataGridView1[1, i].Value.ToString())
                        { checkBox64.Enabled = false; }
                        if (CBj66 == dataGridView1[1, i].Value.ToString())
                        { checkBox63.Enabled = false; }
                        if (CBj67 == dataGridView1[1, i].Value.ToString())
                        { checkBox62.Enabled = false; }
                        if (CBj68 == dataGridView1[1, i].Value.ToString())
                        { checkBox61.Enabled = false; }
                        if (CBj69 == dataGridView1[1, i].Value.ToString())
                        { checkBox60.Enabled = false; }
                        if (CBj610 == dataGridView1[1, i].Value.ToString())
                        { checkBox59.Enabled = false; }
                        if (CBj611 == dataGridView1[1, i].Value.ToString())
                        { checkBox58.Enabled = false; }
                        if (CBj612 == dataGridView1[1, i].Value.ToString())
                        { checkBox57.Enabled = false; }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException) { }
            catch (NullReferenceException) { }

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gold_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gold_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                row += "1;";
                place += "1;";
            }
            if (checkBox2.Checked == true)
            {
                row += "1;";
                place += "2;";
            }
            if (checkBox3.Checked == true)
            {
                row += "1;";
                place += "3;";
            }
            if (checkBox4.Checked == true)
            {
                row += "1;";
                place += "4;";
            }
            if (checkBox5.Checked == true)
            {
                row += "1;";
                place += "5;";
            }
            if (checkBox6.Checked == true)
            {
                row += "1;";
                place += "6;";
            }
            if (checkBox7.Checked == true)
            {
                row += "1;";
                place += "7;";
            }
            if (checkBox8.Checked == true)
            {
                row += "1;";
                place += "8;";
            }
            if (checkBox9.Checked == true)
            {
                row += "1;";
                place += "9;";
            }
            if (checkBox10.Checked == true)
            {
                row += "1;";
                place += "10;";
            }
            if (checkBox20.Checked == true)
            {
                row += "2;";
                place += "1;";
            }
            if (checkBox19.Checked == true)
            {
                row += "2;";
                place += "2;";
            }
            if (checkBox18.Checked == true)
            {
                row += "2;";
                place += "3;";
            }
            if (checkBox17.Checked == true)
            {
                row += "2;";
                place += "4;";

            }
            if (checkBox16.Checked == true)
            {
                row += "2;";
                place += "5;";
            }
            if (checkBox15.Checked == true)
            {
                row += "2;";
                place += "6;";
            }
            if (checkBox14.Checked == true)
            {
                row += "2;";
                place += "7;";
            }
            if (checkBox13.Checked == true)
            {
                row += "2;";
                place += "8;";
            }
            if (checkBox12.Checked == true)
            {
                row += "2;";
                place += "9;";
            }
            if (checkBox11.Checked == true)
            {
                row += "2;";
                place += "10;";
            }
            if (checkBox21.Checked == true)
            {
                row += "2;";
                place += "11;";
            }
            if (checkBox22.Checked == true)
            {
                row += "2;";
                place += "12;";
            }
            if (checkBox32.Checked == true)
            {
                row += "3;";
                place += "1;";
            }
            if (checkBox31.Checked == true)
            {
                row += "3;";
                place += "2;";
            }
            if (checkBox30.Checked == true)
            {
                row += "3;";
                place += "3;";
            }
            if (checkBox29.Checked == true)
            {
                row += "3;";
                place += "4;";
            }
            if (checkBox28.Checked == true)
            {
                row += "3;";
                place += "5;";
            }
            if (checkBox27.Checked == true)
            {
                row += "3;";
                place += "6;";
            }
            if (checkBox26.Checked == true)
            {
                row += "3;";
                place += "7;";
            }
            if (checkBox25.Checked == true)
            {
                row += "3;";
                place += "8;";
            }
            if (checkBox24.Checked == true)
            {
                row += "3;";
                place += "9;";
            }
            if (checkBox23.Checked == true)
            {
                row += "3;";
                place += "10;";
            }
            if (checkBox44.Checked == true)
            {
                row += "4;";
                place += "1;";
            }
            if (checkBox43.Checked == true)
            {
                row += "4;";
                place += "2;";
            }
            if (checkBox42.Checked == true)
            {
                row += "4;";
                place += "3;";
            }
            if (checkBox41.Checked == true)
            {
                row += "4;";
                place += "4;";
            }
            if (checkBox40.Checked == true)
            {
                row += "4;";
                place += "5;";
            }
            if (checkBox39.Checked == true)
            {
                row += "4;";
                place += "6;";
            }
            if (checkBox38.Checked == true)
            {
                row += "4;";
                place += "7;";
            }
            if (checkBox37.Checked == true)
            {
                row += "4;";
                place += "8;";
            }
            if (checkBox36.Checked == true)
            {
                row += "4;";
                place += "9;";
            }
            if (checkBox35.Checked == true)
            {
                row += "4;";
                place += "10;";
            }
            if (checkBox34.Checked == true)
            {
                row += "4;";
                place += "11;";
            }
            if (checkBox33.Checked == true)
            {
                row += "4;";
                place += "12;";
            }
            if (checkBox56.Checked == true)
            {
                row += "5;";
                place += "1;";
            }
            if (checkBox55.Checked == true)
            {
                row += "5;";
                place += "2;";
            }
            if (checkBox54.Checked == true)
            {
                row += "5;";
                place += "3;";
            }
            if (checkBox53.Checked == true)
            {
                row += "5;";
                place += "4;";
            }
            if (checkBox52.Checked == true)
            {
                row += "5;";
                place += "5;";
            }
            if (checkBox51.Checked == true)
            {
                row += "5;";
                place += "6;";
            }
            if (checkBox50.Checked == true)
            {
                row += "7;";
                place += "1;";
            }
            if (checkBox49.Checked == true)
            {
                row += "5;";
                place += "8;";
            }
            if (checkBox48.Checked == true)
            {
                row += "5;";
                place += "9;";
            }
            if (checkBox47.Checked == true)
            {
                row += "5;";
                place += "10;";
            }
            if (checkBox46.Checked == true)
            {
                row += "5;";
                place += "11;";
            }
            if (checkBox45.Checked == true)
            {
                row += "5;";
                place += "12;";
            }
            if (checkBox68.Checked == true)
            {
                row += "6;";
                place += "1;";
            }
            if (checkBox67.Checked == true)
            {
                row += "6;";
                place += "2;";
            }
            if (checkBox66.Checked == true)
            {
                row += "6;";
                place += "3;";
            }
            if (checkBox65.Checked == true)
            {
                row += "6;";
                place += "4;";
            }
            if (checkBox64.Checked == true)
            {
                row += "6;";
                place += "5;";
            }
            if (checkBox63.Checked == true)
            {
                row += "6;";
                place += "6;";
            }
            if (checkBox62.Checked == true)
            {
                row += "6;";
                place += "7;";
            }
            if (checkBox61.Checked == true)
            {
                row += "6;";
                place += "8;";
            }
            if (checkBox60.Checked == true)
            {
                row += "6;";
                place += "9;";
            }
            if (checkBox59.Checked == true)
            {
                row += "6;";
                place += "10;";
            }
            if (checkBox58.Checked == true)
            {
                row += "6;";
                place += "11;";
            }
            if (checkBox57.Checked == true)
            {
                row += "6;";
                place += "12;";
            }
        }
    }
 
}
