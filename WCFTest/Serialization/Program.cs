using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:800");
            using (ServiceHost sh=new ServiceHost(typeof(MyService)))
            {
                sh.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(), uri);
                sh.Open();
                Console.WriteLine("Iservice Is Ready");


                Console.ReadKey();
                sh.Close();
            }

        }
    }

    public class AudioTrack
    {
        //[XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        //[XmlAttribute(AttributeName ="artist")]
        public string Artist { get; set; }
        //[XmlAttribute(AttributeName="no")]
        public int TrackNo { get; set; }
        //[XmlAttribute(AttributeName ="album")]
        public string Album { get; set; }

    }
    [ServiceContract,XmlSerializerFormat]
    interface IService
    {
        [OperationContract]
        void PostMusic(AudioTrack track);
    }
    public class MyService : IService
    {
        public void PostMusic(AudioTrack track)
        {
            OperationContext oc = OperationContext.Current;
            Console.WriteLine(oc.RequestContext.RequestMessage);
        }
    }
}
