using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.Admin_bots_encje
{
    public class Admin_bot_en : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
