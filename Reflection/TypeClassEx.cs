using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;
using System.Linq;

namespace Reflection
{
    internal class TypeClassEx
    {
        //primary way to access the metadata is by using the Type
        public void TypeOfVariable()
        {
            string input1 = "jack";
            
            // Get the current type of input1
            Type input1Type = input1.GetType(); // GetType() method return the type of variable 

            Console.WriteLine("Type of input1 is: " + input1Type);
        }

        public void TypeOfClass()
        {
            //get type of 'TypeClassEx' and load it to Type variable 't'
            Type t = typeof(TypeClassEx); // typeof operator that return type of the program class and assigned in to Type variabel 't'.

            // get Assembly of variable 't' using the Assembly property
            Console.WriteLine(t.Assembly);

        }

        public void InformationAboutEnumerable()
        {

            // get 'typeof' Enumerable and load it to Type variable 't'
            Type t = typeof(Enumerable);

            // the Type class properties return information about the Enumerable Type
            Console.WriteLine("Name : " + t.Name);
            Console.WriteLine("Namespace : " + t.Namespace);
            Console.WriteLine("Base Type :" + t.BaseType);
        }

    }
}
