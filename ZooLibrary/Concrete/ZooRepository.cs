using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ZooRepository : IRepository
    {
        List<Animal> animals = new List<Animal>() {
            new Lion("Timon"),
            new Tiger("Simba"),
            new Elephant("Slon"),
            new Fox("Pumba")
        };

        public void InsertAnimal(string nickname, string kind)
        {
            nickname = nickname.Trim();
            Animal animal = animals.FirstOrDefault(a=> a.Nickname == nickname);


            if (animal == null)
            {
                switch (kind.Trim().ToLower())
                {
                    case "lion":
                        animal = new LionFactory().CreateAnimal(nickname);
                        break;
                    case "tiger":
                        animal = new TigerFactory().CreateAnimal(nickname);
                        break;
                    case "elephant":
                        animal = new ElephantFactory().CreateAnimal(nickname);
                        break;
                    case "bear":
                        animal = new BearFactory().CreateAnimal(nickname);
                        break;
                    case "wolf":
                        animal = new WolfFactory().CreateAnimal(nickname);
                        break;
                    case "fox":
                        animal = new FoxFactory().CreateAnimal(nickname);
                        break;
                    default:
                        animal = null;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The kind of animal is apsend in the list.");
                        break;
                }
            }

            if (animal != null)
            {
                animals.Add(animal);
                Console.WriteLine($"The {kind} was added. Nickname - {nickname}");
            }
        }

        public void FeedAnimal(string nickname) // кормить
        {
            Animal animal = animals.FirstOrDefault(a => a.Nickname == nickname);

            if (animal != null)
            {
                if (animal.State != State.Dead)
                {
                    animal.State = State.Full;
                    Console.WriteLine($"{nickname} was fed");
                }
                else if (animal.State == State.Dead)
                {
                    Console.WriteLine($"{nickname} is dead");
                }
            }
            else
            {
                Console.WriteLine($"{nickname} is apsend in the repository");
            }
            
        }
        public void HealAnimal(string nickname) // лечить
        {
            Animal animal = animals.FirstOrDefault(a => a.Nickname == nickname);

            if (animal != null)
            {
                if (animal.State != State.Dead)
                {
                    animal.HealthUp();
                    Console.WriteLine($"{nickname} was heal");
                }
                else if (animal.State == State.Dead)
                {
                    Console.WriteLine($"{nickname} is dead");
                }
            }
            else
            {
                Console.WriteLine($"{nickname} is apsend in the repository");
            }
        }
        public void DeleteAnimal(string nickname)
        {
            Animal animal = animals.FirstOrDefault(a => a.Nickname == nickname);

            if (animal != null)
            {
                if (animal.State == State.Dead)
                {
                    animals.Remove(animal);
                    Console.WriteLine($"{animal.Nickname} was deleted from repository");
                }
                else
                    Console.WriteLine($"{animal.Nickname} is not dead");
            }
            else
            {
                Console.WriteLine($"{nickname} is apsend in the repository");
            }
        }

        public void ShowAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Name\tHealth\tMaxhp\tState");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var animal in animals.OrderBy(a=>a.State))
            {
                Console.WriteLine(animal.ToString());
            }
            Console.WriteLine();
        }

        public void ChangeStateForRandomAnimal()
        {
            if (animals.Count > 0)
            {
                int random = new Random().Next(animals.Count);
                animals[random].ChangeState();
            }
        }
        public bool CloseZoo()
        {
            bool state = false;
            foreach(var animal in animals)
            {
                if (animal.State != State.Dead)
                {
                    state = true;
                    break;
                }
            }

            return state;
            
        }
    }
}
