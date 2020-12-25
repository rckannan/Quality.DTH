using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Quality.DTH
{
    public class Dealer : Entity, IAggregateRoot
    { 
        private DateTime created_time;
        private DateTime updated_time; 
        private Int64 dealer_acc_id; 
        private string dealer_name; 
        private string dealer_contact;
        private string dealer_address; 
        private Int16 dealer_beat;
        private Int16 dealer_category;

        public Dealer()
        {
            //_isDraft = false;
        }

        public Dealer(Int64 IDbase, DateTime Created_time, DateTime Updated_time, Int64 Dealer_acc_id, 
            string Dealer_name, string Dealer_contact, string Dealer_address, Int16 Dealer_beat, Int16 Dealer_category) : this()
        {
            created_time = Created_time;
            updated_time = Updated_time;
            dealer_acc_id = Dealer_acc_id;
            dealer_name = Dealer_name  ;
            dealer_contact = Dealer_contact;
            dealer_address = Dealer_address;
            dealer_beat = Dealer_beat;
            dealer_category = Dealer_category;
            Idbase = IDbase; 
        } 
    }

    class DealerEntityTypeConfiguration
        : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> dealerConfiguration)
        {
            dealerConfiguration.ToTable("tbl_dealers", COREAPIContext.DEFAULT_SCHEMA);

            dealerConfiguration.HasKey(b => b.Idbase);
 
            dealerConfiguration
               .Property<Int64>("Idbase")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Idbase")  
               .ValueGeneratedOnAdd()
               .IsRequired(true);

            dealerConfiguration
                .Property<DateTime>("created_time")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("created_time")
                .IsRequired(true);

            dealerConfiguration
                .Property<DateTime>("updated_time")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("updated_time")
                .IsRequired(true);

            dealerConfiguration
               .Property<Int64>("dealer_acc_id")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("dealer_acc_id") 
               .IsRequired(true);

            dealerConfiguration
                .Property<string>("dealer_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("dealer_name")
                .IsRequired();

            dealerConfiguration
                .Property<string>("dealer_contact")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("dealer_contact")
                .IsRequired();

            dealerConfiguration
                .Property<string>("dealer_address")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("dealer_address")
                .IsRequired();

            dealerConfiguration
               .Property<Int16>("dealer_beat")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("dealer_beat")
               .IsRequired(true);

            dealerConfiguration
               .Property<Int16>("dealer_category")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("dealer_category")
               .IsRequired(true); 

            //dealerConfiguration.HasMany(b => b.PaymentMethods)
            //   .WithOne()
            //   .HasForeignKey("BuyerId")
            //   .OnDelete(DeleteBehavior.Cascade);

            //var navigation = dealerConfiguration.Metadata.FindNavigation(nameof(Buyer.PaymentMethods));

            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}