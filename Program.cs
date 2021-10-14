using Newtonsoft.Json;
using System;

namespace BlockchainCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockchain dummyCoin = new Blockchain();
            dummyCoin.AddBlock(new Block(DateTime.Now, null, "from:Kamil,to:Tom,amount:100"));
            dummyCoin.AddBlock(new Block(DateTime.Now, null, "from:Tom,to:Kamil,amount:30"));
            dummyCoin.AddBlock(new Block(DateTime.Now, null, "from:Kamil,to:Tom,amount:50"));

            Console.WriteLine(JsonConvert.SerializeObject(dummyCoin, Formatting.Indented));

            Console.WriteLine($"Is Chain Valid: {dummyCoin.IsValid()}");
            Console.WriteLine($"Upate sender first transaction");
            dummyCoin.Chain[1].Data = "{from:Dominik,to:Tom,amount:100}";
            Console.WriteLine($"Is Chain Valid: {dummyCoin.IsValid()}");
        }
    }
}
