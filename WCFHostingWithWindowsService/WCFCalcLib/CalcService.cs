namespace WCFHostingWithWindowsService.WCFCalcLib
{
    using WCFHostingWithWindowsService.WCFCalcLib.Interface;

    public class CalcService : ICalcService
    {
        public double Add(double dblNum1, double dblNum2)
        {
            return (dblNum1 + dblNum2);
        }

        public double Subtract(double dblNum1, double dblNum2)
        {
            return (dblNum1 - dblNum2);
        }

        public double Multiply(double dblNum1, double dblNum2)
        {
            return (dblNum1 * dblNum2);
        }

        public double Divide(double dblNum1, double dblNum2)
        {
            return ((dblNum2 == 0) ? 0 : (dblNum1 / dblNum2));
        }
    }
}
