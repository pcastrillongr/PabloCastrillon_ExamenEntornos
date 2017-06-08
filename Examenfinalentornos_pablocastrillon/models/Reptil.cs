using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenfinalentornos_pablocastrillon.models
{
    //clase con atributos
    class Reptil:Animal
    {
        string especie;
        Boolean venenoso;

        public Reptil(string especie, bool venenoso,string nombre, string fechanacimiento, double peso, string comentarios):base( nombre,  fechanacimiento,  peso,  comentarios)
        {
            this.Especie = especie;
            this.Venenoso = venenoso;
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

        public bool Venenoso
        {
            get
            {
                return venenoso;
            }

            set
            {
                venenoso = value;
            }
        }
        public override String ToString()
        {

            return "nombre:"+Nombre+ "||especie:" +especie+ "||venenoso:" + venenoso + "||fechanacimiento:" + Fechanacimiento + " ||peso:" + Peso+"||comentarios:"+Comentarios;

        }
    }
}
