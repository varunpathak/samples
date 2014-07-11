
namespace StructureMapHelloWorld
{

    public interface IFoodEngine
    {
        void Run();
    }

    public interface IFood
    {
        string GetFood();
    }

    public class SouthIndian : IFood
    {
        public string GetFood()
        {
            return "Idly-Dosa";
        }
    }

    public class Italian : IFood
    {
        public string GetFood()
        {
            return "Pizza";
        }
    }


}
