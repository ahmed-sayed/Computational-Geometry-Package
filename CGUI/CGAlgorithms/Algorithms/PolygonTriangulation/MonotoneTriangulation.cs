using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities;
using CGUtilities.DataStructures;

namespace CGAlgorithms.Algorithms.PolygonTriangulation
{


    class Smart_point_Y_monotone
    {
        public Point current_point;
        public string chain;
        public int ID;

        public  Smart_point_Y_monotone()
        {
            current_point = new Point(0, 0);
            chain = "left";
            ID = 0;
        }
        public  Smart_point_Y_monotone(Point p, string ch , int id)
        {
            current_point = p;
            chain = ch;
            ID = id;
        }
        
    }


    class MonotoneTriangulation  :Algorithm
    {
        OrderedSet<Smart_point_Y_monotone> poly_points;
        Point mini_x = new Point(double.MaxValue, double.MaxValue);
        int index_of_mini_x;
        
     
       
        public override void Run(System.Collections.Generic.List<CGUtilities.Point> points, System.Collections.Generic.List<CGUtilities.Line> lines, System.Collections.Generic.List<CGUtilities.Polygon> polygons, ref System.Collections.Generic.List<CGUtilities.Point> outPoints, ref System.Collections.Generic.List<CGUtilities.Line> outLines, ref System.Collections.Generic.List<CGUtilities.Polygon> outPolygons)
        {

            // Step [ 1 ] :: first at all we must check that polygon points is Sorted CCW
            // Step [ 1 ] :: first at all we must check that polygon points is Sorted CCW


            List<Point> input = new List<Point>(); //

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

            bool Points_sorted_CCW = HelperMethods.IS_points_Sorted_CCW(mini_x, index_of_mini_x, input);

            // if points were sorted CC then Resort them to be CCW
            if (Points_sorted_CCW == false)
            {
               /* for (int i = 0; i < polygons[0].lines.Count; i++)
                {
                    Point temp = polygons[0].lines[i].Start;

                    polygons[0].lines[i].Start = polygons[0].lines[i].End;
                    polygons[0].lines[i].End = temp;

                }*/
                polygons[0].lines.Reverse();
                input.Reverse();
            } // Now we have ploygon sorted CCW 



            // Step [ 2 ] :: Check that the polygon is Monotone 
            // Step [ 2 ] :: Check that the polygon is Monotone 
            bool is_Montone = Check_Poly_IS_Monotone(input);
            if (is_Montone)
            {
                List<Smart_point_Y_monotone> Sorted_Points = Sort_Polygon(input);
                Stack<Smart_point_Y_monotone> My_Stack = new Stack<Smart_point_Y_monotone>();
                My_Stack.Push(Sorted_Points[0]);
                My_Stack.Push(Sorted_Points[1]);

                int ind = 2;
                while (ind != Sorted_Points.Count())
                {
                    Smart_point_Y_monotone V = Sorted_Points[ind];
                    Smart_point_Y_monotone First_Top = My_Stack.Peek();
                    if (V.chain.Equals(First_Top.chain)) // Same Chain
                    {
                        My_Stack.Pop();
                        Smart_point_Y_monotone Sceond_Top = My_Stack.Peek();

                        if (First_Top.chain == "left")
                        {
                            Line line = new Line(Sceond_Top.current_point, First_Top.current_point);
                            Enums.TurnType chain_Type = HelperMethods.CheckTurn(line, V.current_point);
                            if (chain_Type == Enums.TurnType.Left)
                            {
                                outLines.Add(new Line(V.current_point, Sceond_Top.current_point));
                                if (My_Stack.Count == 1)
                                {
                                    My_Stack.Push(V);
                                    ind++;
                                }
                            }
                            else
                            {
                                My_Stack.Push(First_Top);
                                My_Stack.Push(V);
                                ind++;
                            }
                        } // end of condition Same Chain && chain is Left 


                        else if (First_Top.chain == "right")
                        {
                            Line line = new Line(Sceond_Top.current_point, First_Top.current_point);
                            Enums.TurnType type = HelperMethods.CheckTurn(line, V.current_point);
                            if (type == Enums.TurnType.Right)
                            {
                                outLines.Add(new Line(V.current_point, Sceond_Top.current_point));
                                if (My_Stack.Count == 1)
                                {
                                    My_Stack.Push(V);
                                    ind++;
                                }
                            }
                            else
                            {
                                My_Stack.Push(First_Top);
                                My_Stack.Push(V);
                                ind++;
                            }
                        } //end of condtion Same Cahin && chain is Right

                    } //end of Same Chain

                    else  // oppsite Chain 
                    {
                        while (My_Stack.Count != 1)
                        {
                            Smart_point_Y_monotone sceond_Top = My_Stack.Pop();
                            outLines.Add(new Line(V.current_point, sceond_Top.current_point));
                        }
                        My_Stack.Pop();
                        My_Stack.Push(First_Top);
                        My_Stack.Push(V);
                        ind++;
                    } //end of Oppsite Chain 

                  
                } //end of big while loop 
            } //end of condition poly is monotone 
             outLines.Remove(outLines[outLines.Count - 1]);
        } //end of Run 


