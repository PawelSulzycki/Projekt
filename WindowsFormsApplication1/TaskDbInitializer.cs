using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public class TaskDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TaskDbContext>
    {
        protected override void Seed(TaskDbContext context)
        {
            context.SaveChanges();
            base.Seed(context);
        }

    }
}