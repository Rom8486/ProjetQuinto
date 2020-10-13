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

        public Interface_jeux()
        {
            InitializeComponent();
        }

        private void Interface_jeux_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = BackgroundImage.
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
    }
}
