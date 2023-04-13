using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Behavioral.NullObject
{
    class NullState : IState
    {
        public MyContext Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DoSomething()
        {
        }

        public void SwitchState()
        {
        }
    }
}
