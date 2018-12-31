using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamange { get; set; }
        public int MaximumDamange { get; set; }

        public Weapon(int itemTypeID, string name, int price, int minimumDamage, int maximumDamage)
            :base(itemTypeID, name, price)
        {
            MinimumDamange = minimumDamage;
            MaximumDamange = maximumDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamange, MaximumDamange);
        }
    }
}
