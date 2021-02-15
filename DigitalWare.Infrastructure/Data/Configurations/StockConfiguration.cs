using DigitalWare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalWare.Infrastructure.Data.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(stock => stock.ProductId);
            builder.HasIndex(stock => stock.Name).IsUnique();
        }
    }
}