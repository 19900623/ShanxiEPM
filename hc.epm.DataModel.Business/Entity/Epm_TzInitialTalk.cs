//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2019-08-22 16:32:49
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Epm_TzInitialTalk: 初次谈判
	///</summary>
	 public  class  Epm_TzInitialTalk:BaseBusiness
	{
        public Epm_TzInitialTalk()
        {
            TzAttachs = new List<Epm_TzAttachs>();
        }

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
		public decimal? Fees { get; set; }

		///<summary>
		///
		///</summary>
		public DateTime? FeesTime { get; set; }

		///<summary>
		///
		///</summary>
		public string OurSide { get; set; }

		///<summary>
		///
		///</summary>
		public string OtherSide { get; set; }

		///<summary>
		///
		///</summary>
		public string TalkResultType { get; set; }

		///<summary>
		///
		///</summary>
		public string TalkResultName { get; set; }

		///<summary>
		///
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///
		///</summary>
		public int? State { get; set; }

        [NotMapped]
        public List<Epm_TzAttachs> TzAttachs { get; set; }

    }
}

