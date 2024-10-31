namespace LabbAnimals
{
    public class Animal
    {
        public string NameOfAnimal;
        public int age;
        public string Color;
        public string Sound;
        public string Movement;

        public void Presentation()
        {
            Console.WriteLine("The following animal is a/an: " + NameOfAnimal);
        }

        public void Hunting()
        {
            Console.WriteLine("Arghhhh.. I need to " + Movement + "so I can get some food!!! ");
        }

        public void MakeSound()
        {
            Console.WriteLine(Sound + "... ");
        }
    }
}
