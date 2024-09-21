using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComIT.Console
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private int copias;
        private int copiasEnPrestamo;

        public Libro()
        {
            titulo = "N/A";
            autor = "N/A";
            copias = 0;
            copiasEnPrestamo = 0;
        }

        public Libro(string ti, string au, int co, int coPr)
        {
            titulo = ti;
            autor = au;
            copias = co;
            copiasEnPrestamo = coPr;
        }

        public bool Prestar()
        {
            if (copias > 1)
            {
                copias--;
                copiasEnPrestamo++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Devolver()
        {
            if (copiasEnPrestamo > 1) 
            {
                copiasEnPrestamo--;
                copias++;
                return true;
            } else
            {
                return false;
            }
        }

        public void Datos()
        {
            System.Console.WriteLine("Titulo:   " + titulo);
            System.Console.WriteLine("Autor:   " + autor);
            System.Console.WriteLine("Copias:   " + copias);
            System.Console.WriteLine("Prestamos:   " + copiasEnPrestamo);
        }
    }
}
