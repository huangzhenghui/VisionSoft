using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionCore.Core.Project
{
    public static class ProjDelegate
    {
        public delegate void DeliveryHeader(SetHeader_Info setHeader_Info);
        public static DeliveryHeader deliveryHeader;

        public delegate void DeliveryData(ShowData_Info showData_Info);
        public static DeliveryData deliveryData;

        public delegate void DgvAddRow();
        public static DgvAddRow dgvAddRow;

        public delegate void DeliverySolName(string solName);
        public static DeliverySolName deliverySolName;

        public delegate void DeliveryRefreshClientDebugMsg(string msg);
        public static DeliveryRefreshClientDebugMsg deliveryRefreshClientDebugMsg;
    }
}
