using Ejemplo2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Size = new Size(100, 100);


            // Agregar el control PictureBox al formulario
            this.Controls.Add(pictureBox1);
        }

        private void actualizarGrid()
        {
            dgvlistado.DataSource = null;
            dgvlistado.DataSource = Productos; /*los nombres de columna que veremos son 
los de las propiedades*/
        }
        private void reseteo()
        {
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            ruta.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvlistado.SelectedRows[0];
            int posicion = dgvlistado.Rows.IndexOf(selected); //almacena en cual fila estoy
            edit_indice = posicion; //copio esa variable en índice editado
            Producto product = Productos[posicion]; /*esta variable de tipo persona, se carga 
con los valores que le pasa el listado*/
            //lo que tiene el atributo se lo doy al textbox
            txtnombre.Text = product.Nombre;

            txtdescripcion.Text = product.Descripcion;
            txtmarca.Text = product.Marca;
            txtprecio.Text = Convert.ToString(product.Precio);
            txtstock.Text = Convert.ToString(product.Stock);
            pictureBox1.Image = Image.FromFile(product.Img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto product = new Producto();
            product.Nombre = txtnombre.Text;
            product.Descripcion = txtdescripcion.Text;
            product.Marca = txtmarca.Text;
            product.Precio = float.Parse(txtprecio.Text);
            product.Stock = int.Parse(txtstock.Text);
            product.Img = ruta.Text;
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product); /*al arreglo de Productos le agrego el objeto creado con 
todos los datos que recolecté*/
            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llama
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo(); 
                 actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Seleccionar una imagen";
            openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            openFileDialog1.ShowDialog();

            // Obtener la ruta de la imagen seleccionada
            string rutaImagen = openFileDialog1.FileName;
            ruta.Text = rutaImagen;
            pictureBox1.Image = Image.FromFile(rutaImagen);

        }
    }
}
