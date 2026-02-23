using System;
using System.Linq;

namespace SistemaStock.Models
{
    public class Producto
    {
        protected int id { get; set; }
        protected static int globalID;
        protected string nombre;
        protected decimal precio;
        protected int stock;
        protected bool estado;

        public Producto(string nombre, decimal precio, int stock)
        {
            globalID++;
            id = globalID;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Estado = estado;
        }
        public Producto()
        {
            estado = true;
        }
        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Debe ingresar un nombre");
                }
                else if (value.Any(char.IsDigit)) {
                    throw new Exception("Debe ingresar un nombre sin numeros");
                }
                nombre = value;
            }
        }
        public decimal Precio
        {
            get { return precio; }

            set
            {

                if (precio < 0) {
                    throw new Exception("Debe ingresa un valor real ");
                }
                precio = value;
            }
        }
        public int Stock
            {
            get { return stock; }

            set
            {
                if (stock < 0) {
                    throw new Exception("Debe ingresar un stock mayor a 0 ");
                }
                stock = value;
            }
        }   
        public bool Estado 
        {
            get {return estado; }

            set {
                if(value==true||Stock<0)
                {
                    throw new Exception("No se puede dar de baja un producto sin stock");
                }
                estado = value;
            }
        }

    }   

    }
