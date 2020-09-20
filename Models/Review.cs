using System.Runtime.Serialization;

namespace eurasia.Models
{
    [DataContract]
    public class Review
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ClientName { get; set; }
        [DataMember]
        public string Text { get; set; }
    }
}