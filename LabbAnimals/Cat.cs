namespace LabbAnimals
{
    public class Cat : Animal
    {
        public string CatType { get; set; } = "Indoor";

        // konstruktor för att skapa cats värde

        public Cat(string name = "Cat", int age = 0, string color = "White", string sound = "Mjau", string movement = "Run", string catType = "Indoor")
            : base(name, age, color, sound, movement)
        {
            CatType = catType;
        }

        public void Climb()
        {
            Console.WriteLine("The " + NameOfAnimal + " is climbing on the sofa! ");
        }

        // info om typ av katt
        public void ShowType()
        {
            Console.Write("The " + NameOfAnimal + " is a " + CatType + " cat. ");
         
        }

        public override void MakeSound()
        {
            Console.WriteLine("The " + NameOfAnimal + " goes " + Sound + "! ");
        }
    }
}
