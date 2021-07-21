using System;
using Torres_Hanoi;

namespace Torres_Hanoi
{
    class Program
    {

        public static Disco d1 = new Disco
        {
            dimension = 1,

        };
        public static Disco d2 = new Disco
        {
            dimension = 2
        };
        public static Disco d3 = new Disco
        {
            dimension = 3
        };
        public static Disco d4 = new Disco
        {
            dimension = 4
        };

        public static Torre t1 = new Torre
        {
            Numero = 1,
            Lugar_1 = 0,
            Lugar_2 = 0,
            Lugar_3 = 0,
            Lugar_4 = 0,
        };
        public static Torre t2 = new Torre
        {
            Numero = 2,
            Lugar_1 = 0,
            Lugar_2 = 0,
            Lugar_3 = 0,
            Lugar_4 = 0,
        };
        public static Torre t3 = new Torre
        {
            Numero = 3,
            Lugar_1 = 0,
            Lugar_2 = 0,
            Lugar_3 = 0,
            Lugar_4 = 0,
        };
        public static Juego Juego = new Juego();


        static void Main(string[] args)
        {
            Juego.jugador = Bienvenida();
            Juego_nuevo();

            int d_m, t_d, mov;
            do
            {
                Console.Clear();
                Datos_Juego();
                Imprimir_torre(t1);
                Imprimir_torre(t2);
                Imprimir_torre(t3);

                Console.WriteLine("Ingrese # de disco que desea mover");
                d_m = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese # de disco que desea mover");
                t_d = int.Parse(Console.ReadLine());
                Hacer_Movimiento(d_m, t_d);
                //Comprobar si gano               
            } while (d_m != 0);

        }

        static void Juego_nuevo()
        {
            d4.Ubicacion_t = 1;
            d4.Ubicacion_l = 1;
            d3.Ubicacion_t = 1;
            d3.Ubicacion_l = 2;
            d2.Ubicacion_t = 1;
            d2.Ubicacion_l = 3;
            d1.Ubicacion_t = 1;
            d1.Ubicacion_l = 4;


            t1.Lugar_1 = d4.dimension;
            t1.Lugar_2 = d3.dimension;
            t1.Lugar_3 = d2.dimension;
            t1.Lugar_4 = d1.dimension;



        }

        static void Datos_Juego()
        {
            Console.WriteLine($"////Jugador {Juego.jugador}////Movimiento {Juego.Movimientos}////////");
        }


        static void Imprimir_torre(Torre torre)
        {
            Console.WriteLine("");
            Console.WriteLine($"//////////////Torre {torre.Numero}///////////////");
            Console.WriteLine("");
            Console.WriteLine("     X");
            switch (torre.Lugar_4)
            {
                case 0: Console.WriteLine("     X"); break;
                case 1: Console.WriteLine("    XX1"); break;
                case 2: Console.WriteLine("   XXXX2"); break;
                case 3: Console.WriteLine("  XXXXXX3"); break;
                case 4: Console.WriteLine(" XXXXXXXX4"); break;
                default: break;
            }


            switch (torre.Lugar_3)
            {
                case 0: Console.WriteLine("     X"); break;
                case 1: Console.WriteLine("    XX1"); break;
                case 2: Console.WriteLine("   XXXX2"); break;
                case 3: Console.WriteLine("  XXXXXX3"); break;
                case 4: Console.WriteLine(" XXXXXXXX4"); break;
                default: break;
            }

            switch (torre.Lugar_2)
            {
                case 0: Console.WriteLine("     X"); break;
                case 1: Console.WriteLine("    XX1"); break;
                case 2: Console.WriteLine("   XXXX2"); break;
                case 3: Console.WriteLine("  XXXXXX3"); break;
                case 4: Console.WriteLine(" XXXXXXXX4"); break;
                default: break;
            }


            switch (torre.Lugar_1)
            {
                case 0: Console.WriteLine("     X"); break;
                case 1: Console.WriteLine("    XX1"); break;
                case 2: Console.WriteLine("   XXXX2"); break;
                case 3: Console.WriteLine("  XXXXXX3"); break;
                case 4: Console.WriteLine(" XXXXXXXX4"); break;
                default: break;
            }
            Console.WriteLine("------------");
        }




        static string Bienvenida()
        {

            string m;
            Console.WriteLine("");
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine("///////////// TORRES DE HANOI ///////////////");
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del jugador");
            m = Console.ReadLine();
            return m;

        }

