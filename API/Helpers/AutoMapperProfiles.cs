using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()             //Create, from
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => //#96
                    src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())); //#97
            CreateMap<Photo, PhotoDto>();
             CreateMap<MemberUpdateDto, AppUser>(); //#118
             CreateMap<RegisterDto, AppUser>(); //#148
        }
    }
}
