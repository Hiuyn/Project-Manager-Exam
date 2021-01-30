using PMSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Domain.AggregatesModel.MUserAggregates
{
    public class MUser : BaseEntity, IAggregateRoot
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
