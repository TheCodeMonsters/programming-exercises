using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonApi
{
    public partial class PokemonVista : UserControl
    {
        public PokemonVista(string nombre, Image imagen)
        {
            InitializeComponent();
            this.nombre.Text = nombre;
            this.imagen.Image = imagen;
        }

        private void PokemonVista_Load(object sender, EventArgs e)
        {

        }
    }
}
