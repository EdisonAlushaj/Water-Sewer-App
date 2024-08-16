using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Water_Sewer_BackEnd.Data;
using Water_Sewer_BackEnd.Entities;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Cors;
using System.Linq;
using System.Threading.Tasks;

namespace Water_Sewer_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private DataContext _context;

        public ContactUsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactRequest>>> GetAllContactRequests()
        {
            var contactRequests = await _context.ContactRequests.ToListAsync();
            return Ok(contactRequests);
        }

        [HttpPost]
        public async Task<ActionResult<ContactRequest>> Contact([FromBody] ContactRequest contactRequest)
        {
            Console.WriteLine("Received contact request for Name: " + contactRequest.Name);

            // Create a response object with name, email, and message
            var contactResponse = new ContactRequest
            {
                Name = contactRequest.Name,
                Email = contactRequest.Email,
                Message = contactRequest.Message
            };

            // Add the contact request to the context and save changes
            _context.ContactRequests.Add(contactResponse);
            await _context.SaveChangesAsync();

            return Ok(contactResponse);
        }
    }
}
