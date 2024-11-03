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

    // Subklass för hundar
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

    // Subklass för katter
    public class Cat : Animal
    {
        public bool IsIndoor { get; set; }

        // konstruktor för att skapa cats värde

        public Cat(string name = "Cat", int age = 0, string color = "White", string sound = "Mjau", string movement = "Run", bool isIndoor = true)
            : base(name, age, color, sound, movement)
        {
            IsIndoor = isIndoor;
        }

        public void Climb()
        {
            Console.WriteLine("The " + NameOfAnimal + " is climbing on the sofa! ");
        }

        // info om typ av katt
        public void ShowType()
        {
            Console.Write("The " + NameOfAnimal + " likes to be ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(True = indoor, False = outside): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(IsIndoor);
        }

        public override void MakeSound()
        {
            Console.WriteLine("The " + NameOfAnimal + " goes " + Sound + "! ");
        }
    }

    // Subklass för groda
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

    // Subklass för bulldog som ärver subklassen dog
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


    // Subklass för chihuahua som ärver subklassen dog

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
