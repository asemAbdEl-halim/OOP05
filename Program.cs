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

            #endregion
        }
    }
}
