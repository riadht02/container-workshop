namespace ApplicationDemoWorkshop
{
    using ApplicationDemoWorkshop.Pages;
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    public class MonitorHub : Hub
    {
        public async Task SendData()
        {
            var data  = new MonitoringDataModel();
            data.SessionCount = GlobalVariables.SessionCount;
            data.CpuUsage = GlobalVariables.GetCpuUsageForProcess();
            data.OsVersion = GlobalVariables.osver;
            data.Hostname = GlobalVariables.hostname;

            await Clients.All.SendAsync("ReceiveMessage", data);
        }
    }
}
