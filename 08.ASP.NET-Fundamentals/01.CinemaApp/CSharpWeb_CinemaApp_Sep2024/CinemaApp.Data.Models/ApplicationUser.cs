﻿using Microsoft.AspNetCore.Identity;

namespace CinemaApp.Data.Models
{
	public class ApplicationUser : IdentityUser<Guid>
	{
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        // TODO: Add more properties to our user
    }
}
