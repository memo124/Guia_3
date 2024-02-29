using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_g4
{
    public partial class Form1 : Form
    {
        public List<alumno> listaAlumno = new List<alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alumno alumno = new alumno();
            if (txtnombre.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un nombre");
                return;
            }
            if (txtapellido.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un apellido");
                return;
            }
            if (txtcarnet.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un carnet");
                return;
            }
            if (txtmateria.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar una materia");
                return;
            }
            if (txtnota1.Text.Equals("")  || (float.Parse(txtnota1.Text) < 0.0 || float.Parse(txtnota1.Text) >10.0))
            {
                MessageBox.Show("Favor ingresar una nota valida entre 1 a 10 - nota 1");
                return;
            }
            if (txtnota2.Text.Equals("") || (float.Parse(txtnota2.Text) < 0.0 || float.Parse(txtnota2.Text) > 10.0))
            {
                MessageBox.Show("Favor ingresar una nota valida entre 1 a 10 - nota 2");
                return;
            }
            if (txtnota3.Text.Equals("") || (float.Parse(txtnota3.Text) < 0.0 || float.Parse(txtnota3.Text) > 10.0))
            {
                MessageBox.Show("Favor ingresar una nota valida entre 1 a 10 - nota 3");
                return;
            }
            alumno.nombre = txtnombre.Text;
            alumno.apellido = txtapellido.Text;
            alumno.carnet = txtcarnet.Text;
            alumno.materia = txtmateria.Text;
            alumno.nota1 = float.Parse(txtnota1.Text);
            alumno.nota2 = float.Parse(txtnota2.Text);
            alumno.nota3 = float.Parse(txtnota3.Text);
            alumno.promedio = (float.Parse(txtnota1.Text) + float.Parse(txtnota2.Text) + float.Parse(txtnota3.Text)) / 3;
            listaAlumno.Add(alumno);
            actualizarGrid();
        }
        private void actualizarGrid()
        {
            data.DataSource = null;
            data.DataSource = listaAlumno; /*los nombres de columna que veremos son 
los de las propiedades*/
        }
    }
}
