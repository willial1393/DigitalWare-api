using DigitalWare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalWare.Infrastructure.Data.Configurations
{
    public class CustomerInvoiceConfiguration : IEntityTypeConfiguration<CustomerInvoice>
    {
        public void Configure(EntityTypeBuilder<CustomerInvoice> builder)
        {
            builder.HasKey(invoice => invoice.Id);
            builder.Property(invoice => invoice.Total).HasColumnType("money");
        }
    }
}