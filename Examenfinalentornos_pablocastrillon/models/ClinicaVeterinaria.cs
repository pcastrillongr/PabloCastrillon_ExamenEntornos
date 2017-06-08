using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenfinalentornos_pablocastrillon.models
{
    class ClinicaVeterinaria
    {

        //clinica donde guardaremos nuestros animales y realizaremos las acciones que sean solicitadas desde el ma

        private List<Animal> animales;

    

        public ClinicaVeterinaria()
        {
            this.animales = new List<Animal>();

        }

        public void insertarAnimal()
        {

            

            Boolean cantaor = false;
            string especie;
            string nombre;
            string raza;
            string microchip;
            Boolean venenoso = false;
            string fechanacimiento;
            double peso ;
            string comentarios;
            bool escorrecto;
            int respuesta;
            do
            {
                Console.WriteLine("Que animal desea anhadir");
                Console.WriteLine("1-Perro");
                Console.WriteLine("2-Gato");
                Console.WriteLine("3-Pajaro");
                Console.WriteLine("4-Reptil");

                escorrecto = Int32.TryParse(Console.ReadLine(), out respuesta);

                if (!escorrecto)
                {
                    Console.WriteLine("Debe introducir un numero");
                    escorrecto = false;

                }

                if (escorrecto)
                {

                    if (respuesta < 1 || respuesta > 4)
                    {
                        Console.WriteLine("Debe introducir un numero del menu");
                        escorrecto = false;

                    }

                }
            } while (!escorrecto);

            switch (respuesta)
            {

                case 1:

                    Console.WriteLine("Introduzca el nombre del perro:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca su fecha de nacimiento");
                    fechanacimiento = Console.ReadLine();
                    Console.WriteLine("Introduzca su peso");

                    do
                    {
                        escorrecto = double.TryParse(Console.ReadLine(), out peso);
                        if (!escorrecto)
                        {

                            Console.WriteLine("Debe introducir un numero");
                        }

                    } while (!escorrecto);

                    Console.WriteLine("Introduzca los comentarios");
                    comentarios = Console.ReadLine();
                    Console.WriteLine("Introduzca la raza");
                    raza = Console.ReadLine();
                        Console.WriteLine("Introduzca el microchip");
                        microchip = Console.ReadLine();

                        Animal perrito = new Perro(raza, microchip, nombre, fechanacimiento, peso, comentarios);

                        animales.Add(perrito);
                        Console.WriteLine("Perrito Anhadido");
                        break;

                case 2:


                    Console.WriteLine("Introduzca el nombre del gato:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca su fecha de nacimiento");
                    fechanacimiento = Console.ReadLine();
                    Console.WriteLine("Introduzca su peso");

                    do
                    {
                        escorrecto = double.TryParse(Console.ReadLine(), out peso);
                        if (!escorrecto)
                        {

                            Console.WriteLine("Debe introducir un numero");
                        }

                    } while (!escorrecto);

                    Console.WriteLine("Introduzca los comentarios");
                    comentarios = Console.ReadLine();
                    Console.WriteLine("Introduzca la raza");
                    raza = Console.ReadLine();
                    Console.WriteLine("Introduzca el microchip");
                    microchip = Console.ReadLine();

                    Animal gatito = new Perro(raza, microchip, nombre, fechanacimiento, peso, comentarios);

                    animales.Add(gatito);
                    Console.WriteLine("Gatito Anhadido");
                    break;

                case 3:


                    Console.WriteLine("Introduzca el nombre del pajaro:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca su fecha de nacimiento");
                    fechanacimiento = Console.ReadLine();
                    Console.WriteLine("Introduzca su peso");

                    do
                    {
                        escorrecto = double.TryParse(Console.ReadLine(), out peso);
                        if (!escorrecto)
                        {

                            Console.WriteLine("Debe introducir un numero");
                        }

                    } while (!escorrecto);

                    Console.WriteLine("Introduzca los comentarios");
                    comentarios = Console.ReadLine();
                    Console.WriteLine("Introduzca la especie");
                    especie = Console.ReadLine();
                    Console.WriteLine("es cantador?");
                    cantaor = false;

                    Animal pajarito = new Pajaro(especie, cantaor, nombre, fechanacimiento, peso, comentarios);

                    this.animales.Add(pajarito);
                    Console.WriteLine("Pajarito Anhadido");

                    break;

                case 4:


                    Console.WriteLine("Introduzca el nombre del reptil:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca su fecha de nacimiento");
                    fechanacimiento = Console.ReadLine();
                    Console.WriteLine("Introduzca su peso");

                    do
                    {
                        escorrecto = double.TryParse(Console.ReadLine(), out peso);
                        if (!escorrecto)
                        {

                            Console.WriteLine("Debe introducir un numero");
                        }

                    } while (!escorrecto);

                    Console.WriteLine("Introduzca los comentarios");
                    comentarios = Console.ReadLine();
                    Console.WriteLine("Introduzca la especie");
                    especie = Console.ReadLine();
                    Console.WriteLine("es venenoso?");
                    venenoso = false;

                    Animal lagartija = new Reptil(especie, venenoso, nombre, fechanacimiento, peso, comentarios);

                    animales.Add(lagartija);
                    Console.WriteLine("Reptil Anhadido");

                    break;





            }

        }
        public void ModificarComentarios()
        {

            

            string nombre;

            Console.WriteLine("Introduzca el nombre del animal al que modificar los comentarios");
            nombre = Console.ReadLine();
            string comentariosnuevos;


            foreach (Animal x in animales)
            {
                if (x.Nombre.Equals(nombre))
                {
                    Console.WriteLine("Indique los comentarios que quiere anhadir");
                    comentariosnuevos = Console.ReadLine();
                    x.Comentarios = comentariosnuevos;
                    Console.WriteLine("Comentarios anhadidos");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No tenemos ese animal en nuestra clinica");
                    Console.WriteLine();
                }

            }
            
                

         }
      
        public void MostrarFichaAnimal()
        {
           

           
            string nombre;

            Console.WriteLine("Introduzca el nombre del animal al que desea ver la ficha");
            nombre = Console.ReadLine();


           
           foreach (Animal x2 in animales)
                {
                    if (x2.Nombre.Equals(nombre))
                    {

                        Console.WriteLine(x2.ToString());
                    Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("No tenemos ese animal en nuestra clinica");
                    Console.WriteLine();
                    }
                }
            }

        public void pesar()
        {
            
           
            string nombreaux;

            Console.WriteLine("Introduzca el nombre del animal que quiere saber su peso");
            nombreaux = Console.ReadLine();


                foreach (Animal z in animales)
                {

                    if (z.Nombre.Equals(nombreaux))
                    {
                        Console.WriteLine("Peso=" + z.Peso);
                    Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No disponemos de ese animal es nuestra clinica");
                    Console.WriteLine();
                    }


                
            }
        }
        }
    }

