using StructureMap;
using System;

namespace StructureMapHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureDependencies();


            Console.WriteLine("Type indian for Indian food / type italian for Italian Food / Press E to Exit");

            string foodKind = Console.ReadLine();

            while (String.IsNullOrEmpty(foodKind) == false && foodKind.ToLower() != "e")
            {

                IFood food;

                if (foodKind.ToLower().Contains("italian"))
                {
                    food = ObjectFactory.GetNamedInstance<IFood>("ItalianFoodKey");
                    Console.WriteLine("Thanks for Ordering " + food.GetFood());
                    foodKind = Console.ReadLine();
                }

                else if (foodKind.ToLower().Contains("indian"))
                {
                    food = ObjectFactory.GetNamedInstance<IFood>("IndianFoodKey");
                    Console.WriteLine("Thanks for Ordering " + food.GetFood());
                    foodKind = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Type indian for Indian food / type italian for Italian Food / Press E to Exit");
                    foodKind = Console.ReadLine();
                }


            }

            Environment.Exit(0);

        }


        private static void ConfigureDependencies()
        {
            //return new Container(x =>
            //{
            //    x.For<IAppEngine>().Use<AppEngine>();
            //    x.For<IGreeter>().Use<FrenchGreeter>();
            //    x.For<IOutputDisplay>().Use<ConsoleOutputDisplay>();
            //});

            ObjectFactory.Initialize(x =>
            {
                // We put the properties for an NHibernate ISession
                // in the StructureMap.config file, so this file
                // must be there for our application to
                // function correctly
                //http://docs.structuremap.net/ConfiguringStructureMap.htm
                x.UseDefaultStructureMapConfigFile = true;
                //x.PullConfigurationFromAppConfig = true;
            });

        }
    }
}
