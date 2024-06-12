using PX.Data.BQL.Fluent;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCRLog
{
    public class GCQualityControlEntry : PXGraph<GCQualityControlEntry, QualityControl>
    {
        public SelectFrom<QualityControl>.View QCCheck;

        public SelectFrom<QCDetails>.
            Where<QCDetails.batchNbr.IsEqual<QualityControl.batchNbr.FromCurrent>.
            And<QCDetails.docType.IsEqual<QualityControl.docType.FromCurrent>>>.View Details;
    }
}
