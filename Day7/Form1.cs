using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            count.Text = "Skaits: ";
            buttonAdd.Click += ButtonAdd_Click;
            buttonMinus.Click += ButtonMinus_Click;
            buttonClean.Click += ButtonClean_Click;
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            inputNumber.Text = "1";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text) - 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //int skaitlis = int.Parse(inputNumber.Text);
            //skaitlis++;
            //inputNumber.Text = skaitlis.ToString();

            //vai-->

            inputNumber.Text = (int.Parse(inputNumber.Text) + 1).ToString();
        }

    }
}
