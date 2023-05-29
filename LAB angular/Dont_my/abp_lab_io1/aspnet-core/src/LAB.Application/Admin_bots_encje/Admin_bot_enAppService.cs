using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Admin_bots_encje.Dto;

namespace LAB.Admin_bots_encje
{
        public class Admin_bot_enAppService : AsyncCrudAppService<Admin_bot_en, Admin_bot_enDto, long, PagedAdmin_bot_enResultRequestDto, Admin_bot_enDto, Admin_bot_enDto>, IAdmin_bot_enAppService
    {
        public Admin_bot_enAppService(IRepository<Admin_bot_en, long> repository) : base(repository)
        {

        }
    }
}

