using System.Runtime.Serialization;

namespace MyFirstWCF
{
    public class HappinessMessageObject
    {
        [DataMember]
        public int HappinessNumber { get; set; } = 0;
        [DataMember]
        public string HappinessMessage { get; set; } = "";
    }
}