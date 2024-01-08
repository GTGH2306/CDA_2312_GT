namespace PassageParRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            Console.WriteLine(age);
            AjouterUnAn(ref age);
            Console.WriteLine(age);
        }

        static void AjouterUnAn(ref int _age)
        {
            _age++;
        }
    }
}