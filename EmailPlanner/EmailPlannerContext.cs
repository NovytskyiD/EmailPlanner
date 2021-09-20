using System.Data.Entity;

namespace EmailPlanner
{
    class EmailPlannerContext : DbContext
    {
        public EmailPlannerContext() : base("DefaultConnection")
        {

        }

        public DbSet<EmailPlan> EmailPlans { get; set; }
    }
}
