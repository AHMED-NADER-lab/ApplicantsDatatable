using ApplicantsDatatable.Data.Entities;
using ApplicantsDatatable.Data.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicantsDatatable.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ApplicationVM, Application>();

            CreateMap<Application,ApplicationVM >();







        }
        }
    }

