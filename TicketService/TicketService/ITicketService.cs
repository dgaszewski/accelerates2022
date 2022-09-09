namespace TicketService
{
    public interface ITicketService
    {
        decimal CountPrice(bool isAdult, bool isEvening, IPriceProvider provider);
    }
}