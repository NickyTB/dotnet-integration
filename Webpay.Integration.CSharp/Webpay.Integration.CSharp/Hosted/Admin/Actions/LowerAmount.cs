using System.Xml;
using Webpay.Integration.CSharp.Hosted.Admin.Response;

namespace Webpay.Integration.CSharp.Hosted.Admin.Actions
{
    public class LowerAmount
    {
        public readonly long AmountToLower;
        public readonly long TransactionId;

        public LowerAmount(long transactionId, long amountToLower)
        {
            TransactionId = transactionId;
            AmountToLower = amountToLower;
        }

        public static LowerAmountResponse Response(XmlDocument responseXml)
        {
            return new LowerAmountResponse(responseXml);
        }
    }
}