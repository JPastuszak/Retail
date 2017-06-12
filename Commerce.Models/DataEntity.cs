using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Models
{
    public class DataEntity
    {
        public int Id { get; set; }

        public Guid GlobalId { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public DataEntity()
        {
            //this.Id = 0;
            this.GlobalId = Guid.NewGuid();
            this.Created = DateTime.Now;
            this.Modified = DateTime.Now;
        }
    }
}
