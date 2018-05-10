namespace FinanzasApi
{
    using AutoMapper;
    using System.Reflection;

    public class AutomapperConfiguration
    {
        public void Configure()
        {
            Mapper.Initialize(x => x.AddProfiles(Assembly.GetExecutingAssembly()));
        }
    }
}