        static Boolean Hacer_Movimiento(int disco, int torre)
        {
            Torre t_d = new Torre();
            Torre t_o = new Torre();
            Boolean libre = false;
            int ubi_t = 0, ubi_l = 0;
            // identitico las coordenadas del disco
            switch (disco)
            {
                case 1: ubi_t = d1.Ubicacion_t; ubi_l = d1.Ubicacion_l; break;
                case 2: ubi_t = d2.Ubicacion_t; ubi_l = d2.Ubicacion_l; break;
                case 3: ubi_t = d3.Ubicacion_t; ubi_l = d3.Ubicacion_l; break;
                case 4: ubi_t = d4.Ubicacion_t; ubi_l = d4.Ubicacion_l; break;
                default: break;
            }
            //Optengo una copia de la torre Destino
            switch (torre)
            {
                case 1: t_d = t1; break;
                case 2: t_d = t2; break;
                case 3: t_d = t3; break;
                default: break;
            }
            // OPtengo una copia de la torre Origen
            switch (ubi_t)
            {
                case 1: t_o = t1; break;
                case 2: t_o = t2; break;
                case 3: t_o = t3; break;
                default: break;
            }


            // Verificamos que el disco seleccionado no este bloqueado
          
                switch (ubi_l)
                {
                    case 1:
                    if (t_o.Lugar_2==0)
                    {
                        libre = true;
                    }
                    break;

                    case 2:
                    if (t_o.Lugar_3 == 0)
                    {
                        libre = true;
                    }
                    break;

                    case 3:
                    if (t_o.Lugar_4 == 0)
                    {
                        libre = true;
                    }
                    break;

                    case 4: libre=true;
                    break;

                    default:
                    libre = false;
                    break;
                }

            if (libre)
            {

                if (t_d.Numero != t_o.Numero)
                {
                    // Lugar uno vericacion
                    if (t_d.Lugar_1 == 0)
                    {
                        t_d.Lugar_1 = disco;
                        // limpiar torre origen
                        switch (ubi_l)
                        {
                            case 1: t_o.Lugar_1 = 0; break;
                            case 2: t_o.Lugar_2 = 0; break;
                            case 3: t_o.Lugar_3 = 0; break;
                            case 4: t_o.Lugar_4 = 0; break;
                            default: break;
                        }
                        //actualizar coordenadas
                        ubi_t = t_d.Numero;
                        ubi_l = 1;
                    }
                    else
                    {
                        // Lugar dos vericacion
                        if (t_d.Lugar_2 == 0 && t_d.Lugar_1 > disco)
                        {
                            t_d.Lugar_2 = disco;
                            // limpiar torre origen
                            switch (ubi_l)
                            {
                                case 1: t_o.Lugar_1 = 0; break;
                                case 2: t_o.Lugar_2 = 0; break;
                                case 3: t_o.Lugar_3 = 0; break;
                                case 4: t_o.Lugar_4 = 0; break;
                                default: break;
                            }
                            //actualizar coordenadas
                            ubi_t = t_d.Numero;
                            ubi_l = 2;
                        }
                        else
                        {
                            // Lugar tres vericacion
                            if (t_d.Lugar_3 == 0 && t_d.Lugar_2 > disco)
                            {
                                t_d.Lugar_3 = disco;
                                // limpiar torre origen
                                switch (ubi_l)
                                {
                                    case 1: t_o.Lugar_1 = 0; break;
                                    case 2: t_o.Lugar_2 = 0; break;
                                    case 3: t_o.Lugar_3 = 0; break;
                                    case 4: t_o.Lugar_4 = 0; break;
                                    default: break;
                                }
                                //actualizar coordenadas
                                ubi_t = t_d.Numero;
                                ubi_l = 3;
                            }
                            else
                            {
                                // Lugar tres vericacion
                                if (t_d.Lugar_4 == 0 && t_d.Lugar_3 > disco)
                                {
                                    t_d.Lugar_4 = disco;
                                    // limpiar torre origen
                                    switch (ubi_l)
                                    {
                                        case 1: t_o.Lugar_1 = 0; break;
                                        case 2: t_o.Lugar_2 = 0; break;
                                        case 3: t_o.Lugar_3 = 0; break;
                                        case 4: t_o.Lugar_4 = 0; break;
                                        default: break;
                                    }
                                    //actualizar coordenadas
                                    ubi_t = t_d.Numero;
                                    ubi_l = 4;
                                }


                            }

                        }



                    }





                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Movimiento no permitido");
                    Console.ReadKey();
                }

              
            }

            else
            {
                Console.WriteLine("Movimiento no permitido");
                Console.ReadKey();
            }



            switch (disco)
            {
               case 1: d1.Ubicacion_t = ubi_t;d1.Ubicacion_l= ubi_l; break;
               case 2: d2.Ubicacion_t = ubi_t;d2.Ubicacion_l = ubi_l; break;
               case 3: d3.Ubicacion_t = ubi_t;d3.Ubicacion_l = ubi_l; break;
               case 4: d4.Ubicacion_t = ubi_t;d4.Ubicacion_l = ubi_l; break;
               default: break;
            }


            return true;
        }


    }
}
