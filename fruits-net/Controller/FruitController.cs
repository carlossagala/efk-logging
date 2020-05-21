using System;
using System.Collections.Generic;
using fruit.Model;
using fruit.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;

namespace fruit.Controller
{

    [Route("/api/[controller]")]
    [ApiController]
    public class FruitController
    {

        private readonly IFruitService _fruitService;
        private readonly Microsoft.Extensions.Logging.ILogger _logger;


        public FruitController(IFruitService fruitService, ILogger<FruitController> logger)
        {
            _fruitService = fruitService;
            _logger = logger;
        }



        [HttpGet]
        public List<Fruit> GetAll()
        {
            
            var fruits = _fruitService.GetAll();
            _logger.LogInformation("GET response: {@Fruits}", fruits);
            return fruits;

        }

        [HttpPost]
        public Fruit PostFruit(Fruit fruit)
        {
            _logger.LogInformation("POST Request: {@Fruit}", fruit);

            return _fruitService.PostFruit(fruit.name);

        }


    }
}
