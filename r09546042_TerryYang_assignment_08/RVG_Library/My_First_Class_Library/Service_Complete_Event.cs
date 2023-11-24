using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Variate_Generator_Library
{
    public class Service_Complete_Event : Discrete_Event
    {

        Server the_Server;
        public Service_Complete_Event(Server server, double time)
        {
            the_Server = server;
            event_Time = time;
        }

        public override void Process_Event()
        {
            the_Server.Complete_Current_Service(event_Time);
        }
    }
}