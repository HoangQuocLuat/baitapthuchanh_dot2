using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;
using SQLitePCL;

// namespace MVC_Project.Controllers
// {

//     public class PersonController : Controller
//     {
//         private readonly ApplicationDbContext _context;
//         public PersonController(ApplicationDbContext context)
//         {
//             _context = context;
//         }

//         public async Task<IActionResult> Index() 
//         {
//             var model = await _context.Person.ToListAsync();
//             return View(model)
//         }

//         public IActionResult Create()
//         {
            
//         }

//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Create([Bind("PersonId, FullName")] Person person) 
//         {

//         }
//         public async Task<IActionResult> Edit(string id) 
//         {

//         }
        
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Edit(string id, [Bind("PersonId, FullName")] Person person)
//         {

//         }
//         public async Task<IActionResult> Delete(string id) 
//         {

//         }
//         [HttpPost, ActionName("Delete")]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> DeleteConfirmed(sting id) 
//         {

//         }
//         private bool PersonExists(string id)
//         {

//         }
//      }
// }
