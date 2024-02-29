using Guia_unidad_3_24022024.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_unidad_3_24022024
{
    public partial class Form2 : Form
    {
        public List<Persona> PersonaRecibe = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = PersonaRecibe;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text== "")
            {
                actualizarGrid();
                return;
            }
            // Buscar todos los elementos que cumplen una condición
            List<Persona> resultados = PersonaRecibe.FindAll(x => x.Nombre == textBox1.Text.ToString());
            dataGridView1.DataSource = resultados;
        }
    }
}
