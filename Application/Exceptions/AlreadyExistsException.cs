using System;
using Domain;

namespace Application.Exceptions
{
    public class AlreadyExistsException : DomainException
    {
        public AlreadyExistsException() : base("Entity already exists")
        {
            
        }

        public AlreadyExistsException(string message) : base(message)
        {
            
        }
        
        public AlreadyExistsException(string entity, string property, string value) : base($"{entity} with {property}={value} already exists.")
        {
            
        }
    }
}