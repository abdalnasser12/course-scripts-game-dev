
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture10
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                if (health >= 100)
                {
                    health = 100;
                }
                else if (health <= 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }
        public Character(string Name, int Healthh, Position positionn)
        {
            this.name = Name;
            this.Health = Healthh;
            this.position = positionn;
        }
        public Character() : this("no name", 100, new Position(0, 0, 0))
        {

        }
        public virtual void Displayinfo()
        {
            Debug.Log(name);
            Debug.Log(Health);
            position.PrintPosition();
        }
        public void Attack(int hit, Character characterTarget)
        {
            int damage = characterTarget.Health - hit;
            if (damage >= 100)
            {
                damage = 100;
            }
            else if (damage <= 0)
            {
                damage = 0;
            }
            else
            {
                damage = characterTarget.Health - hit;
            }
            characterTarget.Health = damage;
            Debug.Log(characterTarget.Health);

        }
        public void Attack(int hit, Character characterTarget, string attackType)
        {



            Attack(hit, characterTarget);
            Debug.Log(attackType);

        }
    }

}