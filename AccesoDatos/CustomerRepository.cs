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
    }
}
