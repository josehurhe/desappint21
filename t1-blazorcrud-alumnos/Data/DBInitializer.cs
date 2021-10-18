using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace t1_blazorcrud_alumnos.Data
{
    public class DBInitializer
    {
        public static void Initialize(AppDBContext context){
            context.Database.EnsureCreated();
        }
    }
}