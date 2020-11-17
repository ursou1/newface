using System;

namespace newface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog anotherdog = new Dog("Shai", new DateTime(2003,11,26));
            Console.WriteLine($"Имя: {anotherdog.Name} Возраст: {anotherdog.Age}");
            ((IWalking)anotherdog).Walk();

            Bird anotherbird = new Bird("Malek", new DateTime(1999,1,2));
            Console.WriteLine($"Имя: {anotherbird.Name} Возраст: {anotherbird.Age}");
            ((IFlying)anotherbird).Fly();
            
            Fish anotherfish = new Fish("Nemo", new DateTime(2018,12,17));
            Console.WriteLine($"Имя: {anotherfish.Name} Возраст: {anotherfish.Age}");
            ((ISwimming)anotherfish).Swim();

            Butterfly anotherbutterfly = new Butterfly("SOS", new DateTime(2014,8,4));
            Console.WriteLine($"Имя: {anotherbutterfly.Name} Возраст: {anotherbutterfly.Age}");
            ((IFlying)anotherbutterfly).Fly();


            Gym gym = new Gym();
            gym.AddAnimal(anotherdog, anotherbird, anotherfish, anotherbutterfly);
            gym.LetsMove();
        }
    }
}
