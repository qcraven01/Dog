using System;

namespace Dog
{
    public class Dog

    //I got stuck on adding gender into my program
    {
        public string name;
        public string owner;
        public int age;
      

        public Dog(string name, string owner, int age)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            //I am stuck here... I cant figure out how to add this.gender = gender; It's diff from the other three above because it is type enum
        }
        public void Bark(int times)
        {
            for (int i = 0; i < times; i++)
            {


                Console.WriteLine("Woof");
            }
           
        }
        public string GetTag()
        {
            return String.Format("If lost, call {0}. His name is {1} and he is {2} years old.", owner, name, age);
        }

        class MainClass
    {
        public static void Main(string[] args)
        {
            Dog puppy = new Dog("Onion", "Bill", 1);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());
        }
    }
    
            
        
        }   


        }

    

