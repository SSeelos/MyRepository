using System;
using System.Collections.Generic;

namespace MyLibrary.EventsAndDelegates_CodeMonkey
{
    public interface IPublisher { }
    public class MyPublisher
    {
        public event EventHandler OnEventTriggered;
        public event EventHandler<string> OnEventArgsTriggered;

        public event Action OnActionTriggered;
        public event Action<string, string> OnActionTriggeredArgs;
        public event Func<string> OnFuncTriggered;
        public event Func<string, string> OnFuncParamTriggered;

        public delegate void EventDelegate(string param);
        public event EventDelegate OnEventDelegateTriggered;

        private void TriggerEvent()
        {
            OnEventTriggered?.Invoke(this, EventArgs.Empty);
        }
        private void TriggerEventArgs(string param)
        {
            OnEventArgsTriggered?.Invoke(this, param);
        }
        private void TriggerAction()
        {
            OnActionTriggered?.Invoke();
        }
        private void TriggerAction(string param1, string param2)
        {
            OnActionTriggeredArgs?.Invoke(param1, param2);
        }
        private string TriggerFunc()
        {
            return OnFuncTriggered?.Invoke();
        }
        private List<string> TriggerFuncDyn()
        {
            var str = new List<string>();
            foreach (Delegate del in OnFuncTriggered?.GetInvocationList())
            {
                str.Add((string)del.DynamicInvoke());
            }
            return str;
        }
        private string TriggerFuncParam(string param)
        {
            return OnFuncParamTriggered?.Invoke(param);
        }
        private void TriggerEventDelegate(string param)
        {
            OnEventDelegateTriggered?.Invoke(param);
        }
        public void TriggerALL()
        {
            TriggerEvent();

            TriggerEventArgs("arg");

            TriggerAction();

            TriggerAction("arg1", "arg2");

            //returns only from the last subscriber
            string functResult = TriggerFunc();

            List<string> functResults = TriggerFuncDyn();

            //returns only from the last subscriber
            var funcResParam = TriggerFuncParam("arg");

            TriggerEventDelegate("param");
        }
    }
}
