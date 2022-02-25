using System;
using Companys;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DeliveryRequest deliveryRequest1 = new DeliveryRequest(DateTime.Now.Date, 123, 386724, "ул. Колотушкина");
            DeliveryRequest deliveryRequest2 = new DeliveryRequest(DateTime.Now.Date, 123, 386724, "ул. Колотушкина");
            DeliveryRequest deliveryRequest3 = new DeliveryRequest(DateTime.Now.Date, 123, 386724, "ул. Колотушкина");
            DeliveryRequest deliveryRequest4 = new DeliveryRequest(DateTime.Now.Date, 123, 386724, "ул. Колотушкина");
            DeliveryRequest deliveryRequest5 = new DeliveryRequest(DateTime.Now.Date, 123, 386724, "ул. Колотушкина");

            RejectedDelivery rd1 = new RejectedDelivery("просрочен", DateTime.Now.Date, 123, 386724, "ул. Колотушкина");
            RejectedDelivery rd2 = new RejectedDelivery("просрочен", DateTime.Now.Date, 123, 386724, "ул. Колотушкина");
            RejectedDelivery rd3 = new RejectedDelivery("просрочен", DateTime.Now.Date, 123, 386724, "ул. Колотушкина");


            deliveryRequest1.GetDeliveryInfo();
            deliveryRequest2.GetDeliveryInfo();
            deliveryRequest3.GetDeliveryInfo();
            deliveryRequest4.GetDeliveryInfo();
            deliveryRequest5.GetDeliveryInfo();

            rd1.GetDeliveryInfo();
            rd2.GetDeliveryInfo();
            rd3.GetDeliveryInfo();

        }
    }
}

