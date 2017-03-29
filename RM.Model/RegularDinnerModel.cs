using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Model
{
    /// <summary>
    /// 套餐管理类
    /// </summary>
    public class RegularDinnerModel
    {
        /// <summary>
        /// 套餐编号，32位，guid
        /// </summary>
        public string RegularDinnerId { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string RegularDinnerName { get; set; }

        /// <summary>
        /// 套餐流量
        /// </summary>
        public decimal RegularDinnerFlowed { get; set; }

        /// <summary>
        /// 套餐结束时间
        /// </summary>
        public DateTime RegularDinnerEndTime { get; set; }

        /// <summary>
        /// 套餐状态，0，过期（禁用），1、正常，2作废
        /// </summary>
        public int Status { get; set; }

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
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