        private List<Smart_point_Y_monotone> Sort_Polygon(List<Point> input)
        {
            // Step [ 1 ] :: Get min and max points on y-axis
            Tuple<int, int> index_Min_Max = Get_Mini_Max_Y_Axis(input);
            int index_Min_Y = index_Min_Max.Item1;
            int index_Max_Y = index_Min_Max.Item2;


            int Right = getPrevIndex(index_Max_Y, input.Count());;
            int Left  = getNextIndex(index_Max_Y, input.Count());
        
            Point Right_point =  input[Right];
            Point Left_point  =  input[Left ];

            List<Smart_point_Y_monotone> Sorted_List = new List<Smart_point_Y_monotone>();
            Sorted_List.Add(new Smart_point_Y_monotone(input[index_Max_Y], "max", index_Max_Y)); //add Max_Y

            while (true)
            {
                if (Right == index_Min_Y && Left ==index_Min_Y)
                {
                    break;
                }

                if (Right_point.Y > Left_point.Y)
                {
                    Sorted_List.Add(new Smart_point_Y_monotone(Right_point, "right", Right));
                    Right = getPrevIndex(Right, input.Count());
                    Right_point = input[Right];
                }
                else if (Left_point.Y > Right_point.Y)
                {
                    Sorted_List.Add(new Smart_point_Y_monotone(Left_point, "left", Left));
                    Left = getNextIndex(Left, input.Count());
                    Left_point = input[Left];
                }
                else
                {
                    if ( Right_point.X > Left_point.X)
                    {
                        Sorted_List.Add(new Smart_point_Y_monotone(Right_point, "right", Right));
                        Right = getPrevIndex(Right, input.Count());
                        Right_point = input[Right];
                    }

                    else if (Left_point.X >Right_point.X)
                    {
                        Sorted_List.Add(new Smart_point_Y_monotone(Left_point, "left", Left));
                        Left = getNextIndex(Left, input.Count());
                        Left_point = input[Left];
                    }
                }
            } //end of while 
            Sorted_List.Add(new Smart_point_Y_monotone(input[index_Min_Y], "min", index_Min_Y)); //add mini_y
            return Sorted_List;
        } //end of Sort_Polygon


        private bool Check_Poly_IS_Monotone(List<Point> input)
        {
            // Step [ 1 ] :: Get min and max points on y-axis
            Tuple<int,int>index_Min_Max = Get_Mini_Max_Y_Axis(input);
            int index_Min_Y = index_Min_Max.Item1;
            int index_Max_Y = index_Min_Max.Item2;


            // Step [2 ] :: Check from max to min the y-coordinates of the in between points decreases
            bool Left_Monotone = true;

            int Next = -1;
            while (Next != index_Min_Max.Item1)
            {
                Next = getNextIndex(index_Max_Y, input.Count());
                if (input [Next].Y > input[index_Max_Y].Y)
                {
                    Left_Monotone = false;
                }
                index_Max_Y = Next;
            }

            //
            // Step [ 3 ] :: Check from min to max the y-coordinates of the in between points increases

            bool Right_Monotone = true;

             Next = -1;
            while (Next != index_Min_Max.Item2)
            {
                Next = getNextIndex(index_Min_Y, input.Count());
                if (input[Next].Y < input[index_Max_Y].Y)
                {
                    Right_Monotone = false;
                }
                 index_Min_Y = Next;
            }
            if (Right_Monotone == false || Left_Monotone == false)
            {
                return false;
            }
            return true;
        } //end of Check_Poly_IS_Monotone Function 

        private Tuple<int, int> Get_Mini_Max_Y_Axis(List<Point> input)
        {
            double Min_Y = double.MaxValue;
            double Max_Y = double.MinValue;

            int index_Min_Y = 0;
            int index_Max_Y = 0;

            int count = input.Count();
            for (int i = 0; i <count; i++)
            {
                if (input[i].Y > Max_Y || (input[i].Y == Max_Y && input[i].X > input[index_Max_Y].X)) // get max in y , ( tie case : choose max X)
                {
                    Max_Y = input[i].Y;
                    index_Max_Y = i;
                }
                if (input[i].Y < Min_Y || (input[i].Y == Min_Y && input[i].X < input[index_Min_Y].X) ) // get min in y , ( tie case : choose Min X)
                {
                    Min_Y = input[i].Y;
                    index_Min_Y = i;
                }
            }

            return new Tuple<int, int>(index_Min_Y, index_Max_Y);
        } // end of get mini_max_Y Function 
       

        /// <summary>
        /// Get Prev index point
        private int getPrevIndex(int index, int polygonSize)
        {
            return (index - 1 + polygonSize) % polygonSize;
        }

        /// <summary>
        /// Get next index point
        private int getNextIndex(int index, int polygonSize)
        {
            return (index + 1) % polygonSize;
        }

        public override string ToString()
        {
            return "Monotone Triangulation";
        }
    }
}
