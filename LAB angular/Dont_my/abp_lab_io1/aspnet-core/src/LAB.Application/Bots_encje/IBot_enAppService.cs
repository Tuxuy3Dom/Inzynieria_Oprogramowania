using Abp.Application.Services;
using LAB.Bots_encje.Dto;

namespace LAB.Bots_encje
{
    public interface IBot_enAppService : IAsyncCrudAppService<Bot_enDto, long, PagedBot_enResultRequestDto, Bot_enDto, Bot_enDto>
    {

    }
}

