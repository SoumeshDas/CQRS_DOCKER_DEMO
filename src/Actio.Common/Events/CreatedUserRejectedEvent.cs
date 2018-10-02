namespace Actio.Common.Events
{
    public class CreatedUserRejected : IRejectedEvent
    {
        public string Reason {get;}

        public string Code {get;}

        public string  Email { get;}

        protected CreatedUserRejected(){}

        public CreatedUserRejected(string reson,string code,string email){
            Reason=reson;
            Code=code;
            email=Email;
        }
        
    }

}