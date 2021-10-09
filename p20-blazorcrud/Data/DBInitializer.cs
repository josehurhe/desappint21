using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud.Data
{
    public class DBInitializer
    {
        public static void Initialize(AppDBContext context){
            context.Database.EnsureCreated();
            if (context.Employees.Any()){
                return;
            }
            var employees = new Employee[]{
                new Employee("Carlos Castaneda Ramirez", "Male", "Zacatecas", "Profesor"),
                new Employee("Blanca Solis Recendez", "Female", "Fresnillo", "Profesora"),
                new Employee("Juan Villa Cisneros", "Male", "Zacatecas", "Profesor"),
                new Employee("Uriel Cortez Vargas", "Male", "Guadalupe", "Trabajador"),
                new Employee("Ma Concepcion Lopez", "Female", "Jerez", "Intendente"),
            };


            foreach (Employee emp in employees)
            {
                context.Employees.Add(emp);
            }
            context.SaveChanges();
        }
    }
}