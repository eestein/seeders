public enum CountryRegion
{
    /// <summary>
    /// Norte
    /// </summary>
    North = 1,

    /// <summary>
    /// Nordeste
    /// </summary>
    Northeast = 2,

    /// <summary>
    /// Sudeste
    /// </summary>
    Southeast = 3,

    /// <summary>
    /// Sul
    /// </summary>
    South = 4,

    /// <summary>
    /// Centro-oeste
    /// </summary>
    Midwest = 5
}

public class State : BaseEntity
{
    /// <summary>
    /// Nome.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Sigla.
    /// </summary>
    public string Acronym { get; set; }

    /// <summary>
    /// Código de identificação nacional (Código IBGE no Brasil).
    /// </summary>
    public int NationalCode { get; set; }

    /// <summary>
    /// Região do país na qual o estado se encontra.
    /// </summary>
    public CountryRegion Region { get; set; }

    /// <summary>
    /// ID do país.
    /// </summary>
    public Guid CountryId { get; set; }

    /// <summary>
    /// País.
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// Cidades.
    /// </summary>
    public List<City> Cities { get; set; }

    public State()
    {
        Cities = new List<City>();
    }
}

DbModelBuilder.Entity<State>().HasData(
    new State
    {
        Id = Guid.Parse("203778f8-d5f1-4b44-939f-110c43836215"), Acronym = "BA", Name = "Bahia", NationalCode = 29,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("7877d5e2-7ed7-45f7-9c86-12d49206a17d"), Acronym = "CE", Name = "Ceará", NationalCode = 23,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("f24c294b-d670-4e40-ae09-15beab13fb46"), Acronym = "PB", Name = "Paraíba", NationalCode = 25,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("b5c5cc21-f23e-44f2-8332-17fac683cd1a"), Acronym = "DF", Name = "Distrito Federal", NationalCode = 53,
        Region = CountryRegion.Midwest, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("fc4e930a-407a-44f6-89f7-2cbb42973030"), Acronym = "PR", Name = "Paraná", NationalCode = 41,
        Region = CountryRegion.South, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("7540b0cb-914e-4f55-aa09-360d671204ba"), Acronym = "RN", Name = "Rio Grande do Norte", NationalCode = 24,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("b724cea5-b989-4f73-be94-3adef9c2958f"), Acronym = "SP", Name = "São Paulo", NationalCode = 35,
        Region = CountryRegion.Southeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("02c74069-b971-41dd-b0c6-3ed95ea03bd3"), Acronym = "SE", Name = "Sergipe", NationalCode = 28,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("39f54cdd-5bbb-4ae6-af53-41f21df4e742"), Acronym = "SC", Name = "Santa Catarina", NationalCode = 42,
        Region = CountryRegion.South, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("ed15a972-dbf0-4629-adcf-49b50e931992"), Acronym = "PI", Name = "Piauí", NationalCode = 22,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("effab603-92d4-47ec-8baa-5f45354e139f"), Acronym = "PE", Name = "Pernambuco", NationalCode = 26,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("bd13b95c-f3eb-4e2d-bd89-63198f705fb4"), Acronym = "PA", Name = "Pará", NationalCode = 15,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("a1c66b8e-b30b-4252-a34d-6a463b9644f7"), Acronym = "RJ", Name = "Rio de Janeiro", NationalCode = 33,
        Region = CountryRegion.Southeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("2741f6f8-a892-4fb3-bda0-6e48749e469f"), Acronym = "AM", Name = "Amazonas", NationalCode = 13,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("e38701a6-6cb2-45a1-80fb-735f83ac48a4"), Acronym = "ES", Name = "Espírito Santo", NationalCode = 32,
        Region = CountryRegion.Southeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("aa2c0de4-4c9c-403e-a08e-78710d734feb"), Acronym = "RS", Name = "Rio Grande do Sul", NationalCode = 43,
        Region = CountryRegion.South, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("90811b92-c733-440c-9c4b-7d0590ea166c"), Acronym = "AP", Name = "Amapá", NationalCode = 16,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("5177e782-00d0-48b9-8fa5-85b077eecfa5"), Acronym = "MT", Name = "Mato Grosso", NationalCode = 51,
        Region = CountryRegion.Midwest, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("41c0c860-4c7e-4d2a-bde1-8e72bf757383"), Acronym = "MS", Name = "Mato Grosso do Sul", NationalCode = 50,
        Region = CountryRegion.Midwest, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("6a4f76c8-9387-4471-97ab-92626996e7c0"), Acronym = "AL", Name = "Alagoas", NationalCode = 27,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("88ca4865-82b4-4149-a744-92c850ae99cf"), Acronym = "RO", Name = "Rondônia", NationalCode = 11,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("b76a1430-94e8-48cb-b6e8-9b0769ee25e6"), Acronym = "RR", Name = "Roraima", NationalCode = 14,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("916ed727-92c6-42b8-b3b4-9d83c6333682"), Acronym = "AC", Name = "Acre", NationalCode = 12,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("1da596a3-6a27-4389-b344-b67bec6c7d06"), Acronym = "MA", Name = "Maranhão", NationalCode = 21,
        Region = CountryRegion.Northeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("0be62f89-5a26-4a4f-90f0-bfa0d23c8b1e"), Acronym = "GO", Name = "Goiás", NationalCode = 52,
        Region = CountryRegion.Midwest, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("4185bc1c-2b9f-4b46-b696-ca35fe0f48d3"), Acronym = "MG", Name = "Minas Gerais", NationalCode = 31,
        Region = CountryRegion.Southeast, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    },
    new State
    {
        Id = Guid.Parse("4e65caf9-be04-4df2-abc8-d42d9148faa3"), Acronym = "TO", Name = "Tocantins", NationalCode = 17,
        Region = CountryRegion.North, CountryId = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d")
    }
);
