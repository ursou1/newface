using System;
using System.Collections.Generic;
using System.Text;

namespace newface
{
    class Gym
    {
        public List<Animal> animals = new List<Animal>();
        public void AddAnimal(Animal anotherdog, Animal anotherbird, Animal anotherfish, Animal anotherbutterfly)
        {
            animals.Add(anotherdog);
            animals.Add(anotherbird);
            animals.Add(anotherfish);
            animals.Add(anotherbutterfly);
        }
        public void LetsMove()
        {
            if (animals is IWalking) // проверяем, может ли собака ходить
            {
                IWalking iDog = animals as IWalking; // получаем интерфейсную ссылку. за счет условия выше мы можем быть уверены, что здесь не будет значения null
                iDog.Walk(); // вызываем метод интерфейса, он вызовет реализацию этого метода в классе Dog
            }
            if (animals is IFlying) // проверяем, может ли собака ходить
            {
                IFlying iFly = animals as IFlying; 
                iFly.Fly(); 
            }
            if (animals is ISwimming) 
            {
                ISwimming iSwim = animals as ISwimming; 
                iSwim.Swim(); 
            }
            if (animals is IFlying)
            {
                IFlying iButterfly = animals as IFlying;
                iButterfly.Fly(); 
            }
            
        }
    }
}
