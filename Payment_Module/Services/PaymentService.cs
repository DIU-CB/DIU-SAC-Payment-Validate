using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Payment_Module.DiuSac;
//using Payment_Module.Data;
using Payment_Module.Interface;
using Payment_Module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Module.Services
{
    public class PaymentService:IPayment
    {
        public readonly HttpClient _httpClient;
        private readonly PaymentDBContext _context;

        private readonly DIU_SACContext _SacContext;

        public PaymentService(HttpClient httpClient, PaymentDBContext context, DIU_SACContext SacContext)
        {
            _httpClient = httpClient;
            _context = context;
            _SacContext = SacContext;
        }

        public async Task<PaymentResponseBody> PaymentVerification(string reffId)
        {

            string token = "ceb263b97edc55698ab6fcf755ebcc1d";
            
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("reff_id",reffId),
                new KeyValuePair<string,string>("token",token)

            }
            );
            //var Json = JsonConvert.SerializeObject(body);

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var reqBody = new StringContent(Json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("", formContent);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();


                 PaymentResponseBody paymentRasponse= JsonConvert.DeserializeObject<PaymentResponseBody>(result);
                
                

                try
                {
                    var AlreadyExist = _context.Application_Payment.FirstOrDefault(x => x.reff_id == reffId);
                    if (AlreadyExist == null)
                    {
                        if (paymentRasponse.data.status == "VALID" || paymentRasponse.data.status == "VALIDATED")
                        {
                            string ApplicationId = reffId.Split(".")[1];
                            paymentRasponse.data.ApplicationId = ApplicationId;
                            var StudentApplication = _SacContext.Application.FirstOrDefault(x => x.Id == ApplicationId);

                            if (StudentApplication != null)
                            {
                                StudentApplication.Paid = true;
                                _SacContext.Application.Update(StudentApplication);
                                _SacContext.SaveChanges();


                            }

                            _context.Application_Payment.Add(paymentRasponse.data);
                            _context.SaveChanges();

                            paymentRasponse.message = "success";
                        }
                        else
                        {
                            paymentRasponse.message = "failed";
                            
                        }
                    }
                    else
                    {

                        paymentRasponse.message = "duplicate";
                        

                    }





                    return paymentRasponse;
                }
                catch
                {
                    paymentRasponse.message = "failed";

                    return paymentRasponse;
                }


            }
            else
            {
                PaymentResponseBody paymentRasponse = new PaymentResponseBody();
                paymentRasponse.message = "failed";
                return paymentRasponse;
            }

            

        }
    }
}
