using Com.Hopper.Hts.Airlines.Api;
using ApiModel = Com.Hopper.Hts.Airlines.Model;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Com.Hopper.Hts.Airlines.Flow
{
    public interface IDgFlow
    {
        Task<ApiModel.DgContract> UpdateDgContractStatus(string contractReference, Model.UpdateDgContractStatusRequest request, bool paymentCardTokenized);
    }

    public partial class DgFlow : IDgFlow
    {
        internal FormOfPaymentToApi _formOfPaymentToApi;
        internal IDisruptionGuaranteeDGApi _dgApi;

        public DgFlow(FormOfPaymentToApi formOfPaymentToApi, IDisruptionGuaranteeDGApi dg)
        {
            _formOfPaymentToApi = formOfPaymentToApi;
            _dgApi = dg;
        }

        public async Task<ApiModel.DgContract> UpdateDgContractStatus(string contractReference, Model.UpdateDgContractStatusRequest request, bool paymentCardTokenized)
        {
            var fops = new List<ApiModel.FormOfPayment>();
            foreach (var p in request.FormsOfPayment)
            {
                fops.Add(_formOfPaymentToApi.ToApi(p, shouldTokenize: paymentCardTokenized));
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

            var task = await _dgApi.PutDgContractsIdUpdateStatusAsync(contractReference, paymentRequest);
            return task.Ok() ?? throw new InvalidOperationException("DG API response is null or invalid.");
        }
    }
}