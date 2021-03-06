﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingSystem.Models
{
    public class SaleRecord
    {
        /// <summary>
        /// 售卖记录主键
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public int UserId { get; set; }
        /// <summary>
        /// 售卖时间
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public DateTime SaleTime { get; set; }
        /// <summary>
        /// 售卖价格
        /// </summary>
        [SugarColumn(IsNullable = false)]

        public Double SalePrice { get; set; }
    }
}