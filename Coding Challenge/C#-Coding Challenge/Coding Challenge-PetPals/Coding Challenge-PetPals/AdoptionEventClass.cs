using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge_PetPals
{
    //AdoptionEvent Class:Attributes:Participants(List of IAdoptable) : A list of participants(shelters and adopters) in the adoption event.
    //Methods:HostEvent(): Hosts the adoption event.RegisterParticipant(IAdoptable participant): Registers a participant for the event.
    internal class AdoptionEventClass
    {
        private List<IAdoptable_Interface> Participants = new List<IAdoptable_Interface>();

        public void RegisterParticipant(IAdoptable_Interface participant)
        {
            Participants.Add(participant);
            Console.WriteLine("Participant registered for the adoption event.");
        }

        public void HostEvent()
        {
            Console.WriteLine("Adoption Event");
            foreach (IAdoptable_Interface participant in Participants)
            {
                participant.Adopt();
            }
        }
    }
}
