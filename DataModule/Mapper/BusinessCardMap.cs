using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using CoreModule.Models;

namespace DataModule.Mapper
{
    public class BusinessCardMap : EntityTypeConfiguration<BusinessCard>
    {
        public BusinessCardMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired();
            ToTable("Card");
        }
    }
}
