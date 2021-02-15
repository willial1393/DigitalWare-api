using DigitalWare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalWare.Infrastructure.Data.Configurations
{
    public class StockHistoryConfiguration : IEntityTypeConfiguration<StockHistory>
    {
        public void Configure(EntityTypeBuilder<StockHistory> builder)
        {
            builder.HasKey(history => history.Id);
        }
    }
}