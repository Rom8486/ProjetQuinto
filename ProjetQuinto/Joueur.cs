using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetQuinto
{
    class Joueur
    {

        private int _nbPoints;
        private int _nbManchesRemportees;
        private int _nbPropositions;
        private int _nbErreurs;
        string _alias;
        const int _nbEssaisMax=7;

        public int NbPoints 
        { get { return _nbPoints; }
            set { _nbPoints = value; }
        }

        public int NbManchesRemportees
        {
            get { return _nbManchesRemportees; }
            set { _nbManchesRemportees = value; }
        }

        public int NbPropositions
        {
            get { return _nbPropositions; }
            set { _nbPropositions = value; }
        }

        public int NbErreurs
        {
            get { return _nbErreurs; }
            set { _nbErreurs = value; }
        }

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        //private int CalculNbPoints(TimeSpan tps, int NbErreurs,  )
        //{

        //}



    }
}
