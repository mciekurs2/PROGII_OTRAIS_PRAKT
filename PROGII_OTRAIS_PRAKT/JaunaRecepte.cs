using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGII_OTRAIS_PRAKT
{
    public partial class JaunaRecepte : Form
    {
        public JaunaRecepte()
        {
            InitializeComponent();
        }

        private string fileName = "";
        private void IzveidotButton_Click(object sender, EventArgs e)
        {


            var nosaukums = nosaukumsBox.Text;
            var pagatavosana = pagatavosanaBox.Text;
            var sastavdalas = sastavdalasBox.Text;
            var pic = File.ReadAllBytes(fileName);



            var timeStamp = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
            var dbConnection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\data_base\manaDB.mdb"
            };
            dbConnection.Open();

            var dbCommand = new OleDbCommand
            {
                Connection = dbConnection,
                CommandText = "INSERT INTO Receptes (timeStamp, nosaukums, pagatavosana, sastavdalas, bilde) VALUES (@timeStamp, @nosaukums, @pagatavosana, @sastavdalas, @bilde)"
            };

            //meta error par CommandText. Pisos 1h, nevaru atrast kur problemaa
            dbCommand.Parameters.AddWithValue("@timeStamp", OleDbType.DBTimeStamp).Value = timeStamp;
            dbCommand.Parameters.AddWithValue("@nosaukums", OleDbType.Char).Value = nosaukums;
            dbCommand.Parameters.AddWithValue("@pagatavosana", OleDbType.Char).Value = pagatavosana;
            dbCommand.Parameters.AddWithValue("@sastavdalas", OleDbType.Char).Value = sastavdalas;
            dbCommand.Parameters.AddWithValue("@bilde", OleDbType.Char).Value = pic;


            dbCommand.ExecuteNonQuery();

            MessageBox.Show("Recepte pievienota");
            dbConnection.Close();





            Hide();
        }

        private void bildesIzveleButton_Click(object sender, EventArgs e)
        {

            var choofdlog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                fileName = choofdlog.FileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }

        }
    }
}
