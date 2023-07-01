using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BotanicShop.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{
    [Required]
    public string? Fname { get; set; }
    [Required]
    public string? Lname { get; set; }
    public string? Addres { get; set; } = string.Empty;
    public string? ZipCode { get; set; } = string.Empty;
    public string? City { get; set; } = string.Empty;
    public string? Country { get; set; } = string.Empty;
    

    public User()
    {

    }
    public User(string firstName, string lastName, string Address, string zipcode,string city, string country )
    {
        Fname=firstName;
        Lname=lastName;
        ZipCode=zipcode ?? "";
        City=city ?? "";
        Country=country ?? "";
    }
    public User(string firstName, string lastName)
    {
        Fname = firstName;
        Lname=lastName;
        ZipCode = string.Empty;
        City=string.Empty;
        Country=string.Empty;
            


    }

    public User(string userName) : base(userName)
    {
    }
}

