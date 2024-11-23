namespace LabbAnimals
{
    public class Program
    {
        static void Main(string[] args)
        {
            // instanser av djur skapas
            Dog dog = new Dog("Dog", 16, "Black", "Woff Woff", "Run", "Muscular");
            Cat cat = new Cat("Cat", 10, "White", "Mjauuuuuu", "Run", "Indoor");
            Frog frog = new Frog("Frog", 2, "Green", "Ribbit", "Jump", "Pool");
            Animal animal = new Animal();
            Console.WriteLine(animal.NameOfAnimal);
            Console.WriteLine(animal.Age);

            // metoder till alla djur anropas
            dog.Presentation();
            dog.MakeSound();
            dog.Play();
            dog.Hunting();
            Console.WriteLine("");

            cat.Presentation();
            cat.ShowType();
            cat.MakeSound();
            cat.Climb();
            cat.Hunting();
            Console.WriteLine("");

            frog.Presentation();
            frog.MakeSound();
            frog.Swim();
            frog.Hunting();
            Console.WriteLine("");

            // skapar instanser av subklasserna som ärver dog
            Bulldog bulldog = new Bulldog("Bulldog", 5, "Grey");
            Chihuahua chihuahua = new Chihuahua("Chihuahua", 6, "Pink");

            //anropar metoder
            bulldog.Presentation();
            bulldog.MakeSound();
            bulldog.Snore();
            Console.WriteLine("");

            chihuahua.Presentation();
            chihuahua.MakeSound();
            chihuahua.SoftBark();
            
        }
    }
}
