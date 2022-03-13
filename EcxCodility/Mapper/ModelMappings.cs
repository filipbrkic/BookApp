using AutoMapper;
using EcxCodility.Common.Models;
using EcxCodility.DAL.Models;
using EcxCodility.Models;

namespace EcxCodility.Mapper
{
    public class ModelMappings : Profile
    {
        public ModelMappings()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<BookDTO, BookViewModel>().ReverseMap();
            CreateMap<BookDTO, BookEditViewModel>().ReverseMap();
        }
    }
}
