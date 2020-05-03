using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Width += 3;
            if (panel1.Width > 361)
            {
                this.Hide();
                Form1 Record = new Form1();
                timer1.Stop();
                Record.Show();
            }

        }
    }
}
