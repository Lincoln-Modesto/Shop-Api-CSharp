using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers {
    
    public class ProductController : ControllerBase {


        public async Task<ActionResult<List<Product>>> Get([FromServices]DataContext context){
            var products = await context.Products.Include(x => x.Category).AsNoTracking().ToListAsync();
            return products; 
        }
    }
}