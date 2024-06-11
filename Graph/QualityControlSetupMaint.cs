using System;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace NCRLog
{
  public class QualityControlSetupMaint : PXGraph<QualityControlSetupMaint, ISOSetup>
  {

        public SelectFrom<ISOSetup>.View Setup;

  }
}