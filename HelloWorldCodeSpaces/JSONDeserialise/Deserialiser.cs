using System.Text.Json;

namespace JSONDeserialise
{
    public class Deserialiser
    {
        static string jsonFilePath = "/workspaces/DotNetCodeSpaces/HelloWorldCodeSpaces/JSONDeserialise/Configuration.json";
        static string jsonString = File.ReadAllText(jsonFilePath);

        public static PIDConfigData parsePid(string pid)
        {
            
           
            // Deserialize the JSON string to a JsonDocument
            JsonDocument doc = JsonDocument.Parse(jsonString);

            // Access the root element of the JsonDocument
            JsonElement root = doc.RootElement;

            PIDConfigData configData = new PIDConfigData();

            configData.address = root.GetProperty(pid).GetProperty("address").GetInt32();
            configData.pinType = root.GetProperty(pid).GetProperty("type").GetString();
            configData.device  = root.GetProperty(pid).GetProperty("device").GetString();
            configData.unit   = root.GetProperty(pid).GetProperty("units").GetString();

            return configData;

        }
    }
}

