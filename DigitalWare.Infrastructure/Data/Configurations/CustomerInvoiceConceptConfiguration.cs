using DigitalWare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalWare.Infrastructure.Data.Configurations
{
    public class CustomerInvoiceConceptConfiguration : IEntityTypeConfiguration<CustomerInvoiceConcept>
    {
        public void Configure(EntityTypeBuilder<CustomerInvoiceConcept> builder)
        {
            builder.HasKey(concept => concept.Id);
            builder.Property(concept => concept.UnitPrice).HasColumnType("money");
            builder.Property(concept => concept.Total).HasColumnType("money");
        }
    }
}