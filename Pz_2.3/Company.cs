using System;
using System.Collections.Generic;
using System.Text;

namespace Companys
{
    public class DeliveryRequest
    {
        protected int ID { get; set; }
        protected DateTime RequestTime { get; set; }
        protected int Summ { get; set; }
        protected string Аdr { get; set; }

        private static int I = 0;
        private static int II = 0;

        private static int AllSumm = 0;
        private static int Requests = 0;

        public DeliveryRequest(DateTime RequestTime, int ID = -1, int Summ = 200, string Аdr = "Аdr")
        {

            AllSumm += Summ;
            Requests++;

            this.ID = ID;
            this.RequestTime = RequestTime;
            this.Summ = Summ;
            this.Аdr = Аdr;
        }

        public DeliveryRequest(int ID)
        {
            this.ID = ID;
            this.RequestTime = DateTime.Now.Date;
            this.Summ = -1;
            this.Аdr = "adr";
        }

        public void GetDeliveryInfo()
        {
            Console.WriteLine($"ID = {ID}, RequestTime = {RequestTime}, Summ = {Summ}, Аdr = {Аdr}");
        }

    }
}
