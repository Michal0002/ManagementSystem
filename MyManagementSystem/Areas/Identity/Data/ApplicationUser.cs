using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyManagementSystem.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName ="nvarchar(16)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(16)")]
    public string LastName { get; set; }
}

