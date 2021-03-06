//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2018-05-14 14:26:51
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Epm_Milepost:里程碑表
	///</summary>
	 public  class  Epm_Milepost:BaseBusiness
	{ 
		///<summary>
		///父级Id
		///</summary>
		public long? ParentId { get; set; }

		///<summary>
		///编码
		///</summary>
		public string Code { get; set; }

		///<summary>
		///名称
		///</summary>
		public string Name { get; set; }

		///<summary>
		///说明
		///</summary>
		public string Description { get; set; }

		///<summary>
		///排序
		///</summary>
		public int? Sort { get; set; }

		///<summary>
		///预留与本省系统对接
		///</summary>
		public string Code1 { get; set; }

		///<summary>
		///预留与本省系统对接
		///</summary>
		public string Code2 { get; set; }

		///<summary>
		///预留与本省系统对接
		///</summary>
		public string Code3 { get; set; }

		///<summary>
		///预留与本省系统对接
		///</summary>
		public string Code4 { get; set; }

		///<summary>
		///预留与本省系统对接
		///</summary>
		public string Code5 { get; set; }

		///<summary>
		///状态
		///</summary>
		public int? State { get; set; }

		///<summary>
		///备注
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///创建单位Id
		///</summary>
		public long? CrtCompanyId { get; set; }

		///<summary>
		///创建单位Name
		///</summary>
		public string CrtCompanyName { get; set; }

        /// <summary>
        /// 工期
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// 需要人数
        /// </summary>
        public int Population { get; set; }

    }
}

