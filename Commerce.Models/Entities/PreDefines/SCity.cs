using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Commerce.Models.Entities.PreDefines
{
    public class SCity : DataEntity
    {
        public SCity()
        {
            spostalcodes = new HashSet<SPostalCode>();
        }

        //[Key]
        //public long S_CIDADE_I_ID { get; set; }

        public long S_STATE_I_ID { get; set; }

        public long? S_CITY_I_IDIBGE { get; set; }

        public long? S_CITY_I_STATEIBGE { get; set; }

        [StringLength(40)]
        public string S_CITY_S_NAME { get; set; }

        public virtual ICollection<SPostalCode> spostalcodes { get; set; }

        public virtual SState sstates { get; set; }
    }
}
