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
        int filaActual = 1;
        string Nombre = "Nombre";
        string Sector = "Sector";
        string DNI = "DNI";
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
                // Guardar el valor en la matriz en la posición [0, 0]
                dgvInformacion.Rows[0].Cells[0].Value = Nombre;
                dgvInformacion.Rows[0].Cells[1].Value = Sector;
                dgvInformacion.Rows[0].Cells[2].Value = DNI;

                MatDGV[0, 0] = Nombre;
                MatDGV[0, 1] = Sector;
                MatDGV[0, 2] = Dni;
                txtNombre.Text = "";
                txtSector.Text = "";
                txtDni.Text = "";
                dgvInformacion.Rows[filaActual].Cells[0].Value=MatDGV[filaActual,0];
                dgvInformacion.Rows[filaActual].Cells[1].Value=MatDGV[filaActual, 1];
                dgvInformacion.Rows[filaActual].Cells[2].Value=MatDGV[filaActual, 2];
                filaActual++;
                if (filaActual >= 10)
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
