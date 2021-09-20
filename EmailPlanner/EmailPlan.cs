using System;

namespace EmailPlanner
{
    public class EmailPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime FirstLetterDate { get; set; }
        public DateTime SecondLetterDate { get; set; }
        public DateTime ThirdLetterDate { get; set; }
        public DateTime FourthLetterDate { get; set; }
    }
}
