using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// InteligentMerchantPromo Data Structure.
    /// </summary>
    public class InteligentMerchantPromo : AlipayObject
    {
        /// <summary>
        /// 商户自运营活动，当promo_type='GENERAL_MERCHANT',该对象不能为空，其他类型无效
        /// </summary>
        [JsonProperty("general_promo")]
        public InteligentGeneralMerchantPromo GeneralPromo { get; set; }

        /// <summary>
        /// 子活动营销类型；枚举值：（GENERAL_MERCHANT：商户自运营活动）
        /// </summary>
        [JsonProperty("promo_type")]
        public string PromoType { get; set; }
    }
}
