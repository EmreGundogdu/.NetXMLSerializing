using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeXML
{
    [Serializable]
    [XmlRoot("MemberDetails")] //En baştaki içerikleri kapsayan ana tag'ın ismini değiştirmemimiz sağlayan bir attribute'dir
    public class Member
    {
        [XmlElement("MemberName")] //element tag isimlerini değiştirmemizi sağlayn bir attirbute'dir.
        public string Name { get; set; }
        [XmlElement("MemberEmail")]
        public string Email { get; set; }
        public int Age { get; set; }
        [XmlIgnore]
        public DateTime JoiningDate { get; set; }
        [XmlAttribute("PlatinumMember")] // tag'ın içerisine attribte yazabilmeyi ayarlamamızı sağlayan bir attribute'dir.
        public bool IsPlatinumMember { get; set; }
    }
}
