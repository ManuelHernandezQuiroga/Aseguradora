using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void AddSP()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese el UserName del Usuario: ");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Usuario: ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Paterno del Usuario: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Materno del Usuario: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Email del Usuario: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el Sexo del Usuario: H= Hombre | M= Mujer ");
            usuario.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Telefono del Usuario: ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el Celular del Usuario: ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese el Fecha de Nacimiento del Usuario (dd-MM-aaaa): ");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese el CURP del Usuario: ");
            usuario.CURP = Console.ReadLine();

            ML.Result result = BL.Usuario.AddSP(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario ha sido registrado con éxito.");
            }
            else
            {
                Console.WriteLine("El usuario no pudo ser registrado." + result.ErrorMessage);
            }
        }

        public static void UpDateSP()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Indique el Usuario a modificar.");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el UserName del Usuario: ");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Usuario: ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Paterno del Usuario: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido Materno del Usuario: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese el Email del Usuario: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese el Sexo del Usuario: ");
            usuario.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Telefono del Usuario: ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el Celular del Usuario: ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingrese el Fecha de Nacimiento del Usuario (dd-MM-aaaa): ");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingrese el CURP del Usuario: ");
            usuario.CURP = Console.ReadLine();

            ML.Result result = BL.Usuario.UpDateSP(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario ha sido registrado con éxito.");
            }
            else
            {
                Console.WriteLine("El usuario no pudo ser registrado." + result.ErrorMessage);
            }
        }

        public static void DeleteSP()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Indique el Id a eliminar.");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.DeleteSP(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario ha sido eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("El usuario no pudo ser eliminado." + result.ErrorMessage);
            }
        }

        public static void UsuarioGetAll()
        {
            ML.Result result = BL.Usuario.UsuarioGetAll();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Email: " + usuario.Email);
                    Console.WriteLine("Sexo: " + usuario.Sexo);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Celular: " + usuario.Celular);
                    Console.WriteLine("Fecha Nacimiento: " + usuario.FechaNacimiento);
                    Console.WriteLine("CURP: " + usuario.CURP);
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ocurrió un error al consultar la información" + result.ErrorMessage);
            }
        }

        public static void UsuarioGetById()
        {
            ML.Result result = BL.Usuario.UsuarioGetById(1);

            if (result.Correct)
            {

                //unboxing 
                ML.Usuario usuario = ((ML.Usuario)result.Object);

                Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Sexo: " + usuario.Sexo);
                Console.WriteLine("Telefono: " + usuario.Telefono);
                Console.WriteLine("Celular: " + usuario.Celular);
                Console.WriteLine("Fecha Nacimiento: " + usuario.FechaNacimiento);
                Console.WriteLine("CURP: " + usuario.CURP);
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Ocurrió un error al consultar la información" + result.ErrorMessage);
            }

        }
    }
}