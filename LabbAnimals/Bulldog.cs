namespace LabbAnimals
{
    public class Bulldog : Dog
    {
        // konstruktor för att skapa bulldogs värde

        public Bulldog(string name, int age, string color)
            : base(name, age, color, "Woff Woff ", "Run ", "Grey") { }

        public void Snore()
        {
            Console.WriteLine("The " + NameOfAnimal + " is snoring! ");
        }
    }
}
