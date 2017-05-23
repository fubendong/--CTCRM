using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.occupy.adjust
    /// </summary>
    public class InventoryOccupyAdjustRequest : BaseTopRequest<Top.Api.Response.InventoryOccupyAdjustResponse>
    {
        /// <summary>
        /// 商家外部订单号
        /// </summary>
        public string BizUniqueCode { get; set; }

        /// <summary>
        /// 商品初始库存信息： [{ "TBOrderCode":"淘宝交易号","TBSubOrderCode ":"淘宝子交易单号","originalStoreCode":"交易下单的仓库编码","storeCode":"要切换占用到的商家仓库编码"," scItemId ":"商品后端ID","scItemCode":"商品商家编码","inventoryType":"仓储类型","quantity":"新仓库的占用数量，如果不传，则取用原先的占用数"}]
        /// </summary>
        public string Items { get; set; }

        /// <summary>
        /// 业务操作时间
        /// </summary>
        public Nullable<DateTime> OperateTime { get; set; }

        /// <summary>
        /// 订单类型：B2C、B2B
        /// </summary>
        public string TbOrderType { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.inventory.occupy.adjust";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_unique_code", this.BizUniqueCode);
            parameters.Add("items", this.Items);
            parameters.Add("operate_time", this.OperateTime);
            parameters.Add("tb_order_type", this.TbOrderType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_unique_code", this.BizUniqueCode);
            RequestValidator.ValidateRequired("items", this.Items);
            RequestValidator.ValidateRequired("operate_time", this.OperateTime);
            RequestValidator.ValidateRequired("tb_order_type", this.TbOrderType);
        }

        #endregion
    }
}