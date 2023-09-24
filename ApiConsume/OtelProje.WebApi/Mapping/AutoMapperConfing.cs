using AutoMapper;
using OtelProje.DtoLayer1.Dtos.RoomDto;
using OtelProje.EntityLayer1.Concrete;
using System.Runtime;

namespace OtelProje.WebApi.Mapping
{
    public class AutoMapperConfing:Profile
    {
        public AutoMapperConfing() 
        {
            CreateMap<RoomAddDto,Room>();
            CreateMap<Room,RoomAddDto>();

            CreateMap <UpdateRoomDto, Room>().ReverseMap();
        }  
    }
}
