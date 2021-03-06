﻿using System;

namespace ByteartRetailMini.Domain.Models
{
    [Serializable]
    public class Role : DomainObject
    {
        /// <summary>
        /// 获取或设置角色名称。
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 获取或设置角色描述。
        /// </summary>
        public virtual string Description { get; set; }
    }
}