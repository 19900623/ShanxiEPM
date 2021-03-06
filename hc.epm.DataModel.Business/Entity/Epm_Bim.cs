//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2018-05-14 14:26:50
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Epm_Bim:模型表
	///</summary>
	 public  class  Epm_Bim:BaseBusiness
	{ 
		///<summary>
		///项目表Id
		///</summary>
		public long? ProjectId { get; set; }

		///<summary>
		///项目名称
		///</summary>
		public string ProjectName { get; set; }

		///<summary>
		///模型名称
		///</summary>
		public string Name { get; set; }

		///<summary>
		///描述
		///</summary>
		public string Desciption { get; set; }

		///<summary>
		///版本号
		///</summary>
		public string VersionOrder { get; set; }

		///<summary>
		///版本标识Key
		///</summary>
		public string VersionNo { get; set; }

		///<summary>
		///版本标识Value
		///</summary>
		public string VersionName { get; set; }

		///<summary>
		///上传人Id
		///</summary>
		public long? SubmitUserId { get; set; }

		///<summary>
		///上传人Name
		///</summary>
		public string SubmitUserName { get; set; }

		///<summary>
		///上传单位Id
		///</summary>
		public long? SubmitCompanyId { get; set; }

		///<summary>
		///上传单位Name
		///</summary>
		public string SubmitCompanyName { get; set; }

		///<summary>
		///上传时间
		///</summary>
		public DateTime? SubmitDate { get; set; }

		///<summary>
		///设计单位Id
		///</summary>
		public long? DesignCompanyId { get; set; }

		///<summary>
		///设计单位Name
		///</summary>
		public string DesignCompanyName { get; set; }

		///<summary>
		///模型Id
		///</summary>
		public string BIMId { get; set; }

		///<summary>
		///模型地址
		///</summary>
		public string BIMAddress { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        public string BIMName { get; set; }

        /// <summary>
        /// 模型状态
        /// </summary>
        public string BIMState { get; set; }
        public string BIMImg { get; set; }

        ///<summary>
        ///是否最新 1是 0否
        ///</summary>
        public bool? IsNew { get; set; }

		///<summary>
		///状态[10待处理,20审核通过,30已驳回,40已废弃]枚举
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
        /// 版本是否有效
        /// </summary>
        public bool IsValidate { get; set; }

        public string BIMDBPath { get; set; }
    }
}

