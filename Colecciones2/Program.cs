using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> Grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matemáticas", "MAT2019");
            Grupo historia = new Grupo("Historia", "HST2019");

            Grupos.Add(matematicas);
            Grupos.Add(historia);

            Alumno Jesus = new Alumno("Jesus", "189289");
            Alumno Maria = new Alumno("Maria", "189000");
            Alumno Jose = new Alumno("Jose", "189001");
            Alumno Pedro = new Alumno("Pedro", "189002");
            Alumno Ana = new Alumno("Ana", "189003");
            Alumno Eduardo = new Alumno("Eduardo", "189004");

            historia.Alumnos.Add(Jesus);
            historia.Alumnos.Add(Eduardo);
            historia.Alumnos.Add(Ana);

            matematicas.Alumnos.Add(Jose);
            matematicas.Alumnos.Add(Pedro);
            matematicas.Alumnos.Add(Ana);
            matematicas.Alumnos.Add(Maria);
            matematicas.Alumnos.Add(Jesus);
            matematicas.Alumnos.Add(Eduardo);

            foreach (Grupo grupo in Grupos)
            {
                Console.WriteLine("\nGrupo: " + grupo.Codigo);
                Console.WriteLine("Materia: " + grupo.Materia + " \n");
                Console.WriteLine("Lista de Alumnos: \n");

                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("Alumno: " + alumno.Nombre + " \nMatrícula: " + alumno.Matricula);
                }
            }

            //alumno1.Nombre = "Jesus";

            Console.Read();
        }
    }
}
