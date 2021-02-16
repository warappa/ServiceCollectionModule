namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Groups related service configurations.
    /// </summary>
    public interface IServiceCollectionModule
    {
        /// <summary>
        /// Adds the service configurations of this module to the provided <see cref="IServiceCollection"/> instance.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the service configurations of this module to.</param>
        void ConfigureServices(IServiceCollection services);
    }
}
