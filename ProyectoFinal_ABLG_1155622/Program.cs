using System;
using System.Collections;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoFinal_ABLG_1155622
{
    class Program
    {
        static string nombre;
        static int Cantidadhoras; 
        static int [] Habitacion1 = new int[Cantidadhoras];
        static int [] Habitacion2 = new int[Cantidadhoras];
        static int[] Habitacion3 = new int[Cantidadhoras];
        static int[] Habitacion4 = new int[Cantidadhoras];
        static int CantidadHoras;
        static int[] HABITACION1 = new int[CantidadHoras];
        static int[] HABITACION2 = new int[CantidadHoras];
        static int[] HABITACION3 = new int[CantidadHoras];
        static int[] HABITACION4 = new int[CantidadHoras];
        static int[] habitacion1 = new int[CantidadHoras];
        static int[] habitacion2 = new int[CantidadHoras];
        static int[] habitacion3 = new int[CantidadHoras];
        static int[] habitacion4 = new int[CantidadHoras];
        static int entro;
        static int salio;
        static int nuncaentro;
        static int siempreEstuvo; 
        static int EntroSalio;
        static int Hora; 
      
        static void Main(string[] args)
        { 
            Instrucciones();
            Ventilacion();
            RandomVentilacion(); 
            Calefaccion();
            RandomCalefaccion(); 
            Iluminacion();
            EjecucionLunes();
            

            Console.ReadKey(); 
        } 
        public static void Instrucciones ()
        {
            Console.WriteLine("Bienvenido/a, este es un programa automtaizado que te permitirá controlar la calefacción, ventilación e iluminación de tu casa");
            Console.WriteLine("");
            Console.WriteLine("Para que el sistema funcione tienes que ingresar los datos que se te soliciten para programar el panel de control del sistema");
            Console.WriteLine("");
            Console.WriteLine("El programa puede funcionar de manera autonoma una vez detecte un patron en los primeros datos ingresados, por eso, solo se te solcitiaran los datos para la habtacion 1, en el día Lunes ");
            Console.WriteLine("");

            Console.WriteLine("Primero, lo primero ¿cuál es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Es un gusto " + nombre + ", estoy para servirte");
            Console.WriteLine("");

        }
       
        public static void Ventilacion ()
        {
            Console.WriteLine("Ahora estableceremos los parámetros para la calefacción y ventilación");
            Console.WriteLine("");
            Console.WriteLine("Ingresa la cantidad de horas que quieres que se acitve la ventilación en la habitacion 1; ingresa 3 como minimo y 5 como maximo");
            Cantidadhoras = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (Cantidadhoras < 2)
            {
                Console.WriteLine("Son muy pocas horas, la humedad excederá el 70%, la ventilación debe encenderse por lo menos 3 veces al día");
                Console.WriteLine("Escribe la cantidad de horas que quieres que se acitve la ventilación de la habitación 1");
                Cantidadhoras = int.Parse(Console.ReadLine());
            } 
                Console.WriteLine("Ahora ingresa las horas de activacion de la ventilación");
                Console.WriteLine("");
                Console.WriteLine("Por ejemplo si quieres que se active a las 7 de la mañana escribe 7 o si quieres que se active a las 7 de la noche escribe 19, porque a esas horas serán las 7 y 19 horas del día, respectivamente");
                Console.WriteLine("");
            Console.WriteLine("Solo puedes escribir horas comenzando por las 7 de la mañana y terminando a las 7 de la noche, asi no habrá mucho frío en cada habitación"); 

                int[] Habitacion1 = new int[Cantidadhoras];

                for (int i = 0; i < Habitacion1.Length; i++)
                {
                    Console.WriteLine("Ingresa la hora");
                    Habitacion1[i] = int.Parse(Console.ReadLine());

                }
        }

        public static void RandomVentilacion()
        {
            Random random = new Random();

            Console.WriteLine("El programa hará el resto, las horas de los demás cuartos se programaran en base al rango de horas permitido para la habitación 1; esto será para cada habitación y para el resto de días");
            Console.WriteLine("");

            for (int i = 0; i < Habitacion1.Length; i++)
            {
                Habitacion2[i] = random.Next(7, 19);
            }
          
            for (int i = 0; i < Habitacion1.Length; i++)
            {
                Habitacion3[i] = random.Next(7, 19);
            }
           
            for (int i = 0; i < Habitacion1.Length; i++)
            {
                Habitacion4[i] = random.Next(7, 19);
            }
        }
        public static void Calefaccion()
            
        {
            Console.WriteLine("Ahora estipulemos los parámetros para la calefacción");
            Console.WriteLine("");
            Console.WriteLine("Escribe la misma cantidad de horas que pusiste en ventilacion, para la calefacción en la habitacion 1, asi habrá un equilibrio entre ventilacion y calefaccion");
            CantidadHoras = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (CantidadHoras < 1)
            {
                Console.WriteLine("Son muy pocas horas, al menos enciende la calefacción" + Cantidadhoras + " veces en el día para que no haga frío");
                Console.WriteLine(""); 
                Console.WriteLine("Escribe otra vez la cantidad");
                CantidadHoras = int.Parse(Console.ReadLine());
            }

            
            
                Console.WriteLine("Ingresa las horas de activación y luego la temperatura en Celsius para cada hora");
                Console.WriteLine("");
                Console.WriteLine("Por ejemplo: si quieres que la temperatura este a 19 grados escribe el numero 19");
                Console.WriteLine("");
                Console.WriteLine("Solo puedes ingresar temperaturas entre los 18 y 22 grados que no haya mucho frío ni mucho calor");

            int[] HABITACION1 = new int[CantidadHoras];
            int[] habitacion1= new int[CantidadHoras+1];

                for (int i = 0; i < HABITACION1.Length; i++)
                {
                    Console.WriteLine("Ingresa la hora");
                    HABITACION1[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Ahora ingresa la temperatura de esa hora");
                    habitacion1[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }
            
           
        }

        public static void RandomCalefaccion()
        {
           
            Console.WriteLine("Ahora el programa hará el resto para la calefacción");
            Random cal = new Random();
            for (int i = 0; i < habitacion1.Length; i++)
            {
                HABITACION2[i] = cal.Next(18, 22);
                habitacion2[i] = cal.Next(7, 19);
            }
           
            for (int i = 0; i < habitacion1.Length; i++)
            {
                HABITACION3[i] = cal.Next(18, 22);
                habitacion3[i] = cal.Next(7, 19);
            }
        
            for (int i = 0; i < habitacion1.Length; i++)
            {
                HABITACION4[i] = cal.Next(18, 22);
                habitacion4[i] = cal.Next(7, 19);
            }
        }

        public static void Iluminacion ()
        { 
            Console.WriteLine("Ahora solo falta programar la iluminacion");
            Console.WriteLine(""); 
            Console.WriteLine("Para esto tienes que indicarle al progarama la referencia para saber si entro o salio alguien, puedes usar un numero para indicar si entro y otro para indicar si salio");
            Console.WriteLine(""); 
            Console.WriteLine("¿Que numero escoges para indicar si entro alguien?");
            entro= int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("¿Que numero escoges para indicar si salio alguien?");
            salio = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("¿Que numero escoges para indicar si no entro nadie en la habitacion?");
            nuncaentro= int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("¿Quizas alguien siempre se quedó dentro de la habitacion a esa hora, ingresa un numero para esa opcion");
            siempreEstuvo = int.Parse(Console.ReadLine());
            Console.WriteLine("");

        }

        public static void EjecucionLunes()
        {

            Console.WriteLine("Ha llegado la hora, el programa esta listo para iniciar la automatizacion");
            Console.WriteLine("");
            Console.WriteLine("Por medio de la hora que indiques, se registrará la actividad de todas las funciones que tu programaste");
            Console.WriteLine("");
            Console.WriteLine("Indica la hora a evaluar");
            Hora = int.Parse(Console.ReadLine());

            //Se evalua ventilacion
            
            int[] Habitacion1 = new int[Cantidadhoras]; 
            int[] Habitacion2 = new int[Cantidadhoras];
            int[] Habitacion3 = new int[Cantidadhoras];
            int[] Habitacion4 = new int[Cantidadhoras]; 

                for (int i = 7; i < Habitacion1.Length; i++)
                {
                    if (Hora == Habitacion1[i])
                    {
                        Console.WriteLine("Ventilación apagada en la habitación 1");
                    }
                    if (Hora == Habitacion2[i])
                    {
                        Console.WriteLine("La ventilación esta encendida en la habitacion 2");
                    }


                    if (Hora == Habitacion3[i])
                    {
                        Console.WriteLine("La ventilación esta encendida en la habitacion 3");
                    }


                    if (Hora == Habitacion4[i])
                    {
                        Console.WriteLine("La ventilación esta encendida en la habitacion 4");
                    }
                }

            //Se evalua calefaccion 
            int[] HABITACION1 = new int[CantidadHoras]; 
            int[] HABITACION2 = new int[CantidadHoras];
            int[] HABITACION3 = new int[CantidadHoras];
            int[] HABITACION4 = new int[CantidadHoras];
        
            int[] habitacion1 = new int[CantidadHoras];
            int [] habitacion2 = new int[CantidadHoras];
            int[] habitacion3 = new int[CantidadHoras]; 
            int[] habitacion4 = new int[CantidadHoras];

            for (int i = 18; i < habitacion1.Length; i++)
            { 
                    if (Hora == HABITACION1[i])
                    {
                        Console.WriteLine("La calefacción esta encendida en la habitación 1 con una temperatura de: " + habitacion1[i]);
                    }
                    if (Hora == HABITACION2[i])
                    {
                        Console.WriteLine("La calefacción esta encendida en la habitación 1 con una temperatura de: " + habitacion2[i]);
                    }
                    if (Hora == HABITACION3[i])
                    {
                        Console.WriteLine("La calefacción esta encendida en la habitación 1 con una temperatura de: " + habitacion3[i]);
                    }
                    if (Hora == HABITACION4[i])
                    {
                        Console.WriteLine("La calefacción esta encendida en la habitación 1 con una temperatura de: " + habitacion4[i]);
                    }
            }

            

            //Se evalua iluminacion

            int[] iluminacion = new int[4]; 

            for (int i=1;i < 4; i++)
            {
                Console.WriteLine("¿Entró alguien a la habitación? "+ i+ ". Recuerda utilizar " + entro + ", " + salio + ", " + nuncaentro + " o " + siempreEstuvo +  " según sea el caso");
                Console.WriteLine("");
                EntroSalio = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (EntroSalio == siempreEstuvo)
                {
                    Console.WriteLine("La luz en la habitación" + i + " estuvo encendida");
                    Console.WriteLine("");
                }

                if (EntroSalio == nuncaentro)
                {
                    Console.WriteLine("La luz en la habitación" + i + " estuvo apagada");
                    Console.WriteLine(""); 
                }

                if (EntroSalio == entro)
                {
                    Console.WriteLine("Luz encendida");
                    Console.WriteLine(""); 
                }

                if (EntroSalio == entro)
                {
                    Console.WriteLine("¿La persona que entró, salió de la habitación?");
                    Console.WriteLine("");
                    EntroSalio = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    if (EntroSalio == salio)
                    {
                        Console.WriteLine("Luz apagada");
                    }
                    else
                    {
                        Console.WriteLine("La luz continuó encendida");
                        Console.WriteLine("");
                    }
                }
            }

            
        }
     


    }
}
