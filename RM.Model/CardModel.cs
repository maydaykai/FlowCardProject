using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Model
{
    /// <summary>
    /// 卡管理类
    /// </summary>
    public class CardModel
    {
        /// <summary>
        /// 主键32位，guid 小写
        /// </summary>
        public string CardId { get; set; }

        /// <summary>
        /// 卡编号
        /// </summary>
        public string ICCID { get; set; }

        /// <summary>
        /// 代理ID
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 使用类型,普通企业账号等
        /// </summary>
        public string EmployType { get; set; }

        /// <summary>
        /// 运营商
        /// </summary>
        public string MNO { get; set; }

        /// <summary>
        /// 套餐ID  来自套餐管理
        /// </summary>
        public string RegularDinnerId { get; set; }

        /// <summary>
        /// 用户码
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// 卡片状态：0无状态，1测试期,2沉默期，3已激活，4停机，5作废
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 套餐结束时间
        /// </summary>
        public DateTime RegularEndTime { get; set; }

        /// <summary>
        /// 开通时长（月）
        /// </summary>
        public int OpenDeadline { get; set; }


        /// <summary>
        /// 总流量
        /// </summary>
        public decimal SumFlowed { get; set; }

        /// <summary>
        /// 使用流量
        /// </summary>
        public decimal EmployFlowed { get; set; }

        /// <summary>
        /// 剩余流量
        /// </summary>
        public decimal ResidualFlowed { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchNumber { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateUserId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// 材质：1普通卡，2工业卡
        /// </summary>
        public int MaterialId { get; set; }

        /// <summary>
        /// 是否流量共享：false不共享，true共享
        /// </summary>
        public bool IsFlowedShare { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 能否次月变更：0否，1能
        /// </summary>
        public bool IsNextMonthChange { get; set; }

        /// <summary>
        /// 预警流量
        /// </summary>
        public decimal WarningFlowed { get; set; }

        /// <summary>
        /// 预警手机号
        /// </summary>
        public string WarningMobile { get; set; }

    }
}
