﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Qinweir.Application.Contracts
{
  public  class UpdateMaterialNameDTO
    {

     
        /// <summary>
        /// 材料类型
        /// </summary>
        public string MaterialsType { get; set; }
        /// <summary>
        /// 材料名称
        /// </summary>
        public string MaterialsName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string units { get; set; }
      
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }


    }
}
