using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class QuickHull : Algorithm
    {
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            /*
            Input = a set S of n points 
    Assume that there are at least 2 points in the input set S of points

QuickHull (S) 
{ 
    // Find convex hull from the set S of n points

    Convex Hull := {} 
    Find left and right most points, say A & B, and add A & B to convex hull 
    Segment AB divides the remaining (n-2) points into 2 groups S1 and S2 
        where S1 are points in S that are on the right side of the oriented line from A to B, 
        and S2 are points in S that are on the right side of the oriented line from B to A 
    FindHull (S1, A, B) 
    FindHull (S2, B, A) 
}

FindHull (Sk, P, Q) 
{ 
    // Find points on convex hull from the set Sk of points 
    // that are on the right side of the oriented line from P to Q

   If Sk has no point, 
        then  return. 
    From the given set of points in Sk, find farthest point, say C, from segment PQ 
    Add point C to convex hull at the location between P and Q 
    Three points P, Q, and C partition the remaining points of Sk into 3 subsets: S0, S1, and S2 
        where S0 are points inside triangle PCQ, S1are points on the right side of the oriented 
        line from  P to C, and S2 are points on the right side of the oriented line from C to Q. 
    FindHull(S1, P, C) 
    FindHull(S2, C, Q) 
}

Output = convex hull

            */
            List<Point> convex_hull = new List<Point>();

            //Find left and right most points,  and add them to convex hull 
            Point Left_most = points.Where(p => p.X == points.Min(min => min.X)).First();
            Point Right_most = points.Where(p => p.X == points.Max(max => max.X)).First();
            convex_hull.Add(Left_most);
            convex_hull.Add(Right_most);


            // Segment AB divides the remaining (n-2) points into 2 groups S1 and S2 
            // where S1 are points in S that are on the right side of the oriented line from A to B, 
            // and S2 are points in S that are on the right side of the oriented line from B to A 

            List<Point> S1 = new List<Point>();
            List<Point> S2 = new List<Point>();


            Line Division_segment = new Line(Left_most, Right_most);
            for (int i = 0; i < points.Count(); i++)
            {
                if ((points[i].X != Left_most.X && points[i].Y != Left_most.Y)
                    && (points[i].X != Right_most.X && points[i].Y != Right_most.Y))
                {
                    if (Enums.TurnType.Right == HelperMethods.CheckTurn(Division_segment, points[i]))
                    {
                        S1.Add(points[i]);
                    }
                    else if (Enums.TurnType.Left == HelperMethods.CheckTurn(Division_segment, points[i]))
                    {
                        S2.Add(points[i]);
                    }
                }
            }

            Find_Hull(S1, Left_most, Right_most, convex_hull);
            Find_Hull(S2, Right_most, Left_most, convex_hull);


            outPoints = convex_hull;

        }

        public static void Find_Hull(List<Point> SK, Point P, Point Q, List<Point> convex_hull)
        {
            // If Sk has no point,  then  return. 
            if (SK.Count() != 0 )
            {
            //else  From the given set of points in Sk, find farthest point, say C,from segment PQ
            double max_distance = double.MinValue;
            Point C = SK[0]; // farthest point  ( ang garbage value ) 
            Line Line_PQ = new Line(P, Q);
            for (int i = 0; i < SK.Count(); i++)
            {
                if ((SK[i].X != P.X && SK[i].Y != P.Y)
                    && (SK[i].X != Q.X && SK[i].Y != Q.Y))
                {
                    double dis = HelperMethods.Dis_between_lineANDpoint(SK[i], Line_PQ);
                    if (dis > max_distance)
                    {
                        max_distance = dis;
                        C = SK[i];
                    }
                }
            }
            //Add point C to convex hull at the location between P and Q 
            int index = convex_hull.IndexOf(P);
            convex_hull.Insert(index + 1, C);

            // Three points P, Q, and C partition the remaining points of Sk into 3 subsets: S0, S1, and S2 
            // where S0 are points inside triangle PCQ, S1are points on the right side of the oriented 
            // line from  P to C, and S2 are points on the right side of the oriented line from C to Q.
            // FindHull(S1, P, C) 
            // FindHull(S2, C, Q) 

            List<Point> S1 = new List<Point>();
            List<Point> S2 = new List<Point>();

            Line P_to_C = new Line(P, C);
            Line C_to_Q = new Line(C, Q);
            for (int i = 0; i < SK.Count(); i++)
            {
                if ((SK[i].X != P.X && SK[i].Y != P.Y)
                    && (SK[i].X != Q.X && SK[i].Y != Q.Y)
                    && (SK[i].X != C.X && SK[i].Y != C.Y))
                {
                    if (Enums.TurnType.Right == HelperMethods.CheckTurn(P_to_C, SK[i]))
                    {
                        S1.Add(SK[i]);
                    }
                    else if (Enums.TurnType.Right == HelperMethods.CheckTurn(C_to_Q, SK[i]))
                    {
                        S2.Add(SK[i]);
                    }
                }
            }
            Find_Hull(S1, P, C, convex_hull);
            Find_Hull(S2, C, Q, convex_hull);
        } //end of if Sk has no point 
        }
        public override string ToString()
        {
            return "Convex Hull - Quick Hull";
        }
    }
}
