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
    public partial class Prioridade : Form
    {
        public Prioridade()
        {
            InitializeComponent();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
            Application.Exit();
        }

        private void Prioridade_Load(object sender, EventArgs e)
        {
            txt1.Text = Principal.p1;
            txt2.Text = Principal.p2;
            txt3.Text = Principal.p3;
        }
    }
}
