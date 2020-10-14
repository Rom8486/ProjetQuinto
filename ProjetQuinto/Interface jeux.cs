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
       
        #region Singleton
        private static Interface_jeux _instance;
        public static Interface_jeux GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Interface_jeux();
            }
            return _instance;
        }
        private void Interface_jeux_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

        int duree = 0;
        /// <summary>
        /// Fonctions
        /// </summary>
      
        enum Contextes
        {
            Initial = 0,
            GameStarted = 1,
            GameLost = 2
        }

        #region Gestionnaire de Contextes
        void GestionnaireContextes(Contextes contexte)
        {
            switch (contexte)
            {
                case Contextes.Initial:
                    gbDifficulté.Enabled = true;
                    gbInformation.Enabled = false;
                    btnStart.Enabled = false;
                    tbTimer.Enabled = false;
                    tbNbreEssais.Enabled = false;
                    tbMotADeviner.Enabled = false;
                    pnlClavierNumerique.Enabled = false;
                    break;
                case Contextes.GameStarted:
                    gbDifficulté.Enabled = false;
                    gbInformation.Enabled = true;
                    btnStart.Enabled = false;
                    tbTimer.Enabled = true;
                    tbNbreEssais.Enabled = true;
                    tbMotADeviner.Enabled = true;
                    pnlClavierNumerique.Enabled = true;
                    break;
                case Contextes.GameLost:
                    GestionnaireContextes(Contextes.Initial);
                    break;
                default:
                    break;
            }
        }
        #endregion

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
            GestionnaireContextes(Contextes.Initial);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            tbMotADeviner.Text += bouton.Text;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CreationTimer();
            GestionnaireContextes(Contextes.GameStarted);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            duree++;
            tbTimer.Text = duree.ToString();
        }

        #region Radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
              
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

            }
        }
        #endregion

        private void Interface_jeux_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Parent.BackgroundImage;
            this.Refresh();
        }


    }
}
