using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Programmering1
{
    internal class person

    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavoriteFood { get; set; }
        public string Hobby { get; }
     

        public person(string name, int age, string favoriteFood, string hobby)
        {
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;
            Hobby = hobby;
           

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Hei,jeg heter {Name}., Jeg er  {Age} år gammel., Jeg elsker {FavoriteFood}.,Jeg liker {Hobby}");
           

        }
        
    }

}
