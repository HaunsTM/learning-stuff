namespace CalcClient
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double dblX = 2000.0;
            double dblY = 100.0;
            double dblResult = 0;
            try
            {
                Console.WriteLine("Using TCP Binding", dblX, dblY, dblResult);
                CalcServiceClient objCalcClient1 = new CalcServiceClient("NetTcpBinding_ICalcService");
                dblResult = objCalcClient1.Add(dblX, dblY);
                Console.WriteLine("Calling Add >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2} ", dblX, dblY, dblResult);
                dblResult = objCalcClient1.Subtract(dblX, dblY);
                Console.WriteLine("Calling Sub >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2}", dblX, dblY, dblResult);
                dblResult = objCalcClient1.Multiply(dblX, dblY);
                Console.WriteLine("Calling Mul >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2}", dblX, dblY, dblResult);
                dblResult = objCalcClient1.Divide(dblX, dblY);
                Console.WriteLine("Calling Sub >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2}", dblX, dblY, dblResult);
                Console.WriteLine("Using Basic HTTP Binding", dblX, dblY, dblResult);
                CalcServiceClient objCalcClient2 = new CalcServiceClient("BasicHttpBinding_ICalcService");
                dblResult = objCalcClient2.Add(dblX, dblY);
                Console.WriteLine("Calling Add >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2}", dblX, dblY, dblResult);
                dblResult = objCalcClient2.Subtract(dblX, dblY);
                Console.WriteLine("Calling Sub >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2}", dblX, dblY, dblResult);
                dblResult = objCalcClient2.Multiply(dblX, dblY);
                Console.WriteLine("Calling Mul >>  X : {0:F2}  Y : {1:F2}  Result: {2:F2}", dblX, dblY, dblResult);
                dblResult = objCalcClient2.Divide(dblX, dblY);
                Console.WriteLine("Calling Sub >>  X : {0:F2}  Y : {1:F2}  Result: { 2:F2}", dblX, dblY, dblResult);
            }
            catch (Exception eX)
            {
                Console.WriteLine("There was an error while calling Service [" + eX.Message + "]");
            }
        }
    }
}
