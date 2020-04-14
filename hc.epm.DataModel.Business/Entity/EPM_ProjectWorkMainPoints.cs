//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2018-08-14 08:57:51
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Business
{
    ///<summary>
    ///EPM_ProjectWorkMainPoints:
    ///</summary>
    public class Epm_ProjectWorkMainPoints : BaseBusiness
    {
        ///<summary>
        ///项目Id
        ///</summary>
        public long? ProjectId { get; set; }

        ///<summary>
        ///工程内容
        ///</summary>
        public string WorkMain { get; set; }

        ///<summary>
        ///工程内容
        ///</summary>
        public string WorkMainValues { get; set; }

        ///<summary>
        ///是否计费
        ///</summary>
        public string Unit { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }

        ///<summary>
        ///厂家
        ///</summary>
        public long? CompanyId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string CompanyName { get; set; }

        ///<summary>
        ///数量
        ///</summary>
        public decimal? Qty { get; set; }

        ///<summary>
        ///备注
        ///</summary>
        public string Description { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Val { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DicValue { get; set; }

    }
}
