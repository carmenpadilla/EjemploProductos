using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProductos
{
   public  class ListaProducto
    {
           public  List<Producto> Productos { set; get; }
            public ListaProducto()
            {
                Productos = new List<Producto>();
            }
           public void AnadirElemento(Producto producto)
            {
              Productos.Add(producto);
            }

            public List<Producto> NombreLetra(String letra)
            {
                List<Producto> aux = new List<Producto>();
                foreach (Producto producto in Productos)
                {
                    if (producto.Nombre.Contains(letra))
                    {
                        aux.Add(producto);
                    }
                }
                return aux;
            //hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhjjj
            }
    

      }
    }

