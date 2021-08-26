using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Generics
{
    public partial class Form1 : Form
    {
        Combining combining = new Combining();
        GenericReadOnly<Student> student = new GenericReadOnly<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lengthArr1 = int.Parse(textBox1.Text);
            int[] arr1 = new int[lengthArr1];
            int lengthArr2 = int.Parse(textBox2.Text);
            int[] arr2 = new int[lengthArr2];

            int[] combinedArr = combining.Combine<int>(arr1, arr2);
            textBox3.Text = combinedArr.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(student.Switch == false)
            {
                student.Switch = true;
                MessageBox.Show("Now you can add!");
            }
            else
            {
                student.Switch = false;
                MessageBox.Show("Now you can't add!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.Id = int.Parse(textBox4.Text);
            try
            {
                student.Add(student1);   
            }
            catch (InvalidOperationException)
            {

                MessageBox.Show("First make sure you're not readonly!");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == "מספר")
            {
                SortedArr<double> sortedArrDouble = new SortedArr<double>();
                sortedArrDouble.Add(double.Parse(textBox6.Text));
                MessageBox.Show("נוסף בהצלחה");
            }
            else if (textBox5.Text == "תו")
            {
                SortedArr<char> sortedArrChar = new SortedArr<char>();
                if(textBox6.Text.Length == 1)
                {
                    char arrVal = textBox6.Text[0];
                    sortedArrChar.Add(arrVal);
                    MessageBox.Show("נוסף בהצלחה");
                }
                else
                {
                    MessageBox.Show("איבר לא תקין");
                }
            }


        }
    }
}
