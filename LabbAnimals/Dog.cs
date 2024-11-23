namespace LabbAnimals
{
    public class Dog : Animal
    {
        public string BodyType { get; set; } = "Normal";

        // konstruktor för att skapa dogs värde
        public Dog(string name = "Dog", int age = 0, string color = "Brown",
            string sound = "Bark", string movement = "Run", string bodytype = "Medium")
            : base(name, age, color, sound, movement)
        {
            BodyType = bodytype;
        }

        public void Play()
        {
            Console.WriteLine("The " + NameOfAnimal + " is playing the ball! ");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The " + BodyType + " " + NameOfAnimal + " goes " + Sound + "! ");
        }
    }
}
