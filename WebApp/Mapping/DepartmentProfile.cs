using AutoMapper;
using DAL.Entities;
using Microsoft.AspNetCore.Routing.Constraints;
using WebApp.Models;

namespace WebApp.Mapping
{
    public class DepartmentProfile:Profile
    {
        public DepartmentProfile() 
        {
            CreateMap<Department, DepartmentViewModel>()
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ReverseMap();
        }
    }
}
