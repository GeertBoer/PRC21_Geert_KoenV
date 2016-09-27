using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    class Administration
    {
        private List<Animal> animals; 

        public Administration()
        {
            animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {         
            if(animal != null)
            {
                animals.Add(animal);
                return true;
            }
            return false;  
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in animals)
            {
                if(a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animals.Remove(a);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            foreach (Animal a in animals)
            {
                if(a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return a;
                }
                else if(a.ChipRegistrationNumber != chipRegistrationNumber)
                {
                    return null;
                }
            }
            return null;
        }

        public bool checkChipNr(int nr)
        {
            foreach (Animal a in animals)
            {
                if (a.ChipRegistrationNumber == nr)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
