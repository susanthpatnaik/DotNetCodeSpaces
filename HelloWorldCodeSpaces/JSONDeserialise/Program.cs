

using JSONDeserialise;

class Program
{
    static void Main(string[] args)
    {

        PIDConfigData PIDValue = new PIDConfigData();
        
        
        PIDValue = Deserialiser.parsePid("FT522");
        Console.WriteLine(PIDValue.address);
        Console.WriteLine(PIDValue.pinType);
        Console.WriteLine(PIDValue.unit);
        Console.WriteLine(PIDValue.device);
        
    }
       
}
