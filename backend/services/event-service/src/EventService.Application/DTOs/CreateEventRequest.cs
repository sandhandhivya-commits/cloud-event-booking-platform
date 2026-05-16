using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Application.DTOs
{
    public class CreateEventRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}
