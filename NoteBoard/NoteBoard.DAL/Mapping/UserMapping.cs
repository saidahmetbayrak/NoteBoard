using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using NoteBoard.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoteBoard.DAL.Mapping
{
    class UserMapping:EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(a => a.FirstName).IsRequired().HasMaxLength(20);
            Property(a => a.LastName).IsRequired().HasMaxLength(20);
            Property(a => a.UserName).IsRequired().HasMaxLength(18);

            HasKey(u => u.UserID);//PrimaryKey oldugunu belirttik 
            Property(u => u.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);//UserID otomatik atamasını sağlıyor

            Map(a => a.MapInheritedProperties());//BaseManager class'indan instances aldık
            HasIndex(a => a.UserName).IsUnique();//Kullanıcı adı benzersiz oldugunu belirttik
        }
    }
}
