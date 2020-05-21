using System;
using System.Collections.Generic;
using fruit.Model;

namespace fruit.service
{
    public interface IFruitService
    {
        public List<Fruit> GetAll();
        public Fruit PostFruit(string Fruit);
    }

 
}
