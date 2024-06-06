﻿using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
        
    [Required, MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
        
    [Required, MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
        
    [Required, EmailAddress, MaxLength(100)]
    public string Email { get; set; } = string.Empty;
}