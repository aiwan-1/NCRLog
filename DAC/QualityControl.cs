using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.AM;
using PX.Objects.AR;
using System;
using PX.Objects.AM.Attributes;
using PX.Objects.SO;

namespace NCRLog
{


    [PXCacheName(Messages.QualityControl)]
    public class QualityControl : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<QualityControl>.By<batchNbr, docType>
        {
            public static QualityControl Find(PXGraph graph, string batchNbr, string docType, PKFindOptions options = PKFindOptions.None) => FindBy(graph, batchNbr, docType, options);
        }
        public static class FK
        {
            public class Details : QCDetails.PK.ForeignKeyOf<QualityControl>.By<batchNbr, docType> { }
        }
        #endregion

        #region BatchNbr
        public abstract class batchNbr : BqlString.Field<batchNbr> { }
        [PXDBString(15, IsKey = true, IsUnicode = true)]
        [PXSelector(typeof(AMBatch.batNbr),
            typeof(AMBatch.docType))]
        [PXRestrictor(typeof(Where<AMBatch.docType.IsEqual<Messages.move>>), Messages.MoveNotFound, typeof(AMBatch.docType))]
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
        [PXSelector(typeof(AMBatch.docType),
            typeof(AMBatch.batNbr))]
        [PXRestrictor(typeof(Where<AMBatch.docType.IsEqual<Messages.move>>), Messages.MoveNotFound, typeof(AMBatch.docType))]
        [AMDocType.List]
        [PXUIField(DisplayName = "Doc Type")]
        public virtual string DocType
        {
            get;
            set;
        }
        #endregion

        #region CustomerID
        public abstract class customerID : BqlInt.Field<customerID> { }
        [Customer]
        [PXUIField(DisplayName = "Customer ID")]
        public virtual int? CustomerID
        {
            get;
            set;
        }
        #endregion


        #region SOOrderNbr
        public abstract class sOOrderNbr : BqlString.Field<sOOrderNbr> { }

        [PXDBString(15, IsUnicode = true)]
        [PXSelector(typeof(SOOrder.orderNbr),
            typeof(SOOrder.orderType),
            typeof(SOOrder.customerID))]
        [PXUIField(DisplayName = "SO Order Nbr")]
        public virtual string SOOrderNbr
        {
            get;
            set;
        }
        #endregion

        #region Date
        public abstract class date : BqlDateTime.Field<date> { }

        [PXDBDate()]
        [PXUIField(DisplayName = "Date")]
        public virtual DateTime? Date
        {
            get;
            set;
        }
        #endregion

        #region Owner
        public abstract class owner : BqlInt.Field<owner> { }
        [PX.TM.Owner]
        [PXUIField(DisplayName = "Owner")]
        public virtual int? Owner
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
