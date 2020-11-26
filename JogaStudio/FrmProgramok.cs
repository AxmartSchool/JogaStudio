using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogaStudio
{
    public partial class FrmProgramok : Form
    {
        private readonly SqlConnection connectionString;

        public FrmProgramok(SqlConnection connectionString)
        {
            
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void FrmProgramok_Load(object sender, EventArgs e)
        {

            connectionString.Open();
            var r = new SqlCommand(
                "SELECT beosztas.id, idopont, tagok.nev, pozok.nev, diakok " +
                "FROM beosztas " +
                "INNER JOIN tagok ON beosztas.instruktor = tagok.id " +
                "INNER JOIN pozok ON beosztas.tananyag = pozok.id;", connectionString)
                .ExecuteReader();

            while (r.Read())
            {

                dgvProgramok.Rows.Add(
                    r[0], r.GetDateTime(1).ToString("yyyy-MM-dd"), r.GetDateTime(1).ToString("hh:mm"), r[2], r[3], r.GetString(4).Split('-').Length);



            }

            connectionString.Close();



        }
    }
}
