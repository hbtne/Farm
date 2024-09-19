
using Bai1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.Business
{
    public class Farm
    {
        private Animals _d;
        public Farm()
        {
            _s = new Animals();
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> a = new List<Animal>();
            for (int i = 0; i < Cow.Quantity + Sheep.Quantity + Goat.Quantity; i++)
            {
                if (i < Cow.Quantity)
                    a.Add(new Cow());
                else if (i < Cow.Quantity + Sheep.Quantity)
                    a.Add(new Sheep());
                else
                    a.Add(new Goat());
            }
            return a;
        }
        public void Updateamount(int cowA, int sheepA, int goatA)
        {
            Cow.Quantity = cowA;
            Sheep.Quantity = sheepA;
            Goat.Quantity = goatA;
        }
        public void Updategd(Label lbCow, Label lbSheep, Label lbGoat)
        {
            lbCow.Text = Cow.Quantity.ToString();
            lbSheep.Text = Sheep.Quantity.ToString();
            lbGoat.Text = Goat.Quantity.ToString();
        }
        public string soundwhenhurngy()
        {
            string sound = "";
            for (int i = 0; i < GetAllAnimals().Count(); i++)
            {
                sound += GetAllAnimals().ElementAt(i).MakeSound();
            }
            return sound;
        }
        public void whenfull(Label cowA, Label cowM, Label sheepA, Label sheepM, Label goatA, Label goatM)
        {
            List<Animal> currentAnimals = GetAllAnimals();
            for (int i = 0; i < currentAnimals.Count(); i++)
            {
                if (currentAnimals.ElementAt(i) is Cow)
                {
                    if (Cow.Quantity > 1)
                        Cow.Quantity += currentAnimals.ElementAt(i).GiveBirth();
                    Cow.MilkVolume += currentAnimals.ElementAt(i).GiveMilk();
                }
                else if (currentAnimals.ElementAt(i) is Sheep)
                {
                    if (Sheep.Quantity > 1)
                        Sheep.Quantity += currentAnimals.ElementAt(i).GiveBirth();
                    Sheep.MilkVolume += currentAnimals.ElementAt(i).GiveMilk();
                }
                else
                {
                    if (Goat.Quantity > 1)
                        Goat.Quantity += currentAnimals.ElementAt(i).GiveBirth();
                    Goat.MilkVolume += currentAnimals.ElementAt(i).GiveMilk();
                }
            }
            cowA.Text = Cow.Quantity.ToString();
            cowM.Text = Cow.MilkVolume.ToString();
            sheepA.Text = Sheep.Quantity.ToString();
            sheepM.Text = Sheep.MilkVolume.ToString();
            goatA.Text = Goat.Quantity.ToString();
            goatM.Text = Goat.MilkVolume.ToString();
        }
    }
}
