using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lvElementos.Items.Add(elem);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxColorFavorito.Items.Add("Rojo");
            cbxColorFavorito.Items.Add("Verde");
            cbxColorFavorito.Items.Add("Azul");
            cbxColorFavorito.Items.Add("Rosado");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = cbxChocolate.Checked == true ? "Te gusta el chocolate" : "No te gusta el chocolate";
            string tipo;
            if (rbtGryffindor.Checked == true)
                tipo = "Gryffindor";
            else if (rbtHufflepuff.Checked == true)
                tipo = "Hufflepuff";
            else if (rbtRavenclaw.Checked == true)
                tipo = "Ravenclaw";
            else
                tipo = "Slytherin";

            string colorFavorito = cbxColorFavorito.SelectedItem.ToString(); // se pone el tostring porque cuando yo obtengo el selectedItem me devuelve un objeto y dice maxi que tiene que ver con las herencias.Entonce me devolveria un object si yo no le pongo el ToString

            string mensaje = "Tu nombre es " + nombre + ", tu fecha de nacimiento " + fecha + ". " + chocolate + ". " + "Sos de " + tipo + ". Y tu color favorito es el " + colorFavorito;

            MessageBox.Show(mensaje);
        }   

    }
}
