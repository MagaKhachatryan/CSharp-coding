using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelsImplementetion
{
    static public class Parallel<T>
    {
        public static void ForEach<T>(IEnumerable<T> items, Action<T> action)
        {
            if (items == null)
                throw new ArgumentNullException("enumerable");
            if (action == null)
                throw new ArgumentNullException("action");

            var resetEvents = new List<ManualResetEvent>();

            foreach (var item in items)
            {

                var evt = new ManualResetEvent(false);
                ThreadPool.QueueUserWorkItem((i) =>
                {
                    action((T)i);
                    evt.Set();
                }, item);
                 resetEvents.Add(evt);
            }

            foreach (var re in resetEvents)
                re.WaitOne();
        }
    }
}
