using System;
using System.Collections.Generic;

namespace HaHome.App.Domain.Entities
{
    public class Patient : Person
    {
        public History History { get; set; }
        public List<VitalSign> VitalSigns { get; set; }
        public Relative Relative { get; set; }
        public Nurse Nurse { get; set; }
        public Doctor Doctor { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

}

