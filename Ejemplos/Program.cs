using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Contpaqi.Sql.Comercial.Empresa.Factories;

namespace Ejemplos
{
    public class Program
    {
        public static async Task Main()
        {
            const string connectionString = @"Data Source=AR-SERVER\COMPAC;User ID=sa;Password=Sdmramos1;";
            const string initialCatalog = "adPRUEBAS_COMERCIAL";

            try
            {
                using (var context = ComercialEmpresaDbContextFactory.CreateInstance(connectionString, initialCatalog))
                {
                    Console.WriteLine($"Connection String: {context.Database.Connection.ConnectionString}");

                    Console.WriteLine("Buscando conceptos");
                    var conceptos = await context.admConceptos.AsNoTracking().OrderBy(e => e.CNOMBRECONCEPTO).ToListAsync();

                    Console.WriteLine($"# de conceptos: {conceptos.Count}");

                    foreach (var concepto in conceptos)
                    {
                        Console.WriteLine($"{concepto.CCODIGOCONCEPTO.Trim()} | {concepto.CNOMBRECONCEPTO.Trim()}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
}