using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Quality.DTH.Queries
{
    public interface IDealerQueries
    {
        Task<DealerDTO> GetDealer(int id);

        Task<IEnumerable<DealerDTO>> GetDealers();
    }

    public class DealerQueries : IDealerQueries
    {
        private string _connectionString = string.Empty;
        public DealerQueries(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));
        }


        public async Task<DealerDTO> GetDealer(int id)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<DealerDTO>(
                   @"select * from DTH.tbl_dealers
                        WHERE Idbase=@id"
                        , new { id }
                    );

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<DealerDTO>> GetDealers()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                var result = await connection.QueryAsync<DealerDTO>(
                   @"select * from DTH.tbl_dealers ");

                if (result.AsList().Count == 0)
                    throw new KeyNotFoundException();

                return result;
            }
        }
         
    }

    public class DealerDTO
    {
        public Int64 Idbase { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
        public Int64 dealer_acc_id { get; set; }
        public string dealer_name { get; set; }
        public string dealer_contact { get; set; }
        public string dealer_address { get; set; }
        public Int16 dealer_beat { get; set; }
        public Int16 dealer_category { get; set; }

    }


}
