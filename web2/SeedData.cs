using Microsoft.AspNetCore.Identity;

namespace web2
{
    public static class SeedData
    {//main function
        public static void Seed(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);

        }
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            //checking if there is any user
            if (userManager.FindByNameAsync("admin").Result== null)
            {
                //creating an obj
                var user = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@localhost"
                };
                var result = userManager.CreateAsync(user, "Password1").Result;
                if(result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();

                }
            }

        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
               var result = roleManager.CreateAsync(role).Result;

            };
            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Employee"
                };
                var result = roleManager.CreateAsync(role).Result;

            };
        }

    }



}



