using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            product p = new product()
            {
                Id = 1,
                Name = "Apple",
                Price = 12
            };
            Message msg = Message.CreateMessage(MessageVersion.Soap12, "test-action","Hello world");
            MessageHeader hd = MessageHeader.CreateHeader("ItemNumber", "app-test", 2000);
            msg.Headers.Add(hd);
            Console.WriteLine($"Header:{msg.Headers.GetHeader<int>("ItemNumber", "app-test")}");
            Console.WriteLine($"Body: {msg.GetBody<string>()}");
        }

    }
    public class product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }

    }
}
