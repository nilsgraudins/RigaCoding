using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string enteredNumber = "";
        string operation = "";
        bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
            

        }
        private void number_clicked(int num)
        {
            if(isOperationClicked)
            {
                Izvade.Text = "";
                isOperationClicked = false;
            }

            if(Izvade.Text == "0")
            {
                Izvade.Text = "";
            }

            Izvade.Text += num.ToString();
        }
        private void operation_clicked(string op)
        {

            //1. šobrīd attēlotais skaitlis jāsaglabā kā "enteredNumber"
            enteredNumber = Izvade.Text;
            //2. izvēlētā darbība jāsaglabā kā "operation"
            operation = op;
            //3. spiežot ciparu pēc darbības - jāsāk jauna ievade
            isOperationClicked = true;

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            number_clicked(0);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            number_clicked(1);

        }

        private void button_2_Click(object sender, EventArgs e)
        {
            number_clicked(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            number_clicked(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            number_clicked(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            number_clicked(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            number_clicked(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            number_clicked(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            number_clicked(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            number_clicked(9);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            Izvade.Text = "";
        }

        private void buttonDalits_Click(object sender, EventArgs e)
        {
            operation_clicked("/");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation_clicked("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation_clicked("-");
        }

        private void buttonReiz_Click(object sender, EventArgs e)
        {
            operation_clicked("*");
        }

        private void buttonVienads_Click(object sender, EventArgs e)
        {

        }
    }
}
