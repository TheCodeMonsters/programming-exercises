using PokemonApi.Models;
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
    public partial class Pokemon : Form
    {
        ApiRequest api = new ApiRequest();

        public Pokemon()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pokemon_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void cargarDatos()
        {
            Pokelista pokelista = new Pokelista();
            flowLayoutPanel1.Controls.Clear();

            Pokelista pokemon = new Pokelista();

            pokemon = api.obtenerLista();

            foreach (var item in pokemon.listaPokemones) 
            {
                flowLayoutPanel1.Controls.Add(new PokemonVista(item.Name, item.GetImagen()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        

        
    }
}
