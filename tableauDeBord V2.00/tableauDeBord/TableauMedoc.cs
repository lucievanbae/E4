using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableauDeBord
{
    public partial class TableauMedoc : Form
    {
        public TableauMedoc()
        {
            InitializeComponent();
        }

        private void TableauMedoc_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet9.CoutTotal'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.coutTotalTableAdapter1.Fill(this.tableaudebordDataSet9.CoutTotal);
            // TODO: cette ligne de code charge les données dans la table 'tableaudebordDataSet8.CoutTotal'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.coutTotalTableAdapter.Fill(this.tableaudebordDataSet8.CoutTotal);

        }

        private void btnCoutTotal_Click(object sender, EventArgs e)
        {
            CoutTotal coutTotal = new CoutTotal();
            coutTotal.Show();
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Choix choix = new Choix();
            choix.Show();
            this.Hide();
        }
    }
}
