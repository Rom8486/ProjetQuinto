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
    public partial class TopScoresChart : Form
    {
        public TopScoresChart()
        {
            InitializeComponent();
        }

        private void TopScoresChart_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        #region Singleton 
        private static TopScoresChart _instance;
        
        public static TopScoresChart GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TopScoresChart();
            }
            return _instance;
        }
        private void TopScoresChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

    }
}
