using System.Text.Json.Serialization;

namespace GenericDemo
{
    public class Character
    {
        public string Name {get;set;}            
        public string Species {get;set;}  
        public int Height {get;set;}
        public decimal Weight {get;set;}                
        public Character()
        {
            Name = string.Empty;
            Species = string.Empty;
            Height = 0;
            Weight = 0;
        }


        public override string ToString()
        {
            return $"{Name}, {Species}, {Height}cm, {Weight}kg";
        }        
    }
}