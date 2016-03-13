using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class RequestForServ
    {
        public int ID;
        public int[] ChannelNeeds=new int[100];
        public int Priority;
        public bool WasInQueue = false;
        public double WaitTime;
        public double ArrivalTime;//время прибытия
        public double EndTime;//время завершения обслуживания

        public RequestForServ(int n)
        {
            ID = n;
            foreach (Device item in Form1.DeviceList)
            {
                ChannelNeeds[item.ID] = 1;// (int)Form1.channeldist.NextDouble();
            }
            Priority = 1;// (int)Form1.priordist.NextDouble();
        }
    }
}
