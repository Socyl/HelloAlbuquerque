using System;

namespace HelloAlbuquerque
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello There Albuquerque!");
            

            string[] languages = new string[]{
                "C#", "COBOL", "Java",
                "C++", "Visual Basic", "Pascal",
                "Fortran", "Lisp", "J#"};

            foreach(string item in languages)
            {
                Console.WriteLine(item);  
            }

            Console.WriteLine();
            Array.Sort(languages);

            foreach (string item in languages)
            {
                Console.WriteLine(item);
            }

        }
    }
}
