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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryLopezSantiagoLab2
{
    public partial class frmGrilla : Form
    {
        string[,] MatDGV = new string[10, 3];
        int i = 1;
        public frmGrilla()
        {
            //Agrego las columnas y los nombres 
            InitializeComponent();
            dgvInformacion.ColumnCount = 3;
            dgvInformacion.Columns[0].Name = "Nombre";
            dgvInformacion.Columns[1].Name = "Sector";
            dgvInformacion.Columns[2].Name = "DNI";
        }
        private void frmGrilla_Load(object sender, EventArgs e)
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Verifico que la caja de texto no esté vacía
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtSector.Text) && !string.IsNullOrWhiteSpace(txtDni.Text))
            {
                //Guardo los datos de las cajas de texto en la Matriz
                MatDGV[i, 0] = txtNombre.Text;
                MatDGV[i, 1] = txtSector.Text;
                MatDGV[i, 2] = txtDni.Text;
                //Agrego a la grilla los datos
                dgvInformacion.Rows.Add(new string[] { txtNombre.Text, txtSector.Text, txtDni.Text });
                i++;
                //Limpio los txt
                txtNombre.Clear();
                txtSector.Clear();
                txtDni.Clear();
                //Si esta llena la Matriz no carga nada
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
