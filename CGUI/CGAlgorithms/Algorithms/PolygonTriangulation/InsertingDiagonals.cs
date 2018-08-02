using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities;

namespace CGAlgorithms.Algorithms.PolygonTriangulation
{
    class InsertingDiagonals : Algorithm
    {
        Point mini_x = new Point(double.MaxValue, double.MaxValue);
        int index_of_mini_x;
        List<Point> input_points_list = new List<Point>();
        List<Line> outputDiagonals = new List<Line>();


        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {


            List<Point> input = new List<Point>(); // this list used only once to check the sort of points 

            // get minimum_X to use it in checking that the polygon points are sorted CCW OR Not 
            for (int i = 0; i < polygons[0].lines.Count(); i++)
            {
                Point p = polygons[0].lines[i].Start;
                if (p.X <= mini_x.X)
                {
                    if (p.X < mini_x.X)
                    {
                        mini_x = p;
                        index_of_mini_x = i;
                    }

                    else if (p.Y < mini_x.Y)
                    {
                        mini_x = p;
                        index_of_mini_x = i;
                    }
                }
                input.Add(p);
            }

            #region check  points are sorted CCW OR CC
            bool Points_sorted_CCW = HelperMethods.IS_points_Sorted_CCW(mini_x, index_of_mini_x, input);

            // if points were sorted CC then Resort them to be CCW
            if (Points_sorted_CCW == false)
            {
                for (int i = 0; i < polygons[0].lines.Count; i++)
                {
                    Point temp = polygons[0].lines[i].Start;

                    polygons[0].lines[i].Start = polygons[0].lines[i].End;
                    polygons[0].lines[i].End = temp;

                }
                polygons[0].lines.Reverse();
            }
            #endregion
            // create a list of points

            int size = polygons[0].lines.Count();
            for (int i = 0; i < size; i++)
            {
                input_points_list.Add(polygons[0].lines[i].Start);
            }
           Inserting_Diagonals(input_points_list);
           outLines = outputDiagonals;
         //  outputDiagonals.Clear();
        } //end of Run 

        public void Inserting_Diagonals(List<Point> polygon)
        {
            
            if (polygon.Count > 3)
            
            {
                // next rotational =( i + 1 ) % count ;
                //  pre rotational = ((i-1) + count) % count ;
            
                Point c = polygon[0];

                int index_c_prev =( 0 - 1 + polygon.Count()) % polygon.Count();
                Point c_prev = polygon[index_c_prev ];

                int index_C_Next =( 0 + 1) % polygon.Count() ;
                Point c_Next = polygon[index_C_Next ];

                #region check that the segment internal segment
                // first we must check that the segment between  ( C_prev & C_next ) is internal segment 
                // the segment between C_prev & C_next is internal if ( the point C is convex point )
                while (HelperMethods.CheckTurn(new Line(c_prev ,c_Next),c) == Enums.TurnType.Left )
                {
                    //the point C is reflex and the segment is External
                    // so we should work on the Next point of C ( c_Next ) and update the pre & next to be the prev & next of the new point c
                    // after update we must check also that the new point is convex point 
                    // and the segment between it's prev & next is internal segment also 
                    Point temp = c;
                    c = c_Next;
                    c_prev = temp;

                    index_c_prev = (index_c_prev + 1) % polygon.Count();

                    //get the new_Next of the  Old_next 
                    index_C_Next = (index_C_Next + 1) % polygon.Count();
                    c_Next = polygon[index_C_Next];
                }
                #endregion

                #region check the segment is diagonal 

                Line l1 = new Line(c_prev, c_Next);
                double max_distance = double.MinValue;
                Point fathest_point = new Point(0, 0); // any intial value
                bool points_inside_triangle = false;
                for (int i = 0; i < polygon.Count; i++)
                {
                    if (HelperMethods.PointInTriangle(polygon[i], c, c_prev, c_Next) == Enums.PointInPolygon.Inside)
                    {
                        points_inside_triangle = true;
                        double dis = HelperMethods.Dis_between_lineANDpoint(polygon[i], l1);
                        if (dis > max_distance)
                        {
                            max_distance = dis;
                            fathest_point = polygon[i];
                        }
                    }
                }
                #endregion

                List<Point> p1 = new List<Point>();
                List<Point> p2 = new List<Point>();

                Point start = new Point(0, 0); //any intial vaue 
                Point end = new Point(0, 0);//any intial vaue 

                if (points_inside_triangle == false) // no points inside the triangle
                {
                    Line line_prev_AND_next = new Line(c_prev, c_Next);
                    outputDiagonals.Add(line_prev_AND_next);

                    start = c_Next;
                    end   = c_prev;
                }
                    // there is points inside triangle 
                else
                {
                    outputDiagonals.Add(new Line(c, fathest_point));

                    start = c;
                    end   = fathest_point;
                }

                p1 = subpolygon(end, start, polygon);
                p2 = subpolygon(start, end, polygon);


                Inserting_Diagonals(p1);
                Inserting_Diagonals(p2);
            }

           // return outputDiagonals;

        } //end of inserting diagonals function 

        public List<Point> subpolygon(Point start, Point end, List<Point> points)
        {

            int index_of_start = 0, index_of_end = 0;

            int found_start_AND_end = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (found_start_AND_end != 2)
                {
                    if (points[i] == start)
                    {
                        index_of_start = i;
                        found_start_AND_end++;
                    }
                    if (points[i] == end)
                    {
                        index_of_end = i;
                        found_start_AND_end++;
                    }
                }
                else
                    break; // this  mean now we have the index_of_start & index_of_end
            }
            List<Point> new_polygon = new List<Point>();
            if (index_of_end < index_of_start)
            {
                new_polygon.AddRange( points.GetRange(index_of_start, ( points.Count() - index_of_start ) ));
                new_polygon.AddRange( points.GetRange(0 , (  index_of_end + 1) ));
            }
            else
            {
                new_polygon.AddRange( points.GetRange(index_of_start, (index_of_end - index_of_start + 1) ));
            }
            return new_polygon;
        }
        public override string ToString()
        {
            return "Inserting Diagonals";
        }
    }
}
