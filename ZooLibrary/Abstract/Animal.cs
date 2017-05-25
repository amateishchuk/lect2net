using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Animal
    {
        protected int health;
        protected int MAXHEALTH;
        public State State { get; set; } = State.Full;
        public string Nickname { get; protected set; }

        protected Animal(string nickname)
        {
            this.Nickname = nickname;
        }

        public void HealthUp()
        {
            if (State != State.Dead && health < MAXHEALTH)
            {
                health++;
            }
        }

        public void ChangeState()
        {
            if (State < State.Sick)
                State++;
            if (State == State.Sick && health > 0)
                health--;
            if (health == 0)
                State = State.Dead;
        }
        private void isSick()
        {
            if (health > 0)
                health--;
            else
                State = State.Dead;
        }

        public override string ToString()
        {
            return String.Format($"{this.Nickname}\t{this.health}\t{this.MAXHEALTH}\t{this.State}");
        }
    }
}
