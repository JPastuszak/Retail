using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


using Commerce.Models.Entities.Finance;

namespace Commerce.Models.Entities.PreDefines
{
    public class SBank:DataEntity
    {

        public SBank()
        {
            cbankaccounts = new HashSet<CBankAccount>();
        }

        //[Key]
       // public long S_BANK_I_ID { get; set; }

        public long? S_BANK_I_CODBACEN { get; set; }

        [StringLength(100)]
        public string S_BANK_S_NAME { get; set; }

        [StringLength(100)]
        public string S_BANK_S_SITE { get; set; }

        public virtual ICollection<CBankAccount> cbankaccounts { get; set; }
    }
}
