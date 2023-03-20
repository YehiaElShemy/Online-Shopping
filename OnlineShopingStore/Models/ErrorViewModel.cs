using System;

namespace OnlineShopingStore.Models
{
    public class ErrorViewModel
    {

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
