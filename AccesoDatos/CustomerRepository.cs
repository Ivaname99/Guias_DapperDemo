using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public List<Customers> ObtenerTodo()
        {
            using(var conexion = DataBase.GetSqlConnection())
            {
                String SelectAll = "";
                SelectAll = SelectAll + "SELECT [CustomerID] " + "\n";
                SelectAll = SelectAll + "      ,[CompanyName] " + "\n";
                SelectAll = SelectAll + "      ,[ContactName] " + "\n";
                SelectAll = SelectAll + "      ,[ContactTitle] " + "\n";
                SelectAll = SelectAll + "      ,[Address] " + "\n";
                SelectAll = SelectAll + "      ,[City] " + "\n";
                SelectAll = SelectAll + "      ,[Region] " + "\n";
                SelectAll = SelectAll + "      ,[PostalCode] " + "\n";
                SelectAll = SelectAll + "      ,[Country] " + "\n";
                SelectAll = SelectAll + "      ,[Phone] " + "\n";
                SelectAll = SelectAll + "      ,[Fax] " + "\n";
                SelectAll = SelectAll + "  FROM [dbo].[Customers]";

                var cliente = conexion.Query<Customers>(SelectAll).ToList();
                return cliente;
            }
        }

        public Customers ObtenerPorId(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectPorId = "";
                SelectPorId = SelectPorId + "SELECT [CustomerID] " + "\n";
                SelectPorId = SelectPorId + "      ,[CompanyName] " + "\n";
                SelectPorId = SelectPorId + "      ,[ContactName] " + "\n";
                SelectPorId = SelectPorId + "      ,[ContactTitle] " + "\n";
                SelectPorId = SelectPorId + "      ,[Address] " + "\n";
                SelectPorId = SelectPorId + "      ,[City] " + "\n";
                SelectPorId = SelectPorId + "      ,[Region] " + "\n";
                SelectPorId = SelectPorId + "      ,[PostalCode] " + "\n";
                SelectPorId = SelectPorId + "      ,[Country] " + "\n";
                SelectPorId = SelectPorId + "      ,[Phone] " + "\n";
                SelectPorId = SelectPorId + "      ,[Fax] " + "\n";
                SelectPorId = SelectPorId + "  FROM [dbo].[Customers] " + "\n";
                SelectPorId = SelectPorId + "  WHERE CustomerID = @CustomerID";

                var cliente = conexion.QueryFirstOrDefault<Customers>(SelectPorId, new {CustomerID = id});
                return cliente;
            }
        }

        public int InsertarCliente(Customers customer)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String Insertar = "";
                Insertar = Insertar + "INSERT INTO [dbo].[Customers] " + "\n";
                Insertar = Insertar + "           ([CustomerID] " + "\n";
                Insertar = Insertar + "           ,[CompanyName] " + "\n";
                Insertar = Insertar + "           ,[ContactName] " + "\n";
                Insertar = Insertar + "           ,[ContactTitle] " + "\n";
                Insertar = Insertar + "           ,[Address]) " + "\n";
                Insertar = Insertar + "     VALUES " + "\n";
                Insertar = Insertar + "           (@CustomerID " + "\n";
                Insertar = Insertar + "           ,@CompanyName " + "\n";
                Insertar = Insertar + "           ,@ContactName " + "\n";
                Insertar = Insertar + "           ,@ContactTitle " + "\n";
                Insertar = Insertar + "           ,@Address)";

                var insertadas = conexion.Execute(Insertar, new
                {
                    CustomerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    Address = customer.Address,
                });
                return insertadas;
            }
        }

        public int ActualizarCliente(Customers customers)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String UpdateCustomer = "";
                UpdateCustomer = UpdateCustomer + "UPDATE [dbo].[Customers] " + "\n";
                UpdateCustomer = UpdateCustomer + "   SET [CustomerID] = @CustomerID " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[CompanyName] = @CompanyName " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[ContactName] = @ContactName " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[ContactTitle] = @ContactTitle " + "\n";
                UpdateCustomer = UpdateCustomer + "      ,[Address] = @Address " + "\n";
                UpdateCustomer = UpdateCustomer + " WHERE CustomerID = @CustomerID";

                var actualizadas = conexion.Execute(UpdateCustomer, new
                {
                    CustomerID = customers.CustomerID,
                    CompanyName = customers.CompanyName,
                    ContactName = customers.ContactName,
                    ContactTitle = customers.ContactTitle,
                    Address = customers.Address,
                });
                return actualizadas;
            }
        }

        public int EliminarCliente(string id )
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String Delete = "";
                Delete = Delete + "DELETE FROM [dbo].[Customers] " + "\n";
                Delete = Delete + "      WHERE CustomerID = @CustomerID";

                var eliminadas = conexion.Execute(Delete, new
                {
                    CustomerID = id,
                });
                return eliminadas;
            }
        }
    }
}
