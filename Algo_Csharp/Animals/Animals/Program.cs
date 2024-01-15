namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal chat = new("Chat");
            Bee abeille = new();
            Labrador michel = new("Michel");
            Pinscher pinpon = new("Pinpon");

            chat.Eat();
            chat.Move();

            abeille.Move();
            abeille.Eat();
            abeille.Buzz();

            michel.Move();
            michel.Move();
            michel.Move();

            pinpon.Move();

        }
    }
}