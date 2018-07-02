using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCS
{
    class IncrementID
    {

        ConDB ConDB = new ConDB();



        public int IncrementItem()
        {
            int IncremID;
            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetItem(@"Select * From Item order by ItemNo DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return IncremID = 1;

                default:
                    return IncremID = int.Parse(dtIncrement.Rows[0]["ItemNo"].ToString()) + 1;

            }
        }

        public int IncrementBox()
        {
        
            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetItem(@"Select * From Box order by BoxNo DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return  int.Parse(dtIncrement.Rows[0]["BoxNo"].ToString()) + 1;

            }
        }

        public int IncrementShipmentRoute()
        {

            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetItem(@"Select * From ShipmentRoute order by RouteNo DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return int.Parse(dtIncrement.Rows[0]["RouteNo"].ToString()) + 1;

            }
        }


        public int IncrementLocation()
        {

            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetItem(@"Select * From Location order by LocationNo DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return int.Parse(dtIncrement.Rows[0]["LocationNo"].ToString()) + 1;

            }
        }

        public int IncrementInitTranNo()
        {

            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetItem(@"Select * From InitialTran order by InitTranNo DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return int.Parse(dtIncrement.Rows[0]["InitTranNo"].ToString()) + 1;

            }
        }

        public int IncrementInitFreightNo()
        {

            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetFreightTranDT(@"Select * From FreightTranHD order by FreightNoHD DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return int.Parse(dtIncrement.Rows[0]["FreightNoHD"].ToString()) + 1;
            }
        }


        public int IncrementFreightTranDT()
        {

            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetFreightTranDT(@"Select * From FreightTranDT order by SeqNoDT DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return int.Parse(dtIncrement.Rows[0]["SeqNoDT"].ToString()) + 1;

            }
        }


        public int IncrementUserAccount()
        {

            DataTable dtIncrement = new DataTable();
            dtIncrement = ConDB.GetFreightTranDT(@"Select * From UserAccount order by UserID DESC");
            switch (dtIncrement.Rows.Count)
            {
                case 0:
                    return 1;

                default:
                    return int.Parse(dtIncrement.Rows[0]["UserID"].ToString()) + 1;

            }
        }




    }
}
