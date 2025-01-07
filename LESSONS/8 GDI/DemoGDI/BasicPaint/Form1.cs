using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BasicPaint
{
    public partial class Form1 : Form
    {
        private Bitmap paintImage;
        private Graphics paintGraphics;
        private Point lastPoint;
        private bool isMouseDown = false;
        private ColorDialog colorPicker = new ColorDialog();
        private Bitmap workingImage;
        private Graphics workingGraphics;
        private System.Windows.Forms.Button selectedShapeButton;
        public Form1()
        {
            InitializeComponent();

            loadPictureBox();
            selectedShapeButton = btnPen;
            selectedShapeButton.BackColor = Color.Red;
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            clickedButton.BackColor = Color.Red;
            selectedShapeButton = clickedButton;
        }

        void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (selectedShapeButton.Text == "Pen")
                {
                    DrawLineInCanvas(e.Location);
                }
                else
                {
                    DrawShapeInWorkingImage(e.Location);
                }
            }
        }

        void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (selectedShapeButton.Text != "Pen")
            {
                DrawShapeInWorkingImage(e.Location);
                paintImage = new Bitmap(workingImage);
                paintGraphics = Graphics.FromImage(paintImage);
                pictureBox.Image = paintImage;
            }
        }

        private void DrawShapeInWorkingImage(Point currentPoint)
        {
            Pen pen = new Pen(colorPicker.Color, trackBar.Value);

            workingImage = new Bitmap(paintImage);
            workingGraphics = Graphics.FromImage(workingImage);

            int startPointX = lastPoint.X < currentPoint.X ? lastPoint.X : currentPoint.X;
            int startPointY = lastPoint.Y < currentPoint.Y ? lastPoint.Y : currentPoint.Y;

            int shapeWidth = (lastPoint.X > currentPoint.X ? lastPoint.X : currentPoint.X) - startPointX;
            int shapeHeight = (lastPoint.Y > currentPoint.Y ? lastPoint.Y : currentPoint.Y) - startPointY;

            switch (selectedShapeButton.Text)
            {
                case "Rectangle":
                    if (!cbFillColor.Checked)
                    {
                        workingGraphics.DrawRectangle(pen, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    else
                    {
                        workingGraphics.FillRectangle(pen.Brush, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    break;

                case "Circle":
                    if (!cbFillColor.Checked)
                    {
                        workingGraphics.DrawEllipse(pen, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    else
                    {
                        workingGraphics.FillEllipse(pen.Brush, startPointX, startPointY, shapeWidth, shapeHeight);
                    }
                    break;

                case "Triangle":
                    Point point1 = new Point() { X = startPointX, Y = startPointY + shapeHeight };
                    Point point2 = new Point() { X = startPointX + (shapeWidth / 2), Y = startPointY };
                    Point point3 = new Point() { X = startPointX + shapeWidth, Y = startPointY + shapeHeight };

                    if (!cbFillColor.Checked)
                    {
                        workingGraphics.DrawPolygon(pen, new Point[] { point1, point2, point3 });
                    }
                    else
                    {
                        workingGraphics.FillPolygon(pen.Brush, new Point[] { point1, point2, point3 });
                    }
                    break;

                case "Line":
                    workingGraphics.DrawLine(pen, lastPoint, currentPoint);
                    break;
            }

            if (isMouseDown && selectedShapeButton.Text != "Line")
            {
                Pen outLinePen = new Pen(Color.Black);
                outLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                workingGraphics.DrawRectangle(outLinePen, startPointX, startPointY, shapeWidth, shapeHeight);
            }

            pictureBox.Image = workingImage;
        }

        private void DrawLineInCanvas(Point currentPoint)
        {
            Pen pen = new Pen(colorPicker.Color, trackBar.Value);
            paintGraphics.DrawLine(pen, lastPoint, currentPoint);
            lastPoint = currentPoint;
            pictureBox.Refresh();
        }

        private void loadPictureBox()
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;

            paintImage = new Bitmap(width, height);

            paintGraphics = Graphics.FromImage(paintImage);

            paintGraphics.FillRectangle(Brushes.White, 0, 0, width, height);

            pictureBox.Image = paintImage;

            pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            clickedButton.BackColor = Color.Red;
            selectedShapeButton = clickedButton;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            clickedButton.BackColor = Color.Red;
            selectedShapeButton = clickedButton;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            clickedButton.BackColor = Color.Red;
            selectedShapeButton = clickedButton;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            selectedShapeButton.BackColor = SystemColors.Control;
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            clickedButton.BackColor = Color.Red;
            selectedShapeButton = clickedButton;
        }
    }
}
