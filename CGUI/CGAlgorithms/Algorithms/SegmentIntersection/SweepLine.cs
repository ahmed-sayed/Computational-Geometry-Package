using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities;
using CGUtilities.DataStructures;
namespace CGAlgorithms.Algorithms.SegmentIntersection
{
    public class Event
    {
        public Point Current_Point;
        public int status; // 0 : start , 1 : End ,  2 : intersection 
        public int L1_index;
        public int L2_index;
        /*
        public Event()
        {
            Current_Point =new Point(1,1) ;
            status = 0;
            L1_index = 0;
            L2_index = 0;
        }*/
        public Event(Point p, int stat, int ind1, int ind2)
        {
            Current_Point = p;
            status = stat;
            L1_index = ind1;
            L2_index=ind2;
        }
    }


    public class SweepLine : Algorithm
    {
        double SW_line = 3; // any intial value fow SweepLine  
        List<Line> copy_OF_input_lines = new List<Line>();

        OrderedSet<Event> L_SweepLine_Ordered_SET;
        OrderedSet<Event> Q_Ordered_SET_EventPoints;

        List<Point> intersection_points_list = new List<Point>();
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            // copy_OF_input_lines
            for (int i = 0; i < lines.Count; i++)
            {
                copy_OF_input_lines.Add(lines[i]);
            }

            Comparison<Event> L_comparer = new Comparison<Event>(SweepLine_Sort);
            L_SweepLine_Ordered_SET = new OrderedSet<Event>(L_comparer);


            Comparison<Event> Q_comparer = new Comparison<Event>(Event_Points_Sort);
            Q_Ordered_SET_EventPoints = new OrderedSet<Event>(Q_comparer);

            for (int i = 0; i < lines.Count; i++)  // if the line was drawn from Right to Left
            {

                if (lines[i].Start.X > lines[i].End.X) // if the line was drawn from Right to Left
                {
                    Point temp = copy_OF_input_lines[i].Start;
                    copy_OF_input_lines[i].Start = copy_OF_input_lines[i].End;
                    copy_OF_input_lines[i].End = temp;
                }

                /* // InitializeEvents(Q_Ordered_SET_EventPoints,  Lines ) ==--->> fill (Q_Ordered_SET_EventPoints) ==--->> add the lines( start & end ) 
                 // to  OrderedSet of EventPoints , sorted based on their x axis, increasing y on tie.
                 //     Event current_segment_Start = new Event(lines[i].Start, 0, i, 0);
                 //   Event current_segment_End   = new Event(lines[i].End  , 1, i, 0);

  */
                Q_Ordered_SET_EventPoints.Add(new Event(copy_OF_input_lines[i].Start, 0, i, 0));
                Q_Ordered_SET_EventPoints.Add(new Event(copy_OF_input_lines[i].End, 1, i, 0));

            } // end of add fill the Q_Ordered_SET_EventPoints


            while (Q_Ordered_SET_EventPoints.Count != 0) // While Q is not empty do:
            {
                /* EventPoint currentEvent = min of Q.
                   Remove currentEvent.
                   HandleEvent(currentEvent);*/

                Event current_Event = Q_Ordered_SET_EventPoints[0];
                Q_Ordered_SET_EventPoints.Remove(Q_Ordered_SET_EventPoints[0]);
                HandleEvent(current_Event);

               }
            intersection_points_list.Sort(my_sort);
            for (int i = 0; i < intersection_points_list.Count(); i++) // delete duplicated values 
            {

                if (i != intersection_points_list.Count() - 1) // LAST INDEX I == 5 , I+1 = 6 -->>> 6 OUT OF RANGE 
                {

                    if (Math.Round( intersection_points_list[i].X,2) == Math.Round( intersection_points_list[i + 1].X,2 ) &&
                        Math.Round( intersection_points_list[i].Y,2) == Math.Round( intersection_points_list[i + 1].Y,2))
                    {
                        intersection_points_list.Remove(intersection_points_list[i]);
                        i--;
                    }
                }  
            }
            outPoints = intersection_points_list;
        } // end of run algorithm

