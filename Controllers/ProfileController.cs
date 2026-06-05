using Microsoft.AspNetCore.Mvc;
using RegistrationPortal.Api.Data;
using RegistrationPortal.Api.DTOs;
using RegistrationPortal.Api.Models;

namespace RegistrationPortal.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfileController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("submit")]
        public async Task<IActionResult> Submit([FromBody] UserProfileDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var profile = new UserProfile
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Age = dto.Age,
                YearsOfExperience = dto.YearsOfExperience,
                Skills = string.Join(",", dto.Skills),
                SubmittedAt = DateTime.UtcNow
            };

            _context.UserProfiles.Add(profile);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Profile submitted successfully" });
        }
    }
}