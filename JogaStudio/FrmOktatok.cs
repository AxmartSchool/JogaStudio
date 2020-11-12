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
    public partial class FrmOktatok : Form
    {
        SqlConnection connection;
        Dictionary<string,int > Oktatok;

        public FrmOktatok(SqlConnection connectionSring)
        {
            connection = connectionSring;
            Oktatok = new Dictionary<string, int>();
            
            InitializeComponent();
        }

        private void FrmOktatok_Load(object sender, EventArgs e)
        {
            connection.Open();

            var cmd = new SqlCommand("Select nev, id From tagok where mester = 1;", connection);
            var r = cmd.ExecuteReader();
            
            while (r.Read())
            {
                Oktatok.Add( r.GetString(0), r.GetInt32(1));
            }


            connection.Close();

            LbOktatokFeltoltes();

        }

        private void LbOktatokFeltoltes()
        {
            foreach (var oktatoNev in Oktatok.Keys)
            {
                lbOktatok.Items.Add(oktatoNev);


            }
        }

        private void lbOktatok_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
            Brushes.Orange : new SolidBrush(e.BackColor);
            g.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawString(
            (sender as ListBox).Items[e.Index].ToString(), e.Font,
                new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void lbOktatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbOrak.Clear();

            connection.Open();

            var cmd = new SqlCommand($"select idopont from beosztas where instruktor ={Oktatok[lbOktatok.SelectedItem.ToString()]} ", connection);
            

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                rtbOrak.Text += $"{r.GetDateTime(0).ToString("yyyy-MM-dd")}\t\t{r.GetDateTime(0).ToString("HH-mm")}\n";
            }
            connection.Close();
        }
    }
}
