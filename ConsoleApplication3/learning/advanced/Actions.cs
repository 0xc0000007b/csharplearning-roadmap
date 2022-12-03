using System;

namespace ConsoleApplication3
{
    public delegate void EventDelegate();
    public delegate void EventDelegate1();
    public class Actions
    {
        public event EventDelegate TestEvent;
        public event EventDelegate1 TestEvent1;

        public void OnTestEvent()
        {
            TestEvent?.Invoke();
        }

        public void OnTestEvent1()
        {
            TestEvent1?.Invoke();
        }
    }
}