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
    public class SFlagCard : DataEntity
    {
        //[Key]
        //public long S_BANDEIRA_I_ID { get; set; }

        [StringLength(30)]
        public string S_FLAG_S_NAME { get; set; }

        public long? S_FLAG_I_DAYS { get; set; }
    }
}
