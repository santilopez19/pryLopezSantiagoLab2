using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace pryLopezSantiagoLab2
{
    public partial class frmGrilla : Form
    {
        string[,] MatDGV = new string[10, 3];
        int i = 1;
        public frmGrilla()
        {
            InitializeComponent();
        }
        private void frmGrilla_Load(object sender, EventArgs e)
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Sector = txtSector.Text;
            string Dni = txtDni.Text;

            // Verificar que la caja de texto no esté vacía
            if (!string.IsNullOrWhiteSpace(Nombre)&& !string.IsNullOrWhiteSpace(Sector) && !string.IsNullOrWhiteSpace(Sector))
            {
                MatDGV[i, 0] = Nombre;
                MatDGV[i, 1] = Sector;
                MatDGV[i, 2] = Dni;
                dgvInformacion.Rows[i].Cells[0].Value=MatDGV[i,0];             
                dgvInformacion.Rows[i].Cells[1].Value=MatDGV[i, 1];
                dgvInformacion.Rows[i].Cells[2].Value=MatDGV[i, 2];
                i++;
                txtNombre.Text = "";
                txtSector.Text = "";
                txtDni.Text = "";
                if (i >= 10)
                {
                    MessageBox.Show("No hay mas espacio.");
                }
            }
            else
            {
                MessageBox.Show("Por favor completa los campos");
            }

        }
    }
}
