using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using System;
using PX.Objects.SO;
using GILCustomizations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCRLog
{
    [PXCacheName(Messages.QCDetails)]
    public class QCDetails : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<QCDetails>.By<batchNbr, docType>
        {
            public static QCDetails Find(PXGraph graph, string batchNbr, string docType, PKFindOptions options = PKFindOptions.None) => FindBy(graph, batchNbr, docType, options);
        }
        public static class FK
        {
            public class Quality : QualityControl.PK.ForeignKeyOf<QCDetails>.By<batchNbr, docType> { }
        }
        #endregion

        #region BatchNbr
        public abstract class batchNbr : BqlString.Field<batchNbr> { }
        [PXDBString(15, IsKey = true, IsUnicode = true)]
        [PXDBDefault(typeof(QualityControl.batchNbr))]
        [PXParent(typeof(FK.Quality))]
        [PXUIField(DisplayName = "Batch Nbr")]
        public virtual string BatchNbr
        {
            get;
            set;
        }
        #endregion

        #region DocType
        public abstract class docType : BqlString.Field<docType> { }
        [PXDBString(10, IsKey = true, IsUnicode = true)]
        [PXDBDefault(typeof(QualityControl.docType))]
        [PXParent(typeof(FK.Quality))]
        [PXUIField(DisplayName = "Doc Type")]
        public virtual string DocType
        {
            get;
            set;
        }
        #endregion

        #region Thickness
        public abstract class thickness : BqlString.Field<thickness> { }

        [PXDBString(25, IsUnicode = true)]
        [PXUIField(DisplayName = "Panel Thickness")]
        public virtual string Thickness
        {
            get;
            set;
        }
        #endregion

        #region Lengthmm
        public abstract class lengthmm : BqlString.Field<lengthmm> { }

        [PXDBString(25, IsUnicode = true)]
        [PXUIField(DisplayName = "Length (mm)")]
        public virtual string Lengthmm
        {
            get;
            set;
        }
        #endregion

        #region Widthmm
        public abstract class widthmm : BqlString.Field<widthmm> { }

        [PXDBString(25, IsUnicode = true)]
        [PXUIField(DisplayName = "Width (mm)")]
        public virtual string Widthmm
        {
            get;
            set;
        }
        #endregion

        #region DiagonalCheck
        public abstract class diagonalCheck : BqlString.Field<diagonalCheck> { }

        [PXDBString(25, IsUnicode = true)]
        [PXUIField(DisplayName = "Diagonal Check")]
        public virtual string DiagonalCheck
        {
            get;
            set;
        }
        #endregion

        #region Damage
        public abstract class damage : BqlString.Field<damage> { }

        [PXDBString(256, IsUnicode = true)]
        [PXUIField(DisplayName = "Damage")]
        public virtual string Damage
        {
            get;
            set;
        }
        #endregion

        #region Cleaning
        public abstract class cleaning : BqlString.Field<cleaning> { }

        [PXDBString(25, IsUnicode = true)]
        [PXUIField(DisplayName = "Cleaning")]
        public virtual string Cleaning
        {
            get;
            set;
        }
        #endregion

        #region VisualCheck
        public abstract class visualCheck : BqlString.Field<visualCheck> { }

        [PXDBString(256, IsUnicode = true)]
        [PXUIField(DisplayName = "Visual Check")]
        public virtual string VisualCheck
        {
            get;
            set;
        }
        #endregion

        #region CustomerSpecific
        public abstract class customerSpecific : BqlString.Field<customerSpecific> { }

        [PXDBString(256, IsUnicode = true)]
        [PXUIField(DisplayName = "Customer Specific")]
        public virtual string CustomerSpecific
        {
            get;
            set;
        }
        #endregion

        #region DailyBondTest
        public abstract class dailyBondTest : BqlString.Field<dailyBondTest> { }

        [PXDBString(128, IsUnicode = true)]
        [PXUIField(DisplayName = "Daily Bond Test")]
        public virtual string DailyBondTest
        {
            get;
            set;
        }
        #endregion

        #region PanelRef
        public abstract class panelRef : BqlString.Field<panelRef> { }

        [PXDBString(25, IsUnicode = true)]
        [PXSelector(typeof(SOLineExt.usrPanelRef),
            typeof(SOLine.inventoryID),
            typeof(SOLine.orderNbr))]
        [PXRestrictor(typeof(Where<SOLine.orderNbr.IsEqual<QualityControl.sOOrderNbr.FromCurrent>>), Messages.MoveNotFound, typeof(SOLineExt.usrPanelRef))]
        [PXUIField(DisplayName = "PanelRef")]
        public virtual string PanelRef
        {
            get;
            set;
        }
        #endregion


        #region Quantity
        public abstract class quantity : BqlDecimal.Field<quantity> { }

        [PXDBDecimal(6)]
        [PXUIField(DisplayName = "Quantity")]
        public virtual decimal? Quantity
        {
            get;
            set;
        }
        #endregion


        #region System Fields

        #region CreatedDateTime
        [PXDBCreatedDateTime()]
        public virtual DateTime? CreatedDateTime { get; set; }
        public abstract class createdDateTime :
        PX.Data.BQL.BqlDateTime.Field<createdDateTime>
        { }
        #endregion

        #region CreatedByID
        [PXDBCreatedByID()]
        public virtual Guid? CreatedByID { get; set; }
        public abstract class createdByID :
        PX.Data.BQL.BqlGuid.Field<createdByID>
        { }
        #endregion

        #region CreatedByScreenID
        [PXDBCreatedByScreenID()]
        public virtual string CreatedByScreenID { get; set; }
        public abstract class createdByScreenID :
        PX.Data.BQL.BqlString.Field<createdByScreenID>
        { }
        #endregion

        #region LastModifiedDateTime
        [PXDBLastModifiedDateTime()]
        public virtual DateTime? LastModifiedDateTime { get; set; }
        public abstract class lastModifiedDateTime :
        PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime>
        { }
        #endregion

        #region LastModifiedByID
        [PXDBLastModifiedByID()]
        public virtual Guid? LastModifiedByID { get; set; }
        public abstract class lastModifiedByID :
        PX.Data.BQL.BqlGuid.Field<lastModifiedByID>
        { }
        #endregion

        #region LastModifiedByScreenID
        [PXDBLastModifiedByScreenID()]
        public virtual string LastModifiedByScreenID { get; set; }
        public abstract class lastModifiedByScreenID :
        PX.Data.BQL.BqlString.Field<lastModifiedByScreenID>
        { }
        #endregion

        #region Tstamp
        [PXDBTimestamp()]
        public virtual byte[] Tstamp { get; set; }
        public abstract class tstamp :
        PX.Data.BQL.BqlByteArray.Field<tstamp>
        { }
        #endregion

        #region NoteID
        [PXNote()]
        public virtual Guid? NoteID { get; set; }
        public abstract class noteID : PX.Data.BQL.BqlGuid.Field<noteID> { }
        #endregion

        #endregion
    }
}
