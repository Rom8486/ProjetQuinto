using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetQuinto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interface_jeux interface_jeux = new Interface_jeux();
            interface_jeux.MdiParent = this;
            interface_jeux.Show();
        }
    }
}
