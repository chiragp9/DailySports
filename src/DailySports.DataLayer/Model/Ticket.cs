﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailySports.DataLayer.Model
{
    public class Ticket
    {
        [Key]
        public int Id { get; set;}
        public Nullable<decimal> Price { get; set; }
        public string Notes { get; set; }
        public long Quantity { get; set; }
        [ForeignKey("TicketId")]
        public virtual TicketType ticketType { get; set; }
        public int TicketId { get; set; }
    }
}
