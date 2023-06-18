using BLL.Helpers.PasswordHasher;
using BLL.Services.VisitorService;
using DAL.Db.Uof;
using DAL.Entities.PersonsEntities;
using LibraryApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VisitorController : ControllerBase
{
    private readonly IVisitorService _visitorService;
    private readonly IPasswordHash _passwordHasher;

    public VisitorController(IVisitorService visitorService, IPasswordHash passwordHasher)
    {
        _visitorService = visitorService;
        _passwordHasher = passwordHasher;
    }

    [HttpPost]
    [Route("registration")]
    public IActionResult RegistreUser([FromBody] RegistrationRequest userRegData)
    {
        var newVisitor = new Visitor
        {
            Email = userRegData.Email,
            Name = userRegData.Name,
            Surname = userRegData.Surname,
            Id = Guid.NewGuid(),
        };
        if(!Enum.TryParse<VisitorRole>(userRegData.Role, out VisitorRole role))
        {
            throw new Exception("Incorrect user role.");
        }
        newVisitor.Role = role;
        newVisitor.Password = _passwordHasher.EncryptPassword(userRegData.Password, newVisitor.Id.ToByteArray());

        _visitorService.AddVisitor(newVisitor);
        return Ok();
    }

    [HttpGet]
    [Route("all")]
    public IActionResult GetAllUsers()
    {
        return Ok(_visitorService.GetVisitors());
    }
}
