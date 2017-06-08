using Examenfinalentornos_pablocastrillon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenfinalentornos_pablocastrillon.models
{
    //clase con atributos

    abstract class Animal:IPesable
    {
     
        private string nombre;
        private string fechanacimiento;
        private double peso;
        private string comentarios;

        public Animal(string nombre, string fechanacimiento, double peso, string comentarios)
        {
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
            this.peso = peso;
            this.comentarios = comentarios;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Fechanacimiento
        {
            get
            {
                return fechanacimiento;
            }

            set
            {
                fechanacimiento = value;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string Comentarios
        {
            get
            {
                return comentarios;
            }

            set
            {
                comentarios = value;
            }
        }

        public new virtual String ToString() {

            return "";
        }

        public void Pesar(double peso)
        {
            
        }
    }
}
