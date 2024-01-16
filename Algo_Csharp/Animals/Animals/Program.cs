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
            Herbivorous chevre = new("Chêvre");
            Horse bojack = new();
            Giraffe giraffe = new();


            chat.Eat();
            chat.Move();

            abeille.Move();
            abeille.Eat();
            abeille.Buzz();

            michel.Move();
            michel.Move();
            michel.Move();

            pinpon.Move();

            chevre.Move();
            chevre.Eat();

            bojack.Move();
            bojack.Eat();
            bojack.Neigh();

            giraffe.Move();
            giraffe.Eat();
            giraffe.Moo();

        }
    }
}