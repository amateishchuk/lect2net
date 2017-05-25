using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IRepository
    {
        void InsertAnimal(string nickname, string kind);
        void FeedAnimal(string nickname);
        void HealAnimal(string nickname);
        void DeleteAnimal(string nickname);
        void ShowAnimals();
        void ChangeStateForRandomAnimal();
        bool CloseZoo();
    }
}
