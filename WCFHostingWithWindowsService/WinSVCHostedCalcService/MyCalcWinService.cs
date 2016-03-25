namespace WCFHostingWithWindowsService.WinSVCHostedCalcService
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.ServiceProcess;

    public partial class MyCalcWinService : ServiceBase
    {
        private ServiceHost m_svcHost = null;

        public MyCalcWinService()
        {
            this.InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (this.m_svcHost != null) this.m_svcHost.Close();

            /*The OnStart() handler is called, when the said service is started (through service control panel, or command line or otherwise),it does the following things.*/

            /*Defines two end points.*/
            string strAdrHTTP = "http://localhost:9001/CalcService";
            string strAdrTCP = "net.tcp://localhost:9002/CalcService";

            /*Creates and initializes a new instance of ServiceHost class, with the instance of the service (WCFCalcLib.CalcService) and its base addresses (adrbase) specified.*/
            Uri[] adrbase = { new Uri(strAdrHTTP), new Uri(strAdrTCP) };
            this.m_svcHost = new ServiceHost(typeof(WCFHostingWithWindowsService.WCFCalcLib.CalcService), adrbase);

            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
            this.m_svcHost.Description.Behaviors.Add(mBehave);

            /*Adding service endpoints to the hosted service*/
            BasicHttpBinding httpb = new BasicHttpBinding();
            this.m_svcHost.AddServiceEndpoint(typeof(WCFHostingWithWindowsService.WCFCalcLib.Interface.ICalcService), httpb, strAdrHTTP);
            this.m_svcHost.AddServiceEndpoint(typeof(IMetadataExchange),
            MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            
            NetTcpBinding tcpb = new NetTcpBinding();
            /*Adding just behavior to the service is not sufficient for publication of metadata, you must add an IMetadataExchange endpoint to your service for each supported binding type.*/
            this.m_svcHost.AddServiceEndpoint(typeof(WCFHostingWithWindowsService.WCFCalcLib.Interface.ICalcService), tcpb, strAdrTCP);
            this.m_svcHost.AddServiceEndpoint(typeof(IMetadataExchange),
            MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

            /*Finally open the host, and we are ready to go.*/
            this.m_svcHost.Open();
        }

        protected override void OnStop()
        {
            if (m_svcHost != null)
            {
                m_svcHost.Close();
                m_svcHost = null;
            }
        }
    }
}
