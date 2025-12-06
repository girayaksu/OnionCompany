using System;

namespace OnionCompany.Application.Exceptions
{

    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}


