using Com.Hopper.Hts.Airlines.Flow.Model;
using Com.Hopper.Hts.Airlines.Spreedly.Api;
using Com.Hopper.Hts.Airlines.Api;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using Com.Hopper.Hts.Airlines.Spreedly.Model;
using System;
using Com.Hopper.Hts.Airlines.Client;
using System.Threading.Tasks;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface ICfarFlow
    {
        Task<ApiModel.CfarContract> UpdateCfarContractWithFormsOfPayment(string contractReference, UpdateCfarContractFormsOfPaymentRequest request, bool shouldTokenize, string? sessionId);
    }

    public partial class CfarFlow : ICfarFlow
    {

        internal FormOfPaymentToApi _formOfPaymentToApi;
        internal ICancelForAnyReasonCFARApi _cfarApi;

        public CfarFlow(FormOfPaymentToApi formOfPaymentToApi, ICancelForAnyReasonCFARApi cfar)
        {
            _formOfPaymentToApi = formOfPaymentToApi;
            _cfarApi = cfar;
        }

        public async Task<ApiModel.CfarContract> UpdateCfarContractWithFormsOfPayment(string contractReference, UpdateCfarContractFormsOfPaymentRequest request, bool shouldTokenize, string? sessionId)
        {
            var fops = new List<ApiModel.FormOfPayment>();
            foreach (var p in request.FormsOfPayment)
            {
                fops.Add(_formOfPaymentToApi.ToApi(p, shouldTokenize: shouldTokenize));
            }
            var paymentRequest = new ApiModel.UpdateCfarFormOfPaymentRequest(fops);

            var task = await _cfarApi.PutCfarContractsIdFormsOfPaymentAsync(contractReference, paymentRequest, sessionId ?? new Option<string>());
            return task.Ok() ?? throw new InvalidOperationException("CFAR API response is null or invalid.");
        }
    }
}