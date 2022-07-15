using System;

namespace HaHome.App.Domain.Entities
{
    public class VitalSign
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double Value { get; set; }
        public Sign Sign { get; set; }
    }
}
