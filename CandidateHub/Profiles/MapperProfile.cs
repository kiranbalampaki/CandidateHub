using AutoMapper;
using CandidateHub.DTOs;
using CandidateHub.Models;

namespace CandidateHub.Profiles
{
    public class MapperProfile: Profile
    {

        public MapperProfile()
        {
            CreateMap<Candidate, CandidateDto>().ReverseMap();
        }
    }
}
