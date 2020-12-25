using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Quality.DTH
{
    public class master_serialitem : Entity, IAggregateRoot
    { 
        private string item_name;
        private string item_detail; 

        protected master_serialitem()
        {
            //_isDraft = false;
        }

        public master_serialitem(Int64 IDbase,  
            string Item_name, string Item_detail) : this()
        {
            item_name = Item_name;
            item_detail = Item_detail; 
            Idbase = IDbase;
        }
    }

    class master_serialitemEntityTypeConfiguration
        : IEntityTypeConfiguration<master_serialitem>
    {
        public void Configure(EntityTypeBuilder<master_serialitem> dealerConfiguration)
        {
            dealerConfiguration.ToTable("tbl_master_serialitem", COREAPIContext.DEFAULT_SCHEMA);

            dealerConfiguration.HasKey(b => b.Idbase);

            dealerConfiguration
               .Property<Int64>("Idbase")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Idbase")
               .ValueGeneratedOnAdd()
               .IsRequired(true); 

            dealerConfiguration
                .Property<string>("item_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("item_name")
                .IsRequired();

            dealerConfiguration
                .Property<string>("item_detail")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("item_detail")
                .IsRequired(); 

            //dealerConfiguration.HasMany(b => b.PaymentMethods)
            //   .WithOne()
            //   .HasForeignKey("BuyerId")
            //   .OnDelete(DeleteBehavior.Cascade);

            //var navigation = dealerConfiguration.Metadata.FindNavigation(nameof(Buyer.PaymentMethods));

            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}