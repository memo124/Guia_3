﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.clases
{
    internal class Producto
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        int stock;
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        string img;
        public string Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
