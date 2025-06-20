﻿using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.AM.Attributes;
using PX.Objects.AM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCRLog
{
    [PXCacheName(Messages.PressGlueLog)]
    public class PressGlueLogHeader : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<PressGlueLogHeader>.By<pressNo, date>
        {
            public static PressGlueLogHeader Find(PXGraph graph, int? pressNo, DateTime? date, PKFindOptions options = PKFindOptions.None) => FindBy(graph, pressNo, date, options);
        }
        public static class FK
        {
            public class LogDetail : PressGlueLogDetails.PK.ForeignKeyOf<PressGlueLogHeader>.By<pressNo, date> { }
        }
        #endregion


        #region BatchNbr
        public abstract class batchNbr : BqlString.Field<batchNbr> { }

        [PXDBString(15, IsUnicode = true)]
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
        [PXDBString(10, IsUnicode = true)]
        [AMDocType.List]
        [PXRestrictor(typeof(Where<AMBatch.docType.IsEqual<Messages.move>>), Messages.MoveNotFound, typeof(AMBatch.docType))]
        [PXUIField(DisplayName = "Doc Type")]
        public virtual string DocType
        {
            get;
            set;
        }
        #endregion

        #region PressNo
        public abstract class pressNo : BqlInt.Field<pressNo> { }
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Press No")]
        public virtual int? PressNo
        {
            get;
            set;
        }
        #endregion

        #region GlueManufacturer
        public abstract class glueManufacturer : BqlString.Field<glueManufacturer> { }

        [PXDBString(64, IsUnicode = true)]
        [PXUIField(DisplayName = "Glue Manufacturer")]
        public virtual string GlueManufacturer
        {
            get;
            set;
        }
        #endregion

        #region GlueSetting
        public abstract class glueSetting : BqlString.Field<glueSetting> { }

        [PXDBString(10, IsUnicode = true)]
        [PXUIField(DisplayName = "Glue Setting")]
        public virtual string GlueSetting
        {
            get;
            set;
        }
        #endregion

        #region DiffPressure
        public abstract class diffPressure : BqlString.Field<diffPressure> { }

        [PXDBString(10, IsUnicode = true)]
        [PXUIField(DisplayName = "Differential Pressure")]
        public virtual string DiffPressure
        {
            get;
            set;
        }
        #endregion

        #region TargetWeightg
        public abstract class targetWeightg : BqlString.Field<targetWeightg> { }

        [PXDBString(16, IsUnicode = true)]
        [PXUIField(DisplayName = "Target Weight (g)")]
        public virtual string TargetWeightg
        {
            get;
            set;
        }
        #endregion

        #region Resultg
        public abstract class resultg : BqlString.Field<resultg> { }

        [PXDBString(16, IsUnicode = true)]
        [PXUIField(DisplayName = "Result (g)")]
        public virtual string Resultg
        {
            get;
            set;
        }
        #endregion

        #region TestedBy
        public abstract class testedBy : BqlInt.Field<testedBy> { }

        [PX.TM.Owner]
        [PXUIField(DisplayName = "Tested By")]
        public virtual int? TestedBy
        {
            get;
            set;
        }
        #endregion

        #region Date
        public abstract class date : BqlDateTime.Field<date> { }

        [PXDBDate(IsKey = true)]
        [PXDefault(typeof(AccessInfo.businessDate), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Date")]
        public virtual DateTime? Date
        {
            get;
            set;
        }
        #endregion

        #region SiteID
        public abstract class siteID : BqlString.Field<siteID> { }
        [PXDBString(25, IsUnicode = true)]
        [PXUIField(DisplayName = "Site")]
        public virtual string SiteID
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
