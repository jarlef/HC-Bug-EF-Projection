using Data;

namespace HC15;

public class InitializeDbService(CompanyContext companyContext) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await companyContext.Seed(stoppingToken);
    }
}
