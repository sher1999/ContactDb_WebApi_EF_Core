using Domain.Entities;
using Infrastruvture.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private  ContactServise _contacService;
    public ContactController(ContactServise contacService)
    {
        _contacService = contacService;
    }

    [HttpGet]
    public List<Contact> Get()
    {
        return _contacService.Get();
    }
    
    [HttpGet("{id}")]
    public Contact Get(int id) => _contacService.Get(id);
    
    [HttpPost]
    public void Post([FromBody] Contact contact) => _contacService.Add(contact);
    
    [HttpPut]
    public void Put([FromBody] Contact contact) => _contacService.Update(contact);
    
    [HttpDelete("{id}")]
    public void Delete(int id) => _contacService.Delete(id);


}