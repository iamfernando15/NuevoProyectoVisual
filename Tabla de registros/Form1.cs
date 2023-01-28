using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tabla_de_registros
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dtgvPersona.Rows.Add();

            //Para colocar la info
            dtgvPersona.Rows[n].Cells[0].Value = txtID.Text;
            dtgvPersona.Rows[n].Cells[1].Value = txtName.Text;
            dtgvPersona.Rows[n].Cells[2].Value = txtApellido.Text;
            dtgvPersona.Rows[n].Cells[3].Value = txtEdad.Text;
            dtgvPersona.Rows[n].Cells[4].Value = txtTel.Text;
            dtgvPersona.Rows[n].Cells[5].Value = cbxLista.Text;

            //Limpiar info
            txtID.Text = "";
            txtName.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtTel.Text = "";
            cbxLista.Text = "";
        }

        private void dtgvPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = dtgvPersona.CurrentRow.Index;
            txtID.Text = dtgvPersona[0, n].Value.ToString();
            txtName.Text = dtgvPersona[1, n].Value.ToString();
            txtApellido.Text = dtgvPersona[2, n].Value.ToString();
            txtEdad.Text = dtgvPersona[3, n].Value.ToString();
            txtTel.Text = dtgvPersona[4, n].Value.ToString();
            cbxLista.Text = dtgvPersona[5, n].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvPersona.Rows.RemoveAt(n);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLimpiarCajas_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtTel.Clear();
            cbxLista.Text = "";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            n = dtgvPersona.CurrentRow.Index;

            dtgvPersona[0, n].Value = txtID.Text;
            dtgvPersona[1, n].Value = txtName.Text;
            dtgvPersona[2, n].Value = txtApellido.Text;
            dtgvPersona[3, n].Value = txtEdad.Text;
            dtgvPersona[4, n].Value = txtTel.Text;
            dtgvPersona[5, n].Value = cbxLista.Text;

        }
    }
}
