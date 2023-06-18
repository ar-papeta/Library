using DAL.Entities.AuxiliaryEntities;
using DAL.Entities.PersonsEntities;
using DAL.Entities.PublicationEnteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.ViewModels;

public class RegistrationRequest
{
    public string Role { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;
}
