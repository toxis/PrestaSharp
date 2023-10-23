using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bukimedia.PrestaSharp.Entities
{
    [XmlType(Namespace = "Bukimedia/PrestaSharp/Entities")]
    public class store : PrestaShopEntity, IPrestaShopFactoryEntity
    {
        public long? id { get; set; }
        public long? id_country { get; set; }
        public long? id_state { get; set; }
        public string hours { get; set; }
        public string postcode { get; set; }
        public string city { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public int active { get; set; } = 1;
        public List<Entities.AuxEntities.language> name { get; set; } = new List<AuxEntities.language>();
        public List<Entities.AuxEntities.language> address1 { get; set; } = new List<AuxEntities.language>();
        public List<Entities.AuxEntities.language> address2 { get; set; } = new List<AuxEntities.language>();
    }
}
