using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem
{
    abstract class Ticket
    {
        public Ticket (int TicketID)
        {
            this.TicketID = TicketID;
        }
        public int TicketID { get; set; }
        public DateTime IssueDate = DateTime.Now;


        public abstract void ProcessTicket();//abstract method for child class to implement

        public virtual void TicketDetails()//concrete method to display ticket details. this method can be overriden because of the 'virtual' keyword
        {
            Console.WriteLine($"Ticket ID: {TicketID}, Date: {IssueDate}");
        }

    }

    class TransportTicket : Ticket  //This line shows that TransportTickets is a child class for Ticket
    {
        public TransportTicket (int TicketID) : base(TicketID)
        {
            this.TicketID = TicketID;
        }
        int seatNumber;
        public override void ProcessTicket()
        {

            //int seatNumber;
            while(true)
                try 
                {
                    Console.WriteLine("What is your seat number?");
                    seatNumber = Int32.Parse(Console.ReadLine());  //Int32.Parse()  converts the input into an int
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            
        }

        public override void TicketDetails()
        {
            Console.WriteLine("***Transport Ticket Details***");
            base.TicketDetails();
            Console.WriteLine($"Seat Number: {seatNumber}");
        }
    }

    class EventTicket : Ticket   //This line shows that EventTickets is a child class for Ticket
    {
        public EventTicket(int TicketID) : base(TicketID)
        {
            this.TicketID = TicketID;
        }
        int age;
        public override void ProcessTicket()
        {
            Console.WriteLine("How old are you?");
            age = Int32.Parse(Console.ReadLine());
            if(age <18)
            {
                Console.WriteLine("You are too young to enter!");

            }
            else
            {
                Console.WriteLine("Your ticket has been processed!");
            }

            
        }
        public override void TicketDetails()
        {
            if (age < 18)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("***Event Ticket Details***");
                base.TicketDetails();
                Console.WriteLine($"Age: {age}");
            }
        }

    }
}
