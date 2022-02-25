using Companys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pz_2._3
{
    class RejectedDelivery : DeliveryRequest
    {

        private string Reason;

        public RejectedDelivery(string Reason, DateTime RequestTime, int ID = -1, int Summ = 200, string Аdr = "Аdr")
            : base(RequestTime, ID, Summ, Аdr)
        {
            this.Reason = Reason;
        }

        public new virtual void GetDeliveryInfo()
        {
            Console.WriteLine($"ID = {ID}, RequestTime = {RequestTime}, Summ = {Summ}, Аdr = {Аdr}, Reason = {Reason}");
        }

    }
}
