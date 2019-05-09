using System;

namespace Examples
{

    public class EventMemoryLick
    {
        public event EventHandler<MsgEventArgs> Msg;
       
    }

    public class ClassMemoryLick
    {
        public ClassMemoryLick(EventMemoryLick item)
        {
            
            item.Msg += handler1;
        }
        public void handler1(object sender, MsgEventArgs e)
        {
            Console.WriteLine(e.msg);
        }

       
    }

    public class MsgEventArgs: EventArgs
    {
        public string msg {get;  set; }
    }


}
