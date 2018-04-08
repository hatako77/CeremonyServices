using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace CeremonyServices.Models
{
    public class ApplicationUser : IdentityUser
    {
        ...
        public virtual UserInfo UserInfo { get; set; }
        public virtual ICollection<Venue> Venue { get; set; }
    
    }

    
    public class UserInfo
    {
        [ForeignKey("User")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        [Column(TypeName="bigint")]
        public int? Mobile { get; set; }

        public virtual ApplicationUser User { get; set; }
    }

    public class Venue
    {
        [Column(TypeName="bigint")]
        public int VenueId { get; set; }
        [DefaultValue(3000)]
        public int Credit { get; set; }
        [DefaultValue("true")]
        public Boolean Suspended { get; set; }
        public DateTime? ExpDate { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Column(TypeName="bigint")]
        public int? Mobile { get; set; }
        [Column(TypeName="bigint")]
        public int? Phone1 { get; set; }
        [Column(TypeName="bigint")]
        public int? Phone2 { get; set; }
        public string Insta { get; set; }
        public string Telegram { get; set; }
        public string Website { get; set; }

        public int Capacity { get; set; }
        public int Parking { get; set; }
        public bool Coffeeshop { get; set; }
        public bool OldCoffeeshop { get; set; }

        public int EnterancePrice { get; set; }
        public int MusicPrice { get; set; }
        public int FirePlayPrice { get; set; }

        public virtual ICollection<FoodMenu> FoodMenu { get; set; }
        public virtual ApplicationUser User { get; set; }
    }

    public class FoodMenu
    {
        [Column(TypeName="bigint")]
        public int FoodMenuId { get; set; }
        public string Dsc { get; set; }
        public int Price { get; set; }
        public virtual Venue Venue { get; set; }
    }

    public class VenuePayment
    {
        public int PaymentId { get; set; }
        public DateTime PayDate { get; set; }
        public int Price { get; set; }
        public bool Done { get; set; }
        public string PayCode { get; set; }

        public virtual Venue Venue { get; set; }
    }


    //ConnectionString Name Must Be: "CSDatabase"
    public class CSContext : DbContext
    { 
        public CSContext() : base("CSDatabase") {}

        public DbSet<UserInfo> UserInfos { get; set; } 
        public DbSet<Venue> Venues { get; set; } 
        public DbSet<FoodMenu> FoodMenus { get; set; } 
        public DbSet<VenuePayment> VenuePayments { get; set; } 
    }


}
