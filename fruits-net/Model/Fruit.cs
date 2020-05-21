using System;
namespace fruit.Model
{
    public class Fruit
    {
        public Fruit()
        {
        }

        public Fruit(int id , string name)
        {
            this.id = id;
            this.name = name;
        }

        public int id { get; set; }
        public string name { get; set; }
        
    }
}
