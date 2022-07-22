namespace CalibrationAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }

        private void btnTakeNear4mA_Click(object sender, EventArgs e)
        {
            nudValue.Value = nudNear4mA.Value;
        }

        private void btnTakeNear20mA_Click(object sender, EventArgs e)
        {
            nudValue.Value = nudNear20mA.Value;
        }

        private void btnCalibrateAt4mA_Click(object sender, EventArgs e)
        {
            lbTaked4mA.Text = $"{nudNear4mA.Value}";
        }

        private void btnCalibrateAt20mA_Click(object sender, EventArgs e)
        {
            lbTaked20mA.Text = $"{nudNear20mA.Value}";
        }

        /*
            В общем случае калибровка по двум точкам дает наклон Kx и смещение Sx. Вычисляются они следующим образом:

            Kx = (p2 - p1) / (c2 - c1);
            Sx = Kx * c1 - p1;

            где p1, p2 - калибровочные точки в мА, c1, c2 - коды АЦП, соответствующие этим точкам.
            При измерении ток в мА вычисляется из кода АЦП так: ma = Kx * code - Sx;
            Чтобы привести вычисления к целочисленной арифметике, нужно масштабировать все значения, чтобы не потерять точность. И не забывать об округлении при каждой операции деления.        
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            // клибровочные точки
            var p1 = 4.0;
            var p2 = 20.0;
            // коды АЦП
            var c1 = double.Parse(lbTaked4mA.Text, System.Globalization.NumberStyles.Number);
            var c2 = double.Parse(lbTaked20mA.Text, System.Globalization.NumberStyles.Number);
            // наклон характеристики
            var Kx = (p2 - p1) / (c2 - c1);
            // смещение характеристики
            var Sx = Kx * c1 - p1;
            var mA = Kx * (double)nudValue.Value - Sx;
            lbResult.Text = $"{mA}";
        }
    }
}