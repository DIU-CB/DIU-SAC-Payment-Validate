using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Payment_Module.Interface;
using Payment_Module.Models;
using Payment_Module.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PaymentModule_StudentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentPushController : ControllerBase
    {
        private readonly IPayment _payment;
        

        public PaymentPushController(IPayment payment,HttpClient httpClient)
        {
            _payment = payment;
            

        }
        [HttpPost("/PaymentFromFront")]
        public async  Task<IActionResult> PaymentFromFront([FromBody] PaymentBodyFromFront paymentBodyFromFront)
        {
            Random ranfom = new Random();


            paymentBodyFromFront.reff_id= paymentBodyFromFront.reff_id+ ranfom.Next(1, 10000).ToString();


            var _httpClient = new HttpClient();
          
            var Json = JsonConvert.SerializeObject(paymentBodyFromFront);
            
            var reqBody = new StringContent(Json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(new Uri("https://api.1card.com.bd/diudocumentpayment/pay"), reqBody);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Ok(result);
            }
            return BadRequest("Error Generating Payment Link");

        }
        
        [HttpPost]
        public async Task<IActionResult> PaymentPush([FromForm]PaymentInfo paymentInfo)
        {
            
            PaymentResponseBody result=await _payment.PaymentVerification(paymentInfo.reff_id);
            

            return Ok(new { message = result.message });
            
        }
    }
}
