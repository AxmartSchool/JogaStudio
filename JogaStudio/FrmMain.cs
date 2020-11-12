using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogaStudio
{
    public partial class FrmMain : Form
    {

        public static SqlConnection connectionString;

        public FrmMain()
        {
            AppDomain.CurrentDomain.SetData(
                "DataDirectory",
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly()
                    .Location.Replace(@"bin\Debug", @"\Resources")));

            connectionString = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" +
                @"AttachDbFileName=|DataDirectory|jogastudio.mdf;"); 

            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show(
                "Biztos vagz benne , hogy ki akarsz lepni?",
                "negerosites",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                 );
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }


      

        }

        private void btnOktatok_Click(object sender, EventArgs e)
        {
            var frm = new FrmOktatok(connectionString);
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
