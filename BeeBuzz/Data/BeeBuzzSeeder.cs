using BeeBuzz.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace BeeBuzz.Data
{
    public class BeeBuzzSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hosting;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public BeeBuzzSeeder(ApplicationDbContext context,
            IWebHostEnvironment hosting,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _hosting = hosting;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureCreated();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));
            }

            if (!_db.Organizations.Any())
            {
                var organization = new Organization()
                {
                    OrganizationName = "0000 - 0000 - 0000 - 0000"
                };

                _db.Organizations.Add(organization);

                _db.SaveChanges();
            }

            if (!_db.Users.Any())
            {

                var admin = new ApplicationUser()
                {
                    Name = "admin",
                    OrganizationId = 1
                };

                var defaultUser = new ApplicationUser()
                {
                    Name = "default",
                    OrganizationId = 1
                };


                _db.Users.Add(admin);
                _db.Users.Add(defaultUser);

                _db.SaveChanges();
            }
        }
    }
}
