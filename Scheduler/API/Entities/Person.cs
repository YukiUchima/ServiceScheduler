﻿namespace API.Entities;

public class Person
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName {  get; set; }
    public required string PhoneNumber { get; set; }
    public string? Email { get; set; }

}
