using Com.Hopper.Hts.Airlines.Api;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface IDgFlow
    {
        Task<ApiModel.DgContract> UpdateDgContractStatus(string contractId, Model.UpdateDgContractStatusRequest request, bool shouldTokenize);
    }

    public partial class DgFlow : IDgFlow
    {
        internal IFormOfPaymentToApi _formOfPaymentToApi;
        internal IDisruptionGuaranteeDGApi _dgApi;

        public DgFlow(IFormOfPaymentToApi formOfPaymentToApi, IDisruptionGuaranteeDGApi dg)
        {
            _formOfPaymentToApi = formOfPaymentToApi;
            _dgApi = dg;
        }

        public async Task<ApiModel.DgContract> UpdateDgContractStatus(string contractId, Model.UpdateDgContractStatusRequest request, bool shouldTokenize)
        {
            var fops = new List<ApiModel.FormOfPayment>();
            foreach (var p in request.FormsOfPayment)
            {
                fops.Add(await _formOfPaymentToApi.ToApi(p, shouldTokenize: shouldTokenize));
            }
            var paymentRequest = new ApiModel.UpdateDgContractStatusRequest(
                status: request.Status,
                pnrReference: request.PnrReference,
                emailAddress: request.EmailAddress,
                phoneNumber: request.PhoneNumber,
                firstName: request.FirstName,
                lastName: request.LastName,
                addressLine1: request.AddressLine1,
                addressLine2: request.AddressLine2,
                city: request.City,
                stateOrProvince: request.StateOrProvince,
                postalCode: request.PostalCode,
                country: request.Country,
                taxesTotal: request.TaxesTotal,
                taxes: request.Taxes,
                formsOfPayment: fops
            );

            var task = await _dgApi.PutDgContractsIdUpdateStatusAsync(contractId, paymentRequest);
            return task.Ok() ?? throw new InvalidOperationException("DG API response is null or invalid.");
        }
    }
}