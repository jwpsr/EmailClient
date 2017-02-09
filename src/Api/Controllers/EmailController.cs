using Data.DbContexts;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        private EmailContext db;

        public EmailController(EmailContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("")]
        [Route("TemplateNames")]
        public IActionResult TemplateNames()
        {
            var templateNames = db.EmailTemplates.Select(x => x.Title).ToList();

            return Ok(templateNames);
        }

        [HttpGet]
        [Route("{id}")]
        [Route("Template/{id}")]
        public IActionResult Template(int id)
        {
            var templates = db.EmailTemplates.Where(x => x.Id == id).SingleOrDefault();

            return Ok(templates);
        }

        [HttpPost]
        [Route("")]
        [Route("Template")]
        public async Task<IActionResult> AddTemplate([FromBody] EmailTemplateDTO dto)
        {
            //TODO: Add automapper
            var newTemplate = new EmailTemplate()
            {
                Title = dto.Title,
                Content = dto.Content,
                CreatedDate = DateTime.UtcNow,
                //TODO: Guid for user creating template
                UpdatedDate = DateTime.UtcNow
            };

            db.EmailTemplates.Add(newTemplate);

            await db.SaveChangesAsync();

            return CreatedAtAction("", newTemplate.Id, newTemplate);
        }
    }
}
