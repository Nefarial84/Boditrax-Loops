using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int loopStart;
            int loopEnd;
            int multiplyBy;
            
            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);
            multiplyBy = int.Parse(textBox3.Text);
            listBox1.Items.Clear();

            for (int i = loopStart; i <= loopEnd; i++)
            {

                answer = multiplyBy * i;

                listBox1.Items.Add(i+" Times " + multiplyBy + " = " + answer.ToString());
            }

           // MessageBox.Show(answer.ToString(), "Answer to Loop", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
