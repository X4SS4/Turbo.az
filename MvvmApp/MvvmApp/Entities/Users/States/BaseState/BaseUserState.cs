using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Models.Users.Base;

namespace TurboAz.Entities.Users.States.BaseState
{
    public abstract class BaseUserState
    {
        protected UserBase userBase;
        public BaseUserState(UserBase userBase) => this.userBase = userBase;
       
        public abstract void SigIn();
    }
}
