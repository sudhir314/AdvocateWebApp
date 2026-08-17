// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AdvocateWebApp.DataAccess.Data
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [StringLength(100)]
        public string? FullName { get; set; }

        [PersonalData]
        [StringLength(50)]
        public string? CaseType { get; set; }

        [PersonalData]
        public string? InitialQuery { get; set; }
    }
}