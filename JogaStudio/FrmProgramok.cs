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
        Dictionary<string, int> oktatok;
        Dictionary<string, int> pozok;



        public FrmProgramok(SqlConnection connectionString)
        {
            
            InitializeComponent();
            oktatok = new Dictionary<string, int>();
            pozok = new Dictionary<string,int >();
            this.connectionString = connectionString;
        }

        private void FrmProgramok_Load(object sender, EventArgs e)
        {

           

            Filldgv();

            connectionString.Open();

            var r = new SqlCommand("Select id,nev FROM  tagok where mester = 1", connectionString).ExecuteReader();
            while (r.Read())
            {
                oktatok.Add( r.GetString(1), r.GetInt32(0));

                cbOktato.Items.Add(r[1]);


            }

            r.Close();

            r = new SqlCommand("Select * FROM  pozok", connectionString).ExecuteReader();

            while (r.Read())
            {
                pozok.Add( r.GetString(1),r.GetInt32(0));
                cbGyakorlat.Items.Add(r[1]);
            }


            connectionString.Close();

            cbOktato.SelectedIndex = 0;
            cbGyakorlat.SelectedIndex = 0;


        }

        private void Filldgv()
        {
            dgvProgramok.Rows.Clear();

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
                    r[0], r.GetDateTime(1).ToString("yyyy-MM-dd"), r.GetDateTime(1).ToString("HH:mm"), r[2], r[3], String.IsNullOrEmpty(r[4].ToString()) ? 0 : r.GetString(4).Split('-').Length);



            }

            r.Close();
            connectionString.Close();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Biztosan torolni akarod a kijelolt rekordokat?", "torles megerositese",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (res == DialogResult.Yes && dgvProgramok.SelectedRows.Count != 0)
            {


                //DELETE
                connectionString.Open();

                foreach (DataGridViewRow row in dgvProgramok.SelectedRows)
                {
                    var deleteCommand = new SqlCommand($"Delte from beosztas where id = {row.Cells[0].Value}", connectionString).ExecuteNonQuery();
                }
                


                connectionString.Close();
                Filldgv();
            }


        }

        private void btnUjEsemeny_Click(object sender, EventArgs e)
        {
            var idopont = $"{dtpDatum.Value.ToString("yyyy-MM-dd")} {tbOra.Text}:{tbPerc.Text}";

            if (!Foglalt(idopont))
            {
                connectionString.Open();

                var insertCommand = new SqlCommand($"Insert into beosztas values ('{idopont}',{oktatok[cbOktato.Text]}, NULL, {pozok[cbGyakorlat.Text]}) ", connectionString).ExecuteNonQuery();

                connectionString.Close();
            }
            else
            {
                MessageBox.Show("Az adott idopontra mar van meghirdetve ora", "idopont utkozes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Filldgv();
        }

        private bool Foglalt(string idopont)
        {
            
            var datumesido = idopont.Split(' ');

            foreach (DataGridViewRow row in dgvProgramok.Rows)
            {
                if (row.Cells[1].Value.ToString() == datumesido[0] &&  row.Cells[2].Value.ToString() ==  datumesido[1] )
                {
                    return true;
                }

            }

            return false;

            
            




        }
    }
}
