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
using System.ComponentModel.DataAnnotations.Schema;

namespace hc.epm.DataModel.Basic
{
    ///<summary>
    ///Base_TypeDictionary:
    ///</summary>
    public class Base_TypeDictionary : BaseBusiness
    {
        ///<summary>
        ///
        ///</summary>
        public long PId { get; set; }

        /// <summary>
        /// 父级名称,列表显示使用
        /// </summary>
        [NotMapped]
        public string PName { get; set; }
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
        ///类型
        ///</summary>
        public string Type { get; set; }


    }
}
