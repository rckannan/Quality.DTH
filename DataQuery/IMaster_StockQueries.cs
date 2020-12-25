using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Quality.DTH.Queries
{
    public interface IMaster_StockQueries
    {
        Task<Master_StockDTO> GetMaster_StockItem(Int64 id);

        Task<IEnumerable<Master_StockDTO>> GetMaster_StockItems();
    }

    public class Master_StockQueries : IMaster_StockQueries
    {
        private string _connectionString = string.Empty;
        public Master_StockQueries(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));
        }


        public async Task<Master_StockDTO> GetMaster_StockItem(Int64 id)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<Master_StockDTO>(
                   @"select * from DTH.tbl_master_stock
                        WHERE  Idbase=@id"
                        , new { id }
                    );

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Master_StockDTO>> GetMaster_StockItems()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<Master_StockDTO>(
                   @"select * from DTH.tbl_master_stock ");

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result;
            }
        }
 
    }

    public class Master_StockDTO
    { 
        public string stock_name { get; set; }
        public string stock_unit { get; set; } 
        public string stock_detail { get; set; }
        public Int16 stock_type { get; set; }
        public decimal stock_cost { get; set; }
        public Int64 Idbase { get; set; }

    }


}
