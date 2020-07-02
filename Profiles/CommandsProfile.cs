using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
        
    //  Mapper.CreateMap<StockCheckViewModel, StockCheck>()
    // .ForMember(m => m.Id, opt => opt.Ignore())
    // .ForMember(vm => vm.StockCheckItems, opt => opt.Ignore())
    // .ForMember(vm => vm.Remarks, opt => opt.MapFrom(m => string.IsNullOrEmpty(m.Remarks) ? "" : m.Remarks))
    // .ForMember(vm => vm.RecordStatus, opt => opt.UseValue(ModelConstant.RecordStatusActive))
    // .AfterMap((model, entity) => UpdateStockCheckItemEntity(entity.StockCheckItems, model.StockCheckItems));


//TODO 
// - improve the profile config cases
// - add unit test using IMapper


    }
    
}