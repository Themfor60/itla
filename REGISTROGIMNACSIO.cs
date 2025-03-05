using System;
using System.Collections.Generic;

class Cliente
{
    public string Nombre { get; set; }
    public int Id { get; set; }
}

class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static int contadorId = 1;

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("1. Dar de alta un cliente");
            Console.WriteLine("2. Mostrar detalles de un cliente");
            Console.WriteLine("3. Listar clientes");
            Console.WriteLine("4. Buscar cliente (Nombre)");
            Console.WriteLine("5. Dar de baja un cliente");
            Console.WriteLine("6. Modificar un cliente");
            Console.WriteLine("7. Salir");
            Console.Write("Opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    DarDeAlta();
                    break;
                case 2:
                    MostrarDetalles();
                    break;
                case 3:
                    ListarClientes();
                    break;
                case 4:
                    BuscarCliente();
                    break;
                case 5:
                    DarDeBaja();
                    break;
                case 6:
                    ModificarCliente();
                    break;
                case 7:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 7);
    }

    static void DarDeAlta()
    {
        Console.Write("Nombre del cliente: ");
        string nombre = Console.ReadLine();
        clientes.Add(new Cliente { Id = contadorId++, Nombre = nombre });
        Console.WriteLine("Cliente agregado.");
    }

    static void MostrarDetalles()
    {
        Console.Write("Ingrese ID del cliente: ");
        int id = int.Parse(Console.ReadLine());
        Cliente cliente = clientes.Find(c => c.Id == id);
        if (cliente != null)
            Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}");
        else
            Console.WriteLine("Cliente no encontrado.");
    }

    static void ListarClientes()
    {
        foreach (var cliente in clientes)
            Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}");
    }

    static void BuscarCliente()
    {
        Console.Write("Ingrese nombre a buscar: ");
        string nombre = Console.ReadLine();
        var resultado = clientes.FindAll(c => c.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
        foreach (var cliente in resultado)
            Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}");
    }

    static void DarDeBaja()
    {
        Console.Write("Ingrese ID del cliente a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        clientes.RemoveAll(c => c.Id == id);
        Console.WriteLine("Cliente eliminado.");
    }

    static void ModificarCliente()
    {
        Console.Write("Ingrese ID del cliente a modificar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente cliente = clientes.Find(c => c.Id == id);
        if (cliente != null)
        {
            Console.Write("Nuevo nombre: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Cliente modificado.");
        }
        else
            Console.WriteLine("Cliente no encontrado.");
    }
}
