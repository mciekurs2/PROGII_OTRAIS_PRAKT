using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGII_OTRAIS_PRAKT
{
    public partial class Autorizacija : Form
    {
        public Autorizacija()
        {
            InitializeComponent();
        }

        private void IenaktButton_Click(object sender, EventArgs e)
        {
            var receptes = new Receptes();
            var autorizacija = new Autorizacija();

            String lietotajvards = lietotajvardsBox.Text;
            String parole = paroleBox.Text;

            String adminLietotajvards = "admin";
            String adminParole = "parole";

            if (lietotajvards.Equals(adminLietotajvards) && parole.Equals(adminParole))
            {
                receptes.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Ievadiet pareizu autentifikacijas info");
            }


        }
    }
}
