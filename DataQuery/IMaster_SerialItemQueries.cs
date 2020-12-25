using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Quality.DTH.Queries
{
    public interface IMaster_SerialItemQueries
    {
        Task<master_serialitemDTO> GetMaster_SerialItem(Int64 id);

        Task<IEnumerable<master_serialitemDTO>> GetMaster_SerialItems();
    }

    public class Master_SerialItemQueries : IMaster_SerialItemQueries
    {
        private string _connectionString = string.Empty;
        public Master_SerialItemQueries(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));
        }


        public async Task<master_serialitemDTO> GetMaster_SerialItem(Int64 id)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<master_serialitemDTO>(
                   @"select * from DTH.tbl_master_serialitem
                        WHERE  Idbase=@id"
                        , new { id }
                    );

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<master_serialitemDTO>> GetMaster_SerialItems()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<master_serialitemDTO>(
                   @"select * from DTH.tbl_master_serialitem ");

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result;
            }
        }
         
    }

    public class master_serialitemDTO
    { 
        public string item_name { get; set; }
        public string item_detail { get; set; } 
        public Int64 Idbase { get; set; }

    }


}
