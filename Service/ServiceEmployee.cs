namespace Service
{
    public class ServiceEmployee : IServiceEmployee
    {
        public Task<IEnumerable<Employee>> GetAsync()
        {
            var result = Enumerable.Range(1, 5).Select(p => new Employee { Id = p, Name = $"Employee {p}" });

            return Task.FromResult(result);
        }
    }
}