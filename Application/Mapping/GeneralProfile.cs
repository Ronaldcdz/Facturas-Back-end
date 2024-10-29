using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs.Cliente;
using Application.Entities;
using AutoMapper;

namespace Application.Mapping
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile(){


            #region Cliente 

            CreateMap<Cliente, ClienteViewDTO>()
            .ReverseMap();
            
            CreateMap<Cliente, ClienteSaveEditDTO>()
            .ReverseMap();
            
            #endregion
        }
    }
}