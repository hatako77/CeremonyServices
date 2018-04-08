using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace CRM.Models
{
    public class UserInfo
    {
        [ForeignKey("User")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Credit { get; set; }
        public Boolean IsPro { get; set; }
        
        public virtual ApplicationUser User { get; set; }
    }

    public class Skill
    {
        public int64 SkillId { get; set; }
        public int16 AdobePhotoshop { get; set; }
        public int16 AdobeIllustrator { get; set; }
        public int16 AdobeAfterEffect { get; set; }
        public int16 AdobeDesign { get; set; }
        public int16 CorelDraw { get; set; }
        
        public virtual ApplicationUser User { get; set; }
    }
    
    public class CSContext : DbContext
    { 
        public CSContext() : base("CSDatabase") {}
        
        public DbSet<UserInfo> UserInfos { get; set; } 
        public DbSet<Product> Products { get; set; } 
    }


}
