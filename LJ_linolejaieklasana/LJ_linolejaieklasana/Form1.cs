using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJ_linolejaieklasana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gridas_izmaksa(double cena, int linoleja_platums, int telpas_platums, int telpas_garums)
        {
            int telpas_izmers = telpas_garums * telpas_platums;
            double izmaksa = cena * telpas_izmers / linoleja_platums;
        }
        

        }
    }

