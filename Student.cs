using System.Collections.Generic;

namespace ClassPlayground
{
    public class Student
    {
        public string Name { get; set; }

        public List<string> Languages { get; set; }

        public Student()
        {
            Languages = new List<string>();
        }
    }
}