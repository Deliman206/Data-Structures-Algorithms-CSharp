using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    public class Shelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public static int TotalAnimals { get; set; }

        public void Enqueue(Animal animal)
        {
            if (animal.Type.ToLower() == "cat" || animal.Type.ToLower() == "dog")
            {
                if (Front == null)
                {
                    Front = animal;
                    Rear = animal;
                }
                else
                {
                    Animal temp = Rear;
                    temp.Next = animal;
                    Rear = animal;
                }
                TotalAnimals += 1;
            }
        }

        public Animal Dequeue(Animal animal)
        {
            Animal animalToAdopt = new Animal();

            for (int i = 0; i < TotalAnimals -1; i++)
            {
                // New Animal to break .next chain
                Animal x = new Animal(Front.Type);

                // Move Next Animal up in line
                Front = Front.Next;

                // Does the animal get adopted?
                // Yes
                if (Front.Type == animal.Type && animalToAdopt.Type == null)
                {
                    animalToAdopt.Type = animal.Type;
                }
                // NO
                else
                {
                    // Add Animal x to Rear
                    Rear.Next = x;

                    // Assign Animal x to Rear
                    Rear = x;
                }
            }
            // Someone is getting adopted!
            TotalAnimals -= 1;

            // Is the requested type in the shelter?
            // No
            if (animalToAdopt.Type == null)
                return Front;
            // Yes
            return animalToAdopt;
        }
    }
}
