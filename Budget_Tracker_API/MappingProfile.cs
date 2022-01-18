using AutoMapper;

namespace Budget_Tracker_API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //figure the mapping figure having to type out for each memeber
            CreateMap<Budget_Tracker_Persistence.Models.Transaction, Budget_Tracker_Services.Models.Transaction_Model>().ReverseMap().ForMember(d => d.Product, opt => opt.MapFrom(s => s.Product));
            CreateMap<Budget_Tracker_Persistence.Models.Product, Budget_Tracker_Services.Models.Product_Model>().ReverseMap();
            CreateMap<Budget_Tracker_Persistence.Models.Account, Budget_Tracker_Services.Models.Account_Model>().ReverseMap().ForMember(d => d.Product, opt => opt.MapFrom(s => s.Product));
            CreateMap<Budget_Tracker_Persistence.Models.Bank, Budget_Tracker_Services.Models.Bank_Model>().ReverseMap();
        }
    }
}
