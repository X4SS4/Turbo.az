using TurboAz.Models.Users.Base;
using System;
using TurboAz.Entities.Users.States.BaseState;

namespace TurboAz.Entities.Users.States
{
    public class UserState : BaseUserState
    {
        public UserState(UserBase userBase) : base(userBase) { }

        public override void SigIn()
        {
            throw new NotImplementedException();
        }
    }
}
