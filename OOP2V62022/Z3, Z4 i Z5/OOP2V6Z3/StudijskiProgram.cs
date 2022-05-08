using System.Collections.Generic;

namespace OOP2V6Z3
{
    public class StudijskiProgram
    {
        public StudijskiProgram()
        {
            Studenti = new List<Student>();
        }
        public string Naziv { get; set; }
        public List<Student> Studenti { get; set; }
    }
}
