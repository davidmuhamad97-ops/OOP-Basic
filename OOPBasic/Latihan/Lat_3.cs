using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic.Latihan
{
    public class Lat_3
    {
        public static void main()
        {
            Email email = new Email("yanto", "Hello world", DateTime.Now, "Send", "");
            email.formatHeader();

            SMS sms = new SMS("yanto", "Hello world", DateTime.Now, "08123456789");
            sms.formatHeader();
        }
    }

    class Notification
    {
        public string Recipient { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public void formatHeader()
        {
            Console.WriteLine($"To: {Recipient}");
            Console.WriteLine($"Time: {Timestamp}");
        }

        public void send()
        {
            Console.WriteLine("Notification sent.");
        }
    }

    class SMS : Notification
    {
        private string phoneNumber;
        private const int MaxMessageLength = 160;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public SMS(string recipient, string message, DateTime timestamp, string phoneNumber)
        {
            Recipient = recipient;
            Message = message;
            Timestamp = timestamp;
            this.phoneNumber = phoneNumber;
        }
        public void send()
        {
            string maximumMessage = Message.Length > MaxMessageLength ? Message.Substring(0, MaxMessageLength) : Message;

            if (Message.Length > MaxMessageLength)
            {
                Console.WriteLine("Warning: Message exceeds maximum length. It will be truncated.");
            }

            Console.WriteLine($"Sending SMS to {Recipient} at {Timestamp}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            
        }
    }

    class Email : Notification
    {
        private string subject;
        private string body;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public Email(string recipient, string message, DateTime timestamp, string subject, string body)
        {
            Recipient = recipient;
            Message = message;
            Timestamp = timestamp;
            this.subject = subject;
            this.body = body;
        }

        public void send()
        {
            Console.WriteLine($"Sending Email to {Recipient} at {Timestamp}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
        }
    }
}