        public int my_sort(Point p1, Point p2)
        {
            if (p1.X < p2.X)
            {
                return -1;
            }
            else if (p1.X > p2.X)
            {
                return 1;
            }
            else return 0;
        }
        public void HandleEvent(Event current_Event)
        {

            if (current_Event.status == 0) //StartEvent
            {
                /*
                 * 1- Insert currentEvent in L.
                      L.Add( new Event(null, type= StartPoint, currentSegment.segmentIndex)
                   
                 * 2. CheckIntersection( L.prev(currentSegment), currentSegment).
                   
                 * 3. CheckIntersection( currentSegment, L.next(currentSegment)).
                 */
                int index_of_current_Event_AS_line = current_Event.L1_index;
                //1- Insert currentEvent in L.   L.Add( new Event(null, type= StartPoint, currentSegment.segmentIndex)

                L_SweepLine_Ordered_SET.Add(new Event(current_Event.Current_Point, 0, index_of_current_Event_AS_line, 0));

                // 2. CheckIntersection( L.prev(currentSegment), currentSegment).
                //  int index_of_current_Event_AS_line = current_Event.L1_index;
                Line current_Event_AS_line = copy_OF_input_lines[index_of_current_Event_AS_line];

                int index_Prev_of_currentEvent = L_SweepLine_Ordered_SET.DirectRightAndLeftRotational(current_Event).Value.L1_index;
                Line Prev_of_currentEvent = copy_OF_input_lines[index_Prev_of_currentEvent];

                bool check_intersection_between_currEvnet_AND_prev = HelperMethods.doIntersect_between_2_Segments(Prev_of_currentEvent, current_Event_AS_line);
                if (check_intersection_between_currEvnet_AND_prev == true)
                {
                    // if ther is intersection between currEvnet AND previous then calculate the cordinates of point of intersection 
                    // AND add this point to  the output points (( intersection_points_list )) so that they appear on the UI and the test cases.
                    // AND also add it to Q_Ordered_SET_EventPoints as these points will be future Events that need to be handled
                    bool infinty_intersection_point = true;
                    Point intersection_point = HelperMethods.Get_intersection_point_cordinates(Prev_of_currentEvent, current_Event_AS_line, ref infinty_intersection_point);
                    if (infinty_intersection_point == false)  //mean that the get_intersection function return an infinity 
                    {

                        
                            intersection_points_list.Add(intersection_point);

                            Event intersection_Event = new Event(intersection_point, 2, index_of_current_Event_AS_line, index_Prev_of_currentEvent);
                            Q_Ordered_SET_EventPoints.Add(intersection_Event);

                    }
                }
                // * 3. CheckIntersection( currentSegment, L.next(currentSegment)).
                int index_Next_of_currentEvent = L_SweepLine_Ordered_SET.DirectRightAndLeftRotational(current_Event).Key.L1_index;
                Line Next_of_currentEvent = copy_OF_input_lines[index_Next_of_currentEvent];

                bool check_intersection_between_currEvnet_AND_Next = HelperMethods.doIntersect_between_2_Segments(Next_of_currentEvent, current_Event_AS_line);
                if (check_intersection_between_currEvnet_AND_Next == true)
                {
                    // if ther is intersection between currEvnet AND Next then calculate the cordinates of point of intersection 
                    // AND add this point to  the output points (( intersection_points_list )) so that they appear on the UI and the test cases.
                    // AND also add it to Q_Ordered_SET_EventPoints as these points will be future Events that need to be handled
                    bool infinty_intersection_point = true;
                    Point intersection_point = HelperMethods.Get_intersection_point_cordinates(Next_of_currentEvent, current_Event_AS_line, ref infinty_intersection_point);
                    if (infinty_intersection_point == false )   //mean that the get_intersection function return an infinity 
                    {
                           intersection_points_list.Add(intersection_point);

                            Event intersection_Event = new Event(intersection_point, 2, index_of_current_Event_AS_line, index_Next_of_currentEvent);
                            Q_Ordered_SET_EventPoints.Add(intersection_Event);
                     }
                }
            } // end of StartEvent 

            else if (current_Event.status == 1)
            {
                /*EndEvent:
                            1 . CheckIntersection( L.prev(currentSegment), L.next(currentSegment) ).
                            2. Delete currentEvent from L.
                            // 1) Add the intersection points (if exists) in the output points so that they appear on the
                            UI and the test cases.
                            // 2) Now L has passed over this segment and we are sure there is no more intersections
                            with this segment, so remove the current segment from L*/

                //            1 . CheckIntersection( L.prev(currentSegment), L.next(currentSegment) ).
                // 1) Add the intersection points (if exists) in the output points so that they appear on the UI and the test cases.


                int index_Prev_of_currentEvent = L_SweepLine_Ordered_SET.DirectRightAndLeftRotational(current_Event).Value.L1_index;
                Line Prev_of_currentEvent = copy_OF_input_lines[index_Prev_of_currentEvent];

                int index_Next_of_currentEvent = L_SweepLine_Ordered_SET.DirectRightAndLeftRotational(current_Event).Key.L1_index;
                Line Next_of_currentEvent = copy_OF_input_lines[index_Next_of_currentEvent];

                bool check_intersection_between_Next_AND_prev = HelperMethods.doIntersect_between_2_Segments(Prev_of_currentEvent, Next_of_currentEvent);
                if (check_intersection_between_Next_AND_prev == true)
                {
                    // if ther is intersection between currEvnet Next AND previous then calculate the cordinates of point of intersection 
                    // AND add this point to  the output points (( intersection_points_list )) so that they appear on the UI and the test cases.
                    // and also add it to Q_Ordered_SET_EventPoints
                    bool infinty_intersection_point = true;
                    Point intersection_point = HelperMethods.Get_intersection_point_cordinates(Prev_of_currentEvent, Next_of_currentEvent, ref infinty_intersection_point);
                    if (infinty_intersection_point == false)  //mean that the get_intersection function return an infinity 
                    {
                        intersection_points_list.Add(intersection_point);

                        Event intersection_Event = new Event(intersection_point, 2, index_Prev_of_currentEvent, index_Next_of_currentEvent);
                        Q_Ordered_SET_EventPoints.Add(intersection_Event);
                    }
                }

                // 2. Delete currentEvent from L.
                // 2) Now L has passed over this segment and we are sure there is no more intersections with this segment, so remove the current segment from L

                L_SweepLine_Ordered_SET.Remove(current_Event);

            }//end of EndEvent

            else if (current_Event.status == 2)
            {
                /*1 . Find s1 & s2 are the segment intersecting together (s1 below s2).
                        2. CheckIntersection( L.prev(s1), s2 )).
                        3. CheckIntersection( L.next(s2), s1))
                        4. Swap s1 and s2 in L.
                        // 1) Store another index in the class of Event that refer to the other segment
                        intersecting with the point.
                        // 2) To swap 2 events, e1 and e2, remove them from the sweepLine and assign the
                        start of each segment of them to the intersection point and reinsert them in the
                        sweepLine. The comparison passed to the sweepLine function will find them having
                        the same x and the same y in their start point, and will check their ends and return the
                        end with the higher Y (and lower X in case of a tie))
                        //3) Add the intersection points (if exists) in the output points so that they appear on
                        the UI and the test cases.
                        */

                //1 . Find s1 & s2 are the segment intersecting together (s1 below s2).
                // 1) Store another index in the class of Event that refer to the other segment intersecting with the point.

                Line S1 = copy_OF_input_lines[current_Event.L1_index];
                Line S2 = copy_OF_input_lines[current_Event.L2_index];


                //        2. CheckIntersection( L.prev(s1), s2 )).

                Event New_S1 = new Event(current_Event.Current_Point, 0, current_Event.L1_index, 0);
                Event Prev_S1 = L_SweepLine_Ordered_SET.DirectRightAndLeftRotational(New_S1).Value;
              
                
                Line Prev_S1_AS_line = copy_OF_input_lines[Prev_S1.L1_index];
                bool intersection_between_PrevS1_AND_S2 = HelperMethods.doIntersect_between_2_Segments(Prev_S1_AS_line, S2);
                if (intersection_between_PrevS1_AND_S2 == true)
                {
                    // add this point to  the output points (( intersection_points_list )) so that they appear on the UI and the test cases.
                    // and also add it to Q_Ordered_SET_EventPoints
                    bool infinty_intersection_point = true;
                    Point intersection_point = HelperMethods.Get_intersection_point_cordinates(Prev_S1_AS_line, S2, ref infinty_intersection_point);
                    if (infinty_intersection_point == false) //mean that the get_intersection function return an infinity 
                    {
                    if (intersection_point.X > current_Event.Current_Point.X)
                            {

                                intersection_points_list.Add(intersection_point);

                                Event intersection_Event = new Event(intersection_point, 2, Prev_S1.L1_index, current_Event.L2_index);
                                Q_Ordered_SET_EventPoints.Add(intersection_Event);

                            }
                    }
                }

                //        3. CheckIntersection( L.next(s2), s1))
                Event New_s2 = new Event(current_Event.Current_Point, 0, current_Event.L2_index, 0);
                Event Next_S2 = L_SweepLine_Ordered_SET.DirectRightAndLeftRotational(New_s2).Key;

                Line Next_s2_as_line = copy_OF_input_lines[Next_S2.L1_index];
                bool intersection_between_NextS2_AND_S1 = HelperMethods.doIntersect_between_2_Segments(Next_s2_as_line, S1);
                if (intersection_between_NextS2_AND_S1 == true)
                {
                    // add this point to  the output points (( intersection_points_list )) so that they appear on the UI and the test cases.
                    // and also add it to Q_Ordered_SET_EventPoints
                    bool infinty_intersection_point = true;
                    Point intersection_point = HelperMethods.Get_intersection_point_cordinates(Next_s2_as_line, S1, ref infinty_intersection_point);
                    if (infinty_intersection_point == false ) //mean that the get_intersection function return an infinity 
                    {       if (intersection_point.X > current_Event.Current_Point.X)
                            {
                                intersection_points_list.Add(intersection_point);

                                Event intersection_Event = new Event(intersection_point, 2, Next_S2.L1_index, current_Event.L1_index);
                                Q_Ordered_SET_EventPoints.Add(intersection_Event);
                            }
                     }
            }

                //4. Swap s1 and s2 in L.
                /* To swap 2 events, e1 and e2, remove them from the sweepLine and assign the
                    start of each segment of them to the intersection point and reinsert them in the
                    sweepLine. The comparison passed to the sweepLine function will find them having
                    the same x and the same y in their start point, and will check their ends and return the
                    end with the higher Y (and lower X in case of a tie))*/


                
                
                L_SweepLine_Ordered_SET.Remove(New_S1);
                L_SweepLine_Ordered_SET.Remove(New_s2);

                New_S1.Current_Point = current_Event.Current_Point;
                //New_S1.L1_index = New_s2.L1_index;

                New_s2.Current_Point = current_Event.Current_Point;
              //  New_s2.L1_index = New_S1.L1_index;

                L_SweepLine_Ordered_SET.Add(New_S1);
                L_SweepLine_Ordered_SET.Add(New_s2);
            } //end of intersectionEvent 

        } // end of HandleEvent Function 
        double get_intersection(double X_max, Line l1)
        {
            // Y = aX+b ->> line Equation 
            double a = (l1.End.Y - l1.Start.Y) / (l1.End.X - l1.Start.X); // ( a ) --->>  is the slope
            double b = l1.Start.Y - (a * l1.Start.X);

            //  return Y ((  Y = aX+b  ))->> line Equation 
            double Y = (a * X_max) + b;

            return Y;
        }
        int SweepLine_Sort(Event e1, Event e2)
        {
            // description of the SweepLine comparer is in section sweepline comparer.pdf

            
            Line l1 = copy_OF_input_lines[e1.L1_index];
            Line l2 = copy_OF_input_lines[e2.L1_index];

            double Xmax = Math.Max(e1.Current_Point.X, e2.Current_Point.X);

            if (e1.Current_Point.X > e2.Current_Point.X)
                Xmax = e1.Current_Point.X;
            else if(e1.Current_Point.X < e2.Current_Point.X)
                Xmax = e2.Current_Point.X;
             else if (e1.Current_Point.X == e2.Current_Point.X)
                Xmax = e1.Current_Point.X;

            double y1 = get_intersection(Xmax, l1);
            double y2 = get_intersection(Xmax, l2);



            if (y1 < y2)
            {
                return -1;
            }
            else if (y1 > y2)
            {
                return 1;
            }

            else
            {

                Xmax = Math.Max(l1.End.X, l2.End.X);

                y1 = get_intersection(Xmax, l1);
                y2 = get_intersection(Xmax, l2);

                
                if (y1 < y2)
                {
                    return -1;
                }
                else if (y1 > y2)
                {
                    return 1;
                }
                else
                    return 0;
            }
        }
        

        int Event_Points_Sort(Event e1, Event e2)
        {
            if (e1.Current_Point.X < e2.Current_Point.X)
                {
                    return -1;
                }
                else if (e1.Current_Point.X > e2.Current_Point.X)
                {
                    return 1;
                }
                else
                {
                    if (e1.Current_Point.Y < e2.Current_Point.Y)
                    {
                        return -1;
                    }
                    else if (e1.Current_Point.Y > e2.Current_Point.Y)
                    {
                        return 1;
                    }
                    else
                        return 0;
                }
        } // End of Event_Points_Sort 


        public override string ToString()
        {
            return "Sweep Line";
        }
    }
}
