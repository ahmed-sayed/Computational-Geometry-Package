using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities;

namespace CGAlgorithms.Algorithms.PolygonTriangulation
{
    public class smart_point
    {
        public Point Current_Point;
        public bool is_Ear;
        public Point Prev;
        public Point Next;

        public smart_point(Point p, bool status, Point p_prev, Point p_next)
        {
            Current_Point = p;
            is_Ear = status;
            Prev = p_prev;
            Next = p_next;
        }
        public smart_point()
        {
            Current_Point = new Point(0, 0);
            is_Ear = false;
            Prev = new Point(0, 0);
            Next = new Point(0, 0);

        }

    }


    class SubtractingEars : Algorithm
    {
        List<Line> interor_diagonals = new List<Line>();
        Point mini_x = new Point(double.MaxValue, double.MaxValue);
        int index_of_mini_x;
        List<smart_point> input_points_list = new List<smart_point>();

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

            // check  points are sorted CCW OR CC
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

            // create a list of Smart_point where each point have (  it's cordinates , Ear_or_Not , Prev_point ,Next_point ) 
            int size = polygons[0].lines.Count();
            for (int i = 0; i < size; i++)
            {
                // next rotational =( i + 1 ) % count ;
                //  pre rotational = ((i-1) + count) % count ;

                Point p = polygons[0].lines[i].Start;
                bool Ear_point = false;
                Point Prev = polygons[0].lines[((i - 1) + size) % size].Start;
                Point next = polygons[0].lines[(i + 1) % size].Start;

                input_points_list.Add(new smart_point(p, Ear_point, Prev, next));
            }

            int current =0 ;
            List<smart_point> List_of_Ear_points = new List<smart_point>();
            input_points_list[0].is_Ear = false;
            for (int i = 0; i < input_points_list.Count(); i++)
            {
                // assign the Status of each vertex in the input_points_list ( Ear OR Not )

                input_points_list[i].is_Ear = false;
                   bool check = check_point_is_Ear(  input_points_list[i], input_points_list);
                
                if (check == true) // if the point is Ear , Then add it to List_of_Ear_points
                {
                    List_of_Ear_points.Add(input_points_list[i]);
                    List_of_Ear_points[current].is_Ear = true; 
                    // the status will be updated in the 2 lists ( input_points_ lis & list_of_Ear_points ) 
                    // because List_of_Ear_points is (( Shallow copy )) of Input_points_list 
                    current++;
                
                }
            }

            while (List_of_Ear_points.Count() != 0)
            {
                if (input_points_list.Count() <= 3) // polygon  now is Traingle 
                {
                    break;
                }
                /*While (E is not Empty)
                    {
                     ear = any point from E;
                     l = subtractEar(ear, E);
                    outlines.Add(l);
                    }*/

                smart_point p = List_of_Ear_points[0];
                Line l1 = subtractEar(p, ref List_of_Ear_points);
                outLines.Add(l1);
            }//End of While loop 

        } // end of Run Function 

        public Line subtractEar(smart_point Ear, ref List<smart_point> E)
        {
            /*SubtractEar(p, E)
            {
             * 
            1 - Remove earPoint from E.
            2- Update neighbours.
            - If p.prev isEar and wasn’t already in E, add it to E.
            - If p.next isEar and wasn’t already in E, add it to E.
            3- return segment from p.prev to p.next.
            
            * }*/
            Line interor_line = new Line(Ear.Prev, Ear.Next);
            E.Remove(Ear);

            // update  also original polygon after Remove the ear point form ears_list and Then remove the point also from the polygon 
            // This update wiil affect in both the input_points_list & List_of_Ear_points (( because it's Shallow copy ))
            bool Status_of_prev_Before =false , Status_of_Next_Before = false;
            int ind_OF_Ear_in_polygon = 0; // any intial value 
            
            for (int i = 0; i < input_points_list.Count; i++)
            {
                if (input_points_list[i].Current_Point == Ear.Prev)
                {
                    input_points_list[i].Next = Ear.Next;
                    Status_of_prev_Before = input_points_list[i].is_Ear;
                    input_points_list[i].is_Ear = check_point_is_Ear(input_points_list[i], input_points_list);
                    if (Status_of_prev_Before == false && input_points_list[i].is_Ear == true) // Kant Not_Ear WE b2t Ear , fa lazm a3mlha add fe List_of_EAr_points
                    {
                        E.Add(input_points_list[i]);
                    }
                    
                    ind_OF_Ear_in_polygon = (i + 1) % input_points_list.Count; // get index of Ear in the polygon to remove it from the polygon  
                    input_points_list.RemoveAt(ind_OF_Ear_in_polygon);
                }
                else if (input_points_list[i].Current_Point == Ear.Next)
                {

                    input_points_list[i].Prev = Ear.Prev;
                    Status_of_Next_Before = input_points_list[i].is_Ear;
                    input_points_list[i].is_Ear = check_point_is_Ear(input_points_list[i], input_points_list);
                    if (Status_of_Next_Before == false && input_points_list[i].is_Ear == true) // Kant Not_Ear WE b2t Ear , fa lazm a3mlha add fe List_of_EAr_points
                    {
                        E.Add(input_points_list[i]);
                    }
       
                }
            }

            // دلوقتى هلف على ال 
            // list_of_Ear_points 
            // وهشوف كل بوينت فيها لو لاقيت انها بعد ال 
            //update 
            // بقت 
            // Not Ear 
            // واشيلها من ال 
            // list_of_ear_points
            for (int i = 0; i < E.Count(); i++)
            {
                if (E[i].is_Ear ==false)
                {
                    E.RemoveAt(i);
                }
            }

            return interor_line;
        } //end of subtructEar function
        bool check_point_is_Ear(  smart_point p,  List<smart_point> points)
        {


            Line l1 = new Line(p.Prev, p.Current_Point);
            bool point_is_Convex = false;
            bool points_inside_triangle = false;
            if (HelperMethods.CheckTurn(l1, p.Next) == Enums.TurnType.Left) // point is convex 
            {
                point_is_Convex = true;

                for (int j = 0; j < points.Count(); j++)
                {
                    if (HelperMethods.PointInTriangle(points[j].Current_Point, p.Prev, p.Current_Point, p.Next) == Enums.PointInPolygon.Inside)
                    {
                        points_inside_triangle = true;
                        
                        break;
                    }
                }
            }
            if ( point_is_Convex == true &&  points_inside_triangle == false) // 2 condtions are true , then this point is Ear point 
            {
                return true;
                p.is_Ear = true;
            }
            else
                p.is_Ear = false;
                return false;
        }


        public override string ToString()
        {
            return "Subtracting Ears";
        }
    }
}
