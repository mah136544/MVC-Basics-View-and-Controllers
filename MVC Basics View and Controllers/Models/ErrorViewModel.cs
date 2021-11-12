using System;

namespace MVC_Basics_View_and_Controllers.Models
{
    public class ErrorViewModel
    {
        public String RequestId { get; set; }
        public bool ShowRequestId => !String.IsNullOrEmpty(RequestId);

    }

}