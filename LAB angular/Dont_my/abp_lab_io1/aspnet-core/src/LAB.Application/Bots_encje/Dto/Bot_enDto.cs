using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Bots_encje.Dto
{
    [AutoMapFrom(typeof(Bot_en))]
    public class Bot_enDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}

