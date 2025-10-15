using ContactPro.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactPro.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //get an instance of the db application context
            var dbContextsvc = svcProvider.GetRequiredService<ApplicationDbContext>();
            Console.WriteLine("Attempting to migrate database...");

            //this is equivalent to update-database
            await dbContextsvc.Database.MigrateAsync(); 

        }
    }
}
