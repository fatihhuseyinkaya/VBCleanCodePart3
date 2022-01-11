using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Büyük sistemler küçüklere değil küçük sistemler büyüklere bağlanmalı.
             */
            Report rapor = new Report(new MailSender());
            Report report = new Report(new SlackSender());

        }
    }

    public class Report
    {
        private ISender mailSender;
        public Report(ISender mailSender)
        {
            this.mailSender = mailSender;
        }
        public void SendMail()
        {
            
            mailSender.Sender();
        }
    }

    public interface ISender
    {
        void Sender();

    }
    public class MailSender :ISender
    {
        public void Sender()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class SlackSender : ISender
    {
        public void Sender()
        {
            Console.WriteLine("Slack message gönderildi");
        }
    }

    public class WSSender : ISender
    {
        public void Sender()
        {
            Console.WriteLine("Whatsapp message gönderildi");
        }
    }
}
