using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Admin_bots_encje.Dto
{
    [AutoMapFrom(typeof(Admin_bot_en))]
    public class Admin_bot_enDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

