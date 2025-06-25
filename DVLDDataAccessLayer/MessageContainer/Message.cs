using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.MessageContainer
{
    public class Message
    {
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }

        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);
        public bool HasSuccess => !string.IsNullOrWhiteSpace(SuccessMessage);

        public static Message FromError(string error) => new Message { ErrorMessage = error };
        public static Message FromSuccess(string success) => new Message { SuccessMessage = success };
    }
}
