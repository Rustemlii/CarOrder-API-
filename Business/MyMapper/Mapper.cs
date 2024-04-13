using AutoMapper;
using DataAccess.Entity;
using DTO.EntityDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.MyMapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<MarkaDTO, Marka>();
            CreateMap<Marka,MarkaDTO>();
            CreateMap<ModelDTO, Model>();
            CreateMap<Model, ModelDTO>();
        }
    }
}
