using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Models.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController(DataContext context) : ControllerBase
{
    private readonly DataContext _context = context;


    #region CREATE

    [HttpPost]
    public async Task<IActionResult> Create(CourseModel model)
    {
        if (ModelState.IsValid)
        {
            var courseEntity = new CourseEntity
            {
                Title = model.Title,
                ImageName = model.ImageName,
                Author = model.Author,
                IsBestseller = model.IsBestseller,
                Duration = model.Duration,
                Price = model.Price,
                DiscountPrice = model.DiscountPrice,
                LikesInPercent = model.LikesInPercent,
                LikesInNumbers = model.LikesInNumbers
            };
            _context.Courses.Add(courseEntity);
            await _context.SaveChangesAsync();
            return Created("", courseEntity);
        }

        return BadRequest();
    }

    #endregion

    #region READ

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _context.Courses.ToListAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(int id)
    { 
        var course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
        if (course != null)
        {
            return Ok(course);
        }

        return NotFound();
    }

#endregion
}
