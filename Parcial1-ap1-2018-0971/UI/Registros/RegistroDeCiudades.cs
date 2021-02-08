using Parcial1_ap1_2018_0971.Entidades;
using Parcial1_ap1_2018_0971.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_ap1_2018_0971
{
    public partial class RegistroDeCiudades : Form
    {
        public RegistroDeCiudades()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CiudadIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
        }

        private bool Validar()
        {
            bool paso = true;

            if (CiudadIdNumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CiudadIdNumericUpDown, "Obligatorio");
                paso = false;
            }

            if (NombreTextBox.Text == "")
            {
                errorProvider1.SetError(NombreTextBox, "Obligatorio");
                paso = false;
            }

            return paso;
        }

        private Ciudades LlenaClase()
        {
            Ciudades ciudades = new Ciudades();
            ciudades.CiudadId = (int)CiudadIdNumericUpDown.Value;
            ciudades.Nombres = NombreTextBox.Text;

            return ciudades;
        }

        private bool LlenaCampos(int id)
        {
            Ciudades ciudades = CiudadesBLL.Buscar(id);

            if(ciudades != null)
            {
                CiudadIdNumericUpDown.Value = ciudades.CiudadId;
                NombreTextBox.Text = ciudades.Nombres;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ExisteEnBaseDeDatos()
        {
            Ciudades ciudades = CiudadesBLL.Buscar((int)CiudadIdNumericUpDown.Value);
            return true;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudades;
            bool paso = false;

            if (!Validar())
                return;
            ciudades = LlenaClase();

            if (CiudadIdNumericUpDown.Value != 0)
            {
                paso = CiudadesBLL.Guardar(ciudades);
                MessageBox.Show("Ciudad Guardada.");
            }
            else
            {
                if(!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("La Ciudad no exites.");
                    return;
                }
                paso = CiudadesBLL.Modificar(ciudades);
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;
            id = (int)CiudadIdNumericUpDown.Value;
            Limpiar();

            if (CiudadesBLL.Eliminar(id))
                MessageBox.Show("Ciudad eliminada.");
            else
                errorProvider1.SetError(CiudadIdNumericUpDown, "No existe esa ciudad");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Ciudades ciudades = new Ciudades();
            id = (int)CiudadIdNumericUpDown.Value;

            ciudades = CiudadesBLL.Buscar(id);
            if(ciudades != null)
            {
                LlenaCampos(id);
                MessageBox.Show("Encontrada.");
            }
            else
            {
                MessageBox.Show("No Encontrada.");
            }
        }
    }
}
