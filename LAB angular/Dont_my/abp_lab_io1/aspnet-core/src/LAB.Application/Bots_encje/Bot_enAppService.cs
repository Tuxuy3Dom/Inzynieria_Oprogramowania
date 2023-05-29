using Abp.Application.Services;
using Abp.Domain.Repositories;
using LAB.Bots_encje.Dto;

namespace LAB.Bots_encje
{
        public class Bot_enAppService : AsyncCrudAppService<Bot_en, Bot_enDto, long, PagedBot_enResultRequestDto, Bot_enDto, Bot_enDto>, IBot_enAppService
    {
        public Bot_enAppService(IRepository<Bot_en, long> repository) : base(repository)
        {

        }
    }
}

