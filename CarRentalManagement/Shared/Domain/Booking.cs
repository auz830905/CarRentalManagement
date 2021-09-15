using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking: BaseModel
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }        
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
