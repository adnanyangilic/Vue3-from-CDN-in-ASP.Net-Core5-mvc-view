using System;

namespace Vue3_from_CDN_in_ASP.Net_Core5_mvc_view.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
