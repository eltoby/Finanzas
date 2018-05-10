namespace FinanzasApi
{
    using AutoMapper;
    using AutoMapper.Configuration.Conventions;
    using AutoMapper.Mappers;

    public class ToDTO : Profile
    {
        public ToDTO()
        {
            AddMemberConfiguration().AddMember<NameSplitMember>().AddName<PrePostfixName>(
                    _ => _.AddStrings(p => p.Postfixes, "Dto"));
            AddConditionalObjectMapper().Where((s, d) => s.Name == d.Name + "Dto");
        }
    }
}
