namespace PracticeA;

using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;

public class UserCredentials
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string User { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Pass { get; set; }

}
