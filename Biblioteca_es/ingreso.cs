using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_es
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "@vicgonza" && txt_contraseña.Text == "9630")
            {
                libreria libreria = new libreria();
                libreria.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "¡AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Clear();
                txt_contraseña.Clear();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
