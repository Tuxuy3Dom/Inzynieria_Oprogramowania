using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB.Admin_bots_encje;

namespace LAB.Bots_encje
{
    public class Bot_en : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }

        //Foreign key for Standard
        public int Admin_bot_en_id { get; set; }
        public Admin_bot_en Admin_bot_en { get; set; }
    }
}
