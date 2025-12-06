using OnionCompany.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OnionCompany.Domain.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
