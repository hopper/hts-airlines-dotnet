using Com.Hopper.Hts.Airlines.Flow.Model;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface IPaymentFlow
    {
        void UpdateCfarContractWithFormsOfPayment(string sessionId, string contractReference, UpdateCfarContractFormsOfPaymentRequest request) {
            
        }
    }
}