using AutoMapper;
using FreelancerProjectManagementAPI.DTOs;
using FreelancerProjectManagementAPI.Models;

namespace FreelancerProjectManagementAPI.AutoMapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FreelancerCreateDTO, Freelancer>();
            CreateMap<FreelanceUpdateDTO, Freelancer>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ProjectCreateDTO, Project>();
            CreateMap<ProjectUpdateDTO, Project>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ProjectProgressCreateDTO, ProjectProgress>();
            CreateMap<ProjectProgressUpdateDTO, ProjectProgress>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
