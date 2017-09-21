using System;

namespace PrototypePattern
{
    /*
    This real-world code demonstrates the Prototype pattern in which 
    new Color objects are created by copying pre-existing, 
    user-defined Colors of the same type.

    
    The classes and objects participating in this pattern are:

    Prototype  (ColorPrototype)
        declares an interface for cloning itself
    ConcretePrototype  (Color)
        implements an operation for cloning itself
    Client  (ColorManager)
        creates a new object by asking a prototype to clone itself

    OUTPUT:
    Cloning color RGB: 255,  0,  0
    Cloning color RGB: 128,211,128
    Cloning color RGB: 211, 34, 20
    */

    /// <summary>
    /// Program startup class for Real-World 
    /// Prototype Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            // Wait for user
            Console.ReadKey();
        }
    }
}