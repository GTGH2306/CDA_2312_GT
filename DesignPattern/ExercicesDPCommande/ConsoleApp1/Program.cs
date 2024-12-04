using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Type type = System.Type.GetType("ConsoleApp1.Bidulle");
            MethodInfo method = type.GetMethod("FaisQuelleChose", BindingFlags.Public | BindingFlags.Instance);

            object obj = Activator.CreateInstance(type);
            method.Invoke(obj,new object[] { "ce que tu veux!" });


        }
    }
}
