using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.map.get.by.extentity
    /// </summary>
    public class WlbItemMapGetByExtentityRequest : BaseTopRequest<Top.Api.Response.WlbItemMapGetByExtentityResponse>
    {
        /// <summary>
        /// 外部实体类型对应的商品id
        /// </summary>
        public Nullable<long> ExtEntityId { get; set; }

        /// <summary>
        /// 外部实体类型： IC_ITEM--ic商品 IC_SKU--ic销售单元
        /// </summary>
        public string ExtEntityType { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.wlb.item.map.get.by.extentity";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ext_entity_id", this.ExtEntityId);
            parameters.Add("ext_entity_type", this.ExtEntityType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ext_entity_id", this.ExtEntityId);
            RequestValidator.ValidateRequired("ext_entity_type", this.ExtEntityType);
        }

        #endregion
    }
}