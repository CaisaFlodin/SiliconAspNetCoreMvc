using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Models.Courses;
using Infrastructure.Models.Home;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribersController(DataContext context, SubscriberRepository subscriberRepository) : ControllerBase
{
    private readonly DataContext _context = context;
    private readonly SubscriberRepository _subscriberRepository = subscriberRepository;


    //[HttpPost]
    //public async Task<IActionResult> Create(SubscribeModel model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var subscriberEntity = new SubscriberEntity
    //        {

    //            Email = model.Email,
    //            CheckboxDaily = model.CheckboxDaily,
    //            CheckboxEvent = model.CheckboxEvent,
    //            CheckboxAdvertising = model.CheckboxAdvertising,
    //            CheckboxStartups = model.CheckboxStartups,
    //            CheckboxWeek = model.CheckboxWeek,
    //            CheckboxPodcasts = model.CheckboxPodcasts,
    //        };
    //        _context.Subscribers.Add(subscriberEntity);
    //        await _context.SaveChangesAsync();
    //        return Created("", subscriberEntity);
    //    }

    //    return BadRequest();
    //}

    [HttpPost]
    public async Task<IActionResult> Create(SubscribeModel model)
    {
        if (ModelState.IsValid)
        {
            if (!await _context.Subscribers.AnyAsync(x => x.Email == model.Email))
            {
                try
                {
                    var subscriberEntity = new SubscriberEntity
                    {

                        Email = model.Email,
                        CheckboxDaily = model.CheckboxDaily,
                        CheckboxEvent = model.CheckboxEvent,
                        CheckboxAdvertising = model.CheckboxAdvertising,
                        CheckboxStartups = model.CheckboxStartups,
                        CheckboxWeek = model.CheckboxWeek,
                        CheckboxPodcasts = model.CheckboxPodcasts,
                    };
                    _context.Subscribers.Add(subscriberEntity);
                    await _context.SaveChangesAsync();
                    return Created("", null);
                }
                catch
                {
                    return Problem("Unable to create subscription.");
                }
                
            }
            else
                return Conflict("Your are already subscribed.");
        }

        return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _subscriberRepository.DeleteOneAsync(x => x.Id == id);

        if (result.StatusCode == Infrastructure.Models.StatusCode.OK)
            return Ok();

        else if (result.StatusCode == Infrastructure.Models.StatusCode.NOT_FOUND)
            return NotFound();

        return BadRequest();
    }
}
