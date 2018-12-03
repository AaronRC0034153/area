using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int w, h;
                w = int.Parse(wBox.Text);
                h = int.Parse(hBox.Text);
                int area = w * h;
                aBox.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Ye head shot that ain't no number");
            }
        }
    }
}
