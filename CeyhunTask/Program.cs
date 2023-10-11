using System;

namespace ceyhun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person("    ceyhun Aghayev   ",19,"912983178523");
            Console.WriteLine($"{person.FullNamee} {person.Age} {person.PhoneNumber}");*/
            
            Custom custom = new Custom();
            custom.Name = "   Tedfkgjndcset   ";


            /*Console.WriteLine(custom.ContainMethod('e'));*/

            /*Console.WriteLine(custom.SubStringElement(3));*/

            /*Console.WriteLine(custom.ReplaceChar('e', 'a'));*/

            Console.WriteLine(custom.Trim_Remove_Space());




        }
    }
}