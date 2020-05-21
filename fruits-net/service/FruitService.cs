using System;
using System.Collections.Generic;
using fruit.Model;

namespace fruit.service
{
    public class FruitService : IFruitService
    {


        public static List<Fruit> _Fruits;



        public FruitService()
        {
            if(_Fruits == null) { 
                _Fruits = new List<Fruit>();

                _Fruits.Add(new Fruit(0,"naranja"));
                _Fruits.Add(new Fruit(1,"banana"));
                _Fruits.Add(new Fruit(2,"manzana"));
            }
        }

        public List<Fruit> GetAll()
        {
            return _Fruits;
        }

        public Fruit PostFruit(string fruta)
        {
            _Fruits.Add(new Fruit(_Fruits.Count, fruta));

            return _Fruits[_Fruits.Count - 1];
        }
    }
}
