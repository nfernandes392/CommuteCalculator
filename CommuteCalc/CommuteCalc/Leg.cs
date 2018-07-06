using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuteElements
{
    public class Leg
    {
        public enum Node
        {
            Home,
            Stop40,
            Stop90,
            Coliseum,
            BayFair,
            DublinPleasanton,
            Stop14,
            Stop30R,
            Work
        }
        public enum Transport
        {
            Walk,
            Bike,
            Bus,
            Bart
        }
        public Leg(Node pointA, Node pointB, Transport transportMethod, int mins)
        {
            PointA = pointA;
            PointB = pointB;
            TransportMethod = transportMethod;
            TravelTime = mins;
        }

        public Node PointA { get; private set; }

        public Node PointB { get; private set; }

        public Transport TransportMethod { get; private set; }

        public int TravelTime { get; private set; }
    }
}
