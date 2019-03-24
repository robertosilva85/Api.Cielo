﻿using System.Collections.Generic;
using Api.Cielo.Lio.Domain.Enums;

namespace Api.Cielo.Lio.Domain.Modules.Payment
{
    public class PaymentResponse: Payment
    {
        public string Url { get; set; }
        public string AuthenticationUrl { get; set; }
        public string ProofOfSale { get; set; }
        public string Tid { get; set; }
        public string AuthorizationCode { get; set; }
        public string PaymentId { get; set; }
        public int? Status { get; set; }
        public ReturnCodeEnumerator ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}