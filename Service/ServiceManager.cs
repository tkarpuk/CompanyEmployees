using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IEmployeeService> _employeeService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repository, logger));
            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repository, logger)); 
        }

        public ICompanyService CompanyService => throw new NotImplementedException();

        public IEmployeeService EmployeeService => throw new NotImplementedException();
    }
}
