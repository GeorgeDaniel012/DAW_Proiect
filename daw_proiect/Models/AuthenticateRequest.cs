﻿namespace daw_proiect.Models;

using System.ComponentModel.DataAnnotations;

public class AuthenticateRequest
{
    [Required]
    public string? Username { get; set; }

    [Required]
    public string? Password { get; set; }
}