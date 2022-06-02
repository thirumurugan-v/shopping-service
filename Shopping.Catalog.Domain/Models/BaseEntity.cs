using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Catalogue.Domain.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public int CreatedById { get; set; }
        public DateTimeOffset ModifiedDateTime { get; set; }
        public int ModifiedById { get; set; }
    }
}
