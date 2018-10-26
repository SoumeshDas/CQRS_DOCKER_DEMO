using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Command
{
    interface IAuthenticateCommand:ICommand
    {
         Guid UserId { get; set; }
    }
}
