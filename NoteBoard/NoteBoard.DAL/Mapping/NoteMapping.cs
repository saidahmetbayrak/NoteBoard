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
    class NoteMapping:EntityTypeConfiguration<Note>
    {
        public NoteMapping()
        {
            Property(n => n.Title).IsRequired().HasMaxLength(25);
            Property(n => n.Content).IsRequired().HasMaxLength(250);

            HasRequired(n => n.User).WithMany(n => n.Notes).HasForeignKey(n => n.UserID);

            Map(b => b.MapInheritedProperties());

            HasKey(n => n.NoteID);
            Property(n => n.NoteID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
