
namespace GenericDemo
{
    public class Car
    {
        public string Brand {get;set;}
        public string Model {get;set;}
        public int Year {get;set;}
        public decimal Price {get;set;}        
        public string Engine {get;set;}
        public Car()
        {
            Brand = string.Empty;
            Model = string.Empty;
            Year = 0;
            Price = 0;
            Engine = string.Empty;

        }

        public override string ToString()
        {
            return $"{Brand}, {Model}, {Year}, {Engine}, {Price:C2}";
        }
    }
}