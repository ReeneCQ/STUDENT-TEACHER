using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_tecsup
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        public Teacher Teacher { get; set; }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Nombre del estudiante: {Name}, Calificación: {Grade}");
        }
    }
}
