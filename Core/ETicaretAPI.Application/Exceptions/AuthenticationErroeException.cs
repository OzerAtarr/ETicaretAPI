using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Exceptions
{
    public class AuthenticationErroeException : Exception
    {
        public AuthenticationErroeException() :base("Kullanıcı veya kimlik Doğrulama hatası!")
        {
        }

        public AuthenticationErroeException(string? message) : base(message)
        {
        }

        public AuthenticationErroeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
