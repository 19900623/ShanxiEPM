//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2017-08-14 10:19:38
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Msg
{
    ///<summary>
    ///Msg_SMSValidate:短信验证码
    ///</summary>
    public class  Msg_SMSValidate: BaseMsg
    { 
		///<summary>
		///短信主体
		///</summary>
		public long SMSId { get; set; }

		///<summary>
		///验证类型
		///</summary>
		public string ValidateType { get; set; }

		///<summary>
		///发送人
		///</summary>
		public long SendId { get; set; }

		///<summary>
		///接收人
		///</summary>
		public long ReceiveId { get; set; }

		///<summary>
		///接收手机
		///</summary>
		public string ReceivePhone { get; set; }

		///<summary>
		///验证码
		///</summary>
		public string Code { get; set; }

		///<summary>
		///验证状态
		///</summary>
		public string State { get; set; }

		///<summary>
		///发送时间
		///</summary>
		public DateTime SendTime { get; set; }

		///<summary>
		///过期时间
		///</summary>
		public DateTime ExpiredTime { get; set; }

	}
}

