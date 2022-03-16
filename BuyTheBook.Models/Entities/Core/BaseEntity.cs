using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Models.Entities.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.IsActive = false;
            this.CreationTime = DateTime.Now;
            this.DeletedTime = null;
        }

        public bool IsActive { get; set; }

        public DateTime CreationTime { get; set; }

        public bool IsDelete { get; set; }

        public DateTime? DeletedTime { get; set; }

    }
}   
