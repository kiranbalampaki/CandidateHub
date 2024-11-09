using AutoMapper;
using CandidateHub.DTOs;
using CandidateHub.Models;
using CandidateHub.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace CandidateHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CandidateController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateCandidate(CandidateDto candidateDto)
        {
            var existingCandidate = await _unitOfWork.CandidateRepository.GetCandidateByEmailAsync(candidateDto.Email);

            var candidate = _mapper.Map<Candidate>(candidateDto);

            if (existingCandidate is null)
            {
                await _unitOfWork.CandidateRepository.AddCandidateAsync(candidate);
            }
            else
            {
                _mapper.Map(candidateDto, existingCandidate);
            }

            await _unitOfWork.CompleteAsync();
            return Ok(candidate);
        }
    }
}