using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����� ������������� �����������
            this.Paint += Form1_Paint; // ������������� �� ������� Paint ��� ���������
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 2); // ������� ������

            // ���������� ������ ������
            PointF[] starPoints = {
                new PointF(200, 50), // ����
                new PointF(240, 150),
                new PointF(350, 150),
                new PointF(260, 210),
                new PointF(300, 320),
                new PointF(200, 250),
                new PointF(100, 320),
                new PointF(140, 210),
                new PointF(50, 150),
                new PointF(160, 150)
            };

            g.DrawPolygon(pen, starPoints); // ������ ������
        }
    }
}
