using AutoMapper;
using ManipuladorString.Domain;
using ManipuladorString.Domain.DTO;

namespace ManipuladorString.Profiles
{
    public class ManipuladorStringRespostaProfile : Profile
    {
        public ManipuladorStringRespostaProfile()
        {
            CreateMap<ManipuladorStringResposta, ReadManipuladorStringRespostaDto>();
        }
    }
}