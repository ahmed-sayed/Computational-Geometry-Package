using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class GrahamScan : Algorithm
    {
        /*   Algorithm Pseudocode 
         * Initialization
- Find a ve rtex v of ch (P ), push it in l and delete it from P
- Angularly sort the points around v
- Push the first point in l and delete if from P
Advance
While there exist points p i ∈ P to be explored, do:
p = top(l)
p − = previous(top(l))
- If p −pp i is a left turn:
- Push p i in l
- Advance i
- Else:
- Pop p from l
Return l*/
        Point minimumY = new Point(0,0) ; // any intial value 
        int index_of_mini_Y = 0;


        List<Point> convex_hull = new List<Point>();

        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {   // step 1 :: find minimum point in Y Axis
            minimumY = points[0]; ; // any intial value 
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].Y < minimumY.Y)
                {
                    minimumY = points[i];
                    index_of_mini_Y = i;
                }

                else if (points[i].Y == minimumY.Y)
                {
                    if (points[i].X < minimumY.X)
                    {
                        minimumY = points[i];
                        index_of_mini_Y = i;
                    }
                }
            }

            Stack<Point> S = new Stack<Point>();
            //Push the first point in S and delete if from input points 
            S.Push(minimumY);
            points.Remove(points[index_of_mini_Y]); // Remove minimumY point from points input 

            //Angularly sort the points around MinimumY
            points.Sort(compare_angle); // sort the points 
            /*While there exist points p i ∈ P to be explored, do:
                p = top(l)
                p − = previous(top(l))
                - If p −pp i is a left turn:
                - Push p i in l
                - Advance i
                - Else:
                - Pop p from l
                Return l*/

            

            // push first 2 points to the Stack :: Note first point ( Minimum_Y ) was pushed before then push sceond point --> points[0]
            // points[0] --> the first point in points input (( the nearst point to minimum according to sort ))  after remove minimum 
          // .. after push this point to stack  , Remove it from points input 
            S.Push(points[0]);
            points.Remove(points[0]);
       
            Line l1 = new Line(points[0],points[1]); // any intial value 
            
            int index = 0;
            while (index != (points.Count()))  //While there exist points p i ∈ P to be explored, do
            {
                // p = top(l)
                
                /*
                - If { p_previous p p(i) } is a left turn:
                - Push p i in l
                - Advance i  ( i ++ )
                - Else:
                - Pop p from l
                 * // end of while 
                Return l*/
                Point p = S.Peek(); // returns the top of the staack without Remove it 
                Point p_previous = previous_of_Top(S);

                l1.Start = p_previous;
                l1.End   = p;

                if (HelperMethods.CheckTurn(l1, points[index]) == Enums.TurnType.Left)
                {
                    S.Push(points[index]);
                    index++;
                }
                else
                {
                    S.Pop();
                }
                    
            }
            outPoints = S.ToList();
        }

        public int compare_angle(Point p1, Point p2)
        {
            //double angle_P1 = HelperMethods.get_angle(minimumY, p1);
            //double angle_P2 = HelperMethods.get_angle(minimumY, p2);

            Line l1 = new Line(minimumY,p1);
            if (HelperMethods.CheckTurn(l1,p2) == Enums.TurnType.Left)
            {
                // angle p1 < angle p2 
                return -1;
            }
            else if (HelperMethods.CheckTurn(l1, p2) == Enums.TurnType.Right)
            {
                return 1; // angle p1 > angle p2 

            }
            else
            {
                double dis_p1 = HelperMethods.distSq_between2points(minimumY, p1);
                double dis_p2 = HelperMethods.distSq_between2points(minimumY, p2);
                if (dis_p1 < dis_p2)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        // function to find previous to top in a stack
        public Point previous_of_Top(Stack<Point> S)
        {
            Point p = S.Peek();
            S.Pop();
            Point res = S.Peek();
            S.Push(p);
            return res;
        }


        public override string ToString()
        {
            return "Convex Hull - Graham Scan";
        }
    }
}
