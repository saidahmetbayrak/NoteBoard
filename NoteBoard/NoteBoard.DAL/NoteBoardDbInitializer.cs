using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using NoteBoard.Model;

namespace NoteBoard.DAL
{
    class NoteBoardDbInitializer:CreateDatabaseIfNotExists<NoteBoardDbContext>
    {
        protected override void Seed(NoteBoardDbContext context)
        {
            User user = new User();
            user.FirstName = "Ahmet";
            user.LastName = "Bayrak";
            user.UserName = "admin";
            user.UserRole = UserRole.Admin;
            user.IsActive = true;
            user.CreatedDate = DateTime.Now;
            user.Passwords.Add(new Password()
            {
                PasswordText = "1234",
                IsActive=true,
                CreatedDate=DateTime.Now
            });
            context.Users.Add(user);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
