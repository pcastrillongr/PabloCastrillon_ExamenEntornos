using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenfinalentornos_pablocastrillon.models
{
    class Pajaro:Animal
        //clase con atributos
    {
        string especie;
        Boolean cantor;


        public Pajaro(string especie, bool cantor, string nombre, string fechanacimiento, double peso, string comentarios):base( nombre,  fechanacimiento,  peso,  comentarios)
        {
            this.Especie = especie;
            this.Cantor = cantor;
        }


        public string Especie
        {
            get
            {
                return especie;
            }

            set
            {
                especie = value;
            }
        }

        public bool Cantor
        {
            get
            {
                return cantor;
            }

            set
            {
                cantor = value;
            }
        }
        public override String ToString()
        {

            return "nombre=" + Nombre + "||especie=" + especie + "||venenoso=" + cantor + "||fechanacimiento=" + Fechanacimiento + " ||peso=" + Peso + "||comentarios=" + Comentarios;

        }
    }
}
