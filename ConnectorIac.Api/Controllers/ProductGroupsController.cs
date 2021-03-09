using ConnectorIac.Bl.Models;
using ConnectorIac.Dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectorIac.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGroupsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductGroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductGroups 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductGroup>>> GetProductGroups()
        {
            return await _context.ProductGroups.ToListAsync();
        }

        // GET: api/ProductGroups/1 
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGroup>> GetProductGroup(int id)
        {
            var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup == null)
            {
                return NotFound();
            }
            return productGroup;
        }

        // PUT: api/ProductGroups/1 
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductGroup(int id, ProductGroup productGroup)
        {
            if (id != productGroup.Id)
            {
                return BadRequest();
            }
            _context.Entry(productGroup).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductGroupExists(id))
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

        // POST: api/ProductGroups 
        [HttpPost]
        public async Task<ActionResult<ProductGroup>> PostProductGroup(ProductGroup productGroup)
        {
            _context.ProductGroups.Add(productGroup);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetProductGroup", new { id = productGroup.Id }, productGroup);
        }

        // DELETE: api/ProductGroups/2 
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductGroup>> DeleteProductGroup(int id)
        {
            var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup == null)
            {
                return NotFound();
            }
            _context.ProductGroups.Remove(productGroup);
            await _context.SaveChangesAsync();
            return productGroup;
        }

        private bool ProductGroupExists(int id)
        {
            return _context.ProductGroups.Any(e => e.Id == id);
        }
    }
}
