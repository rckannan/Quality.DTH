using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Quality.DTH.Queries
{
    public interface IStock_TransQueries
    {
        Task<Stock_TransactionDTO> GetStock_Tran(Int64 id);

        Task<IEnumerable<Stock_TransactionDTO>> GetStock_Tran_list();
    }

    public class Stock_TransQueries : IStock_TransQueries
    {
        private string _connectionString = string.Empty;
        public Stock_TransQueries(string constr)
        {
            _connectionString = !string.IsNullOrWhiteSpace(constr) ? constr : throw new ArgumentNullException(nameof(constr));
        }


        public async Task<Stock_TransactionDTO> GetStock_Tran(Int64 id)
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();
                var sql = $" select tns.*,src.*, dest.*  from DTH.tbl_stock_trans tns Inner join DTH.tbl_dealers src on tns.trans_source_dealer_id = src.Idbase Inner join DTH.tbl_dealers dest on tns.trans_dest_dealer_id = dest.Idbase WHERE  tns.Idbase={id}" ;

                //Func<Stock_TransactionDTO, DealerDTO, DealerDTO> p = (oi, i, v) => 
                //                                             {
                //                                                 oi = oi; oi.trans_source_dealer = i; oi.trans_dest_dealer = v;
                //                                                 return oi;
                //                                             };
                var items = await connection.QueryAsync<Stock_TransactionDTO>(
                                       sql,
                                        new[] {typeof(Stock_TransactionDTO),
                                            typeof(DealerDTO),
                                            typeof(DealerDTO)}
                                        , obj => {
                                            Stock_TransactionDTO _dto = obj[0] as Stock_TransactionDTO;
                                            _dto.trans_source_dealer = obj[1] as DealerDTO;
                                            _dto.trans_dest_dealer = obj[2] as DealerDTO;
                                            return _dto; },splitOn: "Idbase"
                                        );

                return items.FirstOrDefault();

                //var result = await connection.QueryAsync<Stock_TransactionDTO>(
                //   @"select * from DTH.tbl_stock_trans
                //        WHERE  Idbase=@id"
                //        , new { id }
                //    );

                //if (result.AsList().Count == 0)
                //    throw new KeyNotFoundException();

                //return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Stock_TransactionDTO>> GetStock_Tran_list()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection(_connectionString))
            {
                connection.Open();

                //var result = await connection.QueryAsync<Stock_TransactionDTO>(
                //   @"select * from DTH.tbl_stock_trans ");

                //if (result.AsList().Count == 0)
                //    throw new KeyNotFoundException();

                var sql = $" select tns.*,src.*, dest.*  from DTH.tbl_stock_trans tns Inner join DTH.tbl_dealers src on tns.trans_source_dealer_id = src.Idbase Inner join DTH.tbl_dealers dest on tns.trans_dest_dealer_id = dest.Idbase";
                                         
                var items = await connection.QueryAsync<Stock_TransactionDTO>(
                                       sql,
                                        new[] {typeof(Stock_TransactionDTO),
                                            typeof(DealerDTO),
                                            typeof(DealerDTO)}
                                        , obj => {
                                            Stock_TransactionDTO _dto = obj[0] as Stock_TransactionDTO;
                                            _dto.trans_source_dealer = obj[1] as DealerDTO;
                                            _dto.trans_dest_dealer = obj[2] as DealerDTO;
                                            return _dto;
                                        }, splitOn: "Idbase"
                                        );

                return items; 
            }
        }
 
    }

    public class Stock_TransactionDTO
    {
        public Int64 Idbase { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
        public Int64 trans_del_id { get; set; }
        public DateTime trans_date { get; set; }
        public Int64 trans_source_dealer_id { get; set; } 
        public DealerDTO trans_source_dealer { get; set; }
        public Int64 trans_dest_dealer_id { get; set; } 
        public DealerDTO trans_dest_dealer { get; set; }
        public Int16 trans_type { get; set; }
        public Int16 trans_item_type { get; set; }
        public Int64 trans_item_stock_id { get; set; }
        public Int16 trans_qty { get; set; }
        public Int64 trans_item_ser_id { get; set; }
        public string trans_notes { get; set; }

    }


}
