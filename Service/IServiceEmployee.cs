namespace Service
{
    public interface IServiceEmployee
    {
        Task<IEnumerable<Employee>> GetAsync();
    }
}