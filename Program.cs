using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            string resp = "";
            do
            {
                Console.WriteLine("----Crud Usuario----");
                Console.WriteLine("De acuerdo a las opciones siguientes elija una.");
                Console.WriteLine("1.-Agregar Usuario || 2.-Actualizar Usuario || 3.-Eliminar Usuario || 4.-Consultar Usuarios || 5.-Consultar Por Id");
                Console.WriteLine("6.-Agregar Aseguradora || 7.- Actualizar Aseguradora || 8.- Eliminar Aseguradora || 9.- Consultar Aseguradoras || 10.- Consultar Por Id");

                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                
                switch(eleccion)
                {
                    case "1":
                        Usuario.AddSP();
                        break;
                    case "2":
                        Usuario.UpDateSP();
                        break;
                    case "3":
                        Usuario.DeleteSP();
                        break;
                    case "4":
                        Usuario.UsuarioGetAll();
                        break;
                    case "5":
                        Usuario.UsuarioGetById();
                        break;
                    case"6":
                        Aseguradora.AddSP();
                        break;
                    case"7":
                        Aseguradora.UpdateSP();
                        break;
                    case"8":
                        Aseguradora.DeleteSP();
                        break;
                        
                }
                 Console.WriteLine("Desea continuar? s/n:");
                resp = Console.ReadLine();
            }
            while (resp == "s");
            Console.ReadKey();
            }

           // PL.Usuario.DeleteSP();
        }
}

