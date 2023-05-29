using Abp.Application.Services;
using LAB.Admin_bots_encje.Dto;

namespace LAB.Admin_bots_encje
{
    public interface IAdmin_bot_enAppService : IAsyncCrudAppService<Admin_bot_enDto, long, PagedAdmin_bot_enResultRequestDto, Admin_bot_enDto, Admin_bot_enDto>
    {

    }
}

