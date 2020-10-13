using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;
using System.Diagnostics;
//using System.Threading;


namespace ProjetQuinto
{
    public partial class Interface_jeux : Form
    {
        int duree = 0;
        /// <summary>
        /// Fonctions
        /// </summary>
        public void CreationTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            timer.Start();
            //Penser à stopper timer à la fin de la manche

        }
        public Interface_jeux()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            TbMotADeviner.Text += bouton.Text;
        }

        private void TbMotADeviner_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            CreationTimer();



        }
        private void timer_Tick(object sender, EventArgs e)
        {
            
            duree++;
            tbTimer.Text = duree.ToString();
            
        }



    }
}
