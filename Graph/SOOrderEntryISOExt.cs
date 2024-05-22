using PX.Data;
using PX.Objects.SO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace NCRLog
{
    public class SOOrderEntryISOExt : PXGraphExtension<SOOrderEntry>
    {
        public static bool IsActive() => true;

        public static void CreateISORecord(SOOrder order)
        {
            SOOrder row = e.Row;
            using (var ts = new PXTransactionScope()) 
            {
                var iSORecordEntry = PXGraph.CreateInstance<GilcrestMaint>();

                var doc = new ISORecords() { };

                doc.SOOrderNbr = order.OrderNbr;
                doc.CustomerID = order.CustomerID;

                var orderEntry = PXGraph.CreateInstance<SOOrderEntry>();
                orderEntry.SalesOrders.Current = orders;

                foreach (SOOrderItem line in )
            }
        }

        

        public PXAction<SOOrder> CreateISORecordAction;
        [PXButton]
        [PXUIField(DisplayName = "Create NCR/ECN", Enabled = true)]
        protected virtual IEnumerable createISORecord(PXAdapter adapter)
        {
            List 
        }

    }
}*/
