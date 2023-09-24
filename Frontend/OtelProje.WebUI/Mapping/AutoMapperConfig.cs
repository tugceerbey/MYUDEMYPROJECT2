using AutoMapper;
using OtelProje.EntityLayer1.Concrete;
using OtelProje.WebUI.Dtos.AboutDto;
using OtelProje.WebUI.Dtos.AppUserDto;
using OtelProje.WebUI.Dtos.BookingDto;
using OtelProje.WebUI.Dtos.GuestDto;
using OtelProje.WebUI.Dtos.LoginDto;
using OtelProje.WebUI.Dtos.RegisterDto;
using OtelProje.WebUI.Dtos.ServiceDto;
using OtelProje.WebUI.Dtos.StaffDto;
using OtelProje.WebUI.Dtos.SubscribeDto;
using OtelProje.WebUI.Dtos.TestimonialDto;

namespace OtelProje.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
         {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<ResultAppUserDto,AppUser>().ReverseMap();
        }
    }
}
