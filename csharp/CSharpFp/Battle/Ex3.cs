using System;
using System.Text.RegularExpressions;

namespace Battle
{
    public interface Result { }

    public class Success : Result { }

    public class Failure : Result
    {
        public string ErrorMsg { get; }
        public Failure(string errorMsg) => ErrorMsg = errorMsg;
    }

    public class EmailValidation
    {
        static Func<string, bool> matches = email => Regex
            .Match(email, "^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$")
            .Success;

        static Func<string, Result> EmailChecker => email =>
        {
            if (string.IsNullOrEmpty(email))
            {
                return new Failure("email must not be null or empty");
            }
            else if (matches(email))
            {
                return new Success();
            }
            else return new Failure($"email '{email}' was invalid");
        };

        private static void LogError(string errMsg)
            => Console.Error.WriteLine($"Error message logged: {errMsg}");

        private static void SendVerificationMail(string email)
            => Console.WriteLine($"Mail sent to: {email}");

        public static Action Validate(string email)
        {
            var result = EmailChecker(email);
            return result is Success
                ? new Action(() => SendVerificationMail(email))
                : new Action(() => LogError((result as Failure).ErrorMsg));

        }
    }
}



