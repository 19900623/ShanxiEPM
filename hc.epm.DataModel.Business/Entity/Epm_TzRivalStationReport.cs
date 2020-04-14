//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2019-09-02 13:52:36
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Epm_TzRivalStationReport:
	///</summary>
	 public  class  Epm_TzRivalStationReport:BaseBusiness
	{ 
		///<summary>
		///标题
		///</summary>
		public string Title { get; set; }

		///<summary>
		///申报人
		///</summary>
		public string ApplyUser { get; set; }

		///<summary>
		///申报人id
		///</summary>
		public long? ApplyUserId { get; set; }

		///<summary>
		///申报日期
		///</summary>
		public DateTime? ApplyDate { get; set; }

		///<summary>
		///所属单位
		///</summary>
		public string CompanyName { get; set; }

		///<summary>
		///所属单位ID
		///</summary>
		public long? CompanyId { get; set; }

		///<summary>
		///所属部门
		///</summary>
		public string Department { get; set; }

		///<summary>
		///所属部门ID
		///</summary>
		public long? DepartmentId { get; set; }

		///<summary>
		///统计截至日期
		///</summary>
		public DateTime? TotalEndDate { get; set; }

		///<summary>
		///地市编码
		///</summary>
		public string CityCode { get; set; }

		///<summary>
		///地市
		///</summary>
		public string City { get; set; }

		///<summary>
		///加油站总数
		///</summary>
		public int? OilStationSum { get; set; }

		///<summary>
		///全省运营加油站站总数
		///</summary>
		public int? OilStaNum { get; set; }

		///<summary>
		///全省运营加气站总数-CNG
		///</summary>
		public int? GasStaNumCNG { get; set; }

		///<summary>
		///全省运营加气站总数-LNG
		///</summary>
		public int? GasStaNumLNG { get; set; }

		///<summary>
		///中石油总数
		///</summary>
		public int? ZsyStaSum { get; set; }

		///<summary>
		///中石油加油站运营数
		///</summary>
		public int? ZsyOilStaNum { get; set; }

		///<summary>
		///中石油-CNG加气站
		///</summary>
		public int? ZsyGasStaNumCNG { get; set; }

		///<summary>
		///中石油-LNG加气站
		///</summary>
		public int? ZsyGasStaNumLNG { get; set; }

		///<summary>
		///中石化总数
		///</summary>
		public int? ZshStaSum { get; set; }

		///<summary>
		///中石化加油站运营数
		///</summary>
		public int? ZshOilStaNum { get; set; }

		///<summary>
		///中石化-CNG加气站
		///</summary>
		public int? ZshGasStaNumCNG { get; set; }

		///<summary>
		///中石化-LNG加气站
		///</summary>
		public int? ZshGasStaNumLNG { get; set; }

		///<summary>
		///延长壳牌总数
		///</summary>
		public int? YcqpStaSum { get; set; }

		///<summary>
		///延长壳牌加油站运营数
		///</summary>
		public int? YcqpOilStaNum { get; set; }

		///<summary>
		///延长壳牌-CNG加气站
		///</summary>
		public int? YcqpGasStaNumCNG { get; set; }

		///<summary>
		///延长壳牌-LNG加气站
		///</summary>
		public int? YcqpGasStaNumLNG { get; set; }

		///<summary>
		///延长石油总数
		///</summary>
		public int? YcsyStaSum { get; set; }

		///<summary>
		///延长石油加油站运营数
		///</summary>
		public int? YcsyOilStaNum { get; set; }

		///<summary>
		///延长石油-CNG加气站
		///</summary>
		public int? YcsyGasStaNumCNG { get; set; }

		///<summary>
		///延长石油-LNG加气站
		///</summary>
		public int? YcsyGasStaNumLNG { get; set; }

		///<summary>
		///社会站总数
		///</summary>
		public int? ShzStaSum { get; set; }

		///<summary>
		///社会站加油站运营数
		///</summary>
		public int? ShzOilStaNum { get; set; }

		///<summary>
		///社会站-CNG加气站
		///</summary>
		public int? ShzGasStaNumCNG { get; set; }

		///<summary>
		///社会站-LNG加气站
		///</summary>
		public int? ShzGasStaNumLNG { get; set; }

		///<summary>
		///备注
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///部门负责人id
		///</summary>
		public long? DepLeaderId { get; set; }

		///<summary>
		///部门负责人
		///</summary>
		public string DepLeaderName { get; set; }

		///<summary>
		///分管领导id
		///</summary>
		public long? LeaderId { get; set; }

		///<summary>
		///分管领导
		///</summary>
		public string LeaderName { get; set; }

		///<summary>
		///当前状态
		///</summary>
		public string StateType { get; set; }

		///<summary>
		///状态编码
		///</summary>
		public string StateName { get; set; }

		///<summary>
		///签字意见
		///</summary>
		public string SignIdea { get; set; }

        /// <summary>
        /// 当前审批人
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 当前审批人Id
        /// </summary>
        public string ApprovalNameId { get; set; }

        /// <summary>
        /// 流程申请 ID
        /// </summary>
        public string WorkFlowId { get; set; }

        public int State { get; set; }

    }
}
