namespace GenericDemo
{

    public class Items<T> : List<T>
    {

        public Items(): base()
        {}
        public void Print()
        { 
            Type t = typeof(T);
            Console.WriteLine($"List of {t.ToString().Substring(t.ToString().IndexOf('.') + 1)}s");
            foreach(T item in this)
            {
                Console.WriteLine(item?.ToString());
            }
        }
    }
}