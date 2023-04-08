﻿namespace YangiBozor.Service.DTOs;

public class UserForCreationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
}
