using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;



namespace OrderLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Products";
        public ProductModel CreateProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ProductCode", model.ProductCode);
                p.Add("@ProductName", model.ProductName);
                p.Add("@ProductAmount", model.Amount);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@ReceivedDate", DateTime.UtcNow);
                connection.Execute("dbo.spProduct_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                return model;
            }
        }

        public List<ProductModel> GetProductsAll()
        {
            List<ProductModel> output;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ProductModel>("dbo.spProduct_GetAll").ToList();
            }
            return output;
        }
    }
}
