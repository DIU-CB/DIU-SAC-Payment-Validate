//using NPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Payment_Module.Models
{
    public class PaymentResponse
    {
        [Key]
        
        public string reff_id { get; set; }
        
        public string user_id { get; set; }
        public string ApplicationId { get; set; }
        public string status { get; set; }

        public DateTime? tran_date { get; set; }

        public int? tran_id { get; set; }

        public string val_id { get; set; }
        
        public double? amount { get; set; }
       
        public string store_amount { get; set; }

        public string currency { get; set; }

        public string bank_tran_id { get; set; }

        public string card_type { get; set; }

        public string card_no { get; set; }

        public string card_issuer { get; set; }

        public string card_brand { get; set; }

        public string card_issuer_country { get; set; }
        public string card_issuer_country_code { get; set; }
        public string currency_type { get; set; }
        public double? currency_amount { get; set; }
        public double? currency_rate { get; set; }

        public double? base_fair { get; set; }

        public string value_a { get; set; }
        public string value_b { get; set; }
        public string value_c { get; set; }
        public string value_d { get; set; }
        public int? emi_instalment { get; set; }
        public double? emi_amount { get; set; }
        public string emi_description { get; set; }
        public string emi_issuer { get; set; }
        public string account_details { get; set; }
        public string risk_title { get; set; }
        public int? risk_level { get; set; }
        public string APIConnect { get; set; }
        public DateTime? validated_on { get; set; }
        public string gw_version { get; set; }
        
       
       
      
       
    }
}
