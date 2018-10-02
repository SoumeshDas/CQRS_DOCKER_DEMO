using System;
using Actio.Common.Command;

public interface IActivityCommand:ICommand 
    {
         Guid UserId { get; set; }
    }
