namespace WCFHostingWithWindowsService.WinSVCHostedCalcService
{
    using System.ComponentModel;
    using System.ServiceProcess;

    [RunInstaller(true)]
    public partial class CalcServiceInstaller : System.Configuration.Install.Installer
    {
        public CalcServiceInstaller()
        {
            //InitializeComponent();
            serviceProcessInstaller1 = new ServiceProcessInstaller();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1 = new ServiceInstaller();
            serviceInstaller1.ServiceName = "WinSvcHostedCalcService";
            serviceInstaller1.DisplayName = "WinSvcHostedCalcService";
            serviceInstaller1.Description = "WCF Calc Service Hosted by Windows NT Service";
            serviceInstaller1.StartType = ServiceStartMode.Automatic;
            Installers.Add(serviceProcessInstaller1);
            Installers.Add(serviceInstaller1);

        }
    }
}
