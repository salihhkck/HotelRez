using AutoMapper;
using HotelRez.Dto.Dtos.RoomDto;
using HotelRez.EntityLayer.Concrete;

namespace HotelRez.WebAPI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>().ReverseMap();

            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
