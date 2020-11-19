using System;

namespace ClassPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Student cj = new Student()
            {
                Name = "CJ",
                // Languages = new List<string>()
            };

            cj.Languages.Add("Javascript");
            cj.Languages.Add("C#");
        }
    }
}