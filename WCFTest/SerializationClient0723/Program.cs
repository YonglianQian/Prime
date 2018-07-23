using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SerializationClient0723
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(AudioTrack));
            AudioTrack track = new AudioTrack
            {
                Title = "abc",
                Artist = "Jack",
                TrackNo = 123,
                Albums = new List<Album>
                {
                    new Album{Id=1,Name="sky" },
                    new Album{Id=2,Name="Sea" }
                },
            };
            serializer.Serialize(ms, track);
            ms.Position = 0L;
            XDocument document = XDocument.Load(ms);
            Console.WriteLine($"Document: {document}");
        }
    }
    [XmlRoot("Track")]
    public class AudioTrack
    {
        [XmlAttribute(AttributeName = "title",Namespace="aaa")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "artist",Namespace ="bbb")]
        public string Artist { get; set; }
        [XmlElement(Namespace ="ccc")]
        public int TrackNo { get; set; }
        [XmlArray(Namespace ="ddd",ElementName ="Albums1")]
        public List<Album> Albums { get; set; }

    }
    [XmlType(TypeName ="Album")]
    public class Album
    {
        [XmlAttribute(AttributeName = "Id",Namespace ="ff")]
        public int Id { get; set; }
        [XmlElement(Namespace ="gg",ElementName ="Name")]
        public string Name { get; set; }
    }
}
