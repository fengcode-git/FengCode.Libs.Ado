﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FengCode.Libs.Ado
{
    /// <summary>
    /// 忽略特性
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = true)]
    public class IgnoreAttribute : Attribute
    {
    }
}
