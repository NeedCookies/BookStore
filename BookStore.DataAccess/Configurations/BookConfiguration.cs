using BookStore.Core.Models;
using BookStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
    {
        //конфигурация указвыает какие свойста наша сущность должна иметь для БД (то же самое что выставление ограничений для отдельных свойств)
        // Можно также делать с помощью атрибутов
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Title)
                .HasMaxLength(Book.TITLE_MAX_LENGTH)
                .IsRequired();

            builder.Property(t => t.Description)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();
        }
    }
}
