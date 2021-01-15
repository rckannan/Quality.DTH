using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Quality.DTH.Infra;

namespace Quality.DTH.Queries
{
    public interface IMaster_StockQueries
    {
        Task<Master_StockDTO> GetMaster_StockItem(Int64 id);

        Task<IEnumerable<Master_StockDTO>> GetMaster_StockItems();

        Task<Master_StockDTO> GetMaster_StockItem(Int64 id, string stock);
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

        public Task<Master_StockDTO> GetMaster_StockItem(long id, string stock)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Master_StockDTO>> GetMaster_StockItems()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<Master_StockDTO>(
                   @"SELECT Idbase, stock_name, if(stock_type = 1001, 'Serial', 'NonSerial') as stock_type, stock_unit, stock_cost, stock_detail FROM DTH.tbl_master_stock");

                
                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result;
            }
        }
 
    }

    public class Master_StockDTO : BaseDTO
    {
        private string _stock_name;
        public string stock_name { get => _stock_name; set => SetField(ref _stock_name, value); }
        public string stock_unit { get; set; } 
        public string stock_detail { get; set; }
        public string stock_type { get; set; }
        public decimal stock_cost { get; set; }
        public Int64 Idbase { get; set; }

    }


}
