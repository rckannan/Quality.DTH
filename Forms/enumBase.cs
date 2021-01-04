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

    }
}
