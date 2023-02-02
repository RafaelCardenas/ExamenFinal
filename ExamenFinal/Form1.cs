using ExamenFinal.Algortimo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        public int x0;
        public int m;
        public int a;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Insertar un valor");
                    return;
                }
                int x0 = Convert.ToInt32(textBox1.Text);
                int a = Convert.ToInt32(textBox2.Text);     
            } 
            catch 
            { 
            
            }
             if (m > x0 && m > a && a > 0 && x0 > 0)
            {
                Algoritmo algortimo = new Algoritmo();
            }
        }
    }
}
