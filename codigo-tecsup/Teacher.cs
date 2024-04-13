using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_tecsup
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public List<Student> Students { get; set; }

        public Teacher()
        {
            Students = new List<Student>();
        }
    }
}
