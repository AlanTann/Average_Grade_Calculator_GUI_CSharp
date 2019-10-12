using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Queestion5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(gradeTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int number = 0;
            int totalGrades = 0;
            int totalStudent = 0;
            int numberA = 0;
            int numberB = 0;
            int numberC = 0;
            int numberD = 0;
            int numberF = 0;
            double classAverage = 0;
            string output;

            for (i = 0; i < listBox1.Items.Count; ++i)
            {
                number = Convert.ToInt32(listBox1.Items[i]);
                if (number >= 70 && number <= 100)
                {
                    numberA = numberA + 1;
                }
                else if (number >= 60 && number <= 69)
                {
                    numberB = numberB + 1;
                }
                else if (number >= 50 && number <= 59)
                {
                    numberC = numberC + 1;
                }
                else if (number >= 40 && number <= 49)
                {
                    numberD = numberD + 1;
                }
                else if (number >= 0 && number <= 39)
                {
                    numberF = numberF + 1;
                }
                totalGrades = totalGrades + number;
                totalStudent = totalStudent + 1;
            }

            classAverage = totalGrades / totalStudent;

            output = "Total of the Grades is: " + totalGrades + "\nClass average is "
                + classAverage + "\n\nLetter grade summary:\nA:" + numberA + "\nB:" +numberB
                + "\nC:" + numberC + "\nD:" + numberD + "\nF:" + numberF;

            label4.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
