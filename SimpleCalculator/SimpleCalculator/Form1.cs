using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int FirstValue = 0;
            int SecondValue = 0;
            bool numeric = true;


            numeric = (int.TryParse(textBox1.Text, out FirstValue) && int.TryParse(textBox2.Text
             , out SecondValue));


            if (textBox1.Text != null && textBox2.Text != null && numeric)

            {

                if (AddButton.Checked)

                {
                    AnswerBox.Text = (FirstValue + SecondValue).ToString();
                }



                if (SubtractionButton.Checked)

                {
                    AnswerBox.Text = (FirstValue - SecondValue).ToString();
                }


                if (MultiplicationButton.Checked)

                {
                    AnswerBox.Text = (FirstValue * SecondValue).ToString();
                }


                if (DivisionButton.Checked)

                {
                    AnswerBox.Text = (FirstValue / SecondValue).ToString();
                }



            }

            else
            {
                MessageBox.Show("not integers, silly");
            }


        }
    }
}
