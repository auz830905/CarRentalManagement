using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Colours
        [HttpGet]
        public async Task<IActionResult> GetColours()
        {
            var colours = await _unitOfWork.Colour.GetAll();
            return Ok(colours);
        }

        // GET: /Colours/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColour(int id)
        {
            var colour = await _unitOfWork.Colour.Get(c => c.Id == id);

            if (colour == null)
            {
                return NotFound();
            }

            return Ok(colour);
        }

        // PUT: /Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {
            if (id != colour.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colour.Update(colour);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await ColourExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostColour(Colour colour)
        {
            await _unitOfWork.Colour.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: /Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            if (! await ColourExists(id))
            {
                return NotFound();
            }

            await _unitOfWork.Colour.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColourExists(int id)
        {
            return await _unitOfWork.Colour.Get(e => e.Id == id) != null;
        }
    }
}
