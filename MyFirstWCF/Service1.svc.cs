using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyFirstWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string SayHello()
        {
            return "Hello World........";
        }
        public string GetSquareData(string value)
        {
            return "The result from " +value + " x " + value + " is = " + Int32.Parse(value) * Int32.Parse(value);
        }

        public HappinessMessageObject GetHappinessMessage(string id)
        {
            HappinessMessageObject happinessMessageObject = new HappinessMessageObject();

            if(Int32.Parse(id) > 50) 
            { 
                happinessMessageObject.HappinessNumber = Int32.Parse(id);
                happinessMessageObject.HappinessMessage = "Keep it up, doing the best thing you can do!";
            }
            else
            {
                happinessMessageObject.HappinessNumber = Int32.Parse(id);
                happinessMessageObject.HappinessMessage = "Its Ok, take a deep breath and take a short break. You can do it! :)";

            }

            return happinessMessageObject;
        }
    }
}
