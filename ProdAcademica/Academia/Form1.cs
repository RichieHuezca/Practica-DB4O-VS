using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            Estu frm2 = new Estu();
            frm2.ShowDialog();
        }

        private void BtnLibro_Click(object sender, EventArgs e)
        {
            Lib frm3 = new Lib();
            frm3.ShowDialog();
        }

        private void btnPatente_Click(object sender, EventArgs e)
        {
            Pat frm4 = new Pat();
            frm4.ShowDialog();
        }
    }
}
