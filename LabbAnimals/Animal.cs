namespace LabbAnimals
{
    public class Animal
    {
        // Standard egenskaper 
        public string NameOfAnimal { get; set; } = "Unknown Animal";
        public int Age { get; set; } = 0;
        public string Color { get; set; } = "Unknown Color";
        public string Sound { get; set; } = "Unknown Sound";
        public string Movement { get; set; } = "Unknown Movement";

        // Konstruktor för att skapa nya objekt
        public Animal(string name = "Unknown Animal", int age  = 0, string color = "Unknown Color",
            string sound = "Unknown Sound", string movement = "Unknown Movement")
        {
            NameOfAnimal = name;
            Age = age;
            Color = color;
            Sound = sound;
            Movement = movement;
        }
        public void Presentation()
        {
            Console.WriteLine("The following animal is a/an: " + Color + " " + NameOfAnimal + " that is " + Age + " years old. ");
        }

        public void Hunting()
        {
            Console.WriteLine("Arghhhh.. I need to " + Movement + " so I can get some food!!! ");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(Sound + "... ");
        }
    }
}
