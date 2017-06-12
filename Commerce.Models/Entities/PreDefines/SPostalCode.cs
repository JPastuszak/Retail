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
    public class SPostalCode : DataEntity
    {
        //[Key]
        //public long S_CEP_I_ID { get; set; }

        public long S_CIDADES_S_CIDADE_I_ID { get; set; }

        public long S_STATE_I_ID { get; set; }

        [StringLength(72)]
        public string S_POSTALCODE_S_STREET { get; set; }

        [StringLength(8)]
        public string S_POSTALCODE_S_POSTALCODE { get; set; }

        [StringLength(72)]
        public string S_POSTALCODE_S_NEIGHBOURHOOUD{ get; set; }

        public virtual SState sstate { get; set; }

        public virtual SCity scity { get; set; }
    }
}
