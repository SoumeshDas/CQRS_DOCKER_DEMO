using System;

namespace Actio.Common.Command
{
    public class UserActivity:IActivityCommand
    {
        public int Id { get; set; }
        public Guid UserId { get;set; }
        public string  Description { get; set; }
        public string Name { get; set; }    
        public string EmailId { get; set; }
        public DateTime CreatedAt { get; set; }   
    }
}