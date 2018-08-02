using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class ExtremeSegments : Algorithm
    {
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            int Left_counter = 0;
            int size = points.Count();
            bool[] added_status = new bool[size];
            Line line_1 = new Line(points[0], points[1]); // any intial vallue 
               
            for (int i = 0; i < points.Count(); i++)
            {
                for (int j = 0; j < points.Count(); j++)
                {
                    if (i != j)
                    {
                        for (int k = 0; k < points.Count(); k++)
                        {
                            if (i != k && j != k)
                            {
                                if (added_status[i] == false)
                                {


                                    line_1.Start = points[i];
                                    line_1.End=points[j];
                                    if (HelperMethods.CheckTurn(line_1, points[k]) == Enums.TurnType.Left)
                                    {
                                        Left_counter++;
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                            }
                        }// end of k for loop 
                    }
                    if (Left_counter == points.Count() - 2)
                    {
                        if (added_status[i] == false)
                        {

                            outPoints.Add(line_1.End);
                            added_status[i] = true;
                        }
                    }
                    Left_counter = 0;

                }//end of j foor loop 
                Left_counter = 0;
            }//end of i for loop 
        }

        public override string ToString()
        {
            return "Convex Hull - Extreme Segments";
        }
    }
}
