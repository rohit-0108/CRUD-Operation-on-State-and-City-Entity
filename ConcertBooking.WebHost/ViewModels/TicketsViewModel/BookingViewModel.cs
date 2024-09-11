﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.WebHost.ViewModels.TicketsViewModel
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public DateTime bookingDate { get; set; }
        public string ConcertName { get; set; }
        public List<TicketViewModel> Tickets {  get; set; } 
    }
}
