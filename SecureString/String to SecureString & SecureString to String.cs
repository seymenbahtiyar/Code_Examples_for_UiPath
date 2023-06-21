namespace HelloWorld;

using System;
using System.Globalization;
using System.Threading;
using System.Net;
using System.Security;

class Program4
{
    static void test(string[] args)
    {
        // Şifrenizi buraya yazın.
        string var_str_Password = "password";

        // Şifrenizi SecureString'e dönüştürün.
        System.Security.SecureString var_securestr_Password = new System.Security.SecureString();
        var_securestr_Password = new System.Net.NetworkCredential("", var_str_Password).SecurePassword;

        // Şifrenizi tekrar string'e dönüştürün.
        var_str_Password = new System.Net.NetworkCredential("", var_securestr_Password).Password;

    }
}
