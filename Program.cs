using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("B I E N V E N I D O");
            Console.WriteLine("=====SmartPark=====");
            Console.WriteLine("Proyecto 1-b");
            Console.WriteLine("Andrés Vaquiax");
            Console.WriteLine("1103526");
            Console.WriteLine("Sebastian Gonzalez");
            Console.WriteLine("1252426");
            Console.WriteLine("=====SmartPark=====");
            Console.ResetColor();
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();



            //Registro inicial del sistema

            //Declaración de variables para el registro del operador
            int contadorregistro = 0;
            int contadorturno = 0;
            int contadorcapacidad = 0;
            string nombreOperador = "";
            string codigoTurno = "";





            //Nombre del operador

            while (contadorregistro < 1)
            {
                Console.WriteLine("=====SmartPark=====");
                Console.Write("Ingrese el nombre del operador: ");

                nombreOperador = Console.ReadLine();
                if (nombreOperador != "")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Registrado correctamente");
                    Console.WriteLine("==================");
                    Console.ResetColor();
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    contadorregistro++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se ha ingresado un nombre de operador válido.");
                    Console.ResetColor();

                    Console.WriteLine("Presione ENTER para intentar de nuevo...");
                    Console.ReadLine();
                    Console.Clear();

                }

            }

            //Código de turno

            while (contadorturno < 1)
            {
                Console.WriteLine("=====SmartPark=====");
                Console.WriteLine("Ingrese el código de turno: ");
                Console.WriteLine("(Debe contener exactamente 4 dígitos)");
                codigoTurno = Console.ReadLine();

                if (codigoTurno.Length != 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Código de turno no válido. Debe contener exactamente 4 dígitos.");
                    Console.WriteLine("Presione ENTER para intentar de nuevo...");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Registrado correctamente");
                    Console.WriteLine("==================");
                    Console.ResetColor();
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    contadorturno++;
                }
            }

            //Capacidad parqueo
            int capacidadParqueo = 0;
            while (contadorcapacidad < 1)
            {
                Console.WriteLine("=====SmartPark=====");
                Console.WriteLine("Ingrese la capacidad del parqueo: ");
                Console.WriteLine("(Debe ser mayor o igual a 10)");

                bool validez = int.TryParse(Console.ReadLine(), out capacidadParqueo);
                if (validez && capacidadParqueo >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Registrado correctamente");
                    Console.WriteLine("==================");
                    Console.ResetColor();
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    contadorcapacidad++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La capacidad mínima es 10");
                    Console.ResetColor();
                    Console.WriteLine("Presione ENTER para intentar de nuevo...");
                    Console.ReadLine();
                    Console.Clear();

                }
            }

            //Declaración de variables para SMARTPARK :)

            int ticketsCreados = 0;
            int ticketsCerrados = 0;
            double dineroRecaudado = 0.0;
            int tiempoSimulado = 0;
            bool ticketActivo = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====SmartPark=====");
            Console.WriteLine("Bienvenido/a " + nombreOperador + ". Estás usando SmartPark");
            Console.WriteLine("==================");
            Console.ResetColor();
            Console.WriteLine("Presione ENTER para comenzar...");
            Console.ReadLine();
            Console.Clear();

            //Finaliza registro inicial del sistema

            //Menú interactivo (CICLO)

            string nombreCliente = "";
            bool esVIP = false;
            int contadorMenu = 0;
            int espaciosOcupados = 0;
            string placaVehiculo = "";
            int tipoVehiculo = 0;
            int minutoEntrada = 0;
            int minutosEstacionados = 0;
            double tarifaPorHora = 0.0;
            int espaciosDisponibles = 0;
            int minutosSimular = 0;

            while (contadorMenu < 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=====SmartPark=====");
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Crear ticket");
                Console.WriteLine("2. Registrar salida");
                Console.WriteLine("3. Ver estado del parqueo");
                Console.WriteLine("4. Simular paso del tiempo");
                Console.WriteLine("5. Salir");
                Console.WriteLine("==================");
                Console.ResetColor();
                Console.Write("Seleccione una opción: ");
                int opcionMenu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcionMenu)
                {

                    case 1:
                        //Crear ticket

                        if (ticketActivo == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Solo un ticket activo a la vez");
                            Console.WriteLine("==================");
                            Console.ResetColor();
                            Console.WriteLine("Presione ENTER para regresar al menú...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        if (espaciosOcupados >= capacidadParqueo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Parqueo lleno");
                            Console.WriteLine("==================");
                            Console.ResetColor();
                            Console.WriteLine("Presione ENTER para regresar al menú...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        int contadorPlaca = 0;
                        while (contadorPlaca < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Ingrese su número de placa: ");
                            Console.WriteLine("(6 a 8 caracteres, sin espacios)");
                            Console.ResetColor();
                            placaVehiculo = Console.ReadLine();

                            if ((placaVehiculo.Length >= 6) && (placaVehiculo.Length <= 8) && !placaVehiculo.Contains(" "))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Registrado correctamente");
                                Console.WriteLine("==================");
                                Console.ResetColor();
                                contadorPlaca++;
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Placa no válida. Debe contener entre 6 a 8 caracteres y no espacios");
                                Console.ResetColor();
                                Console.WriteLine("Presione ENTER para intentar de nuevo...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        int contadorTipovehiculo = 0;
                        while (contadorTipovehiculo < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Seleccione el tipo de vehículo");
                            Console.WriteLine("1. Moto");
                            Console.WriteLine("2. Auto");
                            Console.WriteLine("3. Pickup/SUV");
                            Console.ResetColor();
                            tipoVehiculo = int.Parse(Console.ReadLine());

                            if (tipoVehiculo < 1 || tipoVehiculo > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Tipo de vehículo no válido. Debe ser 1, 2 o 3");
                                Console.ResetColor();
                                Console.WriteLine("Presione ENTER para intentar de nuevo...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Registrado correctamente");
                                Console.WriteLine("==================");
                                Console.ResetColor();
                                contadorTipovehiculo++;
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        nombreCliente = "";
                        int contadorNombre = 0;
                        while (contadorNombre < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Ingrese su nombre completo: ");
                            Console.ResetColor();
                            nombreCliente = Console.ReadLine();
                            if (nombreCliente != "")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Registrado correctamente");
                                Console.WriteLine("==================");
                                Console.ResetColor();
                                contadorNombre++;
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No se ha ingresado un nombre válido.");
                                Console.ResetColor();
                                Console.WriteLine("Presione ENTER para intentar de nuevo...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("¿El cliente es VIP?");
                            Console.WriteLine("1. Sí");
                            Console.WriteLine("2. No");
                            Console.ResetColor();
                            int opcionVIP = int.Parse(Console.ReadLine());
                            if (opcionVIP == 1)
                            {
                                esVIP = true;
                            }
                            else
                            {
                                esVIP = false;
                            }
                            ticketActivo = true;
                            ticketsCreados++;
                            espaciosOcupados++;
                            minutoEntrada = tiempoSimulado;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Ticket creado exitosamente");
                            Console.WriteLine("==================");
                            Console.ResetColor();
                            Console.WriteLine("Presione ENTER para regresar al menú...");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;
                    case 2:
                        //Cerrar ticket
                        if (ticketActivo == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("No hay ticket activo para cerrar");
                            Console.ResetColor();
                            Console.WriteLine("Presione ENTER para regresar al menú...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            minutosEstacionados = tiempoSimulado - minutoEntrada;
                        }

                        if (tipoVehiculo == 1)
                        {
                            tarifaPorHora = 5.0;
                        }
                        else if (tipoVehiculo == 2)
                        {
                            tarifaPorHora = 10.0;
                        }
                        else
                        {
                            tarifaPorHora = 15.0;
                        }
                        int horasCompletas = minutosEstacionados / 60;
                        int minutosRestantes = minutosEstacionados % 60;

                        if (minutosRestantes > 0)
                        {
                            horasCompletas = horasCompletas + 1;
                        }

                        double cobro = horasCompletas * tarifaPorHora;
                        if (minutosEstacionados <= 15)
                        {
                            cobro = 0;
                        }
                        if (minutosEstacionados > 360)
                        {
                            cobro = cobro + 25;
                        }
                        if (esVIP == true)
                        {
                            cobro = cobro - (cobro * 0.10);
                        }
                        if (minutosEstacionados > 720)
                        {
                            cobro = cobro + (cobro * 0.20);
                        }

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("=====SmartPark=====");
                        Console.WriteLine("Resumen de salida:");
                        Console.WriteLine("Placa: " + placaVehiculo);
                        Console.WriteLine("Nombre: " + nombreCliente);
                        Console.WriteLine("Minutos estacionados: " + minutosEstacionados);
                        Console.WriteLine("Cobro: Q." + cobro);
                        Console.WriteLine("==================");
                        Console.ResetColor();
                        Console.WriteLine("Presione ENTER para continuar...");
                        Console.ReadLine();

                        dineroRecaudado = dineroRecaudado + cobro;
                        ticketsCerrados++;
                        ticketActivo = false;
                        espaciosOcupados = espaciosOcupados - 1;

                        Console.Clear();


                        break;
                    case 3:
                        //Estado del parqueo
                        espaciosDisponibles = capacidadParqueo - espaciosOcupados;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("=====SmartPark=====");
                        Console.WriteLine("Estado del parqueo:");
                        Console.WriteLine("Capacidad total: " + capacidadParqueo);
                        Console.WriteLine("Espacios ocupados: " + espaciosOcupados);
                        Console.WriteLine("Espacios disponibles: " + espaciosDisponibles);
                        Console.WriteLine("Tiempo simulado: " + tiempoSimulado + " minutos");
                        Console.WriteLine("Total recaudado: Q." + dineroRecaudado);
                        Console.WriteLine("Tickets creados: " + ticketsCreados);
                        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                        Console.ResetColor();
                        if (ticketActivo == true)
                        {
                            Console.WriteLine("Ticket activo:");
                            Console.WriteLine("Placa: " + placaVehiculo);
                            if (tipoVehiculo == 1)
                            {
                                Console.WriteLine("Tipo de vehículo: Moto");
                            }
                            else if (tipoVehiculo == 2)
                            {
                                Console.WriteLine("Tipo de vehículo: Auto");
                            }
                            else
                            {
                                Console.WriteLine("Tipo de vehículo: Pickup/SUV");
                            }
                            Console.WriteLine("Minutos estacionados: " + minutosEstacionados);
                            Console.WriteLine("Tarifa por hora: $" + tarifaPorHora);
                        }
                        else
                        {
                            Console.WriteLine("No hay ticket activo");
                        }
                        Console.WriteLine("==================");
                        Console.WriteLine("Presione ENTER para regresar al menú...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        //Simular paso del tiempo
                        if (ticketActivo == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Porfavor, cree un ticket primero");
                            Console.WriteLine("==================");
                            Console.ResetColor();
                            Console.WriteLine("Presione ENTER para regresar al menú...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        int contadorMinutos = 0;
                        while (contadorMinutos < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("=====SmartPark=====");
                            Console.WriteLine("Ingrese la cantidad de minutos a simular: ");
                            Console.WriteLine("(Debe ser un número entre 1 a 1440)");
                            Console.ResetColor();
                            minutosSimular = int.Parse(Console.ReadLine());

                            if ((minutosSimular >= 1) && (minutosSimular <= 1440))
                            {
                                tiempoSimulado = tiempoSimulado + minutosSimular;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tiempo actual: " + tiempoSimulado + " minutos");
                                Console.WriteLine("==================");
                                Console.ResetColor();
                                contadorMinutos++;
                                Console.WriteLine("Presione ENTER para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Cantidad de minutos no válida. Debe ser entre 1 a 1440");
                                Console.ResetColor();
                                Console.WriteLine("Presione ENTER para intentar de nuevo...");
                                Console.ReadLine();
                                Console.Clear();
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tiempo simulado correctamente");
                            Console.WriteLine("==================");
                            Console.ResetColor();

                            if (ticketActivo == true)
                            {
                                minutosEstacionados = tiempoSimulado - minutoEntrada;
                                Console.WriteLine("Tiempo simulado: " + tiempoSimulado + " minutos");
                                Console.WriteLine("Minutos estacionados: " + minutosEstacionados);
                            }

                            if (minutosEstacionados >= 720)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Recargo por permanencia extrema");
                                Console.ResetColor();
                            }
                            else if (minutosEstacionados >= 360)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("¡Cuidado! Multa próxima");
                                Console.ResetColor();
                            }

                            Console.WriteLine("==================");
                            Console.WriteLine("Presione ENTER para regresar al menú...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        //Salir y mostrar resumen final del turno   

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("=====SmartPark=====");
                        Console.WriteLine("Resumen final del turno:");
                        Console.WriteLine("Operador: " + nombreOperador);
                        Console.WriteLine("Codigo de turno: " + codigoTurno);
                        Console.WriteLine("Tickets creados: " + ticketsCreados);
                        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                        Console.WriteLine("Dinero recaudado: Q." + dineroRecaudado);
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();
                        contadorMenu++;
                        Console.WriteLine("Gracias por elegir SmartPark. ¡Hasta luego!");
                        break;
                }
            }




        }
    }
}
