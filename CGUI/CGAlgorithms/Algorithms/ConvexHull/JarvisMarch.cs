using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class JarvisMarch : Algorithm
    {
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {

            /*
             
                vector
   law 3ndk AB w AC
   fa physically enta m3ak 3 points coordinates
   A w B w C
   bas 3ayz AB ka vector w AC ka vector
   eli heya B - A
   dh vector AB
   w C-A eli heya AC

                */
   //                jarvis(S)
   //       pointOnHull = leftmost point in S
   //       i = 0
   //       repeat
   //          P[i] = pointOnHull
   //          endpoint = S[0]         // initial endpoint for a candidate edge on the hull
   //          for j from 1 to |S|
   //             if (endpoint == pointOnHull) or (S[j] is on left of line from P[i] to endpoint)
   //                endpoint = S[j]   // found greater left turn, update endpoint
   //          i = i+1
   //          pointOnHull = endpoint
   //       until endpoint == P[0]      // wrapped around to first hull point

            
            List<Point> hull = new List<Point>();

            // get leftmost point
            Point vStartPoint = points.Where(p => p.X == points.Min(min => min.X)).First();
            
            Point vEndpoint;
            do
            {
                hull.Add(vStartPoint);
                vEndpoint = points[0];

                for (int i = 1; i < points.Count; i++) // find  points furthest clockwise 
                {
                    Line L1 = new Line(vStartPoint,vEndpoint);
                    if ((vStartPoint == vEndpoint)
                        ||( HelperMethods.CheckTurn(L1, points[i]) == Enums.TurnType.Left))
                    {
                        vEndpoint = points[i];
                    }
                }

                vStartPoint = vEndpoint;
            }
            while (vEndpoint != hull[0]);

             outPoints= hull;
        }


        public override string ToString()
        {
            return "Convex Hull - Jarvis March";
        }
    }
}
