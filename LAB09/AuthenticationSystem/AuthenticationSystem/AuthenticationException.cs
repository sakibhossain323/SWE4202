using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationSystem
{
    class AuthenticationException : Exception
    {
        public AuthenticationException(string msg) : base(msg)
        {

        }
    }

    class InvalidUserPassException : AuthenticationException
    {
        public InvalidUserPassException() : base("Invalid username or password")
        {

        }
    }

    class UsernameAlreadyExistsException : AuthenticationException
    {
        public UsernameAlreadyExistsException() : base("Username already exists")
        {

        }
    }

    class PasswordsDontMatchException : AuthenticationException
    {
        public PasswordsDontMatchException() : base("Passwords dont match")
        {

        }
    }

    class CredentialContainsCommaException : AuthenticationException
    {
        public CredentialContainsCommaException(string type) : base($"{type} cannot contain comma(,)")
        {

        }
    }

    class EmptyCredentialException : AuthenticationException
    {
        public EmptyCredentialException(string type) : base($"{type} cannot be empty")
        {

        }
    }
    
    class CredentialLengthException : AuthenticationException
    {
        public CredentialLengthException(string type, int length): base($"{type} must contain at least {length} characters")
        {

        }
    }
}
