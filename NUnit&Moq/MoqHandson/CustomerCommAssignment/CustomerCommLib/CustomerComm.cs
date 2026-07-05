namespace CustomerCommLib
{
    public class CustomerComm
    {
        private readonly IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            // Customer email and message
            string email = "cust123@abc.com";
            string message = "Some Message";

            // Call the dependency
            _mailSender.SendMail(email, message);

            return true;
        }
    }
}