﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iBalekaWeb.Models
{
    public partial class Event
    {
        public Event()
        {
            EventRegistration = new HashSet<EventRegistration>();
            EventRoute = new HashSet<EventRoute>();
            Run = new HashSet<Run>();
            DateCreated = DateTime.Now;
            Deleted = false;
        }

        [Key]
        public int EventId { get; set; }
        public int ClubId { get; set; }
        public string UserID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }

        public virtual ICollection<EventRegistration> EventRegistration { get; set; }
        public virtual ICollection<EventRoute> EventRoute { get; set; }
        public virtual ICollection<Run> Run { get; set; }
        public virtual Club Club { get; set; }
    }
}
