using System;
using System.Windows.Forms;

namespace Biblioteca_es
{
    public partial class libreria : Form
    {
        public libreria()
        {
            InitializeComponent();
        }

        // declaro vector
        private string[] libro, autor, ubicación;
        private string[] cantidad;
        private int indice;

        //salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            libro = new string[5];    //lleno vector
            autor = new string[5];
            ubicación = new string[5];
            cantidad = new string[5];

            libro[0] = "Doce cuentos peregrinos";
            autor[0] = "Gabriel García Marquez";
            ubicación[0] = "Estante 1";
            cantidad[0] = "15";

            libro[1] = "Algebra de baldor";
            autor[1] = "Aurelio Baldor";
            ubicación[1] = "Estante 2";
            cantidad[1] = "20";

            libro[2] = "Levantado del suelo";
            autor[2] = "Jose Saramago";
            ubicación[2] = "Estante 3";
            cantidad[2] = "12";

            libro[3] = "Luna de enfrente";
            autor[3] = "Jorge Luis Borges";
            ubicación[3] = "Estante 6";
            cantidad[3] = "8";

            libro[4] = "La Divina Comedia";
            autor[4] = "Dante";
            ubicación[4] = "Estante 5";
            cantidad[4] = "10";
            //}
            //public void buscar_libro()
            //{


            string li, au;
            li = txt_buscar_libro.Text;
            au = txt_buscar_autor.Text;

            for (int i = 0; i <= 4; i++)
            {
                if (libro[i].Equals(li) || autor[i].Equals(au))
                {
                    txt_nom_libro.Text = libro[i];
                    txt_nom_autor.Text = autor[i];
                    txt_ubicacion.Text = ubicación[i];
                    txt_cantidad.Text = cantidad[i];
                    indice = i;


                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (libro[i] != li && autor[i] != au)
                {
                    _ = MessageBox.Show("El libro o autor ingresado no existen", "¡AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
    }
}















