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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbOtoBakimServisDataSet2.Personel' table. You can move, or remove it, as needed.
            this.PersonelTableAdapter.Fill(this.DbOtoBakimServisDataSet2.Personel);
            // TODO: This line of code loads data into the 'DbOtoBakimServisDataSet.Loglar' table. You can move, or remove it, as needed.
            this.LoglarTableAdapter.Fill(this.DbOtoBakimServisDataSet.Loglar);

            this.reportViewer1.RefreshReport();
        }
    }
}
