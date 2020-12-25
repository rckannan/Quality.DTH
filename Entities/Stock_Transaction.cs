using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Quality.DTH
{
    public class Stock_Transaction : Entity, IAggregateRoot
    { 
        private DateTime created_time;
        private DateTime updated_time;
        private Int64 trans_del_id;
        private DateTime trans_date;
        private Int64 trans_source_dealer_id;
        private Int64 trans_dest_dealer_id;
        private Int16 trans_type;
        private Int16 trans_item_type;
        private Int64 trans_item_stock_id;
        private Int16 trans_qty;
        private Int64 trans_item_ser_id;
        private string trans_notes;

        //private   Dealer _dealer_src; 
        public virtual Dealer trans_source_dealer { get; set; }

        //private   Dealer _dealer_dest;
        public virtual Dealer trans_dest_dealer { get; set; }

        protected Stock_Transaction()
        {
            //_isDraft = false;
            
        }

        public Stock_Transaction(Int64 IDbase, DateTime created_time = default, DateTime updated_time = default, long trans_del_id = 0, DateTime trans_date = default, long trans_source_dealer_id = 0, long trans_dest_dealer_id = 0, short trans_type = 0, short trans_item_type = 0, long trans_item_stock_id = 0, short trans_qty = 0, long trans_item_ser_id = 0, string trans_notes = null) : this()
        {
            this.created_time = created_time;
            this.updated_time = updated_time;
            this.trans_del_id = trans_del_id;
            this.trans_date = trans_date;
            this.trans_source_dealer_id = trans_source_dealer_id;
            this.trans_dest_dealer_id = trans_dest_dealer_id;
            this.trans_type = trans_type;
            this.trans_item_type = trans_item_type;
            this.trans_item_stock_id = trans_item_stock_id;
            this.trans_qty = trans_qty;
            this.trans_item_ser_id = trans_item_ser_id;
            this.trans_notes = trans_notes;

            //trans_source_dealer = new Dealer();
            //trans_dest_dealer = new Dealer();
        }
    }

    class Stock_TransactionEntityTypeConfiguration
        : IEntityTypeConfiguration<Stock_Transaction>
    {
        public void Configure(EntityTypeBuilder<Stock_Transaction> tableConfiguration)
        {
            tableConfiguration.ToTable("tbl_stock_trans", COREAPIContext.DEFAULT_SCHEMA);

            tableConfiguration.HasKey(b => b.Idbase);
             
            tableConfiguration
               .Property<Int64>("Idbase")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Idbase")
               .ValueGeneratedOnAdd()
               .IsRequired(true);
             
            tableConfiguration.Property<DateTime>("created_time").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("created_time").ValueGeneratedOnAdd().IsRequired();
            tableConfiguration.Property<DateTime>("updated_time").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("updated_time").ValueGeneratedOnAddOrUpdate().IsRequired();
            tableConfiguration.Property<Int64>("trans_del_id").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_del_id").IsRequired();
            tableConfiguration.Property<DateTime>("trans_date").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_date").IsRequired();

            tableConfiguration.Property<Int64>("trans_source_dealer_id").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_source_dealer_id").IsRequired();
            tableConfiguration.HasOne<Dealer>(x => x.trans_source_dealer).WithOne().HasForeignKey<Stock_Transaction>("trans_source_dealer_id");

            var navigation = tableConfiguration.Metadata.FindNavigation(nameof(Stock_Transaction.trans_source_dealer));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Property);

            tableConfiguration.HasOne<Dealer>(x => x.trans_dest_dealer).WithOne().HasForeignKey<Stock_Transaction>("trans_dest_dealer_id");
            var navigation2 = tableConfiguration.Metadata.FindNavigation(nameof(Stock_Transaction.trans_dest_dealer));
            navigation2.SetPropertyAccessMode(PropertyAccessMode.Property); 
          
            tableConfiguration.Property<Int64>("trans_dest_dealer_id").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_dest_dealer_id").IsRequired();

            

            tableConfiguration.Property<Int16>("trans_type").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_type").IsRequired();
            tableConfiguration.Property<Int16>("trans_item_type").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_item_type").IsRequired();

            tableConfiguration.Property<Int64>("trans_item_stock_id").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_item_stock_id").IsRequired();
            tableConfiguration.Property<Int16>("trans_qty").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_qty").IsRequired();

            tableConfiguration.Property<Int64>("trans_item_ser_id").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_item_ser_id").IsRequired();

            tableConfiguration.Property<string>("trans_notes").UsePropertyAccessMode(PropertyAccessMode.Field).HasColumnName("trans_notes").IsRequired();
        }
    }
}