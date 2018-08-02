using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities.DataStructures;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class Incremental : Algorithm
    {
        
        
        public Point minimumY = new Point(0, 0); // any intial value 
        int index_of_mini_Y = 0;

        public Line Base_Line;       
        Point B ;  
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            B = new Point( ( (points[0].X + points[1].X + points[2].X )/ 3) , (( points[0].Y + points[1].Y + points[2].Y) / 3));
           
            Point NB = new Point(B.X + 5, B.Y);
            Base_Line = new Line(B, NB);
          
    
            /*
            // step 1 :: find minimum point in Y Axis
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

            // Get Base_line 
          Base_Line.Start = minimumY;
          Point End = new Point(minimumY.X + 5, minimumY.Y);
          Base_Line.End = End;


            */

           // Comparison<Point> comp = new Comparison<Point>(compare_angle);
            OrderedSet<Point> CH = new OrderedSet<Point>(compare_angle);


            // CH.add(Points[0], Points[1], Points[2]);
            CH.Add(points[0]);
            CH.Add(points[1]);
            CH.Add(points[2]);

            Point p = points[0] ; // any intial value 
            Point p_Prev, p_next;
            Line l1 = new Line(points[0], points[1]); // any intial value 
            for (int i = 3; i < points.Count(); i++)
            {
                p = points[i];
                //KeyValuePair<Point, Point> prevANDnext = CH.DirectRightAndLeftRotational(p);
                p_Prev = CH.DirectRightAndLeftRotational(p).Value;
                p_next = CH.DirectRightAndLeftRotational(p).Key;


                l1.Start = p_Prev;
                l1.End = p_next;
                if (HelperMethods.CheckTurn(l1, p) == Enums.TurnType.Right) // Outside the polygon
                {
                    //KeyValuePair<Point, Point> prevANDnext_2 = CH.DirectRightAndLeftRotational(p_Prev);
                    Point New_pre = CH.DirectRightAndLeftRotational(p_Prev).Value;


                    l1.Start = p;
                    l1.End = p_Prev;
                    while (HelperMethods.CheckTurn(l1, New_pre) == Enums.TurnType.Left)
                    {
                        CH.Remove(p_Prev);
                        //left support part
                        p_Prev = New_pre;
                        New_pre = CH.DirectRightAndLeftRotational(p_Prev).Value;

                        l1.Start = p;
                        l1.End = p_Prev;
                    

                    } // end of while Left   Supporting Line
                    
                    Point New_next = CH.DirectRightAndLeftRotational(p_next).Key;

                    l1.Start = p;
                    l1.End = p_next;
                    while (HelperMethods.CheckTurn(l1, New_next) == Enums.TurnType.Right)
                    {
                        CH.Remove(p_next);
                        p_next = New_next;
                        New_next = CH.DirectRightAndLeftRotational(p_next).Key;


                        l1.Start = p;
                        l1.End = p_next;
                    
                    } // // end of while Right  Supporting Line
                    // leave Pre and Next but delete the points between them
                    CH.Add(p);
                }  // end of ( if condtion :: --->> point outside the triangle 
            } // end of for loop
            outPoints = CH.ToList();
        }


        public int compare_angle(Point p1, Point p2)
        {
            double angle_P1 = HelperMethods.get_angle(Base_Line.Start, p1);
            double angle_P2 = HelperMethods.get_angle(Base_Line.Start, p2);

            if (angle_P1 <angle_P2 )
            {
                return -1;
            }

            else if (angle_P1 > angle_P2)
            {
                return 1;
            }
            else
            {
                double dis_p1 = HelperMethods.distSq_between2points(Base_Line.Start, p1);
                double dis_p2 = HelperMethods.distSq_between2points(Base_Line.Start, p2);

                if (dis_p1 < dis_p2)
                {
                    return -1;
                }
                else if (dis_p1 > dis_p2)
                {
                    return 1;
                }
                else
                    return 0;
            }
            /*Line l1 = new Line(Base_Line.Start, p1);
            if (HelperMethods.CheckTurn(l1, p2) == Enums.TurnType.Left)
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
                double dis_p1 = HelperMethods.distSq_between2points(Base_Line.Start, p1);
                double dis_p2 = HelperMethods.distSq_between2points(Base_Line.Start, p2);

                if (dis_p1 < dis_p2)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }*/
        }  //end 


        public override string ToString()
        {
            return "Convex Hull - Incremental";
        }
    }
}
