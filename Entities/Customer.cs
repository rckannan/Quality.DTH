using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quality.DTH.Repository;
using System;

namespace Quality.DTH
{
    public class Customer :Entity, IAggregateRoot
    {
        // DDD Patterns comment
        // Using private fields, allowed since EF Core 1.1, is a much better encapsulation
        // aligned with DDD Aggregates and Domain Entities (Instead of properties and property collections)
        private DateTime DateofBirth;

        // Address is a Value Object pattern example persisted as EF Core 2.0 owned entity
        //public Address Address { get; private set; }


        private Int64 UserID;

        private string Name;

        private string FullName; 

        //private readonly List<Address> _addressitems;
        //public IReadOnlyCollection<Address> AddressItems => _addressitems;
 
        //public static Customer NewDraft()
        //{
        //    var customer = new Customer();
        //    //customer._isDraft = true;
        //    return customer;
        //}

        protected Customer()
        {
            //_isDraft = false;
        }

        public Customer(Int64 IDbase , Int64 userId, string userName, string fullName, DateTime DOB) : this()
        {
            UserID = userId;
            Name = userName;
            FullName = fullName;
            DateofBirth = DOB;
            Idbase = IDbase;
            // Add the OrderStarterDomainEvent to the domain events collection 
            // to be raised/dispatched when comitting changes into the Database [ After DbContext.SaveChanges() ]
            // AddOrderStartedDomainEvent( userId, userName, fullName, DOB );
        }

     

        // DDD Patterns comment
        // This Order AggregateRoot's method "AddOrderitem()" should be the only way to add Items to the Order,
        // so any behavior (discounts, etc.) and validations are controlled by the AggregateRoot 
        // in order to maintain consistency between the whole Aggregate. 
        //public void AddAddressItem( string Street,  string City, string State,string Country, string ZipCode)
        //{
        //    var existingCity = _addressitems.Where(o => o.City == City)
        //        .SingleOrDefault(); 

        //    var addressItem = new Address(Street, City, State, Country, ZipCode );
        //    _addressitems.Add(addressItem); 
        //}

    }

    class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    { 
        public void Configure(EntityTypeBuilder<Customer> COREAPIConfiguration)
        {
            COREAPIConfiguration.ToTable("tblCustomer", COREAPIContext.DEFAULT_SCHEMA);

            COREAPIConfiguration.HasKey(o => o.Idbase); 

            COREAPIConfiguration
               .Property<Int64>("Idbase")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("Idbase")
               .ValueGeneratedOnAdd()
               .IsRequired(true);

            COREAPIConfiguration
                .Property<Int64>("UserID")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UserID")
                .IsRequired(true);

            COREAPIConfiguration
                .Property<string>("Name")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Name")
                .IsRequired();

            COREAPIConfiguration
               .Property<string>("FullName")
               .UsePropertyAccessMode(PropertyAccessMode.Field)
               .HasColumnName("FullName")
               .IsRequired();

            COREAPIConfiguration
                .Property<DateTime>("DateofBirth")
                // .HasField("_orderStatusId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("DateofBirth")
                .IsRequired(); 
        }
    }
}