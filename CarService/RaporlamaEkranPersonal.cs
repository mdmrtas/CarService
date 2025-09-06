using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class RaporlamaEkranPersonal : Form
    {
        public RaporlamaEkranPersonal()
        {
            InitializeComponent();
        }

        private void RaporlamaEkranPersonal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbOtoBakimServisDataSet3.AracBakımKaydı' table. You can move, or remove it, as needed.
            this.AracBakımKaydıTableAdapter.Fill(this.DbOtoBakimServisDataSet3.AracBakımKaydı);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
