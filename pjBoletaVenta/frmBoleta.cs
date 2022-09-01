using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjBoletaVenta
{
    public partial class frmBoleta : Form
    {
        // Variables globales
        int num;
        ListViewItem item;

        // Objeto de la clase Boleta
        Boleta objB = new Boleta();

        public frmBoleta()
        {
            InitializeComponent();
        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
