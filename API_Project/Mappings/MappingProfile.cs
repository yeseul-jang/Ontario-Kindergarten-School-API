using API_Project.Models;
using APIProjectClassLibrary.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Project.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            
            CreateMap<PublicSchool, PublicSchoolDto>();
            CreateMap<PrivateSchool, PrivateSchoolWithoutRateDto>();
            CreateMap<PrivateSchool, PrivateSchoolDto>();
            CreateMap<PrivateSchoolRate, PrivateSchoolRateDto>();
            CreateMap<PrivateSchoolRateForCreationDto, PrivateSchoolRate>();
            CreateMap<PrivateSchoolRateForUpdateDto, PrivateSchoolRate>();
            CreateMap<EnrolmentByGender, EnrolmentByGenderDto>();
            CreateMap<EnrolmentBySchool, EnrolmentBySchoolDto>();

        }
    }
}
