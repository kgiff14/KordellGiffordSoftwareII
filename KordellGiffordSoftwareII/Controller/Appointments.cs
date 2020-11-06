using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordellGiffordCapstone
{
    public class Appointments
    {
        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int alert { get; set; }


        public Appointments(int aId, int cId, int uId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end, int alert = 0)
        {
            appointmentId = aId;
            customerId = cId;
            userId = uId;
            this.title = title;
            this.description = description;
            this.location = location;
            this.contact = contact;
            this.type = type;
            this.url = url;
            this.start = start;
            this.end = end;
        }
    }
}
