using System;

namespace ConsoleApp1
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Email sent by Mail Service");
        }
    }
}