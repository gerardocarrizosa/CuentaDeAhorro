using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_de_Ahorro
{
    public partial class Cuenta : Form
    {
        public Cuenta()
        {
            InitializeComponent();
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd-MMM-yyyy";
            dgvMovimientos.Sort(dgvMovimientos.Columns[0], ListSortDirection.Ascending);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ibtnBorrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void ibtnCargarTabla_Click(object sender, EventArgs e)
        {

        }
    }
}
