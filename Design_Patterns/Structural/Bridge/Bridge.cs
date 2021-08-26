using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Bridge
{
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }

    public class CitibankPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"using citibank payment with {paymentSystem}");
        }
    }

    public class HdfcbankPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"using hdfc payment with {paymentSystem}");
        }
    }

    public abstract class Payment
    {
        public IPaymentSystem paymentSystem { get; set; }

        public abstract void MakePayment();
    }

    public class NetbankingPayment : Payment
    {
        public override void MakePayment()
        {
            paymentSystem.ProcessPayment("Netbanking");
        }
    }

    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            paymentSystem.ProcessPayment("Card");
        }
    }
}
