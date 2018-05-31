using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random r = new Random();
            double rJoseph = Math.Round(r.NextDouble() * 100.0);
            Person Joseph = new Person("Joseph", "Pum Suan Khai", new DateTime(1987, 02, 03), 178, Convert.ToInt32(rJoseph));
            Subject person = new Subject("Math", new DateTime(2018, 2, 26));

            double rPeter = Math.Round(r.NextDouble() * 100.0);
            Person Peter = new Person("Peter", "Smith", new DateTime(1990, 05, 03), 168, Convert.ToInt32(rPeter));
            Subject peter = new Subject("Intro Programming", new DateTime(2017, 03, 15));

            double rJohn = Math.Round(r.NextDouble() * 100.0);
            Person John = new Person("John", "Wong", new DateTime(1988, 04, 10), 181, Convert.ToInt32(rJohn));
            Subject john = new Subject("Web Programming", new DateTime(2016, 3, 16));


            
            Joseph.Fullname();
            Console.WriteLine("ID " + Joseph.ID);
            Console.WriteLine("Joseph Fullname is " + Joseph.Fullname());
            Console.WriteLine("Joseph was born in " + Joseph.DateOfbirth.ToShortDateString());
            Console.WriteLine("Joseph height is " + Joseph.Height + " cm tall");
            Console.WriteLine("Joseph is " + (Joseph.Height-Peter.Height) + " cm taller than Peter");
            Console.WriteLine("Joseph is " + (John.Height-Joseph.Height)  + " cm shorter than John");
            Console.WriteLine("Joseph studied " + person.Subjectname + "  in  " + person.SubjYear);
            Console.ReadLine();

            
            Peter.Fullname();
            Console.WriteLine("ID " + Peter.ID);
            Console.WriteLine("Peter Fullname is " + Peter.Fullname());
            Console.WriteLine("Peter was born in " + Peter.DateOfbirth.ToShortDateString());
            Console.WriteLine("Peter height is " + Peter.Height + " cm tall");
            Console.WriteLine("Peter is " + (Joseph.Height-Peter.Height) + " cm shorter than Joseph");
            Console.WriteLine("Peter is " + (John.Height-Peter.Height) + " cm shorter than John");
            Console.WriteLine("Peter studied " + peter.Subjectname + "  in  " + peter.SubjYear);
            Console.ReadLine();

            
            
            John.Fullname();
            Console.WriteLine("ID " + John.ID);
            Console.WriteLine("John Fullname is " + John.Fullname());
            Console.WriteLine("John was born in " + John.DateOfbirth.ToShortDateString());
            Console.WriteLine("John height is " + John.Height + " cm tall");
            Console.WriteLine("John is " + (John.Height-Joseph.Height) + " cm taller than Joseph");
            Console.WriteLine("John is " + (John.Height-Peter.Height) + " cm taller than Peter");
            Console.WriteLine("John studied " + john.Subjectname + "  in  " + john.SubjYear);
            Console.ReadLine();


        }

    }

   


}
