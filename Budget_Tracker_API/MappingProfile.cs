using AutoMapper;

namespace Budget_Tracker_API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Budget_Tracker_Persistence.Models.Transaction, Budget_Tracker_Services.Models.Transaction_Model>().ReverseMap();
            CreateMap<Budget_Tracker_Persistence.Models.Account, Budget_Tracker_Services.Models.Account_Model>().ReverseMap();
        }
    }
}
