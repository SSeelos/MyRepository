using MyLibrary.MyDesignPrinciples.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.Behavioral.NullObject
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
