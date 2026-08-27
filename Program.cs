namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01

            /*
             * 1) - Object Copying
             * a) What happens when you assign one object variable to another object variable?
             * ==> Anser <==
             * ==> When you assign one object variable to another, both variables refer to the same object in memory.
             * 
             * b) Does assigning one object to another create a new object? Explain.
             * => Anser <==
             * ==> No, assigning one object to another does not create a new object. It only copies the reference to the existing object.
             * 
             * c) What is the difference between copying an object and copying its reference?
             * => Anser <==
             * ==> Copying the object: creates a new separate object, so changing one does not affect the other.
             * Copying the reference: both variables point to the same object, so changing it through one variable affects the other.
             * **/

            #endregion

            #region Question02

            /*
             * 2) Shallow Copy vs Deep Copy
             * 
             * a) What is a Shallow Copy?
             * => Anser <==
             * ==> A Shallow Copy creates a new object, but the reference-type members still point to the same objects.
             * 
             * b) What is a Deep Copy?
             * => Anser <==
             * ==> A Deep Copy creates a new object and also creates new copies of the reference-type members.
             * 
             * c) What happens to reference-type members in Shallow Copy?
             * => Anser <==
             * They point to the same object as the original.
             * 
             * d) What happens to reference-type members in Deep Copy?
             * => Anser <==
             * ==> They point to new separate objects, so changing one does not affect the other.
             * 
             * e) When is Deep Copy safer?
             * => Anser <==
             * ==> When you need to modify the copied object without changing the original object.
             * **/

            #endregion

            #region Question03

            /*
             * 3) Static Members
             * a) What is a static field, and how is it different from an instance field?
             * ==> Anser <==
             * ==> A static field belongs to the class itself, not to each object. There is only one copy shared by all objects.
             * An instance field has a separate copy for each object.
             * 
             * b) What is a static method? Can a static method directly access instance members?
             * => Anser <==
             * ==> A static method belongs to the class and can be called without creating an object.
             * A static method cannot directly access instance members because instance members belong to an object.
             * 
             * c) What is a static constructor, and when is it executed?
             * => Anser <==
             * ==> A static constructor is used to initialize static members.
             * It runs automatically once, before the class is used for the first time.
             * 
             * d) What is a static class? Can you create an object from a static class?
             * A static class is a class that contains only static members.
             * You cannot create an object from a static class.
             * **/

            #endregion

            #region Question04

            /*
             * 4) Extension Methods
             * a) What is an Extension Method?
             * => Anser <==
             * ==> An Extension Method is a method that allows us to add a new method to an existing class without changing the original class.
             * 
             * b) What keyword must be used in the first parameter of an extension method?
             * ==> Anser <==
             * ==> The "this" keyword must be used in the first parameter of an extension method.
             * 
             * c) Where must an extension method be declared?
             * ==> Anser <==
             * ==> It must be inside a static class.
             * 
             * d) Can an extension method access private members of the class it extends?
             * ==> Anser <==
             * ==> No. It cannot directly access private members of the class because it is not actually a member of that class.
             * **/

            #endregion

            #region Question05

            /*
             * 5) Partial Classes and Partial Methods
             * a) What is a Partial Class?
             * ==> Anser <==
             * ==> A Partial Class is a class that can be divided into multiple files, but C# treats them as one class.
             * 
             * b) Why would a developer split one class into multiple files?
             * ==> Anser <==
             * ==> To make the code more organized and easier to manage, especially when the class is very large.
             * 
             * c) What is a Partial Method?
             * ==> Anser <==
             * ==> A Partial Method is a method that can be declared in one part of a partial class and implemented in another part.
             * 
             * d) What happens if a declared partial method has no implementation?
             * ==> Anser <==
             * ==> If it is a valid optional partial method, the compiler removes it, so it causes no error and has no effect.
             * **/

            #endregion

            #endregion

            #region Part02

            #region Question01

            /*
             * 1) - Object Copying
             * => Anser <==
             * Shipment shipment1 = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                new DeliveryAddress("Cairo", "Tahrir Street", 10)
            );
            
            // Reference Copy
            Shipment shipment2 = shipment1;
            
            shipment2.Description = "Mobile Phone";
            
            Console.WriteLine("Reference Copy:");
            Console.WriteLine("Shipment 1 Description: " + shipment1.Description);
            Console.WriteLine("Shipment 2 Description: " + shipment2.Description);
            
            Console.WriteLine();
            
            // Actual Copy
            Shipment shipment3 = shipment1.CopyShipment();
            
            shipment3.Description = "Television";
            
            Console.WriteLine("Actual Copy:");
            Console.WriteLine("Shipment 1 Description: " + shipment1.Description);
            Console.WriteLine("Shipment 3 Description: " + shipment3.Description);
             * **/

            #endregion

            #region Question02

            /*
             2) Shallow Copy
             */

            #endregion

            #region Question03

            /*
             3) Deep Copy
             */

            #endregion

            #region Question04

            /*
             4) Static Field
             */

            #endregion

            #region Question05

            /*
             5) Static Constructor
             */

            #endregion

            #endregion
        }
    }
}
