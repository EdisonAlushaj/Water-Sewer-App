using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Water_Sewer_BackEnd.Data;
using Water_Sewer_BackEnd.Entities;

namespace Water_Sewer_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProjectsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Projects

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var players = await _context.Projects.ToListAsync();
            return Ok(players);
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return project;
        }

        // POST: api/Projects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Project>> PostProject(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProject", new { id = project.Id }, project);
        }

        //Update Project
        [HttpPatch]
        [Route("UpdateProject/{id}")]
        public async Task<Project> UpdateProject(Project objProject)
        {
            _context.Entry(objProject).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return objProject;
        }

        //Delete Project
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Project>>> DeleteProject(int id)
        {
            var dbProject = await _context.Projects.FindAsync(id);
            if (dbProject == null)
                return NotFound("Food not found");

            _context.Projects.Remove(dbProject);

            await _context.SaveChangesAsync();

            return Ok(await _context.Projects.ToListAsync()); ;
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.Id == id);
        }
    }
}
