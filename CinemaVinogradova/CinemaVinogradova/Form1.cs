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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale S = new Sale();
            S.Show();
            this.Hide();
        }

        private void Сотрудники_Click(object sender, EventArgs e)
        { 
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Hide();
            
        }

        private void Расписание_Click(object sender, EventArgs e)
        {
            Raspisanie R = new Raspisanie();
            R.Show();
            this.Hide();
        }
    }
}


    

