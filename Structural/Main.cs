using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.Structural
{
    /*
    Specify the kind of objects to create using a prototypical instance, and create 
    new objects by copying this prototype.
        
    This structural code demonstrates the Prototype pattern in which new objects 
    are created by copying pre-existing objects (prototypes) of the same class.
        
    OUTPUT:
    Cloned: I
    Cloned: II
    */

    /// <summary>
    /// MainApp startup class for Structural
    /// Prototype Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainApp()
        {
            // Create two instances and clone each

            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user
            Console.ReadKey();
        }
    }
}
