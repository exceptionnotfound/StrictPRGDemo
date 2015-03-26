using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StrictPRGDemo.ViewModels.Home
{
public class AddUserVM
{
    [DisplayName("First Name:")]
    [Required(ErrorMessage = "Please enter a first name.")]
    public string FirstName { get; set; }

    [DisplayName("Last Name:")]
    [Required(ErrorMessage = "Please enter a last name.")]
    public string LastName { get; set; }

    [DisplayName("Date of Birth:")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "Please select a date of birth.")]
    public DateTime DateOfBirth { get; set; }
}
}