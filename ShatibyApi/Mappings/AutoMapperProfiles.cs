
using AutoMapper;
using ShatibyApi.Models.DTO;

namespace ShatibyApi.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
           

            CreateMap<ImagesUrls, ImagesUrlsSaveDto>().ReverseMap();

        }
    }
}
