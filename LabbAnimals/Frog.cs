namespace LabbAnimals
{
    public class Frog : Animal
    {
        public string LivingArea { get; set; }

        // konstruktor för att skapa frogs värde

        public Frog(string name = "Frog", int age = 0, string color = "Green",
            string sound = "Ribbit", string movement = "Jump", string livingArea = "Pond")
            : base(name, age, color, sound, movement)
        {
            LivingArea = livingArea;
        }

        public void Swim()
        {
            Console.WriteLine("The " + NameOfAnimal + " is swimming in the " + LivingArea + "! ");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The " + NameOfAnimal + " goes " + Sound + " ! ");
        }
    }
}
