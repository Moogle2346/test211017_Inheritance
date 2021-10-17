using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test211017_Inheritance.Classes;

namespace test211017_Inheritance.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Japanese japanese = new Japanese("田中", 24);
            textBox1.Text = japanese.Say() + "\r\n" + japanese.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            American american = new American("Jeorge", 18);
            textBox1.Text = american.Say() + "\r\n" + american.GetData();
        }
    }
}
