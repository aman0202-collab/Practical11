using System;
using System.ComponentModel.DataAnnotations;

namespace Practical11.Models
{
    // Model class for one campus service request.
    // It matches the ServiceRequests table in the SmartCampusDB database.
    public class ServiceRequest
    {
        public int RequestId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string ServiceType { get; set; }

        [Required]
        public string Description { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public DateTime RequestDate { get; set; }
    }
}
