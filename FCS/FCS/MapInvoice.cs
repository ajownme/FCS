using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS
{
    public class MapInvoice
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FreightNoDT { get; set; }
        public string BoxNameDT { get; set; }
        public string BoxDim { get; set; }
        public string CBMPerBoxDT { get; set; }
        public int DistinctBoxQty { get; set; }
        public double DistinctCBMTotal { get; set; }
        public double DistinctAmountTotal { get; set; }
        public double RMinCharge { get; set; }
        public string LocationName{ get; set; }
        public string Remarks { get; set; }
        public string PONumHD { get; set; }

    }
}
