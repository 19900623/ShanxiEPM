//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2017-08-04 08:45:08
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Basic
{ 
	///<summary>
	///Base_Dictionary:字典
	///</summary>
	 public  class  Base_Dictionary:BaseBusiness
	{ 
		///<summary>
		///编号
		///</summary>
		public string No { get; set; }

		///<summary>
		///名称
		///</summary>
		public string Name { get; set; }

		///<summary>
		///备注
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///启用=0，禁用=1
		///</summary>
		public bool IsEnable { get; set; }

		///<summary>
		///已确认=0，未确认=1
		///</summary>
		public bool IsConfirm { get; set; }

		///<summary>
		///类型
		///</summary>
		public string Type { get; set; }

	}
}

