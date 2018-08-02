using CGAlgorithms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void PT_Case_1()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-101, 308.5), new CGUtilities.Point(154, 262.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(154, 262.5), new CGUtilities.Point(202, 135.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(202, 135.5), new CGUtilities.Point(154, 49.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(154, 49.5), new CGUtilities.Point(-48, -87.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-48, -87.5), new CGUtilities.Point(-154, -61.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-154, -61.5), new CGUtilities.Point(-257, 23.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-257, 23.5), new CGUtilities.Point(-285, 148.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-285, 148.5), new CGUtilities.Point(-246, 232.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-246, 232.5), new CGUtilities.Point(-203, 264.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-203, 264.5), new CGUtilities.Point(-101, 308.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void PT_Case_2()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-88, 245.5), new CGUtilities.Point(51, 62.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(51, 62.5), new CGUtilities.Point(406, 59.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(406, 59.5), new CGUtilities.Point(153, -98.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(153, -98.5), new CGUtilities.Point(221, -268.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(221, -268.5), new CGUtilities.Point(3, -127.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(3, -127.5), new CGUtilities.Point(-118, -276.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-118, -276.5), new CGUtilities.Point(-126, -83.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-126, -83.5), new CGUtilities.Point(-368, 37.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-368, 37.5), new CGUtilities.Point(-174, 50.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-174, 50.5), new CGUtilities.Point(-88, 245.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void PT_Case_3()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-80, 278.5), new CGUtilities.Point(12, 63.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(12, 63.5), new CGUtilities.Point(308, 90.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(308, 90.5), new CGUtilities.Point(304, -1.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(304, -1.5), new CGUtilities.Point(160, 6.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(160, 6.5), new CGUtilities.Point(168, -121.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(168, -121.5), new CGUtilities.Point(-6, -72.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-6, -72.5), new CGUtilities.Point(-72, -188.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-72, -188.5), new CGUtilities.Point(-166, -35.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-166, -35.5), new CGUtilities.Point(-94, 20.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-94, 20.5), new CGUtilities.Point(-218, 102.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-218, 102.5), new CGUtilities.Point(-118, 149.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-118, 149.5), new CGUtilities.Point(-262, 230.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-262, 230.5), new CGUtilities.Point(-151, 317.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-151, 317.5), new CGUtilities.Point(-80, 278.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void PT_Case_4()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-180, 196.5), new CGUtilities.Point(-136, 276.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-136, 276.5), new CGUtilities.Point(84, 208.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(84, 208.5), new CGUtilities.Point(-86, 166.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-86, 166.5), new CGUtilities.Point(147, 130.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(147, 130.5), new CGUtilities.Point(-82, 73.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-82, 73.5), new CGUtilities.Point(206, 46.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(206, 46.5), new CGUtilities.Point(-53, -36.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-53, -36.5), new CGUtilities.Point(249, -85.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(249, -85.5), new CGUtilities.Point(-55, -107.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-55, -107.5), new CGUtilities.Point(-3, -169.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-3, -169.5), new CGUtilities.Point(-85, -165.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-85, -165.5), new CGUtilities.Point(-186, -96.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-186, -96.5), new CGUtilities.Point(-97, -73.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-97, -73.5), new CGUtilities.Point(-194, -14.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-194, -14.5), new CGUtilities.Point(-49, 10.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-49, 10.5), new CGUtilities.Point(-194, 56.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-194, 56.5), new CGUtilities.Point(-88, 109.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-88, 109.5), new CGUtilities.Point(-264, 139.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-264, 139.5), new CGUtilities.Point(-180, 196.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void PT_Case_5()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-27, 223.5), new CGUtilities.Point(70, 217.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(70, 217.5), new CGUtilities.Point(58, 270.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(58, 270.5), new CGUtilities.Point(-32, 283.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-32, 283.5), new CGUtilities.Point(-78, 323.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-78, 323.5), new CGUtilities.Point(-106, 277.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-106, 277.5), new CGUtilities.Point(-117, 196.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-117, 196.5), new CGUtilities.Point(-218, 177.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-218, 177.5), new CGUtilities.Point(-116, 122.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-116, 122.5), new CGUtilities.Point(-251, 122.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-251, 122.5), new CGUtilities.Point(-158, 55.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-158, 55.5), new CGUtilities.Point(-253, 62.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-253, 62.5), new CGUtilities.Point(-175, -13.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-175, -13.5), new CGUtilities.Point(-298, 58.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-298, 58.5), new CGUtilities.Point(-288, -62.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-288, -62.5), new CGUtilities.Point(-349, -111.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-349, -111.5), new CGUtilities.Point(-407, 4.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-407, 4.5), new CGUtilities.Point(-402, -131.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-402, -131.5), new CGUtilities.Point(-468, -39.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-468, -39.5), new CGUtilities.Point(-449, -139.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-449, -139.5), new CGUtilities.Point(-560, -141.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-560, -141.5), new CGUtilities.Point(-466, -208.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-466, -208.5), new CGUtilities.Point(-236, -188.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-236, -188.5), new CGUtilities.Point(-205, -124.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-205, -124.5), new CGUtilities.Point(-157, -198.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-157, -198.5), new CGUtilities.Point(-146, -131.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-146, -131.5), new CGUtilities.Point(-124, -244.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-124, -244.5), new CGUtilities.Point(-72, -247.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-72, -247.5), new CGUtilities.Point(-97, -131.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-97, -131.5), new CGUtilities.Point(-52, -134.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-52, -134.5), new CGUtilities.Point(-31, -234.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-31, -234.5), new CGUtilities.Point(16, -222.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(16, -222.5), new CGUtilities.Point(-2, -109.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-2, -109.5), new CGUtilities.Point(-48, -39.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-48, -39.5), new CGUtilities.Point(72, -31.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(72, -31.5), new CGUtilities.Point(-7, 30.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-7, 30.5), new CGUtilities.Point(87, 32.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(87, 32.5), new CGUtilities.Point(-37, 84.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-37, 84.5), new CGUtilities.Point(54, 94.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(54, 94.5), new CGUtilities.Point(64, 111.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(64, 111.5), new CGUtilities.Point(105, 101.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(105, 101.5), new CGUtilities.Point(128, 93.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(128, 93.5), new CGUtilities.Point(124, 123.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(124, 123.5), new CGUtilities.Point(70, 141.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(70, 141.5), new CGUtilities.Point(22, 125.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(22, 125.5), new CGUtilities.Point(-39, 155.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-39, 155.5), new CGUtilities.Point(-54, 194.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-54, 194.5), new CGUtilities.Point(42, 189.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(42, 189.5), new CGUtilities.Point(43, 206.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(43, 206.5), new CGUtilities.Point(-27, 223.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);

            // Points:
            drawingCanvas.Points.Add(new CGUtilities.Point(-40, 266.5));
        }
        void MT_Case_1()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-42, 332.5), new CGUtilities.Point(291, 212.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(291, 212.5), new CGUtilities.Point(166, 174.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(166, 174.5), new CGUtilities.Point(116, 128.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(116, 128.5), new CGUtilities.Point(84, 54.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(84, 54.5), new CGUtilities.Point(-8, 8.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-8, 8.5), new CGUtilities.Point(100, -53.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(100, -53.5), new CGUtilities.Point(-11, -93.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-11, -93.5), new CGUtilities.Point(143, -165.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(143, -165.5), new CGUtilities.Point(33, -174.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(33, -174.5), new CGUtilities.Point(128, -233.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(128, -233.5), new CGUtilities.Point(-24, -308.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-24, -308.5), new CGUtilities.Point(-142, -190.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-142, -190.5), new CGUtilities.Point(-2, -146.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-2, -146.5), new CGUtilities.Point(-177, -48.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-177, -48.5), new CGUtilities.Point(-58, -23.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-58, -23.5), new CGUtilities.Point(-197, 87.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-197, 87.5), new CGUtilities.Point(8, 181.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(8, 181.5), new CGUtilities.Point(-234, 314.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-234, 314.5), new CGUtilities.Point(-42, 332.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void MT_Case_2()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-113, 332.5), new CGUtilities.Point(-242, 264.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-242, 264.5), new CGUtilities.Point(-176, 137.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-176, 137.5), new CGUtilities.Point(-309, 88.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-309, 88.5), new CGUtilities.Point(-134, -116.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-134, -116.5), new CGUtilities.Point(-221, -281.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-221, -281.5), new CGUtilities.Point(53, -295.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(53, -295.5), new CGUtilities.Point(-72, -87.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-72, -87.5), new CGUtilities.Point(105, -61.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(105, -61.5), new CGUtilities.Point(-57, 18.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-57, 18.5), new CGUtilities.Point(55, 44.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(55, 44.5), new CGUtilities.Point(-88, 103.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-88, 103.5), new CGUtilities.Point(28, 127.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(28, 127.5), new CGUtilities.Point(-67, 197.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-67, 197.5), new CGUtilities.Point(69, 207.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(69, 207.5), new CGUtilities.Point(-96, 261.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-96, 261.5), new CGUtilities.Point(-113, 332.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void MT_Case_3()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-77, 306.5), new CGUtilities.Point(67, 115.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(67, 115.5), new CGUtilities.Point(314, 108.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(314, 108.5), new CGUtilities.Point(191, 64.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(191, 64.5), new CGUtilities.Point(116, 17.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(116, 17.5), new CGUtilities.Point(89, -34.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(89, -34.5), new CGUtilities.Point(81, -126.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(81, -126.5), new CGUtilities.Point(186, -166.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(186, -166.5), new CGUtilities.Point(-21, -192.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-21, -192.5), new CGUtilities.Point(23, -221.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(23, -221.5), new CGUtilities.Point(66, -229.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(66, -229.5), new CGUtilities.Point(144, -231.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(144, -231.5), new CGUtilities.Point(-92, -311.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-92, -311.5), new CGUtilities.Point(-143, -253.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-143, -253.5), new CGUtilities.Point(-47, -218.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-47, -218.5), new CGUtilities.Point(-211, -133.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-211, -133.5), new CGUtilities.Point(47, -82.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(47, -82.5), new CGUtilities.Point(-39, -66.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-39, -66.5), new CGUtilities.Point(-96, -35.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-96, -35.5), new CGUtilities.Point(-126, 14.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-126, 14.5), new CGUtilities.Point(-162, 96.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-162, 96.5), new CGUtilities.Point(-120, 178.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-120, 178.5), new CGUtilities.Point(-149, 215.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-149, 215.5), new CGUtilities.Point(-134, 269.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-134, 269.5), new CGUtilities.Point(-77, 306.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void MT_Case_4()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-42, 319.5), new CGUtilities.Point(-215, 217.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-215, 217.5), new CGUtilities.Point(-70, 96.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-70, 96.5), new CGUtilities.Point(-242, -27.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-242, -27.5), new CGUtilities.Point(-94, -104.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-94, -104.5), new CGUtilities.Point(-247, -230.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-247, -230.5), new CGUtilities.Point(-74, -325.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-74, -325.5), new CGUtilities.Point(155, -256.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(155, -256.5), new CGUtilities.Point(-117, -173.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-117, -173.5), new CGUtilities.Point(134, -65.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(134, -65.5), new CGUtilities.Point(-162, -0.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-162, -0.5), new CGUtilities.Point(112, 82.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(112, 82.5), new CGUtilities.Point(-118, 187.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-118, 187.5), new CGUtilities.Point(97, 224.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(97, 224.5), new CGUtilities.Point(-49, 291.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-49, 291.5), new CGUtilities.Point(23, 308.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(23, 308.5), new CGUtilities.Point(-42, 319.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void MT_Case_5()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-30, 197.5), new CGUtilities.Point(22, 212.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(22, 212.5), new CGUtilities.Point(-46, 219.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-46, 219.5), new CGUtilities.Point(-44, 243.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-44, 243.5), new CGUtilities.Point(-98, 284.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-98, 284.5), new CGUtilities.Point(-183, 239.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-183, 239.5), new CGUtilities.Point(-138, 212.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-138, 212.5), new CGUtilities.Point(-184, 188.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-184, 188.5), new CGUtilities.Point(-145, 180.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-145, 180.5), new CGUtilities.Point(-183, 153.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-183, 153.5), new CGUtilities.Point(-91, 143.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-91, 143.5), new CGUtilities.Point(-282, 64.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-282, 64.5), new CGUtilities.Point(-192, 41.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-192, 41.5), new CGUtilities.Point(-201, 30.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-201, 30.5), new CGUtilities.Point(-176, 12.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-176, 12.5), new CGUtilities.Point(-325, -24.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-325, -24.5), new CGUtilities.Point(-236, -62.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-236, -62.5), new CGUtilities.Point(-366, -96.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-366, -96.5), new CGUtilities.Point(-213, -137.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-213, -137.5), new CGUtilities.Point(-256, -155.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-256, -155.5), new CGUtilities.Point(-271, -171.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-271, -171.5), new CGUtilities.Point(-278, -203.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-278, -203.5), new CGUtilities.Point(-263, -236.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-263, -236.5), new CGUtilities.Point(-230, -266.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-230, -266.5), new CGUtilities.Point(-135, -284.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-135, -284.5), new CGUtilities.Point(-7, -270.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-7, -270.5), new CGUtilities.Point(-108, -208.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-108, -208.5), new CGUtilities.Point(-40, -204.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-40, -204.5), new CGUtilities.Point(-205, -103.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-205, -103.5), new CGUtilities.Point(177, -44.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(177, -44.5), new CGUtilities.Point(112, -1.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(112, -1.5), new CGUtilities.Point(193, 36.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(193, 36.5), new CGUtilities.Point(91, 53.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(91, 53.5), new CGUtilities.Point(58, 79.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(58, 79.5), new CGUtilities.Point(38, 130.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(38, 130.5), new CGUtilities.Point(-34, 132.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-34, 132.5), new CGUtilities.Point(6, 159.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(6, 159.5), new CGUtilities.Point(-60, 182.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-60, 182.5), new CGUtilities.Point(-30, 197.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);

            // Points:
            drawingCanvas.Points.Add(new CGUtilities.Point(-72, 228.5));
        }
        void MP_Case_1()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(177.5, 35.5), new CGUtilities.Point(117.5, 69.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(117.5, 69.5), new CGUtilities.Point(89.5, 210.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(89.5, 210.5), new CGUtilities.Point(15.5, 128.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(15.5, 128.5), new CGUtilities.Point(-41.5, 184.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-41.5, 184.5), new CGUtilities.Point(-97.5, 105.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-97.5, 105.5), new CGUtilities.Point(-39.5, 46.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-39.5, 46.5), new CGUtilities.Point(-98.5, -28.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-98.5, -28.5), new CGUtilities.Point(-167.5, 31.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-167.5, 31.5), new CGUtilities.Point(-188.5, -89.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-188.5, -89.5), new CGUtilities.Point(-71.5, -178.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-71.5, -178.5), new CGUtilities.Point(-42.5, -101.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-42.5, -101.5), new CGUtilities.Point(66.5, -180.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(66.5, -180.5), new CGUtilities.Point(28.5, -65.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(28.5, -65.5), new CGUtilities.Point(163.5, -105.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(163.5, -105.5), new CGUtilities.Point(177.5, 35.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void MP_Case_2()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-92, 253.5), new CGUtilities.Point(-206, 168.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-206, 168.5), new CGUtilities.Point(-337, 208.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-337, 208.5), new CGUtilities.Point(-408, 319.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-408, 319.5), new CGUtilities.Point(-447, 93.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-447, 93.5), new CGUtilities.Point(-285, 102.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-285, 102.5), new CGUtilities.Point(-531, -4.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-531, -4.5), new CGUtilities.Point(-184, -128.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-184, -128.5), new CGUtilities.Point(79, -54.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(79, -54.5), new CGUtilities.Point(-101, 61.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-101, 61.5), new CGUtilities.Point(129, 99.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(129, 99.5), new CGUtilities.Point(-92, 253.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);
        }
        void MP_Case_3()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(65, 248.5), new CGUtilities.Point(44, 250.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(44, 250.5), new CGUtilities.Point(31, 292.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(31, 292.5), new CGUtilities.Point(19, 248.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(19, 248.5), new CGUtilities.Point(3, 248.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(3, 248.5), new CGUtilities.Point(-14, 289.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-14, 289.5), new CGUtilities.Point(-20, 246.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-20, 246.5), new CGUtilities.Point(-43, 240.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-43, 240.5), new CGUtilities.Point(-51, 176.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-51, 176.5), new CGUtilities.Point(-6, 135.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-6, 135.5), new CGUtilities.Point(-16, 83.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-16, 83.5), new CGUtilities.Point(-81, 68.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-81, 68.5), new CGUtilities.Point(-144, 88.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-144, 88.5), new CGUtilities.Point(-204, 155.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-204, 155.5), new CGUtilities.Point(-224, 258.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-224, 258.5), new CGUtilities.Point(-327, 77.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-327, 77.5), new CGUtilities.Point(-203, -66.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-203, -66.5), new CGUtilities.Point(-28, -66.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-28, -66.5), new CGUtilities.Point(-51, -118.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-51, -118.5), new CGUtilities.Point(-34, -152.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-34, -152.5), new CGUtilities.Point(-61, -213.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-61, -213.5), new CGUtilities.Point(-61, -252.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-61, -252.5), new CGUtilities.Point(-98, -276.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-98, -276.5), new CGUtilities.Point(-3, -273.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-3, -273.5), new CGUtilities.Point(-12, -208.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-12, -208.5), new CGUtilities.Point(13, -164.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(13, -164.5), new CGUtilities.Point(5, -119.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(5, -119.5), new CGUtilities.Point(34, -117.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(34, -117.5), new CGUtilities.Point(47, -155.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(47, -155.5), new CGUtilities.Point(83, -193.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(83, -193.5), new CGUtilities.Point(72, -224.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(72, -224.5), new CGUtilities.Point(92, -260.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(92, -260.5), new CGUtilities.Point(180, -252.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(180, -252.5), new CGUtilities.Point(143, -214.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(143, -214.5), new CGUtilities.Point(136, -192.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(136, -192.5), new CGUtilities.Point(102, -153.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(102, -153.5), new CGUtilities.Point(87, -118.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(87, -118.5), new CGUtilities.Point(110, -104.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(110, -104.5), new CGUtilities.Point(95, -69.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(95, -69.5), new CGUtilities.Point(253, -61.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(253, -61.5), new CGUtilities.Point(387, 61.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(387, 61.5), new CGUtilities.Point(349, 266.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(349, 266.5), new CGUtilities.Point(256, 150.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(256, 150.5), new CGUtilities.Point(179, 102.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(179, 102.5), new CGUtilities.Point(128, 95.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(128, 95.5), new CGUtilities.Point(105, 141.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(105, 141.5), new CGUtilities.Point(118, 172.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(118, 172.5), new CGUtilities.Point(115, 217.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(115, 217.5), new CGUtilities.Point(65, 248.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);

            // Points:
            drawingCanvas.Points.Add(new CGUtilities.Point(51, 215.5));
            drawingCanvas.Points.Add(new CGUtilities.Point(-6, 211.5));


        }
        void MP_Case_4()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(12, 256.5), new CGUtilities.Point(-17, 314.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-17, 314.5), new CGUtilities.Point(-23, 251.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-23, 251.5), new CGUtilities.Point(-111, 227.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-111, 227.5), new CGUtilities.Point(-13, 211.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-13, 211.5), new CGUtilities.Point(-122, 163.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-122, 163.5), new CGUtilities.Point(-2, 165.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-2, 165.5), new CGUtilities.Point(-35, 95.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-35, 95.5), new CGUtilities.Point(-98, 103.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-98, 103.5), new CGUtilities.Point(-150, 133.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-150, 133.5), new CGUtilities.Point(-108, 62.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-108, 62.5), new CGUtilities.Point(-54, 58.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-54, 58.5), new CGUtilities.Point(-96, -15.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-96, -15.5), new CGUtilities.Point(-29, -83.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-29, -83.5), new CGUtilities.Point(-106, -173.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-106, -173.5), new CGUtilities.Point(19, -169.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(19, -169.5), new CGUtilities.Point(8, -223.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(8, -223.5), new CGUtilities.Point(-46, -258.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-46, -258.5), new CGUtilities.Point(53, -258.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(53, -258.5), new CGUtilities.Point(54, -179.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(54, -179.5), new CGUtilities.Point(107, -182.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(107, -182.5), new CGUtilities.Point(85, -91.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(85, -91.5), new CGUtilities.Point(194, -72.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(194, -72.5), new CGUtilities.Point(79, 1.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(79, 1.5), new CGUtilities.Point(369, -9.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(369, -9.5), new CGUtilities.Point(363, 138.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(363, 138.5), new CGUtilities.Point(215, 105.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(215, 105.5), new CGUtilities.Point(166, 242.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(166, 242.5), new CGUtilities.Point(77, 114.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(77, 114.5), new CGUtilities.Point(34, 188.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(34, 188.5), new CGUtilities.Point(58, 221.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(58, 221.5), new CGUtilities.Point(12, 256.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);

            // Points:
            drawingCanvas.Points.Add(new CGUtilities.Point(-11, 235.5));
        }
        void MP_Case_5()
        {
            // Polygon[0]:
            var lines = new List<CGUtilities.Line>();
            var p = new CGUtilities.Polygon();
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(1, 258.5), new CGUtilities.Point(-16, 301.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-16, 301.5), new CGUtilities.Point(-25, 254.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-25, 254.5), new CGUtilities.Point(-42, 293.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-42, 293.5), new CGUtilities.Point(-49, 254.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-49, 254.5), new CGUtilities.Point(-104, 243.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-104, 243.5), new CGUtilities.Point(-110, 216.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-110, 216.5), new CGUtilities.Point(-46, 201.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-46, 201.5), new CGUtilities.Point(-104, 186.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-104, 186.5), new CGUtilities.Point(-114, 155.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-114, 155.5), new CGUtilities.Point(-16, 156.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-16, 156.5), new CGUtilities.Point(-89, 47.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-89, 47.5), new CGUtilities.Point(-104, -18.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-104, -18.5), new CGUtilities.Point(-109, -87.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-109, -87.5), new CGUtilities.Point(-95, -163.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-95, -163.5), new CGUtilities.Point(-46, -227.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-46, -227.5), new CGUtilities.Point(-67, -285.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-67, -285.5), new CGUtilities.Point(-117, -312.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-117, -312.5), new CGUtilities.Point(-53, -324.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-53, -324.5), new CGUtilities.Point(-24, -259.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-24, -259.5), new CGUtilities.Point(-19, -318.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-19, -318.5), new CGUtilities.Point(-37, -327.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(-37, -327.5), new CGUtilities.Point(15, -322.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(15, -322.5), new CGUtilities.Point(4, -255.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(4, -255.5), new CGUtilities.Point(42, -240.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(42, -240.5), new CGUtilities.Point(95, -233.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(95, -233.5), new CGUtilities.Point(134, -276.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(134, -276.5), new CGUtilities.Point(192, -318.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(192, -318.5), new CGUtilities.Point(271, -323.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(271, -323.5), new CGUtilities.Point(392, -305.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(392, -305.5), new CGUtilities.Point(345, -287.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(345, -287.5), new CGUtilities.Point(352, -250.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(352, -250.5), new CGUtilities.Point(282, -251.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(282, -251.5), new CGUtilities.Point(322, -208.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(322, -208.5), new CGUtilities.Point(188, -204.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(188, -204.5), new CGUtilities.Point(222, -157.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(222, -157.5), new CGUtilities.Point(112, -181.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(112, -181.5), new CGUtilities.Point(168, -103.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(168, -103.5), new CGUtilities.Point(112, -87.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(112, -87.5), new CGUtilities.Point(55, -57.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(55, -57.5), new CGUtilities.Point(195, -3.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(195, -3.5), new CGUtilities.Point(35, 52.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(35, 52.5), new CGUtilities.Point(191, 110.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(191, 110.5), new CGUtilities.Point(29, 139.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(29, 139.5), new CGUtilities.Point(124, 178.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(124, 178.5), new CGUtilities.Point(20, 206.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(20, 206.5), new CGUtilities.Point(39, 224.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(39, 224.5), new CGUtilities.Point(28, 271.5)));
            lines.Add(new CGUtilities.Line(new CGUtilities.Point(28, 271.5), new CGUtilities.Point(1, 258.5)));
            foreach (var l in lines)
                drawingCanvas.Lines.Add(l);
            p.lines = lines;
            drawingCanvas.Polygons.Add(p);

            // Points:
            drawingCanvas.Points.Add(new CGUtilities.Point(-36, 231.5));


        }

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Add the default "Drawing Mode" option.
            this.algorithmList.Items.Add("Drawing Mode");
            this.algorithmList.SelectedIndex = 0;

            // Get all types in the Algorithm assembly.
            var assemblyTypes = Assembly.GetAssembly(typeof(Algorithm)).GetTypes();
            // Filter to the types that inherite from the abstract class Algorithm.
            var algorithmTypes = assemblyTypes.Where(x => !x.IsAbstract && x.IsSubclassOf(typeof(Algorithm)));
            // Loop on them..
            foreach (var algorithm in algorithmTypes)
            {
                // Initialize instances of the algorithm-based class and add them into the combobox.
                this.algorithmList.Items.Add((Algorithm)Activator.CreateInstance(algorithm, null));
            }


            //Polygon Tri.

            //easy 1
            //PT_Case_1();
            //easy 2
            //PT_Case_2();
            //mid 1
            //PT_Case_3();
            //mid 2
            //PT_Case_4();
            //hard 1
            //PT_Case_5();

            //Monotone Tri.

            //easy 1
            //MT_Case_1();
            //easy 2
            //MT_Case_2();
            //mid 1
            //MT_Case_3();
            //mid 2
            //MT_Case_4();
            //hard 1
            //MT_Case_5();

            //Monotone Part.

            //easy 1
            //MP_Case_1();
            //easy 2
            //MP_Case_2();
            //mid 1
            //MP_Case_3();
            //mid 2
            //MP_Case_4();
            //hard
            MP_Case_5();

            this.drawingCanvas.Focus();
        }

        /// <summary>
        /// Clears the canvases from all points and lines.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            this.drawingCanvas.Points.Clear();
            this.drawingCanvas.Lines.Clear();
            this.resultCanvas.Points.Clear();
            this.resultCanvas.Lines.Clear();
            this.drawingCanvas.Reset();
            this.resultCanvas.Reset();
            this.drawingCanvas.Focus();
            this.algorithmList.SelectedIndex = 0;
        }

        /// <summary>
        /// Handle the selection of the algorithms combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void algorithmList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if the selection was the default "Drawing Mode".
            if (this.algorithmList.SelectedIndex == 0)
            {
                this.resultCanvas.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                // save polygon
                StreamWriter sw = new StreamWriter("Save Drawed Points.txt");
                int i = 0;

                foreach (var p in drawingCanvas.Polygons)
                {
                    sw.WriteLine("// Polygon[" + i + "]:");

                    if (i == 0)
                        sw.Write("var ");

                    sw.WriteLine("lines = new List<CGUtilities.Line>();");

                    if (i == 0)
                        sw.Write("var ");

                    sw.WriteLine("p = new CGUtilities.Polygon();");

                    foreach (var l in p.lines)
                    {
                        sw.WriteLine("lines.Add(new CGUtilities.Line(new CGUtilities.Point(" + l.Start.X + ", " + l.Start.Y + "), new CGUtilities.Point(" + l.End.X + ", " + l.End.Y + ")));");
                    }

                    sw.WriteLine("foreach (var l in lines)");
                    sw.WriteLine("      drawingCanvas.Lines.Add(l);");

                    sw.WriteLine("p.lines = lines;");
                    sw.WriteLine("drawingCanvas.Polygons.Add(p);");

                    sw.WriteLine();
                    ++i;
                }

                sw.WriteLine("// Lines:");
                foreach (var l in drawingCanvas.Lines)
                {
                    sw.WriteLine("drawingCanvas.Lines.Add(new CGUtilities.Line(new CGUtilities.Point(" + l.Start.X + ", " + l.Start.Y + "), new CGUtilities.Point(" + l.End.X + ", " + l.End.Y + ")));");
                }

                sw.WriteLine();


                sw.WriteLine("// Points:");
                foreach (var l in drawingCanvas.Points)
                {
                    sw.WriteLine("drawingCanvas.Points.Add(new CGUtilities.Point(" + l.X + ", " + l.Y + "));");
                }

                sw.WriteLine();


                sw.Close();

                this.resultCanvas.Visibility = System.Windows.Visibility.Visible;

                // Get the algorithm to run.
                Algorithm selectedAlgorithm = this.algorithmList.SelectedItem as Algorithm;

                // Run the algorithm.
                List<CGUtilities.Point> points = new List<CGUtilities.Point>();
                List<CGUtilities.Line> lines = new List<CGUtilities.Line>();
                List<CGUtilities.Polygon> polygon = new List<CGUtilities.Polygon>();

                selectedAlgorithm.Run(((CGUtilities.Point[])this.drawingCanvas.Points.ToArray().Clone()).ToList(),
                    ((CGUtilities.Line[])this.drawingCanvas.Lines.ToArray().Clone()).ToList(),
                    ((CGUtilities.Polygon[])this.drawingCanvas.Polygons.ToArray().Clone()).ToList(),
                    ref points, ref lines, ref polygon);

                // Clear the result canvas.
                this.resultCanvas.Points.Clear();
                this.resultCanvas.Lines.Clear();

                // Populate the result canvase with the results.
                foreach (var item in points)
                {
                    this.resultCanvas.Points.Add(item);
                }

                foreach (var item in lines)
                {
                    this.resultCanvas.Lines.Add(item);
                }
            }

            this.drawingCanvas.Focus();
        }
    }
}
