//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2019-08-23 15:59:07
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace hc.epm.DataModel.Business
{
    ///<summary>
    ///Epm_TzTalkRecord: 评审会记录
    ///</summary>
    public class  Epm_TzTalkRecord:BaseBusiness
	{
        public Epm_TzTalkRecord()
        {
            TzTalkLeaderSign = new Epm_TzTalkLeaderSign();
            TzTalkSign = new List<Epm_TzTalkSign>();
            TzTalkRecordConfirm = new Epm_TzTalkRecordConfirm();
            TzAttachs = new List<Epm_TzAttachs>();
        }

        ///<summary>
        ///
        ///</summary>
        public long? DataId { get; set; }

		///<summary>
		///
		///</summary>
		public long? ProjectId { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectName { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectCodeInvest { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectCodeWhole { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectCodeProject { get; set; }

		///<summary>
		///
		///</summary>
		public DateTime? TalkTime { get; set; }

		///<summary>
		///
		///</summary>
		public string TalkAdress { get; set; }

		///<summary>
		///
		///</summary>
		public string Compere { get; set; }

		///<summary>
		///
		///</summary>
		public string Expert { get; set; }

		///<summary>
		///
		///</summary>
		public string Attender { get; set; }

		///<summary>
		///
		///</summary>
		public string ConclusionType { get; set; }

		///<summary>
		///
		///</summary>
		public string ConclusionName { get; set; }

		///<summary>
		///
		///</summary>
		public string Content { get; set; }

		///<summary>
		///
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///
		///</summary>
		public string OperationTypeType { get; set; }

		///<summary>
		///
		///</summary>
		public string OperationTypeName { get; set; }

		///<summary>
		///
		///</summary>
		public string StateType { get; set; }

		///<summary>
		///
		///</summary>
		public string StateName { get; set; }

		///<summary>
		///
		///</summary>
		public int? State { get; set; }

        [NotMapped]
        public List<Epm_TzAttachs> TzAttachs { get; set; }

        /// <summary>
        /// 投资部门确认
        /// </summary>
        [NotMapped]
        public Epm_TzTalkRecordConfirm TzTalkRecordConfirm { get; set; }

        /// <summary>
        /// 评审会签
        /// </summary>
        [NotMapped]
        public List<Epm_TzTalkSign> TzTalkSign { get; set; }

        /// <summary>
        /// 省公司领导签发
        /// </summary>
        [NotMapped]
        public Epm_TzTalkLeaderSign TzTalkLeaderSign { get; set; }
        
    }
}

