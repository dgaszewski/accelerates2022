namespace TicketService
{
    public interface IPriceProvider
    {
        decimal GetPriceForAdult();
        decimal GetPriceForChild();
    }
}