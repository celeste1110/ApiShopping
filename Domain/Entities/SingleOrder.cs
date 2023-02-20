using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class SingleOrder
    {
        public int orderCode { get; set; }
        public int crewCount { get; set; }
        public int daysCount { get; set; }
        public string dateSail { get; set; }
        public string dateArrival { get; set; }
        public string solpedNumber { get; set; }
        public string dateOrder { get; set; }
        public string commentary { get; set; }
        public string personalName { get; set; }
        public string personalCode { get; set; }
        public int status { get; set; }
        public double totalAmount { get; set; }
        public int boatCode { get; set; }
        public int supplyCode { get; set; }
        public int cardCode { get; set; }
        public int branchCode { get; set; }
        public string boatName { get; set; }
        public double dailyFactor { get; set; }
        public double dailyFactorSpecial { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string confirmationDate { get; set; }
        public string boughtDate { get; set; }
        public string boughtInitDate { get; set; }
        public int attentionPortCode { get; set; }
        public string deliveryCommentary { get; set; }
        public string deliveryDate { get; set; }
        public string receivedCommentary { get; set; }
        public string receivedDate { get; set; }
        public string recevicedQualify { get; set; }
        public string createFor { get; set; }
        public IEnumerable<OrderDetail> detail { get; set; }
    }
}
