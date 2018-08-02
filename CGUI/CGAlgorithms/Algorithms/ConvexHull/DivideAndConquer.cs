using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities.DataStructures;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class DivideAndConquer : Algorithm
    {
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            // Step1: Sort points based on min X and on min Y on tie
            List<Point> sortedPoints = sortBasedOnMinX(points);

            // Step2: Divide and Conquer the points
            outPoints = Divide(sortedPoints);

        }


        List<Point> Divide(List<Point> points)
        {
            if (points.Count() < 6)
            {
                List<Line> outputLines = new List<Line>();
                List<Point> OutPoints = new List<Point>();
                List<Polygon> outputPolygons = new List<Polygon>();
                CGAlgorithms.Algorithms.ConvexHull.QuickHull QH = new QuickHull();
                QH.Run(points, null, null, ref OutPoints, ref  outputLines, ref  outputPolygons);
                return OutPoints;
            }
            else
            {
                int Middle_point_index = (points.Count() / 2) - 1;// Middle Point Index

                List<Point> LCH = new List<Point>();
                List<Point> RCH = new List<Point>();

                List<Point> left_list = new List<Point>();
                List<Point> Right_list = new List<Point>();
                for (int i = 0; i <= Middle_point_index; i++)
                {
                    left_list.Add(points[i]);
                }

                for (int i = Middle_point_index + 1; i < points.Count(); i++)
                {
                    Right_list.Add(points[i]);
                }

                LCH = Divide(left_list);
                RCH = Divide(Right_list);

                return Merge(LCH, RCH);
            }
        }

        List<Point> Merge(List<Point> LCH, List<Point> RCH)
        {


            Point MRP = Get_Right_Most_Point(LCH); // on min X and on max Y on tie
            Point MLP = Get_Left_Most_Point(RCH); // on max X and on max Y on tie

            #region GET Up Supporting Line

            Point ULP = MRP; // Up Left Point
            Point URP = MLP; // Up Right Point


            // next rotational =( i + 1 ) % count ;
            //  pre rotational = ((i-1) + count) % count ;


            // NextLP = LCH.next(ULP)
            Point Next_LP = LCH[(LCH.IndexOf(ULP) + 1) % LCH.Count()];

            // PreRP = RCH.pre(URP)
            Point Pre_RP = RCH[((RCH.IndexOf(URP) - 1) + RCH.Count()) % RCH.Count()];


            Point Original_URP = URP;
            Point Original_ULP = ULP;

            bool upStatus_left = true, upCurrentStatus_left = false;
            bool upStatus_right = true, upCurrentStatus_right = false;
            do
            {
                while (HelperMethods.CheckTurn(new Line(URP, ULP), Next_LP) == Enums.TurnType.Right)
                {
                    ULP = Next_LP;
                    Next_LP = LCH[(LCH.IndexOf(ULP) + 1) % LCH.Count()];


                }

                while (HelperMethods.CheckTurn(new Line(ULP, URP), Pre_RP) == Enums.TurnType.Left)
                {
                    URP = Pre_RP;
                    Pre_RP = RCH[((RCH.IndexOf(URP) - 1) + RCH.Count()) % RCH.Count()];


                }
                Enums.TurnType isTurnLeft_up = HelperMethods.CheckTurn(new Line(URP, ULP), Next_LP);
                if (isTurnLeft_up == Enums.TurnType.Left || isTurnLeft_up == Enums.TurnType.Colinear)
                    upCurrentStatus_left = true;
                Enums.TurnType isTurnRight_up = HelperMethods.CheckTurn(new Line(ULP, URP), Pre_RP);
                if (isTurnRight_up == Enums.TurnType.Right || isTurnRight_up == Enums.TurnType.Colinear)
                    upCurrentStatus_right = true;


            } while ((upStatus_left != upCurrentStatus_left) || (upStatus_right != upCurrentStatus_right));
            //while (URP != Original_URP || ULP != Original_ULP); // While URP or ULP changes
            #endregion


            #region GET Down Supporting Line


            Point DLP = MRP; // Down Left Point 
            Point DRP = MLP; // Down Right Point

            Point Pre_LP = LCH[(LCH.IndexOf(DLP) - 1 + LCH.Count()) % LCH.Count()];
            Point Next_RP = RCH[((RCH.IndexOf(DRP) + 1)) % RCH.Count()];

            Point Original_DRP = DRP;
            Point Original_DLp = DLP;

            bool downStatus_left = true, downCurrentStatus_left = false;
            bool downStatus_right = true, downCurrentStatus_right = false;

            do
            {
                while (HelperMethods.CheckTurn(new Line(DRP, DLP), Pre_LP) == Enums.TurnType.Left)
                {
                    DLP = Pre_LP;
                    Pre_LP = LCH[(LCH.IndexOf(DLP) - 1 + LCH.Count()) % LCH.Count()];


                }


                while (HelperMethods.CheckTurn(new Line(DLP, DRP), Next_RP) == Enums.TurnType.Right)
                {
                    DRP = Next_RP;
                    Next_RP = RCH[(RCH.IndexOf(DRP) + 1) % RCH.Count()];


                }

                Enums.TurnType isTurnRight_down = HelperMethods.CheckTurn(new Line(DRP, DLP), Pre_LP);
                if (isTurnRight_down == Enums.TurnType.Right || isTurnRight_down == Enums.TurnType.Colinear)
                    downCurrentStatus_left = true;
                Enums.TurnType isTurnLeft_down = HelperMethods.CheckTurn(new Line(DLP, DRP), Next_RP);
                if (isTurnLeft_down == Enums.TurnType.Left || isTurnLeft_down == Enums.TurnType.Colinear)
                    downCurrentStatus_right = true;

            } while ((downStatus_left != downCurrentStatus_left) || (downStatus_right != downCurrentStatus_right));
            //while (DRP != Original_DRP || DLP != Original_DLp);  //While DRP or DLP changes

            #endregion

            #region Points from ULP to DLP
            List<Point> Result = new List<Point>();
            for (int i = LCH.IndexOf(ULP); i <= LCH.IndexOf(DLP); i++) // [Points from ULP to DLP] 
            {
                Result.Add(LCH[i]);
            }
            #endregion

            #region Points from DRP to URP
            for (int i = RCH.IndexOf(DRP); i <= RCH.IndexOf(URP); i++) //[Points from DRP to URP]
            {
                Result.Add(RCH[i]);
            }
            #endregion
            return Result; // return [Points from ULP to DLP] + [Points from DRP to URP]
        } //end of merge function 


        /// <summary>
        /// Sorting polygon points based on min X and on min Y on tie
        /// </summary>
        private List<Point> sortBasedOnMinX(List<Point> _points)
        {
            for (int i = 0; i < _points.Count; ++i)
            {
                for (int j = i + 1; j < _points.Count; ++j)
                {
                    if (_points[i].X > _points[j].X)
                    {
                        Point tmp = _points[i];
                        _points[i] = _points[j];
                        _points[j] = tmp;
                    }
                    else if (_points[i].X == _points[j].X)
                    {
                        if (_points[i].Y > _points[j].Y)
                        {
                            Point tmp = _points[i];
                            _points[i] = _points[j];
                            _points[j] = tmp;
                        }
                    }
                }
            }
            return _points;
        }

        public int My_sort(Point p1, Point p2)
        {
            /*
            if (p1.X < p2.X)
            {
                return -1;
            }
            else if (p1.X > p2.X)
            {
                return 1;
            }
            else
            {
                if (p1.Y < p2.Y)
                {
                    return -1;
                }
                else if (p1.Y > p2.Y)
                {
                    return 1;
                }
                else
                    return 0;
            }*/

            if (p1.X.CompareTo(p2.X) == 0)
            {
                return p1.Y.CompareTo(p2.Y);
            }

            else
                return p1.X.CompareTo(p2.X);
        }

        public Point Get_Left_Most_Point(List<Point> points) // get Maximum point in a list 
        {
            Point max_X = points[0];
            for (int i = 0; i < points.Count(); i++)
            {

                if (points[i].X < max_X.X)
                {
                    max_X = points[i];
                }
                else if (points[i].X == max_X.X)
                {
                    if (points[i].Y > max_X.Y)
                    {
                        max_X = points[i];
                    }
                }
            }
            return max_X;
        }
        public Point Get_Right_Most_Point(List<Point> points) // get minimum  point in a list 
        {
            Point mini_X = points[0];
            for (int i = 0; i < points.Count(); i++)
            {
                if (points[i].X > mini_X.X)
                {
                    mini_X = points[i];
                }
                else if (points[i].X == mini_X.X)
                {
                    if (points[i].Y > mini_X.Y)
                    {
                        mini_X = points[i];
                    }
                }
            }
            return mini_X;
        }
        public override string ToString()
        {
            return "Convex Hull - Divide & Conquer";
        }


    }
}
