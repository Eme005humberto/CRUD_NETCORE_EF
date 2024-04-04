using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public partial class Person
{
    public int IdPeople { get; set; }
    [Required]
    public string? NamePeople { get; set; }
    [Required]
    public int? Age { get; set; }
}
