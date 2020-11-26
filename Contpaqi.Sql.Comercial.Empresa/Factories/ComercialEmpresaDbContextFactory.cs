using System;
using System.Data.SqlClient;

namespace Contpaqi.Sql.Comercial.Empresa.Factories
{
    public static class ComercialEmpresaDbContextFactory
    {
        public static ComercialEmpresaDbContext CreateInstance(string contpaqiConnectionString, string initialCatalog)
        {
            if (contpaqiConnectionString == null)
            {
                throw new ArgumentNullException(nameof(contpaqiConnectionString));
            }

            if (initialCatalog == null)
            {
                throw new ArgumentNullException(nameof(initialCatalog));
            }

            var connectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) {InitialCatalog = initialCatalog};

            return new ComercialEmpresaDbContext(new SqlConnection(connectionStringBuilder.ToString()), true);
        }
    }
}