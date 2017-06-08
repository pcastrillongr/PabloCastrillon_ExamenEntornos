using Examenfinalentornos_pablocastrillon.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenfinalentornos_pablocastrillon
{
    class Program
    {
       
        static ClinicaVeterinaria t;
        static void Main(string[] args)
        {
            t = new ClinicaVeterinaria();
            Boolean escorrecto;
            int respuesta;


            //Creo un menu y segu lo introducido lo envio a los distintos metodos




            do
            {
                do
                {
                    Console.WriteLine("******MENÚ******");
                    Console.WriteLine();
                    Console.WriteLine("Que desea hacer:");
                    Console.WriteLine("1-Anhadir animal");
                    Console.WriteLine("2-Modificar Comentarios");
                    Console.WriteLine("3-Pesar Animal");
                    Console.WriteLine("4-Mostrar ficha animal");
                    Console.WriteLine("5-Salir");

                    escorrecto = Int32.TryParse(Console.ReadLine(), out respuesta);

                    if (!escorrecto)
                    {
                        Console.WriteLine("Debe introducir un numero");
                        escorrecto = false;

                    }

                    if (escorrecto)
                    {

                        if (respuesta < 1 || respuesta > 5)
                        {
                            Console.WriteLine("Debe introducir un numero del menu");
                            escorrecto = false;

                        }

                    }
                } while (!escorrecto);


                //nos envia a los metodos de la clase clinica
                switch (respuesta)
                {


                    case 1:
                        t.insertarAnimal();
                        break;
                    case 2:
                        t.ModificarComentarios();
                        break;
                    case 3:t.pesar();

                        break;
                    case 4:
                        t.MostrarFichaAnimal();
                        break;
                    case 5:
                        Despedida();
                        break;
                }
            } while (respuesta != 5);
            
                   

           

            



        }
        public static void Despedida()
        {

            Console.WriteLine("Adios Muchas Gracias");
        }
    }
}
