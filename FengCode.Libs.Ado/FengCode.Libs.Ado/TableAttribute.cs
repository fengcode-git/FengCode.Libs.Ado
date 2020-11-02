using System;
using System.Collections.Generic;
using System.Text;

namespace FengCode.Libs.Ado
{
    /// <summary>
    /// 表特性
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        /// <summary>
        /// 表名称
        /// </summary>
        public string Name { get; set; }
    }
}
