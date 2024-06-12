using PX.Data.BQL.Fluent;
using PX.Data.BQL;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCRLog
{
    public class GCPressGlueLogEntry : PXGraph<GCPressGlueLogEntry, PressGlueLogHeader>
    {
        #region Views
        public SelectFrom<PressGlueLogHeader>.View Header;

        public SelectFrom<PressGlueLogDetails>.
            Where<PressGlueLogDetails.batchNbr.IsEqual<PressGlueLogHeader.batchNbr.FromCurrent>.
                And<PressGlueLogDetails.docType.IsEqual<PressGlueLogHeader.docType.FromCurrent>>>.View Details;
        #endregion


        #region Event Handlers
        protected virtual void _(Events.RowPersisted<PressGlueLogHeader> e)
        {
            PressGlueLogHeader row = e.Row;

            PressGlueLogHeader header = SelectFrom<PressGlueLogHeader>.
                Where<PressGlueLogHeader.date.IsEqual<AccessInfo.businessDate>.
                And<PressGlueLogHeader.pressNo.IsNotEqual<@P.AsInt>>>.View.Select(this, row.Date);

            if (row.Date == header.Date)
            {
                var manufacturer = header.GlueManufacturer;
                var setting = header.GlueSetting;
                var pressure = header.DiffPressure;
                var pressNo = header.PressNo + 1;

                e.Cache.SetValueExt<PressGlueLogHeader.glueManufacturer>(row, manufacturer);
                e.Cache.SetValueExt<PressGlueLogHeader.glueSetting>(row, setting);
                e.Cache.SetValueExt<PressGlueLogHeader.diffPressure>(row, pressure);
                e.Cache.SetValueExt<PressGlueLogHeader.pressNo>(row, pressNo);

            }
        }

        protected virtual void _(Events.RowSelected<PressGlueLogHeader> e)
        {
            PressGlueLogHeader row = e.Row;

            PXUIFieldAttribute.SetEnabled<PressGlueLogHeader.siteID>(e.Cache, row, true);
        }
        #endregion
    }
}
