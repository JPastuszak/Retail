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
    public class SState:DataEntity
    {
        public SState()
        {
            spostalcodes = new HashSet<SPostalCode>();
            scities = new HashSet<SCity>();
        }

        //[Key]
        //public long S_UF_I_ID { get; set; }

        public long S_COUNTRY_S_COUNTRY_I_ID { get; set; }

        [StringLength(20)]
        public string S_STATE_S_NAME { get; set; }

        [StringLength(2)]
        public string S_STATE_S_SIGLA { get; set; }

        [StringLength(1)]
        public string S_STATE_S_ZFM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_STATE_F_PERCENTTAXICMS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? S_STATE_F_PERCENTTAXST { get; set; }

        public virtual ICollection<SPostalCode> spostalcodes { get; set; }

        public virtual ICollection<SCity> scities { get; set; }

        public virtual SCountry scountry { get; set; }
    }
}
