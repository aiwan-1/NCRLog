using PX.Data.BQL;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.AM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCRLog
{
    [PXCacheName(Messages.PressGlueLog)]
    public class PressGlueLogDetails : IBqlTable
    {
        #region Keys
        public class PK : PrimaryKeyOf<PressGlueLogDetails>.By<pressNo, date>
        {
            public static PressGlueLogDetails Find(PXGraph graph, int? pressNo, DateTime? date, PKFindOptions options = PKFindOptions.None) => FindBy(graph, pressNo, date, options);
        }
        public static class FK
        {
            public class LogHeader : PressGlueLogHeader.PK.ForeignKeyOf<PressGlueLogHeader>.By<pressNo, date> { }
        }
        #endregion


        #region BatchNbr
        public abstract class batchNbr : BqlString.Field<batchNbr> { }

        [PXDBString(15, IsUnicode = true)]

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
        [PXUIField(DisplayName = "Doc Type")]
        public virtual string DocType
        {
            get;
            set;
        }
        #endregion

        #region PressNo
        public abstract class pressNo : BqlInt.Field<pressNo> { }
        [PXDBDefault(typeof(PressGlueLogHeader.pressNo))]
        [PXParent(typeof(FK.LogHeader))]
        [PXDBInt(IsKey = true)]
        [PXUIField(DisplayName = "Press No")]
        public virtual int? PressNo
        {
            get;
            set;
        }
        #endregion

        #region Date
        public abstract class date : BqlDateTime.Field<date> { }
        [PXDBDefault(typeof(PressGlueLogHeader.date))]
        [PXParent(typeof(FK.LogHeader))]
        [PXDBDate(IsKey = true)]
        [PXDefault(typeof(AccessInfo.businessDate), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Date")]
        public virtual DateTime? Date
        {
            get;
            set;
        }
        #endregion

        #region StartTemp
        public abstract class startTemp : BqlString.Field<startTemp> { }

        [PXDBString(32, IsUnicode = true)]
        [PXUIField(DisplayName = "Start Temp")]
        public virtual string StartTemp
        {
            get;
            set;
        }
        #endregion

        #region FirstTime
        public abstract class firstTime : BqlString.Field<firstTime> { }

        [PXDBString(16, IsUnicode = true)]
        [PXUIField(DisplayName = "First Sheet: Time")]
        public virtual string FirstTime
        {
            get;
            set;
        }
        #endregion

        #region LastTime
        public abstract class lastTime : BqlString.Field<lastTime> { }

        [PXDBString(16, IsUnicode = true)]
        [PXUIField(DisplayName = "Last Sheet: Time")]
        public virtual string LastTime
        {
            get;
            set;
        }
        #endregion

        #region OpenTimeMin
        public abstract class openTimeMin : BqlString.Field<openTimeMin> { }

        [PXDBString(32, IsUnicode = true)]
        [PXUIField(DisplayName = "Open Time (Min)")]
        public virtual string OpenTimeMin
        {
            get;
            set;
        }
        #endregion

        #region Pressurepsi
        public abstract class pressurepsi : BqlInt.Field<pressurepsi> { }

        [PXDBInt]
        [PXUIField(DisplayName = "Pressure (PSI)")]
        public virtual int? Pressurepsi
        {
            get;
            set;
        }
        #endregion

        #region StartTimePress
        public abstract class startTimePress : BqlString.Field<startTimePress> { }

        [PXDBString(32, IsUnicode = true)]
        [PXUIField(DisplayName = "Start Time: Press")]
        public virtual string StartTimePress
        {
            get;
            set;
        }
        #endregion

        #region ExitTimePress
        public abstract class exitTimePress : BqlString.Field<exitTimePress> { }

        [PXDBString(32, IsUnicode = true)]
        [PXUIField(DisplayName = "Exit Time: Press")]
        public virtual string ExitTimePress
        {
            get;
            set;
        }
        #endregion

        #region PressTimeMins
        public abstract class pressTimeMins : BqlInt.Field<pressTimeMins> { }

        [PXDBInt]
        [PXUIField(DisplayName = "Press Time (Mins)")]
        public virtual int? PressTimeMins
        {
            get;
            set;
        }
        #endregion

        #region CureTimeMins
        public abstract class cureTimeMins : BqlInt.Field<cureTimeMins> { }

        [PXDBInt]
        [PXUIField(DisplayName = "Cure Time (Mins)")]
        public virtual int? CureTimeMins
        {
            get;
            set;
        }
        #endregion

        #region GSM
        public abstract class gSM : BqlString.Field<gSM> { }

        [PXDBString(64, IsUnicode = true)]
        [PXUIField(DisplayName = "GSM")]
        public virtual string GSM
        {
            get;
            set;
        }
        #endregion

        #region Margins
        public abstract class margins : BqlString.Field<margins> { }

        [PXDBString(128, IsUnicode = true)]
        [PXUIField(DisplayName = "Margins")]
        public virtual string Margins
        {
            get;
            set;
        }
        #endregion

        #region SpeedMmin
        public abstract class speedMmin : BqlString.Field<speedMmin> { }

        [PXDBString(32, IsUnicode = true)]
        [PXUIField(DisplayName = "Speed (M/min)")]
        public virtual string SpeedMmin
        {
            get;
            set;
        }
        #endregion

        #region BatchNbrptA
        public abstract class batchNbrptA : BqlString.Field<batchNbrptA> { }

        [PXDBString(16, IsUnicode = true)]
        [PXUIField(DisplayName = "Batch Nbr (pt. A)")]
        public virtual string BatchNbrptA
        {
            get;
            set;
        }
        #endregion

        #region BatchNbrptB
        public abstract class batchNbrptB : BqlString.Field<batchNbrptB> { }

        [PXDBString(16, IsUnicode = true)]
        [PXUIField(DisplayName = "Batch Nbr (pt. B)")]
        public virtual string BatchNbrptB
        {
            get;
            set;
        }
        #endregion


        #region Who
        public abstract class who : BqlInt.Field<who> { }

        [PX.TM.Owner]
        [PXUIField(DisplayName = "Who")]
        public virtual int? Who
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
