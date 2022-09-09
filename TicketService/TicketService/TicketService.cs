using System;

namespace TicketService
{
    public class TicketService : ITicketService
    {
        public decimal CountPrice(bool isAdult, bool isEvening, IPriceProvider provider)
        {
            decimal ticketPrice = 0;

            if (isAdult)
                ticketPrice = provider.GetPriceForAdult();
            else
                ticketPrice = provider.GetPriceForChild();

            if (isEvening)
                ticketPrice *= 2;

            return ticketPrice;
        }
    }
}
