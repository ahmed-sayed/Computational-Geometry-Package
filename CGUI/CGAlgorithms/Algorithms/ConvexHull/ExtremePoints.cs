using CGUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGAlgorithms.Algorithms.ConvexHull
{
    public class ExtremePoints : Algorithm
    {
        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {
            /*
            // My Method Description :
            
             first i will make a Taiangel From any 3 point lets say the triangle Points will be (( i , j , k ))
             * then i will check for every point ( Ex : point (l) such that ( l != i != j != k )
             * if the point in the triangle then i will ignore it , and it will not be  an Extreme Point .
             */

            int number_of_points = points.Count();
            bool remove = false;
            for (int i = 0; i < points.Count(); i++)
            {
                for (int j = 0; j < points.Count(); j++)
                {
                    if ( i != j)
                    {
                        for (int k = 0; k < points.Count(); k++)
                        {
                            if (j != k && i != k)
                            {
                                for (int l = 0; l < points.Count(); l++)
                                {
                                    if (( i != l && j != l && k != l))
                                    {
                                        if (HelperMethods.PointInTriangle(points[i], points[j], points[k], points[l]) == Enums.PointInPolygon.Inside)
                                        {
                                            // if point inside Triangle then remove it 
                                            points.Remove(points[i]);
                                            //number_of_points--;
                                            remove = true;
                                            i--;
                                            break;
                                        }
                                    } // end of (l != i && l != j && l != k)
                                } //end of l for loop
                            } // end of k != j && k != i
                            if (remove == true)
                            {
                                break;
                            }
                        }//end of k for loop 
                    }// end of j != i

                    if (remove == true)
                    {
                        break;
                    }
                }// end of j for loop
                remove = false;
            }// end of i for loop 
            outPoints = points;
        }

        public override string ToString()
        {
            return "Convex Hull - Extreme Points";
        }
    }
}
