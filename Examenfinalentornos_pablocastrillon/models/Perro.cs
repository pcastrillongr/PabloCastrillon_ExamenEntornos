using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenfinalentornos_pablocastrillon.models
{
    //clase con atributos
    class Perro : Animal
    {

        private string raza;
        private string microchip;


        public Perro(string raza, string microchip, string nombre, string fechanacimiento, double peso, string comentarios) : base(nombre, fechanacimiento, peso, comentarios)
        {
            this.Raza = raza;
            this.Microchip = microchip;
        }

        public string Raza
        {
            get
            {
                return raza;
            }

            set
            {
                raza = value;
            }
        }

        public string Microchip
        {
            get
            {
                return microchip;
            }

            set
            {
                microchip = value;
            }
        }

        public override String ToString()
        {

            return "nombre=" + Nombre + "||raza=" + Raza + "||microchip=" + microchip + "||fechanacimiento" + Fechanacimiento + " ||peso=" + Peso + "||comentarios=" + Comentarios;

        }
    }
}
