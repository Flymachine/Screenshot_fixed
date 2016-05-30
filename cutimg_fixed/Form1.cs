using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cutimg_fixed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 cutarea = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            cutarea.Show();
            int a=cutarea.Size.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text= "宽:" + cutarea.Size.Width + ";高:" + cutarea.Size.Height + System.Environment.NewLine + "X:" + cutarea.Location.X + ";Y:" + cutarea.Location.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                cutarea.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cutarea.Show();
        }
    }
}
