using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {

        //public static void AddSP()
        //{
        //    ML.Aseguradora aseguradora = new ML.Aseguradora();

        //    Console.WriteLine("Ingrese el Nombre de la Aseguradora:");
        //    aseguradora.Nombre = Console.ReadLine();

        //    Console.WriteLine("Ingrese la Fecha de creacion:(dd--mm--aaaa)");
        //    aseguradora.FechaCreacion = Console.ReadLine();

        //    Console.WriteLine("Ingrese la Fecha de modificacion:(dd--mm--aaaa)");
        //    aseguradora.FechaModificacion = Console.ReadLine();

        //    Console.WriteLine("Ingrese el Id de Usuario:");
        //    aseguradora.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = new ML.Result();// BL.Aseguradora.AddSP(aseguradora);
        //    if (result.Correct)
        //    {
        //        Console.WriteLine("La aseguradora ha sido registrada con éxito.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("La aseguradora no pudo ser registrada." + result.ErrorMessage);
        //    }
        //}

        public static void AddSP()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Nombre de la Aseguradora:");
            aseguradora.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Id de Usuario:");
            aseguradora.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.AddSP(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La aseguradora ha sido registrada con éxito.");
            }
            else
            {
                Console.WriteLine("La aseguradora no pudo ser registrada." + result.ErrorMessage);
            }
        }

        public static void UpdateSP()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingrese el Id de la Aseguradora:");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre de la Aseguradora:");
            aseguradora.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el Id de Usuario:");
            aseguradora.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.UpdateSP(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La aseguradora ha sido registrada con éxito.");
            }
            else
            {
                Console.WriteLine("La aseguradora no pudo ser registrada." + result.ErrorMessage);
            }
        }

        public static void DeleteSP()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Indique el Id a eliminar.");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            ML.Result result = BL.Aseguradora.DeleteSP(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("La aseguradora ha sido eliminada con éxito.");
            }
            else
            {
                Console.WriteLine("La aseguradora no pudo ser eliminada." + result.ErrorMessage);
            }
        }

    }
}
