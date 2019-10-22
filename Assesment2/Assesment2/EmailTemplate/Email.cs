using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment2.EmailTemplate
{
    public static class Email
    {/// <summary>
     /// {0}:Username
     /// {1}:UserName
     /// {2}:Password
     /// {3}:VerificationCode
     /// </summary>
        public static string EmailTemplate = "Hi <b>{0}</b>,<br><br>Welcome to Theta Solutions. We are happy to see you have registered in our system.<br><br>Your registered username = {1} <br> Your Password = {2} <br><br>Regards,<br>Theta Team";
        public static string LoginTemplate = "Hi <b>{0}</b>,<br><br>Welcome to Theta Solutions. We are happy to see you have registered in our system.<br><br>Your registered username = {1}<br><br>Regards,<br>Theta Team";
        public static string ForgetPasswordTemplate = "Hi <b>{0}</b>,<br><br>Your Password has been Recovered successfully.<br><br>Your registered username = {1}<br> Your Password = {2} <br><br>Regards,<br>Theta Team";
        public static string TwoStepVerificationTemplate = "Hi <b></b>,<br><br>Your Verification Code is:{3}<br><br><br>Regards,<br>Theta Team";

    }

}
