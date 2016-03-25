namespace WCFHostingWithWindowsService.WCFCalcLib.Interface
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ICalcService
    {
        [System.ServiceModel.OperationContract]
        double Add(double dblNum1, double dblNum2);
        [OperationContract]
        double Subtract(double dblNum1, double dblNum2);
        [OperationContract]
        double Multiply(double dblNum1, double dblNum2);
        [OperationContract]
        double Divide(double dblNum1, double dblNum2);
    }
    
}