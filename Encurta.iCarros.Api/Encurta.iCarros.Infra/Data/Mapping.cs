using System;
using System.Threading.Tasks;
using Encurta.iCarros.Domain.Entities;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Encurta.iCarros.Infra.Data
{
    //public class Mapping : IEntityTypeConfiguration<Usuario>
    //{
    //    public void Configure(EntityTypeBuilder<Usuario> builder)
    //    {
    //        builder.ToTable("User");

    //        builder.HasKey(c => c.Id);

    //        builder.Property(c => c.Cpf)
    //            .IsRequired()
    //            .HasColumnName("Cpf");

    //        builder.Property(c => c.BirthDate)
    //            .IsRequired()
    //            .HasColumnName("BirthDate");

    //        builder.Property(c => c.Name)
    //            .IsRequired()
    //            .HasColumnName("Name");
    //    }
    //}
}
