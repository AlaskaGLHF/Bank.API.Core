using Bank.Core.Models;
using Bank.DataBase.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataBase.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<CardEntity>

    {
        public void Configure(EntityTypeBuilder<CardEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .HasMaxLength(Card.MAX_NAME_LENGTH)
                .IsRequired();

            builder.Property(b => b.Email)
                .IsRequired();

            builder.Property(b => b.Hash_password)
                .IsRequired();

            builder.Property(b => b.Created_at)
                .IsRequired();

        }
    }
}
