//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2018-08-30 10:34:07
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Business
{ 
    ///<summary>
    ///Epm_AppVersion: APP 版本管理
    ///</summary>
     public  class  Epm_AppVersion: BaseBusiness
    { 
        ///<summary>
        /// APP 包名
        ///</summary>
        public string AppNum { get; set; }

        ///<summary>
        /// APP 名称
        ///</summary>
        public string AppName { get; set; }

        ///<summary>
        /// APP 版本名称
        ///</summary>
        public string VersionSn { get; set; }

        ///<summary>
        /// APP 版本号
        ///</summary>
        public string VersionCode { get; set; }

        public int AppType { get; set; }

        ///<summary>
        /// 更新地址
        ///</summary>
        public string Url { get; set; }

        ///<summary>
        /// 更新日志
        ///</summary>
        public string UpdateLog { get; set; }

        ///<summary>
        /// 是否强制更新
        ///</summary>
        public bool IsForced { get; set; }

        ///<summary>
        /// 是否当前版本
        ///</summary>
        public bool IsCurrentVersion { get; set; }

        ///<summary>
        /// 状态 0：未发布， 1 已发布， 2 已下架
        ///</summary>
        public int State { get; set; }

        ///<summary>
        /// 发布时间
        ///</summary>
        public DateTime? PublishedTime { get; set; }

    }
}

