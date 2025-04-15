namespace TicketingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket transport = new TransportTicket(30);
            transport.ProcessTicket();
            transport.TicketDetails();

            Ticket Event = new EventTicket(23);
            Event.ProcessTicket();
            Event.TicketDetails();
        }
    }
}
