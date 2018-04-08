using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace CeremonyServices.Models
{
    public class UserInfo
    {
        [ForeignKey("User")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
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
        public DateTime ExpDate { get; set; }
        
        public virtual ApplicationUser User { get; set; }
    }
    
    
    //ConnectionString Name Must Be: "CSDatabase"
    public class CSContext : DbContext
    { 
        public CSContext() : base("CSDatabase") {}
        
        public DbSet<UserInfo> UserInfos { get; set; } 
        public DbSet<Product> Products { get; set; } 
    }


}
