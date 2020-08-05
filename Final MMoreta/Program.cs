using System;

namespace Final_MMoreta
{
    class Program
    {
        
         
        static void Main(string[] args)
        {
            Menu();

        }
       public static void Menu()
       {
            Console.Clear();
            string[] arraynombre = new string[]
            {
        "Anderson Rosario Peña","Mario Gamer","Jancory Carela Rosario","Angela De Los Santos"
            };
            string[] arrayusername = new string[5];
            arrayusername[0] = "40237587803";
            arrayusername[1] = "44256555437";
            arrayusername[2] = "40758996311";
            arrayusername[3] = "00112342032";
            int[] arrayclave = new int[5];
            arrayclave[0] = 1234;
            arrayclave[1] = 4010;
            arrayclave[2] = 5024;
            arrayclave[3] = 6458;
            string[] arrayrol = new string[3];
            arrayrol[0] = "Administrador";
            arrayrol[0] = "Supervisor";
            arrayrol[0] = "Vendedor";
            string[] arrayfecha = new string[5];
            arrayfecha[0] = "21/04/2017";
            arrayfecha[1] = "10/08/2012";
            arrayfecha[2] = "15/03/2010";
            arrayfecha[3] = "30/08/2015";
            
            Console.WriteLine("############################\n#Bienvenido al sistema#\n############################");

            Console.WriteLine("Seleccione la opcion que desea realizar:\n1-Entrar al sistema\n2-Usuarios del sistema");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            switch (respuesta)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Digite el numero de usuario(su cedula sin guiones):");
                        string cedula = Console.ReadLine();
                        Console.WriteLine("Ahora digite la contraseña");
                        int password = Convert.ToInt32(Console.ReadLine());
                        if (cedula == "40237587803")
                        {
                            if (password == 1234)
                            {
                                Console.WriteLine("Bienvenido a menu administrador");
                                Console.Write("Administrador: ");
                                Console.WriteLine(arraynombre[0] + "    Fecha de ingreso es:" + arrayfecha[0]);

                                Console.WriteLine("Desea volver a ingresar como otro usuario? Y o precione cualquier tecla y cerrará automaticamente)");
                                string respuesta2= Console.ReadLine();
                                if (respuesta2.ToUpper() == "Y")
                                {
                                    Menu();
                                }
                                else
                                {
                                    Exit();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingreso algun dato mal, intentelo de nuevo");
                                Menu();
                            }
                        }
                        else if (cedula == "44256555437")
                        {
                            if (password == 4010)
                            {
                                Console.WriteLine("Bienvenido a menu Supervisor");
                                Console.Write("Supervisor: ");
                                Console.WriteLine(arraynombre[1] + "    Fecha de ingreso es:" + arrayfecha[1]);

                                Console.WriteLine("Desea volver a ingresar como otro usuario? Y o precione cualquier tecla y cerrará automaticamente)");
                                string respuesta2 = Console.ReadLine();
                                if (respuesta2.ToUpper() == "Y")
                                {
                                    Menu();
                                }
                                else
                                {
                                    Exit();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingreso algun dato mal, intentelo de nuevo");
                                Menu();
                            }
                        }
                        else if (cedula == "40758996311")
                        {
                            if (password == 5024)
                            {
                                Console.WriteLine("Bienvenido a menu Vendedor");
                                Console.Write("Vendedor: ");
                                Console.WriteLine(arraynombre[2] + "    Fecha de ingreso es:" + arrayfecha[2]);

                                Console.WriteLine("Desea volver a ingresar como otro usuario? Y o precione cualquier tecla y cerrará automaticamente)");
                                string respuesta2 = Console.ReadLine();
                                if (respuesta2.ToUpper() == "Y")
                                {
                                    Menu();
                                }
                                else
                                {
                                    Exit();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingreso algun dato mal, intentelo de nuevo");
                                Menu();
                            }
                        }
                        else if (cedula == "00112342032")
                        {
                            if (password == 6458)
                            {
                                Console.WriteLine("Este usuario esta inactivo, favor de entrar con otro usuario");
                                Menu();
                                Console.WriteLine("Bienvenido a menu Vendedor");
                                Console.Write("Vendedor: ");
                                Console.WriteLine(arraynombre[3] + "    Fecha de ingreso es:" + arrayfecha[3]);

                                Console.WriteLine("Desea volver a ingresar como otro usuario? Y o precione cualquier tecla y cerrará automaticamente)");
                                string respuesta2 = Console.ReadLine();
                                if (respuesta2.ToUpper() == "Y")
                                {
                                    Menu();
                                }
                                else
                                {
                                    Exit();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingreso algun dato mal, intentelo de nuevo");
                                Menu();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("No digito el numero correcto, intente de nuevo");
                        Console.ReadKey();
                        Menu();
                    }
                    break;
                case 2:
                    Console.WriteLine("Seleccione el usuario qu desea ver: ");
                    Console.WriteLine("1-" +arraynombre[0] + "\n2-" + arraynombre[1]+ "\n3-" + arraynombre[2] + "\n4-" + arraynombre[3]);
                    int nombreeleccion = Convert.ToInt32(Console.ReadLine());
                    switch (nombreeleccion)
                    {
                        case 1:
                            Console.WriteLine("Los datos de este usuario son: ");
                            Console.WriteLine("Nombre: " + arrayusername[0] + "\nClave: " + arrayclave[0] + "\nFecha de inicio: " + arrayfecha[0] + "\nPuesto: " + arrayrol[0]);
                            Console.WriteLine("Desea volver al menu principal? precione la Y para volver de lo contrario el programa se cerrará");
                            string respuesta03 = Console.ReadLine();
                            if (respuesta03.ToUpper() == "Y")
                            {
                                Menu();
                            }
                            else
                            {
                                Exit();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Los datos de este usuario son: ");
                            Console.WriteLine("Nombre: " + arrayusername[1] + "\nClave: " + arrayclave[1] + "\nFecha de inicio: " + arrayfecha[1] + "\nPuesto: " + arrayrol[1]);
                            Console.WriteLine("Desea volver al menu principal? precione la Y para volver de lo contrario el programa se cerrará");
                            string respuesta04 = Console.ReadLine();
                            if (respuesta04.ToUpper() == "Y")
                            {
                                Menu();
                            }
                            else
                            {
                                Exit();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Los datos de este usuario son: ");
                            Console.WriteLine("Nombre: " + arrayusername[2] + "\nClave: " + arrayclave[2] + "\nFecha de inicio: " + arrayfecha[2] + "\nPuesto: " + arrayrol[2]);
                            Console.WriteLine("Desea volver al menu principal? precione la Y para volver de lo contrario el programa se cerrará");
                            string respuesta05 = Console.ReadLine();
                            if (respuesta05.ToUpper() == "Y")
                            {
                                Menu();
                            }
                            else
                            {
                                Exit();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Los datos de este usuario son: ");
                            Console.WriteLine("Nombre: " + arrayusername[3] + "\nClave: " + arrayclave[3] + "\nFecha de inicio: " + arrayfecha[3] + "\nPuesto: " + arrayrol[3]);
                            Console.WriteLine("Desea volver al menu principal? precione la Y para volver de lo contrario el programa se cerrará");
                            string respuesta06 = Console.ReadLine();
                            if (respuesta06.ToUpper() == "Y")
                            {
                                Menu();
                            }
                            else
                            {
                                Exit();
                            }
                            break;
                    }

                    break;
            }
       }
        public static void Exit()
        {
            Console.WriteLine("Gracias por entrar al sistema :) Adios");
            //Console.ReadKey();
        }
    }
}
