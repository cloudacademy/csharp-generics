namespace GenericDemo;

class Program
{
    static void Main(string[] args)
    {
        string dataFolder = AppContext.BaseDirectory;
        dataFolder = dataFolder.Substring(0, dataFolder.IndexOf("\\bin\\Debug") + 1) + "Data\\";
        ReadData rd = new ReadData(dataFolder);

        /*Items<int> wholeNumbers = rd.GetData<Items<int>>("NumberData.json");
        wholeNumbers.Print();
        Console.WriteLine();

        Items<Character> characters = rd.GetData<Items<Character>>("CharacterData.json");
        characters.Print();
        Console.WriteLine();

        Items<Car> cars = rd.GetData<Items<Car>>("CarData.json");
        cars.Print();
        Console.WriteLine();*/

        PrintT<object>(rd, "NumberData.json");         
        PrintT<Character>(rd, "CharacterData.json");        
        PrintT<Car>(rd, "CarData.json");      
    }

    private static void PrintT<T>(ReadData rd, string fileName) where T: class
    {
        Items<T> listOfT = rd.GetData<Items<T>>(fileName);
        listOfT.Print();
        Console.WriteLine();
    }  
}
