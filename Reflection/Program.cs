using System;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeClassEx type = new TypeClassEx();

            type.TypeOfVariable(); // Type of variable
            type.TypeOfClass(); // Type of class 'TypeClassEx'
            type.InformationAboutEnumerable();  
            Console.ReadLine();
        }
    }
}
