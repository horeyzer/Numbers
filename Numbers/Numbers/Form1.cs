using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int m, n;
        List<System.Windows.Forms.TextBox> s;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);


            s = new List<System.Windows.Forms.TextBox>(); 
            
            
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= m; i++)
                {
                    System.Windows.Forms.TextBox tB = new System.Windows.Forms.TextBox();
                    tB.Location = new System.Drawing.Point(i * 50, j * 30+70);
                    tB.Name = "tB" + i;
                    tB.Size = new System.Drawing.Size(50, 30);
                    tB.TabIndex = i;
                    this.Controls.Add(tB);
                    s.Add(tB);
                }
                s[0].Text = "Hello";
                s[1].Text = "Bye";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            int p = 0;
            string[,] Val = new string[n, m];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    Val[j, i] = s[p].Text;
                    p++;
                }
                a++;
            }
        }
    }
}
