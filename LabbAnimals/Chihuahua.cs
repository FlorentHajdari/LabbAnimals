namespace LabbAnimals
{
    public class Chihuahua : Dog
    {
        // konstruktor för att skapa chihuahuas värde

        public Chihuahua(string name, int age, string color)
            : base(name, age, color, "Drr Drr ", "Run ", "Pink") { }

        public void SoftBark()
        {
            Console.WriteLine("The " + NameOfAnimal + " is barking with fear! ");
        }
    }
}
