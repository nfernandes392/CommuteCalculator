namespace CommuteCalc
{
    using System.Collections.Generic;
    using CommuteElements;
    using static CommuteElements.Leg;

    public class Program
    {
        static void Main(string[] args)
        {
            // All Paths
            List<Leg> paths = new List<Leg>();

            // From Home
            paths.Add(new Leg(Node.Home, Node.Stop90, Transport.Walk, 6));
            paths.Add(new Leg(Node.Home, Node.Stop90, Transport.Bike, 4));
            paths.Add(new Leg(Node.Home, Node.Coliseum, Transport.Bike, 17));
            paths.Add(new Leg(Node.Home, Node.Stop40, Transport.Walk, 3));

            // From Oakland Bus Stop
            paths.Add(new Leg(Node.Stop90, Node.Coliseum, Transport.Bus, 11));
            paths.Add(new Leg(Node.Stop40, Node.BayFair, Transport.Bus, 43));

            // From BART
            paths.Add(new Leg(Node.Coliseum, Node.DublinPleasanton, Transport.Bart, 26));
            paths.Add(new Leg(Node.BayFair, Node.DublinPleasanton, Transport.Bart, 17));

            // From Dublin/Pleasanton
            paths.Add(new Leg(Node.DublinPleasanton, Node.Stop14, Transport.Bus, 24));
            paths.Add(new Leg(Node.DublinPleasanton, Node.Stop30R, Transport.Bus, 40));
            paths.Add(new Leg(Node.DublinPleasanton, Node.Work, Transport.Bike, 40));

            // From Livermore Bus Stop
            paths.Add(new Leg(Node.Stop14, Node.Work, Transport.Walk, 18));
            paths.Add(new Leg(Node.Stop14, Node.Work, Transport.Bike, 8));
            paths.Add(new Leg(Node.Stop30R, Node.Work, Transport.Walk, 22));
            paths.Add(new Leg(Node.Stop30R, Node.Work, Transport.Bike, 10));

            Node place = Node.Home;
            Node end = Node.Work;

            while (place != end)
            {
            }
        }
    }
}
