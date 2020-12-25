using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Quality.DTH
{
    public class Master_Stock : Entity, IAggregateRoot
    { 
        private string stock_name;
        private string stock_unit;
        private string stock_detail;
        private Int16 stock_type;
        private decimal stock_cost;

        protected Master_Stock()
        {
            //_isDraft = false;
        }

        public Master_Stock(Int64 IDbase,
            string Stock_name, string Stock_unit, string Stock_detail, short Stock_type = 0, decimal Stock_cost = 0) : this()
        {
            stock_name = Stock_name;
            stock_unit = Stock_unit;
            stock_detail = Stock_detail;
            Idbase = IDbase;
            stock_type = Stock_type;
            stock_cost = Stock_cost;
        }
    }

    class Master_StockEntityTypeConfiguration
        : IEntityTypeConfiguration<Master_Stock>
    {
        public void Configure(EntityTypeBuilder<Master_Stock> dealerConfiguration)
        {
            dealerConfiguration.ToTable("tbl_master_stock", COREAPIContext.DEFAULT_SCHEMA);

            dealerConfiguration.HasKey(b => b.Idbase);

            dealerConfiguration
               .Property<Int64>("Idbase")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Idbase")
               .ValueGeneratedOnAdd()
               .IsRequired(true); 

            dealerConfiguration
                .Property<string>("stock_name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("stock_name").HasMaxLength(100)
                .IsRequired();

            dealerConfiguration
                .Property<string>("stock_detail")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("stock_detail").HasMaxLength(250)
                .IsRequired();

            dealerConfiguration
                .Property<string>("stock_unit")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("stock_unit").HasMaxLength(30)
                .IsRequired();

            dealerConfiguration
               .Property<decimal>("stock_cost")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("stock_cost") 
               .IsRequired();

            dealerConfiguration
             .Property<Int16>("stock_type")
             .UsePropertyAccessMode(PropertyAccessMode.Field)
             .HasColumnName("stock_type")
             .IsRequired(); 
        }
    }
}