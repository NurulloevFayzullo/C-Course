﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.LoginRequestDtos;

public class LoginRequestDto
{
    [Required(ErrorMessage = "UserName is required")]
    public string UserName { get; set; } = null!;
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = null!;
}
