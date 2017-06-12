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
    public class SCountry : DataEntity
    {
        public SCountry()
        {
            sstates = new HashSet<SState>();
        }

        //[Key]
       // public long S_PAIS_I_ID { get; set; }

        public long? S_COUNTRY_I_ID { get; set; }

        [StringLength(4)]
        public string S_COUNTRY_S_SIGLA { get; set; }

        [StringLength(30)]
        public string S_COUNTRY_S_NANE { get; set; }

        public long? S_COUNTRY_I_BACEN { get; set; }

        public virtual ICollection<SState> sstates { get; set; }
    }
}
