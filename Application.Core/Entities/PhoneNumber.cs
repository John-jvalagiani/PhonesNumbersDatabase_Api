using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aplication.Core.Entities
{
   
   public class PhoneNumber:BaseEntity
    {
        public string Phone { get; set; }
        public string OwnerName { get; set; } 
    }
}
