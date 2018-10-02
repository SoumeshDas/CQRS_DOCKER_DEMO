namespace Actio.Common.Command
{
    public class AuthenticateUser:ICommand
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}