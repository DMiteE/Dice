using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dice
{
    public partial class Form1 : Form
    {

        public static bool flag1 = false;
        public static bool flag2 = false;
        public static bool flag3 = false;
        public static bool flag4 = false;
        public static bool flag5 = false;
        public static bool flag6 = false;

        int dice1;
        int dice2;
        int dice3;
        string name;
        string name1;
        int suma1 = 0;
        int suma2 = 0;
        int suma11 = 0;
        int suma22 = 0;
        private void SetCurrentTaskNumberPartC(Random random)
        { 
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);
            dice3 = random.Next(1, 7);
        }
        public Form1()
        {
            InitializeComponent();

        }
        private void Winner() {
            if (suma1 == 0 || suma11 == 0)
            {

            }
            else
            {
                if (suma1 > suma11)
                {
                    label3.Text = "Выйграл: " + name;
                }
                else if (suma1 < suma11)
                {
                    label3.Text = "Выйграл: " + name1;
                }
                else if (suma1 == suma11)
                {
                    label3.Text = "Ничья";
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            if (flag1 == true)
            {
               
                for (int k = 1; k < 10; k++)
                {
                    SetCurrentTaskNumberPartC(random);
                    label4.Text += dice1 + "\n";
                    suma1 += (dice1 + dice1)/2;
                    flag1 = false;
                   

                }


            }
            else if (flag2 == true)
            {
                
                for (int i = 0; i < 10; i++)
                {
                    SetCurrentTaskNumberPartC(random);
                    label4.Text += dice1 + "  ||  " + dice2 + "\n";
                    suma2 = dice1 + dice2;
                    suma1 += (suma2 + suma2)/2;
                    flag2 = false;
                }
            }
            else if (flag3 == true) {
                
                for (int i = 0; i < 10; i++)
                {
                    SetCurrentTaskNumberPartC(random);
                    label4.Text += dice1 + "  ||  " + dice2 + "  ||  " + dice3 + "\n";
                    suma2 = dice1 + dice2 + dice3;
                    suma1 += (suma2 + suma2) / 2;
                    flag3 = false;
                }
            }
            label1.Text = "Сумма равна: " + suma1;
            Winner();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try {
                name = Convert.ToString(textBox1.Text);
            }
            catch
            {
                textBox1.Focus();
            }

            try
            {
                name1 = Convert.ToString(textBox2.Text);
            }
            catch
            {
                textBox2.Focus();
            }
        }




        private void button5_Click_1(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
            flag1 = true;
            flag4 = true;
            label4.Text = "";
            label1.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
            flag2 = true;
            flag5 = true;
            label4.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
            flag3 = true;
            flag6 = true;
            label4.Text = "";
            label1.Text = "";
        }




        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

      
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            Random random = new Random();
            if (flag4 == true)
            {

                for (int k = 1; k < 10; k++)
                {
                    SetCurrentTaskNumberPartC(random);
                    label5.Text += dice1 + "\n";
                    suma11 += (dice1 + dice1) / 2;
                    flag4 = false;


                }


            }
            else if (flag5 == true)
            {

                for (int i = 0; i < 10; i++)
                {
                    SetCurrentTaskNumberPartC(random);
                    label5.Text += dice1 + "  ||  " + dice2 + "\n";
                    suma22 = dice1 + dice2;
                    suma11 += (suma22 + suma22) / 2;
                    flag5 = false;
                }
            }
            else if (flag6 == true)
            {

                for (int i = 0; i < 10; i++)
                {
                    SetCurrentTaskNumberPartC(random);
                    label5.Text += dice1 + "  ||  " + dice2 + "  ||  " + dice3 + "\n";
                    suma22 = dice1 + dice2 + dice3;
                    suma11 += (suma22 + suma22) / 2;
                    flag6 = false;
                }
            }
            label2.Text = "Сумма равна: " + suma11;
            Winner();
        }
        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text= "";
            label4.Text = "";
            label2.Text = "";
            label5.Text = "";
            label3.Text = "";
            suma11 = 0;
            suma1 = 0;

        }
    }
}
