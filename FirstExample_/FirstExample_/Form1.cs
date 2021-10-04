using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace FirstExample_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e )
        {
            Jugador jugador = (Jugador)dataGridView1.SelectedRows[0].DataBoundItem;
            Equipo equipo = new Equipo();
            equipo.Guardar(jugador.Id);

        }

        private void ActualizarJugador()
        {
            Jugador jugador = new Jugador();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = jugador.Listar();
        }

        private void ActualizarEquipo()
        {
            Equipo equipo= new Equipo();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = equipo.Listar();
        }

        private void MostrarEquipo_Click(object sender, EventArgs e)
        {
            ActualizarEquipo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarJugadores_Click(object sender, EventArgs e)
        {
            ActualizarJugador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            jugador.Nombre = nombreJug.Text;
            jugador.Posicion= jugPosicion.Text;
            jugador.Pierna_Habil = jugPierna.Text;

            if (jugador.Guardar())
            {
                MessageBox.Show("Jugador guardado");
            }
            ActualizarJugador();
        }

        private void eliminarJugador_Click(object sender, EventArgs e)
        {
            Jugador jugador = (Jugador)dataGridView1.SelectedRows[0].DataBoundItem;
            jugador.Eliminar();
            ActualizarJugador();
        }
    }
}
