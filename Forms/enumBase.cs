using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.DTH.Forms
{
    class enumBase
    {
        public enum StockType: short
        {
            Serial = 1001,
            NonSerial = 1002
        }
        public enum Transtype
        {
            COMPANY_to_ISP = 501,
            ISP_to_DEALER = 502,
            DEALER_to_ISP = 503,
            DEALER_to_DEALER = 504,
            ISP_to_COMPANY = 505,
            DEALER_to_ACTIVATION = 506
        }

        //public class StockTypebase
        //{
        //    private Int64 stock_typeid { get; set; }
        //    private string stock_type { get; set; }
        //    //Serial = 1001,
        //    //NonSerial = 1002
        //    public StockTypebase(Int64 _StockTypeID, string _StockType) {
        //        stock_typeid = _StockTypeID;
        //        stock_type = _StockType;
        //    }
        //}

        //public class StockTypes : List<StockTypebase>
        //{ 
        //    //Serial = 1001,
        //    //NonSerial = 1002

        //    public StockTypes()
        //    {
        //        this.Add(new StockTypebase(1001, "Serial"));
        //        this.Add(new StockTypebase(1002, "NonSerial"));
        //    }
        //}
    }
}
