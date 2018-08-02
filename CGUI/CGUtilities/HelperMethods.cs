using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGUtilities
{
    public class HelperMethods
    {
        public static Enums.PointInPolygon PointInTriangle(Point p, Point a, Point b, Point c)
        {
            if (a.Equals(b) && b.Equals(c))
            {
                if (p.Equals(a) || p.Equals(b) || p.Equals(c))
                    return Enums.PointInPolygon.OnEdge;
                else
                    return Enums.PointInPolygon.Outside;
            }

            Line ab = new Line(a, b);
            Line bc = new Line(b, c);
            Line ca = new Line(c, a);

            if (GetVector(ab).Equals(Point.Identity)) return (PointOnSegment(p, ca.Start, ca.End)) ? Enums.PointInPolygon.OnEdge : Enums.PointInPolygon.Outside;
            if (GetVector(bc).Equals(Point.Identity)) return (PointOnSegment(p, ca.Start, ca.End)) ? Enums.PointInPolygon.OnEdge : Enums.PointInPolygon.Outside;
            if (GetVector(ca).Equals(Point.Identity)) return (PointOnSegment(p, ab.Start, ab.End)) ? Enums.PointInPolygon.OnEdge : Enums.PointInPolygon.Outside;

            if (CheckTurn(ab, p) == Enums.TurnType.Colinear)
                return PointOnSegment(p, a, b) ? Enums.PointInPolygon.OnEdge : Enums.PointInPolygon.Outside;
            if (CheckTurn(bc, p) == Enums.TurnType.Colinear && PointOnSegment(p, b, c))
                return PointOnSegment(p, b, c) ? Enums.PointInPolygon.OnEdge : Enums.PointInPolygon.Outside;
            if (CheckTurn(ca, p) == Enums.TurnType.Colinear && PointOnSegment(p, c, a))
                return PointOnSegment(p, a, c) ? Enums.PointInPolygon.OnEdge : Enums.PointInPolygon.Outside;

            if (CheckTurn(ab, p) == CheckTurn(bc, p) && CheckTurn(bc, p) == CheckTurn(ca, p))
                return Enums.PointInPolygon.Inside;
            return Enums.PointInPolygon.Outside;
        }
        public static Enums.TurnType CheckTurn(Point vector1, Point vector2)
        {
            double result = CrossProduct(vector1, vector2);
            if (result < 0) return Enums.TurnType.Right;
            else if (result > 0) return Enums.TurnType.Left;
            else return Enums.TurnType.Colinear;
        }
        public static bool PointOnRay(Point p, Point a, Point b)
        {
            if (a.Equals(b)) return true;
            if (a.Equals(p)) return true;
            var q = a.Vector(p).Normalize();
            var w = a.Vector(b).Normalize();
            return q.Equals(w);
        }
        public static bool PointOnSegment(Point p, Point a, Point b)
        {
            if (a.Equals(b))
                return p.Equals(a);

            if (b.X == a.X)
                return p.X == a.X && (p.Y >= Math.Min(a.Y, b.Y) && p.Y <= Math.Max(a.Y, b.Y));
            if (b.Y == a.Y)
                return p.Y == a.Y && (p.X >= Math.Min(a.X, b.X) && p.X <= Math.Max(a.X, b.X));
            double tx = (p.X - a.X) / (b.X - a.X);
            double ty = (p.Y - a.Y) / (b.Y - a.Y);

            return (Math.Abs(tx - ty) <= Constants.Epsilon && tx <= 1 && tx >= 0);
        }
        /// <summary>
        /// Get turn type from cross product between two vectors (l.start -> l.end) and (l.end -> p)
        /// </summary>
        /// <param name="l"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Enums.TurnType CheckTurn(Line l, Point p)
        {
            Point a = l.Start.Vector(l.End);
            Point b = l.End.Vector(p);
            return HelperMethods.CheckTurn(a, b);
        }
        public static Point GetVector(Line l)
        {
            return l.Start.Vector(l.End);
        }


        //////////////////////////////////  My own Functios ///////////////////////////
        //////////////////////////////////  My own Functios ///////////////////////////
        //////////////////////////////////  My own Functios ///////////////////////////
        public static void Get_MinMax_points(List<Point> points, int index_Min_X, int index_Max_X,
            int index_Min_Y, int index_Max_Y)
        {

            double max_x = points[0].X;
            double mini_x = points[points.Count() - 1].X;

            double max_y = points[0].Y;
            double mini_y = points[points.Count() - 1].Y;

            for (int i = 0; i < points.Count(); i++)
            {
                //// X Part ////

                if (points[i].X > max_x)     // find Max_X
                {
                    max_x = points[i].X;
                    index_Max_X = i;
                }
                else if (points[i].X < mini_x) // find Min_X
                {
                    mini_x = points[i].X;
                    index_Min_X = i;
                }

                    /// Y Part ////

                else if (points[i].Y > max_y) // find Max_Y
                {
                    max_y = points[i].Y;
                    index_Max_Y = i;
                }
                else if (points[i].Y < mini_y) // find Min_Y
                {
                    mini_y = points[i].Y;
                    index_Min_Y = i;
                }
            } //end of for loop 
        } // end of Get_MinMax_points Function 


        // Get previous index point
        public static int getPrevIndex(int index, int n)
        {
            return (index - 1 + n) % n;
        }

        // Get next index point
        public static int getNextIndex(int index, int n)
        {
            return (index + 1) % n;
        }

        public static Point Get_intersection_point_cordinates(Line l1, Line l2,ref bool infinty_intersection_point)
        {
            // get the intersection_point_cordinates between 2 lines 
            // descrption is in Sweepline Pesudocode.pdf section 4 
            
            
            /* Equation of 2 lines intersecting: y = m1x+c1, y=m2x+c2
                They have the same y, so: m1x+c1 = m2x+c2
                Rearrange the equation: (m1-m2) x = c2- c1
                Having c1 c2, m1, m2, then: x = (c2- c1) / (m1- m2)
                And: y = m1x+c1
                             */
            infinty_intersection_point = true;
            double X1, Y1, X2, Y2, X3, Y3, X4, Y4;

            //l1.start
            X1 = l1.Start.X;
            Y1 = l1.Start.Y;

            //l1.end
            X2 = l1.End.X;
            Y2 = l1.End.Y;

            //l2.start
            X3 = l2.Start.X;
            Y3 = l2.Start.Y;

            //l2.end
            X4 = l2.End.X;
            Y4 = l2.End.Y;

           //  using parametric Equation 

            // calculate the S ( 0 < S < 1) 
            double part_1 = ( (X4 - X3) * (Y3 - Y1)) - ((X3 - X1) * (Y4 - Y3) );
            double part_2 = ( (X4 - X3) * (Y2 - Y1)) - ((X2 - X1) * (Y4 - Y3) );

            double S=0;

            if (part_2 != 0) // avoid division by zero 
            {
                S = part_1 / part_2;
                infinty_intersection_point = false;
            }

            // calculate the t ( 0 < t < 1) 
             part_1 = ((X2 - X1) * (Y3 - Y1)) - ((X3 - X1) * (Y2 - Y1));
             part_2 = ((X4 - X3) * (Y2 - Y1)) - ((X2 - X1) * (Y4 - Y3));
             double t = 0;
             if (part_2 != 0)// avoid division by zero 
             {
                 t = part_1 / part_2;
                 infinty_intersection_point = false;
             }


            Point intersection_point = new Point(0, 0);
            
                intersection_point.X = X1 + ((X2 - X1) * S);
                intersection_point.Y = Y1 + ((Y2 - Y1) * S);

                return intersection_point;
           
        }

        public static bool onSegment(Point p, Point q, Point r) // check if point p  lies on  segment 'pr'  OR not
        {
            // Given three colinear points p, q, r, the function checks if
            // point q lies on line segment 'pr'
            
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
            {
                return true;
            }
            else
            return false;
        }
        public static bool doIntersect_between_2_Segments(Line l1, Line l2)
        {
            // if l1 and l2 are the same line 

            if (l1.Start.X == l2.Start.X &&
                l1.Start.Y == l2.Start.Y &&
                l1.End.X   == l2.End.X   &&
                l1.End.Y   == l2.End.Y )
            {
                return false;
            }
            // Find the four orientations needed for general and special cases

            // General case
            if (HelperMethods.CheckTurn(l1, l2.Start) != HelperMethods.CheckTurn(l1, l2.End)
                && HelperMethods.CheckTurn(l2, l1.Start) != HelperMethods.CheckTurn(l2, l1.End))
            {
                return true;
            }
            // Special Cases
            // p1, q1 and p2 are colinear and p2 lies on segment p1q1
            if (HelperMethods.CheckTurn(l1, l2.Start) == Enums.TurnType.Colinear && HelperMethods.PointOnSegment(l2.Start, l1.Start, l1.End))
            {
                return true;
            }

            // p1, q1 and p2 are colinear and q2 lies on segment p1q1
            if (HelperMethods.CheckTurn(l1, l2.End) == Enums.TurnType.Colinear && HelperMethods.PointOnSegment(l2.End,l1.Start, l1.End))
            {
                return true;
            }
            // p2, q2 and p1 are colinear and p1 lies on segment p2q2
            if (HelperMethods.CheckTurn(l2, l1.Start) == Enums.TurnType.Colinear && HelperMethods.PointOnSegment(l1.Start, l2.Start, l2.End))
            {
                return true;
            }
            // p2, q2 and q1 are colinear and q1 lies on segment p2q2
            if (HelperMethods.CheckTurn(l2, l1.End) == Enums.TurnType.Colinear && HelperMethods.PointOnSegment(l1.End, l2.Start, l2.End))
            {
                return true;
            }

            return false; // Doesn't fall in any of the above cases
        }

        public static double CrossProduct(Point a, Point b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
        public static double dotProduct(Point a, Point b)
        {
            return (a.X * b.X) + (a.Y * b.Y);
        }

        public static double Dis_between_lineANDpoint(Point p1, Line l1)
        {
            Point AC = l1.Start.Vector(p1);
            Point AB = l1.Start.Vector(l1.End);
            double distance = (HelperMethods.CrossProduct(AC, AB)) / Math.Sqrt((AB.X * AB.X) + (AB.Y * AB.Y));

            if (distance < 0)
            {
                return distance * -1;
            }
            return distance;
        }
        public static double get_angle(Point a, Point b)
        {
            double a2_x = a.X + 5;
            double a2_y = a.Y;
            Point a2 = new Point(a2_x, a2_y);


            Point Vec_1 = a.Vector(a2);
            Point Vec_2 = a.Vector(b);


            double cross = HelperMethods.CrossProduct(Vec_1, Vec_2);
            double dot = HelperMethods.dotProduct(Vec_1, Vec_2);

            //dot = x1*x2 + y1*y2      # dot product
            //det = x1*y2 - y1*x2      # determinant == cross product 
            //angle = atan2(det, dot)  # atan2(y, x) or atan2(sin, cos)
            //and you may want to normalize it to the range 0 .. 2 * Pi:
            // if (angle < 0) angle += 2 * M_PI;

            double angle = Math.Atan2(cross, dot) * (180 / Math.PI);
            if (angle < 0)
            {
                // law darbt fo2 fe (180 / Math.PI) // law tel3 el angle < 0 , add 360 
                // law msh  darbt fo2 fe (180 / Math.PI) //  law tel3 el angle < 0 , add (2 * math.PI)
                angle += 360;
            }
            return angle;
        }


        // function to return square of distance
        // between p1 and p2 using iqlidient Distance 
        public static double distSq_between2points(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                                 +
                   (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }


        public static bool IS_points_Sorted_CCW(Point Min_X, int ind_OF_Min_X, List<Point> points)
        {
            // next rotational =( i + 1 ) % count ;
            //  pre rotational = ((i-1) + count) % count ;


            Point prev = points[ ( ind_OF_Min_X - 1  + points.Count()  )% points.Count()];
            Point next = points[ ( ind_OF_Min_X + 1) % points.Count()];

            Line l1 = new Line(prev, next);
            if (HelperMethods.CheckTurn(l1, Min_X) == Enums.TurnType.Right)
            {
                return true;// points are sorted CCW
            }
            else
                return false; // points are sorted CW
        }
    }
}
