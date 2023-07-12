using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BotanicShop.Models;
using Microsoft.AspNetCore.Identity;

namespace BotanicShop.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{
    

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Display(Name = "FName")]
    public string? Fname { get; set; }

    [Required]
    [Display(Name = "LName")]
    public string? Lname { get; set; }

    [Display(Name = "Address")]
    public string? Address { get; set; } = string.Empty;


    [Display(Name = "ZipCode")]
    public string? ZipCode { get; set; } = string.Empty;

    [Display(Name = "City")]
    public string? City { get; set; } = string.Empty;

    [Display(Name = "Country")]
    public string? Country { get; set; } = string.Empty;
    
    [Display(Name = "PhoneNumber")]
    public string? PhoneNR { get; set; } = string.Empty;

    public Cart UserCart { get; set; } 

    public Roletype role { get; set; }
    
    public User(string email,string password,string confpwd,string firstName, string lastName, string Address, string zipcode,string city, string country, string phonenr)
    {
        this.Email = email;
        this.Password = password;
        this.ConfirmPassword = confpwd;
        this.Fname = firstName;
        this.Lname = lastName;
        this.Address = Address ?? "";
        this.ZipCode = zipcode ?? "";
        this.City = city ?? "";
        this.Country = country ?? "";
        this.PhoneNumber = phonenr ?? "";
        this.UserCart = new Cart();
        this.role = Roletype.User;
    }
    
    override public string ToString()
    {
#pragma warning disable CS8603 // Possible null reference return.
        return Fname;
#pragma warning restore CS8603 // Possible null reference return.
    }
    
}
    public enum Roletype
{
    Admin,
    User,
    Guest
}

