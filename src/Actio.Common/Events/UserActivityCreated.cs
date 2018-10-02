using System;

namespace Actio.Common.Events{
    public class UserActivityCreatedEvent : IActivityEvent
    {
        public Guid UserId {get;}

        public int Id { get;  }
        public string  Description { get;  }
        public string Name { get;  }    
        public string EmailId { get;  }
        public DateTime CreatedAt { get;  }   

        protected UserActivityCreatedEvent(){}

        public UserActivityCreatedEvent(string userid ,int id ,string  description ,string name,
        string emailid , DateTime createdat )
        {
            UserId=new  Guid(userid);
            Id=id;
            Description=description;
            Name=name;
            EmailId=emailid;
            CreatedAt=createdat;
        }

    }
}