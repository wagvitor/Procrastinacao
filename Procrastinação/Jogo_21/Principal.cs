using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_21
{
    public partial class Principal : Form
    {
        public static string p1, p2, p3, p4, p5;

        public Principal()
        {
            InitializeComponent();
        }

        private void btnAva_Click(object sender, EventArgs e)
        {
            p1 = txt1.Text;
            p2 = txt2.Text;
            p3 = txt3.Text;
            p4 = txt4.Text;
            p5 = txt5.Text;


            var pri = new Prioridade();
            pri.ShowDialog();
            Application.Exit();
        }
    }
}
