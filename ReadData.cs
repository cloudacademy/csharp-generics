using System.Text.Json;

namespace GenericDemo
{
    public class ReadData
    {
        private string path = string.Empty;
        public T GetData<T>(string fileName) where T : class, new()
        {
            try
            {
                string jsonResult = File.ReadAllText(path + fileName);
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var responseObject = JsonSerializer.Deserialize<T>(jsonResult, options);
                    return responseObject is null ? new T() : responseObject;
                }
                catch
                {
                    return new T();
                }
            }
            catch
            {
                return new T();
            }
        } 

        public ReadData()
        {}

        public ReadData(string folderName)
        {
            path = folderName;
        }


        public T Get<T>(string fileName) where T : class, new()
        {
            string jsonResult = File.ReadAllText(path + fileName);

            var responseObject = JsonSerializer.Deserialize<T>(jsonResult);

            return responseObject is null ? new T() : responseObject;
        } 

    }

}