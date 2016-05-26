using System.Collections.Generic;

namespace Mobile.Models.Pages
{
    public class MyPayslip : BaseModel
    {
        /// <summary>
        /// Payslip Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Net Pay
        /// </summary>
        public string NetPay { get; set; }

        /// <summary>
        /// Payroll Earnings
        /// </summary>
        public List<PayslipItem> Earnings { get; set; }

        /// <summary>
        /// Payroll Deductions
        /// </summary>
        public List<PayslipItem> Deductions { get; set; }

        /// <summary>
        /// Payroll YTD Items
        /// </summary>
        public List<PayslipItem> ToDate { get; set; }

        /// <summary>
        /// Model contains payslip details
        /// </summary>
        public bool HasPayslip { get; set; }
    }

    public class PayslipItem
    {
        /// <summary>
        /// Label as show on the payslip
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Value as show on the payslip
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// SortPosition
        /// </summary>
        public int SortPosition { get; set; }

        /// <summary>
        /// PayslipGroup
        /// </summary>
        public string PayslipGroup { get; set; }
    }
}
