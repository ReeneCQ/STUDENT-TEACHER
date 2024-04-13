

using codigo_tecsup;

class Program
{
    static void Main(string[] args)
    {
        // Crear al menos dos objetos Teacher
        Teacher teacher1 = new Teacher { Id = 1, Name = "Profesor A", Subject = "Matemáticas" };
        Teacher teacher2 = new Teacher { Id = 2, Name = "Profesor B", Subject = "Historia" };

        // Crear al menos cuatro objetos Student
        Student student1 = new Student { Id = 101, Name = "Estudiante 1", Grade = 85.5, Teacher = teacher1 };
        Student student2 = new Student { Id = 102, Name = "Estudiante 2", Grade = 90.0, Teacher = teacher1 };
        Student student3 = new Student { Id = 103, Name = "Estudiante 3", Grade = 75.2, Teacher = teacher2 };
        Student student4 = new Student { Id = 104, Name = "Estudiante 4", Grade = 88.7, Teacher = teacher2 };

        // Asignar los estudiantes a los profesores usando las propiedades de navegación
        teacher1.Students.Add(student1);
        teacher1.Students.Add(student2);
        teacher2.Students.Add(student3);
        teacher2.Students.Add(student4);

        // Llamar al método PrintStudentInfo() de cada estudiante para mostrar su información en la consola
        Console.WriteLine("Información de los estudiantes:");
        student1.PrintStudentInfo();
        student2.PrintStudentInfo();
        student3.PrintStudentInfo();
        student4.PrintStudentInfo();
    }
}