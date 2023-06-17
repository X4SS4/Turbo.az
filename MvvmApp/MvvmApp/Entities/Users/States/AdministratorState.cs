using TurboAz.Models.Users.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Entities.Users.States.BaseState;

namespace TurboAz.Entities.Users.States
{
    public class AdministratorState : BaseUserState
    {
        public AdministratorState(UserBase userBase) : base(userBase) { }

        public override void SigIn()
        {
            throw new NotImplementedException();
        }
    }
}
