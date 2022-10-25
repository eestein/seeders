public class Country : BaseEntity
{
    /// <summary>
    /// Nome do país em português.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Nome completo do país em português.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Nome do país em inglês.
    /// </summary>
    public string EnglishName { get; set; }

    /// <summary>
    /// Nome do país no idioma nativo.
    /// </summary>
    public string NativeName { get; set; }

    /// <summary>
    /// Abreviação (Alpha-2).
    /// </summary>
    public string Iso2Code { get; set; }

    /// <summary>
    /// Abreviação (Alpha-3).
    /// </summary>
    public string Iso3Code { get; set; }

    /// <summary>
    /// Código númerico internacional identificador do país.
    /// </summary>
    public int NumericIsoCode { get; set; }

    /// <summary>
    /// Código DDI.
    /// </summary>
    public int CallingCode { get; set; }

    /// <summary>
    /// Estados.
    /// </summary>
    public List<State> States { get; set; }

    public Country()
    {
        States = new List<State>();
    }
}

DbModelBuilder.Entity<Country>().HasData(
    new Country
    {
        Id = Guid.Parse("0ee4a9ec-aed8-40e0-b2d0-2f447cc0022c"), Iso2Code = "AF", Iso3Code = "AFG", Name = "Afeganistão",
        FullName = "República Islâmica do Afeganistão", CallingCode = 93, NumericIsoCode = 4, EnglishName = "Afghanistan",
        NativeName = "افغانستان"
    },
    new Country
    {
        Id = Guid.Parse("87f66da9-77f8-489f-8cec-6321e770e3da"), Iso2Code = "AL", Iso3Code = "ALB", Name = "Albânia",
        FullName = "República da Albânia", CallingCode = 355, NumericIsoCode = 8, EnglishName = "Albania", NativeName = "Shqipëria"
    },
    new Country
    {
        Id = Guid.Parse("0dafa276-1d00-4067-be9f-47ce0c4fd0d2"), Iso2Code = "DZ", Iso3Code = "DZA", Name = "Algéria",
        FullName = "República Democrática Popular da Algéria", CallingCode = 213, NumericIsoCode = 12, EnglishName = "Algeria",
        NativeName = "الجزائر"
    },
    new Country
    {
        Id = Guid.Parse("41866c27-40c8-496b-ae52-56e56359898f"), Iso2Code = "AS", Iso3Code = "ASM", Name = "Samoa Americana",
        FullName = "Território de Samoa Americana", CallingCode = 1684, NumericIsoCode = 16, EnglishName = "American Samoa",
        NativeName = ""
    },
    new Country
    {
        Id = Guid.Parse("edfd807c-76ff-4798-8fa7-b2ace6d7b10c"), Iso2Code = "AD", Iso3Code = "AND", Name = "Andorra",
        FullName = "Principado Andorra", CallingCode = 376, NumericIsoCode = 20, EnglishName = "Andorra", NativeName = "Andorra"
    },
    new Country
    {
        Id = Guid.Parse("2d9e263c-1365-4282-9395-207fa5fe2b10"), Iso2Code = "AO", Iso3Code = "AGO", Name = "Angola",
        FullName = "República de Angola", CallingCode = 244, NumericIsoCode = 24, EnglishName = "Angola", NativeName = "Angola"
    },
    new Country
    {
        Id = Guid.Parse("8e6588d6-d726-4e65-a4a9-cffa8d27569f"), Iso2Code = "AI", Iso3Code = "AIA", Name = "Anguilla",
        FullName = "Anguilla", CallingCode = 1264, NumericIsoCode = 660, EnglishName = "Anguilla", NativeName = "Anguilla"
    },
    new Country
    {
        Id = Guid.Parse("8dfe29a1-003f-4b69-9c43-fa26097e87d1"), Iso2Code = "AQ", Iso3Code = "ATA", Name = "Antártida",
        FullName = "Antártida", CallingCode = 672, NumericIsoCode = 10, EnglishName = "Antarctica", NativeName = "Antarctica"
    },
    new Country
    {
        Id = Guid.Parse("5622f200-e55d-4092-ac54-7d9bf75a2ecd"), Iso2Code = "AG", Iso3Code = "ATG", Name = "Antigua e Barbuda",
        FullName = "Antigua e Barbuda", CallingCode = 1268, NumericIsoCode = 28, EnglishName = "Antigua and Barbuda",
        NativeName = "Antigua and Barbuda"
    },
    new Country
    {
        Id = Guid.Parse("01747427-9c1b-4d26-a1ca-eb35b1db62ea"), Iso2Code = "AR", Iso3Code = "ARG", Name = "Argentina",
        FullName = "República Argentina", CallingCode = 54, NumericIsoCode = 32, EnglishName = "Argentina", NativeName = "Argentina"
    },
    new Country
    {
        Id = Guid.Parse("eac9d015-2656-4466-9e0f-f330e6c9b451"), Iso2Code = "AM", Iso3Code = "ARM", Name = "Armênia",
        FullName = "República da Armênia", CallingCode = 374, NumericIsoCode = 51, EnglishName = "Armenia", NativeName = "Հայաստան"
    },
    new Country
    {
        Id = Guid.Parse("1ff7f489-759e-45f6-8276-7a8b5bf8283e"), Iso2Code = "AW", Iso3Code = "ABW", Name = "Aruba",
        FullName = "Aruba", CallingCode = 297, NumericIsoCode = 533, EnglishName = "Aruba", NativeName = "Aruba"
    },
    new Country
    {
        Id = Guid.Parse("38135b89-597e-4056-b66b-0ed5c3d90ed5"), Iso2Code = "AU", Iso3Code = "AUS", Name = "Austrália",
        FullName = "Comunidade da Austrália", CallingCode = 61, NumericIsoCode = 36, EnglishName = "Australia",
        NativeName = "Australia"
    },
    new Country
    {
        Id = Guid.Parse("4894d5a5-6d32-4d8e-9c2d-8750d4f2ffc5"), Iso2Code = "AT", Iso3Code = "AUT", Name = "Áustria",
        FullName = "República da Áustria", CallingCode = 43, NumericIsoCode = 40, EnglishName = "Austria", NativeName = "Österreich"
    },
    new Country
    {
        Id = Guid.Parse("3097de8e-fdca-42ce-a15c-e81c973a5667"), Iso2Code = "AZ", Iso3Code = "AZE", Name = "Azerbaijão",
        FullName = "República do Azerbaijão", CallingCode = 994, NumericIsoCode = 31, EnglishName = "Azerbaijan",
        NativeName = "Azərbaycan"
    },
    new Country
    {
        Id = Guid.Parse("47db99b7-08d8-42a6-b9f2-475c7ccaca08"), Iso2Code = "BS", Iso3Code = "BHS", Name = "Bahamas",
        FullName = "Comunidade de Bahamas", CallingCode = 1242, NumericIsoCode = 44, EnglishName = "Bahamas", NativeName = "Bahamas"
    },
    new Country
    {
        Id = Guid.Parse("31a44161-25e7-4288-8386-fc7315dc2bd4"), Iso2Code = "BH", Iso3Code = "BHR", Name = "Bahrein",
        FullName = "Reino do Bahrein", CallingCode = 973, NumericIsoCode = 48, EnglishName = "Bahrain", NativeName = "‏البحرين"
    },
    new Country
    {
        Id = Guid.Parse("f468b88d-a706-4d6d-8272-81edaf530563"), Iso2Code = "BD", Iso3Code = "BGD", Name = "Bangladesh",
        FullName = "República Popular de Bangladesh", CallingCode = 880, NumericIsoCode = 50, EnglishName = "Bangladesh",
        NativeName = "Bangladesh"
    },
    new Country
    {
        Id = Guid.Parse("230dddfa-2eab-4455-bc6a-b76acc263f11"), Iso2Code = "BB", Iso3Code = "BRB", Name = "Barbados",
        FullName = "Barbados", CallingCode = 246, NumericIsoCode = 52, EnglishName = "Barbados", NativeName = "Barbados"
    },
    new Country
    {
        Id = Guid.Parse("0bb859e0-9a17-4dc1-8574-85f669db580b"), Iso2Code = "BY", Iso3Code = "BLR", Name = "Bielorrússia",
        FullName = "República da Bielorrússia", CallingCode = 375, NumericIsoCode = 112, EnglishName = "Belarus",
        NativeName = "Белару́сь"
    },
    new Country
    {
        Id = Guid.Parse("1e703fe4-70c3-4db5-b01f-0861d62d445a"), Iso2Code = "BE", Iso3Code = "BEL", Name = "Bélgica",
        FullName = "Reino da Bélgica", CallingCode = 32, NumericIsoCode = 56, EnglishName = "Belgium", NativeName = "België"
    },
    new Country
    {
        Id = Guid.Parse("4d56f837-2737-4c05-abc6-f34faa5114f0"), Iso2Code = "BZ", Iso3Code = "BLZ", Name = "Belize",
        FullName = "Belize", CallingCode = 501, NumericIsoCode = 84, EnglishName = "Belize", NativeName = "Belize"
    },
    new Country
    {
        Id = Guid.Parse("76d82eff-ea03-41f2-b0ad-f13b60b81537"), Iso2Code = "BJ", Iso3Code = "BEN", Name = "Benin",
        FullName = "República do Benin", CallingCode = 229, NumericIsoCode = 204, EnglishName = "Benin", NativeName = "Bénin"
    },
    new Country
    {
        Id = Guid.Parse("e27860d4-d167-411a-9251-72d53eb332ae"), Iso2Code = "BM", Iso3Code = "BMU", Name = "Bermuda",
        FullName = "Bermuda", CallingCode = 1441, NumericIsoCode = 60, EnglishName = "Bermuda", NativeName = "Bermuda"
    },
    new Country
    {
        Id = Guid.Parse("85105b5f-5dfa-4ed0-bcf6-763f83de79f7"), Iso2Code = "BT", Iso3Code = "BTN", Name = "Butão",
        FullName = "Reino do Butão", CallingCode = 975, NumericIsoCode = 64, EnglishName = "Bhutan", NativeName = "ʼbrug-yul"
    },
    new Country
    {
        Id = Guid.Parse("4cf76f28-78af-4f2f-a992-43694712bc3b"), Iso2Code = "BO", Iso3Code = "BOL", Name = "Bolívia",
        FullName = "Estado Plurinacional da Bolívia", CallingCode = 591, NumericIsoCode = 68, EnglishName = "Bolivia",
        NativeName = "Bolivia"
    },
    new Country
    {
        Id = Guid.Parse("f1967999-aed3-45ce-9172-33aaaa05b2b9"), Iso2Code = "BA", Iso3Code = "BIH", Name = "Bósnia e Herzegovina",
        FullName = "Bósnia e Herzegovina", CallingCode = 387, NumericIsoCode = 70, EnglishName = "Bosnia and Herzegovina",
        NativeName = "Bosna i Hercegovina"
    },
    new Country
    {
        Id = Guid.Parse("d65709f1-811d-4dec-ac9a-fa6591150e31"), Iso2Code = "BW", Iso3Code = "BWA", Name = "Botswana",
        FullName = "República da Botswana", CallingCode = 267, NumericIsoCode = 72, EnglishName = "Botswana",
        NativeName = "Botswana"
    },
    new Country
    {
        Id = Guid.Parse("ff7ec4c1-cc4b-4e84-8c1f-fd1a8b071453"), Iso2Code = "BV", Iso3Code = "BVT", Name = "Ilha Bouvet",
        FullName = "Ilha Bouvet", CallingCode = 47, NumericIsoCode = 74, EnglishName = "Bouvet Island", NativeName = "Bouvetøya"
    },
    new Country
    {
        Id = Guid.Parse("02ab2996-9503-4605-9f9a-a405566a0c7d"), Iso2Code = "BR", Iso3Code = "BRA", Name = "Brasil",
        FullName = "República Federativa do Brasil", CallingCode = 55, NumericIsoCode = 76, EnglishName = "Brazil",
        NativeName = "Brasil"
    },
    new Country
    {
        Id = Guid.Parse("e39e3882-81d6-42a7-8953-025d9229a7be"), Iso2Code = "IO", Iso3Code = "IOT",
        Name = "Território Britânico do Oceano Índico", FullName = "Território Britânico do Oceano Índico", CallingCode = 246,
        NumericIsoCode = 86, EnglishName = "British Indian Ocean Territory", NativeName = "British Indian Ocean Territory"
    },
    new Country
    {
        Id = Guid.Parse("d5a4b60e-22d9-4b53-99d4-94bcf22716cf"), Iso2Code = "BN", Iso3Code = "BRN", Name = "Brunei",
        FullName = "Estado do Brunei Darussalam", CallingCode = 673, NumericIsoCode = 96, EnglishName = "Brunei Darussalam",
        NativeName = "Negara Brunei Darussalam"
    },
    new Country
    {
        Id = Guid.Parse("71cfb26c-976a-40de-8c17-28534f2ba017"), Iso2Code = "BG", Iso3Code = "BGR", Name = "Bulgária",
        FullName = "República da Bulgária", CallingCode = 359, NumericIsoCode = 100, EnglishName = "Bulgaria",
        NativeName = "България"
    },
    new Country
    {
        Id = Guid.Parse("6580d924-f8f4-46d7-98a6-ea800a025753"), Iso2Code = "BF", Iso3Code = "BFA", Name = "Burkina Faso",
        FullName = "Burkina Faso", CallingCode = 226, NumericIsoCode = 854, EnglishName = "Burkina Faso",
        NativeName = "Burkina Faso"
    },
    new Country
    {
        Id = Guid.Parse("e361d052-d6e1-488a-8519-af6cf79013b3"), Iso2Code = "BI", Iso3Code = "BDI", Name = "Burundi",
        FullName = "República do Burundi", CallingCode = 257, NumericIsoCode = 108, EnglishName = "Burundi", NativeName = "Burundi"
    },
    new Country
    {
        Id = Guid.Parse("9cd06ee5-58f5-45cc-a0a0-3c9d3cca437d"), Iso2Code = "KH", Iso3Code = "KHM", Name = "Camboja",
        FullName = "Reino do Camboja", CallingCode = 855, NumericIsoCode = 116, EnglishName = "Cambodia", NativeName = "Kâmpŭchéa"
    },
    new Country
    {
        Id = Guid.Parse("affbda72-f836-4204-91e8-1ed0b5cac5e2"), Iso2Code = "CM", Iso3Code = "CMR", Name = "Camarões",
        FullName = "República de Camarões", CallingCode = 237, NumericIsoCode = 120, EnglishName = "Cameroon",
        NativeName = "Cameroon"
    },
    new Country
    {
        Id = Guid.Parse("f2cbf64d-ee19-4b6f-8101-e3b71d64883a"), Iso2Code = "CA", Iso3Code = "CAN", Name = "Canadá",
        FullName = "Canadá", CallingCode = 1, NumericIsoCode = 124, EnglishName = "Canada", NativeName = "Canada"
    },
    new Country
    {
        Id = Guid.Parse("bb95d987-a719-460f-a786-e711417549b1"), Iso2Code = "CV", Iso3Code = "CPV", Name = "Cabo Verde",
        FullName = "República do Cabo Verde", CallingCode = 238, NumericIsoCode = 132, EnglishName = "Cape Verde",
        NativeName = "Cabo Verde"
    },
    new Country
    {
        Id = Guid.Parse("c2fd3964-1773-4653-ac15-813c1d5026e1"), Iso2Code = "KY", Iso3Code = "CYM", Name = "Ilhas Cayman",
        FullName = "Ilhas Cayman", CallingCode = 1345, NumericIsoCode = 136, EnglishName = "Cayman Islands",
        NativeName = "Cayman Islands"
    },
    new Country
    {
        Id = Guid.Parse("434dda70-ae50-442d-80ed-aa554d5fcce8"), Iso2Code = "CF", Iso3Code = "CAF",
        Name = "República Centro-Africana", FullName = "República Centro-Africana", CallingCode = 236, NumericIsoCode = 140,
        EnglishName = "Central African Republic", NativeName = "Ködörösêse tî Bêafrîka"
    },
    new Country
    {
        Id = Guid.Parse("6033edc0-3632-47c6-b385-f55eb813b4f4"), Iso2Code = "TD", Iso3Code = "TCD", Name = "Chade",
        FullName = "República do Chade", CallingCode = 235, NumericIsoCode = 148, EnglishName = "Chad", NativeName = "Tchad"
    },
    new Country
    {
        Id = Guid.Parse("cbe1853e-243e-4f61-a5bf-f88be9f09281"), Iso2Code = "CL", Iso3Code = "CHL", Name = "Chile",
        FullName = "República do Chile", CallingCode = 56, NumericIsoCode = 152, EnglishName = "Chile", NativeName = "Chile"
    },
    new Country
    {
        Id = Guid.Parse("d0e25fff-89a7-439a-8002-2f34aa15af2b"), Iso2Code = "CN", Iso3Code = "CHN", Name = "China",
        FullName = "República Popular da China", CallingCode = 86, NumericIsoCode = 156, EnglishName = "China", NativeName = "中国"
    },
    new Country
    {
        Id = Guid.Parse("292886c0-f6cd-43d6-a1f5-1e6400f0cf0f"), Iso2Code = "CX", Iso3Code = "CXR", Name = "Ilha Christmas",
        FullName = "Território da Ilha Christmas", CallingCode = 61, NumericIsoCode = 162, EnglishName = "Christmas Island",
        NativeName = "Christmas Island"
    },
    new Country
    {
        Id = Guid.Parse("768000fc-9036-4f48-8c94-70541e9a639a"), Iso2Code = "CC", Iso3Code = "CCK", Name = "Ilhas Cocos (Keeling",
        FullName = "Território das Ilhas Cocos (Keeling", CallingCode = 672, NumericIsoCode = 166,
        EnglishName = "Cocos (Keeling Islands", NativeName = "Cocos (Keeling Islands"
    },
    new Country
    {
        Id = Guid.Parse("002e9ba5-e3d9-428c-8933-2b2d84010a7e"), Iso2Code = "CO", Iso3Code = "COL", Name = "Colômbia",
        FullName = "República da Colômbia", CallingCode = 57, NumericIsoCode = 170, EnglishName = "Colombia",
        NativeName = "Colombia"
    },
    new Country
    {
        Id = Guid.Parse("589b04a7-2eb2-42f2-9673-0e2fa8dd4f6c"), Iso2Code = "KM", Iso3Code = "COM", Name = "Comores",
        FullName = "União das Comores", CallingCode = 269, NumericIsoCode = 174, EnglishName = "Comoros", NativeName = "Komori"
    },
    new Country
    {
        Id = Guid.Parse("3034155c-ca16-47dd-951b-4b0ab7815414"), Iso2Code = "CG", Iso3Code = "COG", Name = "Congo",
        FullName = "República do Congo", CallingCode = 242, NumericIsoCode = 178, EnglishName = "Congo",
        NativeName = "République du Congo"
    },
    new Country
    {
        Id = Guid.Parse("98ee2ed7-1e79-437c-9a87-a873dcf39c6f"), Iso2Code = "CK", Iso3Code = "COK", Name = "Ilhas Cook",
        FullName = "Ilhas Cook", CallingCode = 682, NumericIsoCode = 184, EnglishName = "Cook Islands", NativeName = "Cook Islands"
    },
    new Country
    {
        Id = Guid.Parse("2ebc7a4d-e3f2-4753-b21d-f43c0aa4f8d9"), Iso2Code = "CR", Iso3Code = "CRI", Name = "Costa Rica",
        FullName = "República da Costa Rica", CallingCode = 506, NumericIsoCode = 188, EnglishName = "Costa Rica",
        NativeName = "Costa Rica"
    },
    new Country
    {
        Id = Guid.Parse("2edc0987-b119-4055-9cb0-c579c1799ec0"), Iso2Code = "HR", Iso3Code = "HRV", Name = "Croácia",
        FullName = "República da Croácia", CallingCode = 385, NumericIsoCode = 191, EnglishName = "Croatia (Hrvatska",
        NativeName = "Hrvatska"
    },
    new Country
    {
        Id = Guid.Parse("a09a88e1-5dbf-478e-88e9-febd34bc6cc3"), Iso2Code = "CU", Iso3Code = "CUB", Name = "Cuba",
        FullName = "República de Cuba", CallingCode = 53, NumericIsoCode = 192, EnglishName = "Cuba", NativeName = "Cuba"
    },
    new Country
    {
        Id = Guid.Parse("50fa98a3-ed47-46ab-b95e-72dfa0b6c8d4"), Iso2Code = "CY", Iso3Code = "CYP", Name = "Chipre",
        FullName = "República do Chipre", CallingCode = 357, NumericIsoCode = 196, EnglishName = "Cyprus", NativeName = "Κύπρος"
    },
    new Country
    {
        Id = Guid.Parse("801fa056-32a6-4847-969e-a0ba06896f6d"), Iso2Code = "CZ", Iso3Code = "CZE", Name = "República Tcheca",
        FullName = "República Tcheca", CallingCode = 420, NumericIsoCode = 203, EnglishName = "Czech Republic",
        NativeName = "Česká republika"
    },
    new Country
    {
        Id = Guid.Parse("df06a3e4-5624-4d4b-946a-4e696140f349"), Iso2Code = "DK", Iso3Code = "DNK", Name = "Dinamarca",
        FullName = "Reino da Dinamarca", CallingCode = 45, NumericIsoCode = 208, EnglishName = "Denmark", NativeName = "Danmark"
    },
    new Country
    {
        Id = Guid.Parse("1607132c-4a5f-4d2c-bacd-33f991a53792"), Iso2Code = "DJ", Iso3Code = "DJI", Name = "Djibuti",
        FullName = "República do Djibuti", CallingCode = 253, NumericIsoCode = 262, EnglishName = "Djibouti",
        NativeName = "Djibouti"
    },
    new Country
    {
        Id = Guid.Parse("90fd5ed6-953e-41a3-b000-4e9d5715ca7d"), Iso2Code = "DM", Iso3Code = "DMA", Name = "Dominica",
        FullName = "Comunidade da Dominica", CallingCode = 1767, NumericIsoCode = 212, EnglishName = "Dominica",
        NativeName = "Dominica"
    },
    new Country
    {
        Id = Guid.Parse("aca33aa3-919f-4fa5-923f-73ac9ced7ec4"), Iso2Code = "DO", Iso3Code = "DOM", Name = "República Dominicana",
        FullName = "República Dominicana", CallingCode = 1809, NumericIsoCode = 214, EnglishName = "Dominican Republic",
        NativeName = "República Dominicana"
    },
    new Country
    {
        Id = Guid.Parse("5c2c5267-7f8b-4128-b781-e8f97c37a7b1"), Iso2Code = "TL", Iso3Code = "TLS", Name = "Timor-Leste",
        FullName = "República Democrática de Timor-Leste", CallingCode = 670, NumericIsoCode = 626, EnglishName = "East Timor",
        NativeName = ""
    },
    new Country
    {
        Id = Guid.Parse("660d2dda-d567-4513-bc08-41ac00f7744c"), Iso2Code = "EC", Iso3Code = "ECU", Name = "Equador",
        FullName = "República do Equador", CallingCode = 593, NumericIsoCode = 218, EnglishName = "Ecuador", NativeName = "Ecuador"
    },
    new Country
    {
        Id = Guid.Parse("88acc404-406d-4413-bead-1a9e28a4e80c"), Iso2Code = "EG", Iso3Code = "EGY", Name = "Egito",
        FullName = "República Árabe do Egito", CallingCode = 20, NumericIsoCode = 818, EnglishName = "Egypt", NativeName = "مصر‎"
    },
    new Country
    {
        Id = Guid.Parse("1b83ded7-c381-48b9-9659-3e88329bbbb4"), Iso2Code = "SV", Iso3Code = "SLV", Name = "El Salvador",
        FullName = "República El Salvador", CallingCode = 503, NumericIsoCode = 222, EnglishName = "El Salvador",
        NativeName = "El Salvador"
    },
    new Country
    {
        Id = Guid.Parse("2abd60af-6390-4e43-952c-73f938f2d3ed"), Iso2Code = "GQ", Iso3Code = "GNQ", Name = "Guiné Equatorial",
        FullName = "República do Guiné Equatorial", CallingCode = 240, NumericIsoCode = 226, EnglishName = "Equatorial Guinea",
        NativeName = "Guinea Ecuatorial"
    },
    new Country
    {
        Id = Guid.Parse("8eb5c11c-ebf8-4684-abb0-0c872fe596bb"), Iso2Code = "ER", Iso3Code = "ERI", Name = "Eritreia",
        FullName = "Estado da Eritreia", CallingCode = 291, NumericIsoCode = 232, EnglishName = "Eritrea", NativeName = "ኤርትራ"
    },
    new Country
    {
        Id = Guid.Parse("e4428c76-6f17-48e2-8a11-8453ce05bc99"), Iso2Code = "EE", Iso3Code = "EST", Name = "Estônia",
        FullName = "República da Estônia", CallingCode = 372, NumericIsoCode = 233, EnglishName = "Estonia", NativeName = "Eesti"
    },
    new Country
    {
        Id = Guid.Parse("27400b99-78fe-41cb-a036-42b31185b746"), Iso2Code = "ET", Iso3Code = "ETH", Name = "Etiópia",
        FullName = "República Democrática Federal da Etiópia", CallingCode = 251, NumericIsoCode = 231, EnglishName = "Ethiopia",
        NativeName = "ኢትዮጵያ"
    },
    new Country
    {
        Id = Guid.Parse("f4bb489f-0715-475e-9ada-043a14166081"), Iso2Code = "FK", Iso3Code = "FLK", Name = "Ilhas Malvinas",
        FullName = "Ilhas Malvinas", CallingCode = 500, NumericIsoCode = 238, EnglishName = "Falkland Islands (Malvinas",
        NativeName = "Falkland Islands"
    },
    new Country
    {
        Id = Guid.Parse("08d4b37a-d9b3-4d47-b46b-ca6031f52f2c"), Iso2Code = "FO", Iso3Code = "FRO", Name = "Ilhas Faroe",
        FullName = "Ilhas Faroe", CallingCode = 298, NumericIsoCode = 234, EnglishName = "Faroe Islands", NativeName = "Føroyar"
    },
    new Country
    {
        Id = Guid.Parse("fbb53b37-6300-4f25-a2e4-95ebb882fe5f"), Iso2Code = "FJ", Iso3Code = "FJI", Name = "Fiji",
        FullName = "República do Fiji", CallingCode = 679, NumericIsoCode = 242, EnglishName = "Fiji", NativeName = "Fiji"
    },
    new Country
    {
        Id = Guid.Parse("11ddd1b9-2f2b-4b5b-bfdf-80a859590c29"), Iso2Code = "FI", Iso3Code = "FIN", Name = "Finlândia",
        FullName = "República da Finlândia", CallingCode = 358, NumericIsoCode = 246, EnglishName = "Finland", NativeName = "Suomi"
    },
    new Country
    {
        Id = Guid.Parse("4c3c321b-6b18-4943-82e2-354db88452f1"), Iso2Code = "FR", Iso3Code = "FRA", Name = "França",
        FullName = "República Francesa", CallingCode = 33, NumericIsoCode = 250, EnglishName = "France", NativeName = "France"
    },
    new Country
    {
        Id = Guid.Parse("f4411ed8-ac48-41ab-b07f-2788eb60a885"), Iso2Code = "GF", Iso3Code = "GUF", Name = "Guiana Francesa",
        FullName = "Guiana Francesa", CallingCode = 594, NumericIsoCode = 254, EnglishName = "French Guiana",
        NativeName = "Guyane française"
    },
    new Country
    {
        Id = Guid.Parse("06bf7436-12cc-4bd2-9ecf-af5d427c980c"), Iso2Code = "PF", Iso3Code = "PYF", Name = "Polinésia Francesa",
        FullName = "Polinésia Francesa", CallingCode = 689, NumericIsoCode = 258, EnglishName = "French Polynesia",
        NativeName = "Polynésie française"
    },
    new Country
    {
        Id = Guid.Parse("9ab1966b-7e2a-442b-a5cc-1cc0a9317317"), Iso2Code = "TF", Iso3Code = "ATF",
        Name = "Terras Austrais e Antárticas Francesas", FullName = "Território das Terras Austrais e Antárticas Francesas",
        CallingCode = 33, NumericIsoCode = 260, EnglishName = "French Southern Territories",
        NativeName = "Territoire des Terres australes et antarctiques fr"
    },
    new Country
    {
        Id = Guid.Parse("a8ffe8ef-772b-4c75-b32b-932ed4b3f299"), Iso2Code = "GA", Iso3Code = "GAB", Name = "Gabão",
        FullName = "República Gabonesa", CallingCode = 241, NumericIsoCode = 266, EnglishName = "Gabon", NativeName = "Gabon"
    },
    new Country
    {
        Id = Guid.Parse("2107f705-9dbb-4c4c-999d-7741716ad0f6"), Iso2Code = "GM", Iso3Code = "GMB", Name = "Gâmbia",
        FullName = "República da Gâmbia", CallingCode = 220, NumericIsoCode = 270, EnglishName = "Gambia", NativeName = "Gambia"
    },
    new Country
    {
        Id = Guid.Parse("a045a8f6-cfc7-4ebb-88ad-50583f2803c0"), Iso2Code = "GE", Iso3Code = "GEO", Name = "Geórgia",
        FullName = "Geórgia", CallingCode = 995, NumericIsoCode = 268, EnglishName = "Georgia", NativeName = "საქართველო"
    },
    new Country
    {
        Id = Guid.Parse("5aa1d325-499b-4a23-babe-9c208cad3b4d"), Iso2Code = "DE", Iso3Code = "DEU", Name = "Alemanha",
        FullName = "República Federal da Alemanha", CallingCode = 49, NumericIsoCode = 276, EnglishName = "Germany",
        NativeName = "Deutschland"
    },
    new Country
    {
        Id = Guid.Parse("97bb5fe7-c09b-4038-9353-d6e0dc12e0fc"), Iso2Code = "GH", Iso3Code = "GHA", Name = "Gana",
        FullName = "Repúblia de Gana", CallingCode = 233, NumericIsoCode = 288, EnglishName = "Ghana", NativeName = "Ghana"
    },
    new Country
    {
        Id = Guid.Parse("4d12ee0a-5361-4016-8aa1-7e4e7aaa1905"), Iso2Code = "GI", Iso3Code = "GIB", Name = "Gibraltar",
        FullName = "Gibraltar", CallingCode = 350, NumericIsoCode = 292, EnglishName = "Gibraltar", NativeName = "Gibraltar"
    },
    new Country
    {
        Id = Guid.Parse("cee1acb0-55c2-4ca7-9dfd-5c6dfeb76efa"), Iso2Code = "GG", Iso3Code = "GGY", Name = "Guernsey",
        FullName = "Bailiado de Guernsey", CallingCode = 44, NumericIsoCode = 831, EnglishName = "Guernsey", NativeName = ""
    },
    new Country
    {
        Id = Guid.Parse("bad3a3c1-39a1-4822-8084-7945d0b3bfaa"), Iso2Code = "GR", Iso3Code = "GRC", Name = "Grécia",
        FullName = "República Helênica", CallingCode = 30, NumericIsoCode = 300, EnglishName = "Greece", NativeName = "Ελλάδα"
    },
    new Country
    {
        Id = Guid.Parse("61cd46de-5fa7-4dca-a0a3-45cdc3b9904f"), Iso2Code = "GL", Iso3Code = "GRL", Name = "Groelândia",
        FullName = "Groelândia", CallingCode = 299, NumericIsoCode = 304, EnglishName = "Greenland", NativeName = "Kalaallit Nunaat"
    },
    new Country
    {
        Id = Guid.Parse("eee87d17-a9b0-4458-8cab-77908c74748a"), Iso2Code = "GD", Iso3Code = "GRD", Name = "Granada",
        FullName = "Granada", CallingCode = 1473, NumericIsoCode = 308, EnglishName = "Grenada", NativeName = "Grenada"
    },
    new Country
    {
        Id = Guid.Parse("98a8cead-09c5-4b12-aa3b-d7d633de6dfb"), Iso2Code = "GP", Iso3Code = "GLP", Name = "Guadalupe",
        FullName = "Guadalupe", CallingCode = 590, NumericIsoCode = 312, EnglishName = "Guadeloupe", NativeName = "Guadeloupe"
    },
    new Country
    {
        Id = Guid.Parse("49b72a45-dbfb-43e0-b066-e7ac6b2b3c3d"), Iso2Code = "GU", Iso3Code = "GUM", Name = "Guão",
        FullName = "Território do Guão", CallingCode = 1671, NumericIsoCode = 316, EnglishName = "Guam", NativeName = "Guam"
    },
    new Country
    {
        Id = Guid.Parse("9958b2c2-b165-4ddd-8649-88c999ca5430"), Iso2Code = "GT", Iso3Code = "GTM", Name = "Guatemala",
        FullName = "República da Guatemala", CallingCode = 502, NumericIsoCode = 320, EnglishName = "Guatemala",
        NativeName = "Guatemala"
    },
    new Country
    {
        Id = Guid.Parse("b54c50d4-580f-4a7d-890b-3e0501ddbcf9"), Iso2Code = "GN", Iso3Code = "GIN", Name = "Guiné",
        FullName = "República do Guiné", CallingCode = 224, NumericIsoCode = 324, EnglishName = "Guinea", NativeName = "Guinée"
    },
    new Country
    {
        Id = Guid.Parse("de195d01-1ad7-4b48-a7f1-3662bbffe523"), Iso2Code = "GW", Iso3Code = "GNB", Name = "Guiné-Bissau",
        FullName = "República da Guiné-Bissau", CallingCode = 245, NumericIsoCode = 624, EnglishName = "Guinea-Bissau",
        NativeName = "Guiné-Bissau"
    },
    new Country
    {
        Id = Guid.Parse("49105398-b8f6-4262-9af7-5c2285c7357e"), Iso2Code = "GY", Iso3Code = "GUY", Name = "Guiana",
        FullName = "República Cooperativa da Guiana", CallingCode = 592, NumericIsoCode = 328, EnglishName = "Guyana",
        NativeName = "Guyana"
    },
    new Country
    {
        Id = Guid.Parse("db4139f7-830e-4049-bd8c-f27f6f6064b2"), Iso2Code = "HT", Iso3Code = "HTI", Name = "Haiti",
        FullName = "República do Haiti", CallingCode = 509, NumericIsoCode = 332, EnglishName = "Haiti", NativeName = "Haïti"
    },
    new Country
    {
        Id = Guid.Parse("45fb9ade-4f4c-4a7c-a7c2-47cdbb135bef"), Iso2Code = "HM", Iso3Code = "HMD", Name = "Ilhas Heard e McDonald",
        FullName = "Território das Ilhas Heard e McDonald", CallingCode = 672, NumericIsoCode = 334,
        EnglishName = "Heard and Mc Donald Islands", NativeName = "Heard Island and McDonald Islands"
    },
    new Country
    {
        Id = Guid.Parse("061ddb86-0cfd-4f8a-a686-6f27c61ee9cb"), Iso2Code = "HN", Iso3Code = "HND", Name = "Honduras",
        FullName = "República de Honduras", CallingCode = 504, NumericIsoCode = 340, EnglishName = "Honduras",
        NativeName = "Honduras"
    },
    new Country
    {
        Id = Guid.Parse("3b5f3f0b-ddb7-4723-8f7d-0a766f60dd31"), Iso2Code = "HK", Iso3Code = "HKG", Name = "Hong Kong",
        FullName = "Região Administrativa Especial de Hong Kong da República Popular da China", CallingCode = 852,
        NumericIsoCode = 344, EnglishName = "Hong Kong", NativeName = "香港"
    },
    new Country
    {
        Id = Guid.Parse("ad5bab66-a0e9-4864-ba84-6e19925cb31f"), Iso2Code = "HU", Iso3Code = "HUN", Name = "Hungria",
        FullName = "Hungria", CallingCode = 36, NumericIsoCode = 348, EnglishName = "Hungary", NativeName = "Magyarország"
    },
    new Country
    {
        Id = Guid.Parse("6040636d-2be4-48ea-9498-a77b8af3ce91"), Iso2Code = "IS", Iso3Code = "ISL", Name = "Islândia",
        FullName = "Islândia", CallingCode = 354, NumericIsoCode = 352, EnglishName = "Iceland", NativeName = "Ísland"
    },
    new Country
    {
        Id = Guid.Parse("90fe3b67-bcd5-4a7c-bec7-4ac89460c8df"), Iso2Code = "IN", Iso3Code = "IND", Name = "Índia",
        FullName = "República da Índia", CallingCode = 91, NumericIsoCode = 356, EnglishName = "India", NativeName = "भारत"
    },
    new Country
    {
        Id = Guid.Parse("1ae1cf9f-841e-413e-bea7-53e1b538a5a4"), Iso2Code = "IM", Iso3Code = "IMN", Name = "Ilha de Man",
        FullName = "Ilha de Man", CallingCode = 44, NumericIsoCode = 833, EnglishName = "Isle of Man", NativeName = "Isle of Man"
    },
    new Country
    {
        Id = Guid.Parse("9279464e-fac4-407c-9182-cf320c8e128a"), Iso2Code = "ID", Iso3Code = "IDN", Name = "Indonésia",
        FullName = "República da Indonésia", CallingCode = 62, NumericIsoCode = 360, EnglishName = "Indonesia",
        NativeName = "Indonesia"
    },
    new Country
    {
        Id = Guid.Parse("6403b6f4-73cc-46a4-a06b-45137414d01f"), Iso2Code = "IR", Iso3Code = "IRN", Name = "Iran",
        FullName = "República Islâmica do Iran", CallingCode = 98, NumericIsoCode = 364, EnglishName = "Iran (Islamic Republic of",
        NativeName = "ایران"
    },
    new Country
    {
        Id = Guid.Parse("cd3568df-4e66-40e2-819e-6ddb6cab497d"), Iso2Code = "IQ", Iso3Code = "IRQ", Name = "Iraque",
        FullName = "República do Iraque", CallingCode = 964, NumericIsoCode = 368, EnglishName = "Iraq", NativeName = "العراق"
    },
    new Country
    {
        Id = Guid.Parse("db3658f5-1128-4a3f-b7b6-67d1ed4cdc0d"), Iso2Code = "IE", Iso3Code = "IRL", Name = "Irlanda",
        FullName = "Irlanda", CallingCode = 353, NumericIsoCode = 372, EnglishName = "Ireland", NativeName = "Éire"
    },
    new Country
    {
        Id = Guid.Parse("dcafca49-59bb-4d2e-adcd-dd14fca96349"), Iso2Code = "IL", Iso3Code = "ISR", Name = "Israel",
        FullName = "Estado de Israel", CallingCode = 972, NumericIsoCode = 376, EnglishName = "Israel", NativeName = "יִשְׂרָאֵל"
    },
    new Country
    {
        Id = Guid.Parse("93d62e25-d902-497d-a7d3-7399cbb27a55"), Iso2Code = "IT", Iso3Code = "ITA", Name = "Itália",
        FullName = "República Italiana", CallingCode = 39, NumericIsoCode = 380, EnglishName = "Italy", NativeName = "Italia"
    },
    new Country
    {
        Id = Guid.Parse("77b202d7-5a05-4e87-adf1-5dfd3a16eabc"), Iso2Code = "CI", Iso3Code = "CIV", Name = "Costa do Marfim",
        FullName = "República da Costa do Marfim", CallingCode = 225, NumericIsoCode = 384, EnglishName = "Ivory Coast",
        NativeName = "Côte d''Ivoire"
    },
    new Country
    {
        Id = Guid.Parse("5ced8408-fb31-4cde-9859-1b1e62dcd17f"), Iso2Code = "JE", Iso3Code = "JEY", Name = "Jersey",
        FullName = "Bailiado de Jersey", CallingCode = 44, NumericIsoCode = 832, EnglishName = "Jersey", NativeName = "Jersey"
    },
    new Country
    {
        Id = Guid.Parse("72b821a9-4c08-4cc7-8679-44c4fe58cd2c"), Iso2Code = "JM", Iso3Code = "JAM", Name = "Jamaica",
        FullName = "Jamaica", CallingCode = 1876, NumericIsoCode = 388, EnglishName = "Jamaica", NativeName = "Jamaica"
    },
    new Country
    {
        Id = Guid.Parse("791ea683-96c3-4063-ac06-dceda186cafb"), Iso2Code = "JP", Iso3Code = "JPN", Name = "Japão",
        FullName = "Japão", CallingCode = 81, NumericIsoCode = 392, EnglishName = "Japan", NativeName = "日本"
    },
    new Country
    {
        Id = Guid.Parse("818fab42-4c44-4158-9c82-2a733732e007"), Iso2Code = "JO", Iso3Code = "JOR", Name = "Jordânia",
        FullName = "Reino Hachemita da Jordânia", CallingCode = 962, NumericIsoCode = 400, EnglishName = "Jordan",
        NativeName = "الأردن"
    },
    new Country
    {
        Id = Guid.Parse("cced3e45-a7ce-4265-8554-65b463ae37d7"), Iso2Code = "KZ", Iso3Code = "KAZ", Name = "Cazaquistão",
        FullName = "República do Cazaquistão", CallingCode = 7, NumericIsoCode = 398, EnglishName = "Kazakhstan",
        NativeName = "Қазақстан"
    },
    new Country
    {
        Id = Guid.Parse("75043403-d4a3-4bde-8443-207361faa191"), Iso2Code = "KE", Iso3Code = "KEN", Name = "Quênia",
        FullName = "República do Quênia", CallingCode = 254, NumericIsoCode = 404, EnglishName = "Kenya", NativeName = "Kenya"
    },
    new Country
    {
        Id = Guid.Parse("e19a37fd-3cc7-476d-9fda-b6d22ac10053"), Iso2Code = "KI", Iso3Code = "KIR", Name = "Kiribati",
        FullName = "República do Kiribati", CallingCode = 686, NumericIsoCode = 296, EnglishName = "Kiribati",
        NativeName = "Kiribati"
    },
    new Country
    {
        Id = Guid.Parse("8a37f903-abab-44ee-befc-7cebb1f8dfc3"), Iso2Code = "KP", Iso3Code = "PRK", Name = "Coreia do Norte",
        FullName = "República Democrática Popular da Coreia", CallingCode = 850, NumericIsoCode = 408, EnglishName = "North Korea",
        NativeName = "북한"
    },
    new Country
    {
        Id = Guid.Parse("6a099c1c-376e-412c-83e7-ecf2537a5427"), Iso2Code = "KR", Iso3Code = "KOR", Name = "Coreia do Sul",
        FullName = "República da Coreia", CallingCode = 82, NumericIsoCode = 410, EnglishName = "South Korea", NativeName = "대한민국"
    },
    new Country
    {
        Id = Guid.Parse("d5dca909-4ce9-43cd-86f8-b8dd4f298248"), Iso2Code = "KW", Iso3Code = "KWT", Name = "Kuwait",
        FullName = "Estado do Kuwait", CallingCode = 965, NumericIsoCode = 414, EnglishName = "Kuwait", NativeName = "الكويت"
    },
    new Country
    {
        Id = Guid.Parse("8073dd3c-1ac9-461e-874b-befc2e7c196c"), Iso2Code = "KG", Iso3Code = "KGZ", Name = "Quirguistão",
        FullName = "República Quirguiz", CallingCode = 996, NumericIsoCode = 417, EnglishName = "Kyrgyzstan",
        NativeName = "Кыргызстан"
    },
    new Country
    {
        Id = Guid.Parse("ed0f386a-a008-4c72-a9d9-41273c37056c"), Iso2Code = "LA", Iso3Code = "LAO", Name = "Laos",
        FullName = "República Democrática Popular Lau", CallingCode = 856, NumericIsoCode = 418,
        EnglishName = "Lao People''s Democratic Republic", NativeName = "ສປປລາວ"
    },
    new Country
    {
        Id = Guid.Parse("0369b849-2ba9-4afe-b323-bff03a0d7a8b"), Iso2Code = "LV", Iso3Code = "LVA", Name = "Letônia",
        FullName = "República da Letônia", CallingCode = 371, NumericIsoCode = 428, EnglishName = "Latvia", NativeName = "Latvija"
    },
    new Country
    {
        Id = Guid.Parse("664822d1-4fc7-4773-a6cd-8d4570ddcb7c"), Iso2Code = "LB", Iso3Code = "LBN", Name = "Líbano",
        FullName = "República Libanesa", CallingCode = 961, NumericIsoCode = 422, EnglishName = "Lebanon", NativeName = "لبنان"
    },
    new Country
    {
        Id = Guid.Parse("f1f999c9-db35-4c98-b699-9c26015371c8"), Iso2Code = "LS", Iso3Code = "LSO", Name = "Lesoto",
        FullName = "Reino do Lesoto", CallingCode = 266, NumericIsoCode = 426, EnglishName = "Lesotho", NativeName = "Lesotho"
    },
    new Country
    {
        Id = Guid.Parse("57e533f9-4bdd-4f99-9646-c756f409a98c"), Iso2Code = "LR", Iso3Code = "LBR", Name = "Libéria",
        FullName = "República da Libéria", CallingCode = 231, NumericIsoCode = 430, EnglishName = "Liberia", NativeName = "Liberia"
    },
    new Country
    {
        Id = Guid.Parse("e808ec4a-d9bd-4d57-a181-d0989131b995"), Iso2Code = "LY", Iso3Code = "LBY", Name = "Líbia",
        FullName = "Líbia", CallingCode = 218, NumericIsoCode = 434, EnglishName = "Libyan Arab Jamahiriya", NativeName = "‏ليبيا"
    },
    new Country
    {
        Id = Guid.Parse("ca922aa1-0a8e-426c-b862-d26e088bc35f"), Iso2Code = "LI", Iso3Code = "LIE", Name = "Liechtenstein",
        FullName = "Principado de Liechtenstein", CallingCode = 423, NumericIsoCode = 438, EnglishName = "Liechtenstein",
        NativeName = "Liechtenstein"
    },
    new Country
    {
        Id = Guid.Parse("8add8002-9702-4cbd-b2ab-4ea08a325382"), Iso2Code = "LT", Iso3Code = "LTU", Name = "Lituânia",
        FullName = "República da Lituânia", CallingCode = 370, NumericIsoCode = 440, EnglishName = "Lithuania",
        NativeName = "Lietuva"
    },
    new Country
    {
        Id = Guid.Parse("4cbfa998-f7e9-49fb-aa7f-a9d88e9ba1c0"), Iso2Code = "LU", Iso3Code = "LUX", Name = "Luxemburgo",
        FullName = "Grão-Ducado do Luxemburgo", CallingCode = 352, NumericIsoCode = 442, EnglishName = "Luxembourg",
        NativeName = "Luxembourg"
    },
    new Country
    {
        Id = Guid.Parse("318510c5-feed-4fa9-ab10-8dd19564660c"), Iso2Code = "MO", Iso3Code = "MAC", Name = "Macao",
        FullName = "Macao", CallingCode = 853, NumericIsoCode = 446, EnglishName = "Macau", NativeName = "澳門"
    },
    new Country
    {
        Id = Guid.Parse("a98a70ed-bd25-4d8d-ac8e-be06156cbe29"), Iso2Code = "MK", Iso3Code = "MKD", Name = "Macedônia",
        FullName = "República da Macedônia", CallingCode = 389, NumericIsoCode = 807, EnglishName = "Macedonia",
        NativeName = "Македонија"
    },
    new Country
    {
        Id = Guid.Parse("82ea9c48-2475-4573-a02f-59c1e47d6673"), Iso2Code = "MG", Iso3Code = "MDG", Name = "Madagascar",
        FullName = "República de Madagascar", CallingCode = 261, NumericIsoCode = 450, EnglishName = "Madagascar",
        NativeName = "Madagasikara"
    },
    new Country
    {
        Id = Guid.Parse("527606c5-f9ec-4f82-af27-61ac8f833003"), Iso2Code = "MW", Iso3Code = "MWI", Name = "Malawi",
        FullName = "República de Malawi", CallingCode = 265, NumericIsoCode = 454, EnglishName = "Malawi", NativeName = "Malawi"
    },
    new Country
    {
        Id = Guid.Parse("e4125c1e-2560-49a5-96b9-dde368a932bd"), Iso2Code = "MY", Iso3Code = "MYS", Name = "Malásia",
        FullName = "Malásia", CallingCode = 60, NumericIsoCode = 458, EnglishName = "Malaysia", NativeName = "Malaysia"
    },
    new Country
    {
        Id = Guid.Parse("97ce3c58-e140-427e-80f8-c3eb2d912b15"), Iso2Code = "MV", Iso3Code = "MDV", Name = "Maldivas",
        FullName = "Reública de Maldivas", CallingCode = 960, NumericIsoCode = 462, EnglishName = "Maldives",
        NativeName = "Maldives"
    },
    new Country
    {
        Id = Guid.Parse("e32cef23-5b4d-4f5e-b7a3-fd81db593e08"), Iso2Code = "ML", Iso3Code = "MLI", Name = "Mali",
        FullName = "República do Mali", CallingCode = 223, NumericIsoCode = 466, EnglishName = "Mali", NativeName = "Mali"
    },
    new Country
    {
        Id = Guid.Parse("14c06fe3-8991-4b23-b429-76dc4ba3210d"), Iso2Code = "MT", Iso3Code = "MLT", Name = "Malta",
        FullName = "República de Malta", CallingCode = 356, NumericIsoCode = 470, EnglishName = "Malta", NativeName = "Malta"
    },
    new Country
    {
        Id = Guid.Parse("fa744de7-803c-4b50-b627-a76a145d94ae"), Iso2Code = "MH", Iso3Code = "MHL", Name = "Ilhas Marshall",
        FullName = "República das Ilhas Marshall", CallingCode = 692, NumericIsoCode = 584, EnglishName = "Marshall Islands",
        NativeName = "M̧ajeļ"
    },
    new Country
    {
        Id = Guid.Parse("876e0e24-326c-4a6f-99cc-f573d05a0473"), Iso2Code = "MQ", Iso3Code = "MTQ", Name = "Martinica",
        FullName = "Martinica", CallingCode = 596, NumericIsoCode = 474, EnglishName = "Martinique", NativeName = "Martinique"
    },
    new Country
    {
        Id = Guid.Parse("9266f23b-cb5a-4ec0-be77-b64f2d6cb884"), Iso2Code = "MR", Iso3Code = "MRT", Name = "Mauritânia",
        FullName = "República Islâmica da Mauritânia", CallingCode = 222, NumericIsoCode = 478, EnglishName = "Mauritania",
        NativeName = "موريتانيا"
    },
    new Country
    {
        Id = Guid.Parse("329f8514-5f72-445c-914a-9f0c912ef50c"), Iso2Code = "MU", Iso3Code = "MUS", Name = "Maurício",
        FullName = "República de Maurício", CallingCode = 230, NumericIsoCode = 480, EnglishName = "Mauritius",
        NativeName = "Maurice"
    },
    new Country
    {
        Id = Guid.Parse("901baecf-8773-45cd-9175-85f08bd9d974"), Iso2Code = "YT", Iso3Code = "MYT", Name = "Mayotte",
        FullName = "Departamento de Mayotte", CallingCode = 269, NumericIsoCode = 175, EnglishName = "Mayotte", NativeName = ""
    },
    new Country
    {
        Id = Guid.Parse("2e37ab92-6bb5-499b-9aae-27c37e4962b9"), Iso2Code = "MX", Iso3Code = "MEX", Name = "México",
        FullName = "Estados Unidos Mexicanos", CallingCode = 52, NumericIsoCode = 484, EnglishName = "Mexico", NativeName = "México"
    },
    new Country
    {
        Id = Guid.Parse("8a32b359-293d-48c5-a463-b69795f7c757"), Iso2Code = "FM", Iso3Code = "FSM", Name = "Micronésia",
        FullName = "Estados Federados da Micronesia", CallingCode = 691, NumericIsoCode = 583,
        EnglishName = "Micronesia, Federated States of", NativeName = "Micronesia"
    },
    new Country
    {
        Id = Guid.Parse("436ede13-0d10-4f2e-b741-1f45aa7a970e"), Iso2Code = "MD", Iso3Code = "MDA", Name = "Moldova",
        FullName = "República de Moldova", CallingCode = 373, NumericIsoCode = 498, EnglishName = "Moldova, Republic of",
        NativeName = "Moldova"
    },
    new Country
    {
        Id = Guid.Parse("64d18818-624a-45c5-b06b-d7b0ee9aa049"), Iso2Code = "MC", Iso3Code = "MCO", Name = "Mônaco",
        FullName = "Principado de Mônaco", CallingCode = 377, NumericIsoCode = 492, EnglishName = "Monaco", NativeName = "Monaco"
    },
    new Country
    {
        Id = Guid.Parse("9a76a71c-98dd-4fb2-bf83-9ab1fa3abe30"), Iso2Code = "MN", Iso3Code = "MNG", Name = "Mongólia",
        FullName = "Mongólia", CallingCode = 976, NumericIsoCode = 496, EnglishName = "Mongolia", NativeName = "Монгол улс"
    },
    new Country
    {
        Id = Guid.Parse("d5de3d70-b40c-4913-bde0-94dcc096d010"), Iso2Code = "ME", Iso3Code = "MNE", Name = "Montenegro",
        FullName = "Montenegro", CallingCode = 382, NumericIsoCode = 499, EnglishName = "Montenegro", NativeName = "Црна Гора"
    },
    new Country
    {
        Id = Guid.Parse("9f0a153e-0649-41fe-a0cf-44119c33a2f2"), Iso2Code = "MS", Iso3Code = "MSR", Name = "Montserrat",
        FullName = "Montserrat", CallingCode = 1664, NumericIsoCode = 500, EnglishName = "Montserrat", NativeName = "Montserrat"
    },
    new Country
    {
        Id = Guid.Parse("828d36c2-ad30-40a3-a996-8f8ba24bcd2f"), Iso2Code = "MA", Iso3Code = "MAR", Name = "Marrocos",
        FullName = "Reino de Marrocos", CallingCode = 212, NumericIsoCode = 504, EnglishName = "Morocco", NativeName = "المغرب"
    },
    new Country
    {
        Id = Guid.Parse("8c9e3c47-01a7-46a8-87a3-d00e7db41174"), Iso2Code = "MZ", Iso3Code = "MOZ", Name = "Moçambique",
        FullName = "República de Moçambique", CallingCode = 258, NumericIsoCode = 508, EnglishName = "Mozambique",
        NativeName = "Moçambique"
    },
    new Country
    {
        Id = Guid.Parse("a288d2ee-076a-4b75-8bde-093199eef7e5"), Iso2Code = "MM", Iso3Code = "MMR", Name = "Birmânia",
        FullName = "República da União de Myanmar", CallingCode = 95, NumericIsoCode = 104, EnglishName = "Myanmar",
        NativeName = "Myanma"
    },
    new Country
    {
        Id = Guid.Parse("8da856ec-2dc4-469d-984a-3dcba1b623bc"), Iso2Code = "NA", Iso3Code = "NAM", Name = "Namíbia",
        FullName = "República da Namíbia", CallingCode = 264, NumericIsoCode = 516, EnglishName = "Namibia", NativeName = "Namibia"
    },
    new Country
    {
        Id = Guid.Parse("ed4b0a1b-26d1-4eae-b780-e4208e747d1a"), Iso2Code = "NR", Iso3Code = "NRU", Name = "Nauru",
        FullName = "República de Nauru", CallingCode = 674, NumericIsoCode = 520, EnglishName = "Nauru", NativeName = "Nauru"
    },
    new Country
    {
        Id = Guid.Parse("16de3b0f-1cbc-4564-a64d-a9cf5af359e5"), Iso2Code = "NP", Iso3Code = "NPL", Name = "Nepal",
        FullName = "República Democrática Federativa do Nepal", CallingCode = 977, NumericIsoCode = 524, EnglishName = "Nepal",
        NativeName = "नपल"
    },
    new Country
    {
        Id = Guid.Parse("328cf511-fec6-4a51-acf3-9fa7cd205e1d"), Iso2Code = "NL", Iso3Code = "NLD", Name = "Holanda",
        FullName = "Holanda", CallingCode = 31, NumericIsoCode = 528, EnglishName = "Netherlands", NativeName = "Nederland"
    },
    new Country
    {
        Id = Guid.Parse("a88af154-1dd9-40c9-baab-00690e2c5d7a"), Iso2Code = "AN", Iso3Code = "ANT", Name = "Antilhas Holandesas",
        FullName = "Antilhas Holandesas", CallingCode = 599, NumericIsoCode = 530, EnglishName = "Netherlands Antilles",
        NativeName = ""
    },
    new Country
    {
        Id = Guid.Parse("1c2dd74c-7cc5-46c0-ae6b-a7b28c2f02ad"), Iso2Code = "NC", Iso3Code = "NCL", Name = "Nova Caledônia",
        FullName = "Nova Caledônia", CallingCode = 687, NumericIsoCode = 540, EnglishName = "New Caledonia",
        NativeName = "Nouvelle-Calédonie"
    },
    new Country
    {
        Id = Guid.Parse("db0a2263-c86a-4a15-8766-3b58f9ae5d2b"), Iso2Code = "NZ", Iso3Code = "NZL", Name = "Nova Zelândia",
        FullName = "Nova Zelândia", CallingCode = 64, NumericIsoCode = 554, EnglishName = "New Zealand", NativeName = "New Zealand"
    },
    new Country
    {
        Id = Guid.Parse("f09e831c-c4c4-42de-98b3-3237e2d74622"), Iso2Code = "NI", Iso3Code = "NIC", Name = "Nicarágua",
        FullName = "República da Nicarágua", CallingCode = 505, NumericIsoCode = 558, EnglishName = "Nicaragua",
        NativeName = "Nicaragua"
    },
    new Country
    {
        Id = Guid.Parse("1b9fae55-8e31-40e7-87b1-2ebf1cff9ed1"), Iso2Code = "NE", Iso3Code = "NER", Name = "Niger",
        FullName = "República do Niger", CallingCode = 227, NumericIsoCode = 562, EnglishName = "Niger", NativeName = "Niger"
    },
    new Country
    {
        Id = Guid.Parse("47507eae-2544-4429-9e51-e59cd9e13ac8"), Iso2Code = "NG", Iso3Code = "NGA", Name = "Nigéria",
        FullName = "República Federativa da Nigéria", CallingCode = 234, NumericIsoCode = 566, EnglishName = "Nigeria",
        NativeName = "Nigeria"
    },
    new Country
    {
        Id = Guid.Parse("3053f9b4-4203-4ea2-a5ac-7918ebaeeff1"), Iso2Code = "NU", Iso3Code = "NIU", Name = "Niue",
        FullName = "Niue", CallingCode = 683, NumericIsoCode = 570, EnglishName = "Niue", NativeName = "Niuē"
    },
    new Country
    {
        Id = Guid.Parse("aee6639e-8aa8-4b04-ae0e-9b2ee0f7cd29"), Iso2Code = "NF", Iso3Code = "NFK", Name = "Ilha Norfolk",
        FullName = "Território da Ilha Norfolk", CallingCode = 672, NumericIsoCode = 574, EnglishName = "Norfolk Island",
        NativeName = "Norfolk Island"
    },
    new Country
    {
        Id = Guid.Parse("9d5c3797-c84c-46d1-99d8-f440444bb6ea"), Iso2Code = "MP", Iso3Code = "MNP",
        Name = "Ilhas Marianas do Norte", FullName = "Comunidade das Ilhas Marianas do Norte", CallingCode = 1670,
        NumericIsoCode = 580, EnglishName = "Northern Mariana Islands", NativeName = "Northern Mariana Islands"
    },
    new Country
    {
        Id = Guid.Parse("aefc4a6f-5c66-4ad5-8a17-01801db9002d"), Iso2Code = "NO", Iso3Code = "NOR", Name = "Noruega",
        FullName = "Reino da Noruega", CallingCode = 47, NumericIsoCode = 578, EnglishName = "Norway", NativeName = "Norge"
    },
    new Country
    {
        Id = Guid.Parse("da90bf95-81f3-4cdf-b1d7-f91f61bc8068"), Iso2Code = "OM", Iso3Code = "OMN", Name = "Omã",
        FullName = "Sultanato de Omã", CallingCode = 968, NumericIsoCode = 512, EnglishName = "Oman", NativeName = "عمان"
    },
    new Country
    {
        Id = Guid.Parse("9e431bad-5216-45b6-a367-a5fa9dbd8065"), Iso2Code = "PK", Iso3Code = "PAK", Name = "Paquistão",
        FullName = "República Islâmica do Paquistão", CallingCode = 92, NumericIsoCode = 586, EnglishName = "Pakistan",
        NativeName = "Pakistan"
    },
    new Country
    {
        Id = Guid.Parse("832cc614-f545-4652-b7c5-f83eb5c2136d"), Iso2Code = "PW", Iso3Code = "PLW", Name = "Palau",
        FullName = "República de Palau", CallingCode = 680, NumericIsoCode = 585, EnglishName = "Palau", NativeName = "Palau"
    },
    new Country
    {
        Id = Guid.Parse("e9003e28-0699-4460-86b5-f2a756c83935"), Iso2Code = "PS", Iso3Code = "PSE", Name = "Palestina",
        FullName = "Estado da Palestina", CallingCode = 970, NumericIsoCode = 275, EnglishName = "Palestine", NativeName = "فلسطين"
    },
    new Country
    {
        Id = Guid.Parse("d9f815a8-97f8-4a16-bacb-97d582aff89f"), Iso2Code = "PA", Iso3Code = "PAN", Name = "Panamá",
        FullName = "República do Panamá", CallingCode = 507, NumericIsoCode = 591, EnglishName = "Panama", NativeName = "Panamá"
    },
    new Country
    {
        Id = Guid.Parse("f71e84f3-cd30-4bff-995e-9bad8509c687"), Iso2Code = "PG", Iso3Code = "PNG", Name = "Papua-Nova Guiné",
        FullName = "Estado Independente da Papua-Nova Guiné", CallingCode = 675, NumericIsoCode = 598,
        EnglishName = "Papua New Guinea", NativeName = "Papua Niugini"
    },
    new Country
    {
        Id = Guid.Parse("376b3539-c1f8-47ad-9c47-d774f6356bac"), Iso2Code = "PY", Iso3Code = "PRY", Name = "Paraguai",
        FullName = "República do Paraguai", CallingCode = 595, NumericIsoCode = 600, EnglishName = "Paraguay",
        NativeName = "Paraguay"
    },
    new Country
    {
        Id = Guid.Parse("b0b429db-06eb-4b2b-9a9b-394dd7b687e1"), Iso2Code = "PE", Iso3Code = "PER", Name = "Peru",
        FullName = "República do Peru", CallingCode = 51, NumericIsoCode = 604, EnglishName = "Peru", NativeName = "Perú"
    },
    new Country
    {
        Id = Guid.Parse("caff8549-84ad-4a85-9a05-ab569c17c527"), Iso2Code = "PH", Iso3Code = "PHL", Name = "Filipinas",
        FullName = "República das Filipinas", CallingCode = 63, NumericIsoCode = 608, EnglishName = "Philippines",
        NativeName = "Pilipinas"
    },
    new Country
    {
        Id = Guid.Parse("8404866c-f856-4918-a7a4-7e7bc143e9ef"), Iso2Code = "PN", Iso3Code = "PCN", Name = "Ilhas Picárnia",
        FullName = "Ilhas Picárnia", CallingCode = 672, NumericIsoCode = 612, EnglishName = "Pitcairn",
        NativeName = "Pitcairn Islands"
    },
    new Country
    {
        Id = Guid.Parse("bd20152a-6de9-41be-aed7-9841e04c2eeb"), Iso2Code = "PL", Iso3Code = "POL", Name = "Polônia",
        FullName = "República da Polônia", CallingCode = 48, NumericIsoCode = 616, EnglishName = "Poland", NativeName = "Polska"
    },
    new Country
    {
        Id = Guid.Parse("877572c8-344b-4eb3-a177-85dd4fef968b"), Iso2Code = "PT", Iso3Code = "PRT", Name = "Portugal",
        FullName = "República Portuguesa", CallingCode = 351, NumericIsoCode = 620, EnglishName = "Portugal",
        NativeName = "Portugal"
    },
    new Country
    {
        Id = Guid.Parse("bca3f021-c820-47db-94e9-27808344e57f"), Iso2Code = "PR", Iso3Code = "PRI", Name = "Porto Rico",
        FullName = "Comunidade do Porto Rico", CallingCode = 1787, NumericIsoCode = 630, EnglishName = "Puerto Rico",
        NativeName = "Puerto Rico"
    },
    new Country
    {
        Id = Guid.Parse("cd98db68-68a9-47b5-947d-789807c3620b"), Iso2Code = "QA", Iso3Code = "QAT", Name = "Catar",
        FullName = "Estado do Catar", CallingCode = 974, NumericIsoCode = 634, EnglishName = "Qatar", NativeName = "قطر"
    },
    new Country
    {
        Id = Guid.Parse("a617b258-9807-4bab-8f8d-461d071e2bc8"), Iso2Code = "RE", Iso3Code = "REU", Name = "Reunião",
        FullName = "Polônia", CallingCode = 262, NumericIsoCode = 638, EnglishName = "Reunion", NativeName = "La Réunion"
    },
    new Country
    {
        Id = Guid.Parse("431e7322-370e-467d-b513-cf8d16cc68bf"), Iso2Code = "RO", Iso3Code = "ROM", Name = "Romênia",
        FullName = "Romênia", CallingCode = 40, NumericIsoCode = 642, EnglishName = "Romania", NativeName = "România"
    },
    new Country
    {
        Id = Guid.Parse("27255853-9142-4dd0-b20a-bd4c6bd42419"), Iso2Code = "RU", Iso3Code = "RUS", Name = "Rússia",
        FullName = "Federação Russa", CallingCode = 70, NumericIsoCode = 643, EnglishName = "Russian Federation",
        NativeName = "Россия"
    },
    new Country
    {
        Id = Guid.Parse("f1cfbf16-8d67-4a9c-94b2-45695cfe624b"), Iso2Code = "RW", Iso3Code = "RWA", Name = "Ruanda",
        FullName = "República da Ruanda", CallingCode = 250, NumericIsoCode = 646, EnglishName = "Rwanda", NativeName = "Rwanda"
    },
    new Country
    {
        Id = Guid.Parse("de615920-2dad-4f21-b99b-553f3ff78c3a"), Iso2Code = "KN", Iso3Code = "KNA", Name = "São Cristóvão",
        FullName = "São Cristóvão", CallingCode = 1869, NumericIsoCode = 659, EnglishName = "Saint Kitts and Nevis",
        NativeName = "Saint Kitts and Nevis"
    },
    new Country
    {
        Id = Guid.Parse("d07ffe42-2672-407c-8473-e656760fa832"), Iso2Code = "LC", Iso3Code = "LCA", Name = "Santa Lúcia",
        FullName = "Santa Lúcia", CallingCode = 1758, NumericIsoCode = 662, EnglishName = "Saint Lucia", NativeName = "Saint Lucia"
    },
    new Country
    {
        Id = Guid.Parse("5adab0c7-6351-400a-a2e7-af9843f88280"), Iso2Code = "VC", Iso3Code = "VCT",
        Name = "São Vicente e Granadinas", FullName = "São Vicente e Granadinas", CallingCode = 1784, NumericIsoCode = 670,
        EnglishName = "Saint Vincent and the Grenadines", NativeName = "Saint Vincent and the Grenadines"
    },
    new Country
    {
        Id = Guid.Parse("39cd1128-2958-44fe-b624-5a8e05f6d15d"), Iso2Code = "WS", Iso3Code = "WSM", Name = "Samoa",
        FullName = "Estado Independente de Samoa", CallingCode = 684, NumericIsoCode = 882, EnglishName = "Samoa",
        NativeName = "Samoa"
    },
    new Country
    {
        Id = Guid.Parse("83b3f3bf-9e22-4f34-900b-17716f46dd38"), Iso2Code = "SM", Iso3Code = "SMR", Name = "São Marino",
        FullName = "República de São Marino", CallingCode = 378, NumericIsoCode = 674, EnglishName = "San Marino",
        NativeName = "San Marino"
    },
    new Country
    {
        Id = Guid.Parse("61fe6fa2-dc46-48ea-a517-9375283b3bfb"), Iso2Code = "ST", Iso3Code = "STP", Name = "Sao Tomé e Príncipe",
        FullName = "República Democrática de Sao Tomé e Príncipe", CallingCode = 239, NumericIsoCode = 678,
        EnglishName = "Sao Tome and Principe", NativeName = "São Tomé e Príncipe"
    },
    new Country
    {
        Id = Guid.Parse("155555bb-f00b-40e9-84ad-d109a125d04a"), Iso2Code = "SA", Iso3Code = "SAU", Name = "Arábia Saudita",
        FullName = "Reino da Arábia Saudita", CallingCode = 966, NumericIsoCode = 682, EnglishName = "Saudi Arabia",
        NativeName = "العربية السعودية"
    },
    new Country
    {
        Id = Guid.Parse("17d9b61c-599e-48a6-8856-269b412229a6"), Iso2Code = "SN", Iso3Code = "SEN", Name = "Senegal",
        FullName = "República do Senegal", CallingCode = 221, NumericIsoCode = 686, EnglishName = "Senegal", NativeName = "Sénégal"
    },
    new Country
    {
        Id = Guid.Parse("0e1a9b22-84a7-4d3d-ad20-3bbd21580ed5"), Iso2Code = "RS", Iso3Code = "SRB", Name = "Sérvia",
        FullName = "República da Sérvia", CallingCode = 381, NumericIsoCode = 688, EnglishName = "Serbia", NativeName = "Србија"
    },
    new Country
    {
        Id = Guid.Parse("afa22faa-0bc1-4cce-8434-0fcfff28970d"), Iso2Code = "SC", Iso3Code = "SYC", Name = "Seicheles",
        FullName = "República das Seicheles", CallingCode = 248, NumericIsoCode = 690, EnglishName = "Seychelles",
        NativeName = "Seychelles"
    },
    new Country
    {
        Id = Guid.Parse("f8cddd4f-d783-484d-95cd-605c566d192e"), Iso2Code = "SL", Iso3Code = "SLE",
        Name = "República da Serra Leoa", FullName = "República da Serra Leoa", CallingCode = 232, NumericIsoCode = 694,
        EnglishName = "Sierra Leone", NativeName = "Sierra Leone"
    },
    new Country
    {
        Id = Guid.Parse("355ac3cc-9935-4278-8eca-857a61c6c815"), Iso2Code = "SG", Iso3Code = "SGP", Name = "Singapura",
        FullName = "República da Singapura", CallingCode = 65, NumericIsoCode = 702, EnglishName = "Singapore",
        NativeName = "Singapore"
    },
    new Country
    {
        Id = Guid.Parse("8684ea4e-d614-4e2a-9e91-da0c1f90be3b"), Iso2Code = "SK", Iso3Code = "SVK", Name = "Eslováquia",
        FullName = "República Eslovaca", CallingCode = 421, NumericIsoCode = 703, EnglishName = "Slovakia", NativeName = "Slovensko"
    },
    new Country
    {
        Id = Guid.Parse("d6f8a033-4c9b-4df0-8038-506214ec49ca"), Iso2Code = "SI", Iso3Code = "SVN", Name = "Eslovênia",
        FullName = "República da Eslovênia", CallingCode = 386, NumericIsoCode = 705, EnglishName = "Slovenia",
        NativeName = "Slovenija"
    },
    new Country
    {
        Id = Guid.Parse("8d42836a-5b8b-4b86-9485-c75e49ed18fb"), Iso2Code = "SB", Iso3Code = "SLB", Name = "Ilhas Salomão",
        FullName = "Ilhas Salomão", CallingCode = 677, NumericIsoCode = 90, EnglishName = "Solomon Islands",
        NativeName = "Solomon Islands"
    },
    new Country
    {
        Id = Guid.Parse("43557e63-72b6-47db-802d-1486c06f435b"), Iso2Code = "SO", Iso3Code = "SOM", Name = "Somália",
        FullName = "República da Somália", CallingCode = 252, NumericIsoCode = 706, EnglishName = "Somalia",
        NativeName = "Soomaaliya"
    },
    new Country
    {
        Id = Guid.Parse("e445d4f6-2730-48ea-afec-7c2dc56c5ddb"), Iso2Code = "ZA", Iso3Code = "ZAF", Name = "África do Sul",
        FullName = "República da África do Sul", CallingCode = 27, NumericIsoCode = 710, EnglishName = "South Africa",
        NativeName = "South Africa"
    },
    new Country
    {
        Id = Guid.Parse("06ff06e8-a62a-4274-8f4c-c2f59e4059c4"), Iso2Code = "GS", Iso3Code = "SGS",
        Name = "Ilhas Geórgia do Sul e Sandwich do Sul", FullName = "Ilhas Geórgia do Sul e Sandwich do Sul", CallingCode = 500,
        NumericIsoCode = 239, EnglishName = "South Georgia South Sandwich Islands", NativeName = "South Georgia"
    },
    new Country
    {
        Id = Guid.Parse("ab0eea6b-ab24-42b9-a3fe-45b05e1fd93e"), Iso2Code = "ES", Iso3Code = "ESP", Name = "Espanha",
        FullName = "Reino da Espanha", CallingCode = 34, NumericIsoCode = 724, EnglishName = "Spain", NativeName = "España"
    },
    new Country
    {
        Id = Guid.Parse("bf0efc75-5d9e-44cf-989b-70a53960fef7"), Iso2Code = "LK", Iso3Code = "LKA", Name = "Sri Lanka",
        FullName = "República Democrática Socialista do Sri Lanka", CallingCode = 94, NumericIsoCode = 144,
        EnglishName = "Sri Lanka", NativeName = "śrī laṃkāva"
    },
    new Country
    {
        Id = Guid.Parse("c9abeb9e-3d9a-4b21-bdba-13a788403635"), Iso2Code = "SH", Iso3Code = "SHN", Name = "Santa Helena",
        FullName = "Saint Helena", CallingCode = 290, NumericIsoCode = 654, EnglishName = "St. Helena", NativeName = "Saint Helena"
    },
    new Country
    {
        Id = Guid.Parse("91bd263b-46d0-497c-a04a-46db74af330a"), Iso2Code = "PM", Iso3Code = "SPM", Name = "São Pedro e Miquelon",
        FullName = "Coletividade Territorial de São Pedro e Miquelon", CallingCode = 508, NumericIsoCode = 666,
        EnglishName = "St. Pierre and Miquelon", NativeName = "Saint-Pierre-et-Miquelon"
    },
    new Country
    {
        Id = Guid.Parse("264b7028-504d-456c-9151-69a0bf0c3619"), Iso2Code = "SD", Iso3Code = "SDN", Name = "Sudão",
        FullName = "República do Sudão", CallingCode = 249, NumericIsoCode = 736, EnglishName = "Sudan", NativeName = "السودان"
    },
    new Country
    {
        Id = Guid.Parse("dcd692d1-3866-43d6-a350-28f196180b86"), Iso2Code = "SR", Iso3Code = "SUR", Name = "Suriname",
        FullName = "República do Suriname", CallingCode = 597, NumericIsoCode = 740, EnglishName = "Suriname",
        NativeName = "Suriname"
    },
    new Country
    {
        Id = Guid.Parse("edc09df1-f24f-4953-bb8f-6479f23fefef"), Iso2Code = "SJ", Iso3Code = "SJM", Name = "Esvalbarde",
        FullName = "Esvalbarde", CallingCode = 47, NumericIsoCode = 744, EnglishName = "Svalbard and Jan Mayen Islands",
        NativeName = "Svalbard og Jan Mayen"
    },
    new Country
    {
        Id = Guid.Parse("499ee1bd-9baa-40ae-a94b-6d9e09eba8db"), Iso2Code = "SZ", Iso3Code = "SWZ", Name = "Suazilândia",
        FullName = "Reino da Suazilândia", CallingCode = 268, NumericIsoCode = 748, EnglishName = "Swaziland",
        NativeName = "Swaziland"
    },
    new Country
    {
        Id = Guid.Parse("20e38db9-087b-4001-89e8-fdde6b8f6cda"), Iso2Code = "SE", Iso3Code = "SWE", Name = "Suécia",
        FullName = "Reino da Suécia", CallingCode = 46, NumericIsoCode = 752, EnglishName = "Sweden", NativeName = "Sverige"
    },
    new Country
    {
        Id = Guid.Parse("b8bc390d-c826-4132-8275-3bbd30e48bba"), Iso2Code = "CH", Iso3Code = "CHE", Name = "Suiça",
        FullName = "Confederação Suiça", CallingCode = 41, NumericIsoCode = 756, EnglishName = "Switzerland", NativeName = "Schweiz"
    },
    new Country
    {
        Id = Guid.Parse("81d005e8-8ae5-4658-9224-4c82d3ab42d4"), Iso2Code = "SY", Iso3Code = "SYR", Name = "Síria",
        FullName = "República Árabe Síria", CallingCode = 963, NumericIsoCode = 760, EnglishName = "Syrian Arab Republic",
        NativeName = "سوريا"
    },
    new Country
    {
        Id = Guid.Parse("f569d820-986a-47bd-af0a-aa4bd64d9c23"), Iso2Code = "TW", Iso3Code = "TWN", Name = "Taiwan",
        FullName = "Taiwan", CallingCode = 886, NumericIsoCode = 158, EnglishName = "Taiwan", NativeName = "臺灣"
    },
    new Country
    {
        Id = Guid.Parse("a7ea6d04-d5f3-453a-939e-beed1d16dd2e"), Iso2Code = "TJ", Iso3Code = "TJK", Name = "Tajiquistão",
        FullName = "República do Tajiquistão", CallingCode = 992, NumericIsoCode = 762, EnglishName = "Tajikistan",
        NativeName = "Тоҷикистон"
    },
    new Country
    {
        Id = Guid.Parse("19c8e231-23de-4c4a-a640-18a52a188da8"), Iso2Code = "TZ", Iso3Code = "TZA", Name = "Tanzânia",
        FullName = "República Unida da Tanzânia", CallingCode = 255, NumericIsoCode = 834,
        EnglishName = "Tanzania, United Republic of", NativeName = "Tanzania"
    },
    new Country
    {
        Id = Guid.Parse("db9b82d2-38b7-461c-8fcd-b1339da98fd6"), Iso2Code = "TH", Iso3Code = "THA", Name = "Tailândia",
        FullName = "Reino da Tailândia", CallingCode = 66, NumericIsoCode = 764, EnglishName = "Thailand", NativeName = "ประเทศไทย"
    },
    new Country
    {
        Id = Guid.Parse("c4f14c7c-d446-4999-81e4-9a6eb3956f8c"), Iso2Code = "TG", Iso3Code = "TGO", Name = "Togo",
        FullName = "República Togolesa", CallingCode = 228, NumericIsoCode = 768, EnglishName = "Togo", NativeName = "Togo"
    },
    new Country
    {
        Id = Guid.Parse("a14f238e-d677-4c5a-b2c6-f3b22570dde6"), Iso2Code = "TK", Iso3Code = "TKL", Name = "Toquelau",
        FullName = "Toquelau", CallingCode = 690, NumericIsoCode = 772, EnglishName = "Tokelau", NativeName = "Tokelau"
    },
    new Country
    {
        Id = Guid.Parse("38df89a0-3c07-4ff9-81e9-b98ccc0bc133"), Iso2Code = "TO", Iso3Code = "TON", Name = "Tonga",
        FullName = "Reino de Tonga", CallingCode = 676, NumericIsoCode = 776, EnglishName = "Tonga", NativeName = "Tonga"
    },
    new Country
    {
        Id = Guid.Parse("9e322d78-de01-443c-902a-9a0b963f333b"), Iso2Code = "TT", Iso3Code = "TTO", Name = "Trinidad e Tobago",
        FullName = "República da Trinidad e Tobago", CallingCode = 1868, NumericIsoCode = 780, EnglishName = "Trinidad and Tobago",
        NativeName = "Trinidad and Tobago"
    },
    new Country
    {
        Id = Guid.Parse("bc00c6db-26bc-4137-9df6-32b24612fc6e"), Iso2Code = "TN", Iso3Code = "TUN", Name = "Tunísia",
        FullName = "República da Tunísia", CallingCode = 216, NumericIsoCode = 788, EnglishName = "Tunisia", NativeName = "تونس"
    },
    new Country
    {
        Id = Guid.Parse("45cef321-5020-4b62-af52-38d7a5b91e15"), Iso2Code = "TR", Iso3Code = "TUR", Name = "Turquia",
        FullName = "República da Turquia", CallingCode = 90, NumericIsoCode = 792, EnglishName = "Turkey", NativeName = "Türkiye"
    },
    new Country
    {
        Id = Guid.Parse("33daa1e7-8797-4025-8cea-bffa5a650ded"), Iso2Code = "TM", Iso3Code = "TKM", Name = "Turcomenistão",
        FullName = "Turcomenistão", CallingCode = 7370, NumericIsoCode = 795, EnglishName = "Turkmenistan",
        NativeName = "Türkmenistan"
    },
    new Country
    {
        Id = Guid.Parse("d2ed0584-10ff-4dbd-b492-792a6b66b8f5"), Iso2Code = "TC", Iso3Code = "TCA", Name = "Ilhas Turks e Caicos",
        FullName = "Ilhas Turks e Caicos", CallingCode = 1649, NumericIsoCode = 796, EnglishName = "Turks and Caicos Islands",
        NativeName = "Turks and Caicos Islands"
    },
    new Country
    {
        Id = Guid.Parse("e1a1ae5d-0211-4fb9-9e04-1e5584025502"), Iso2Code = "TV", Iso3Code = "TUV", Name = "Tuvalu",
        FullName = "Tuvalu", CallingCode = 688, NumericIsoCode = 798, EnglishName = "Tuvalu", NativeName = "Tuvalu"
    },
    new Country
    {
        Id = Guid.Parse("0bea28ac-7162-49b7-9e08-edb0272fa360"), Iso2Code = "UG", Iso3Code = "UGA", Name = "Uganda",
        FullName = "República de Uganda", CallingCode = 256, NumericIsoCode = 800, EnglishName = "Uganda", NativeName = "Uganda"
    },
    new Country
    {
        Id = Guid.Parse("af5b9c8c-0da4-4bb2-b9d0-f4c1a4ee173f"), Iso2Code = "UA", Iso3Code = "UKR", Name = "Ucrânia",
        FullName = "Ucrânia", CallingCode = 380, NumericIsoCode = 804, EnglishName = "Ukraine", NativeName = "Україна"
    },
    new Country
    {
        Id = Guid.Parse("25e924a0-e5b7-41fe-96e5-cb46b3fce29a"), Iso2Code = "AE", Iso3Code = "ARE", Name = "Emirados Árabes",
        FullName = "Emirados Árabes Unidos", CallingCode = 971, NumericIsoCode = 784, EnglishName = "United Arab Emirates",
        NativeName = "دولة الإمارات العربية المتحدة"
    },
    new Country
    {
        Id = Guid.Parse("f359c683-76c7-46a3-abd9-771b205d6ff0"), Iso2Code = "GB", Iso3Code = "GBR", Name = "Reino Unido",
        FullName = "Reino Unido da Grã-Bretanha e Irlanda do Norte", CallingCode = 44, NumericIsoCode = 826,
        EnglishName = "United Kingdom", NativeName = "United Kingdom"
    },
    new Country
    {
        Id = Guid.Parse("89020baf-5471-455b-87ec-87b1ce26aaf2"), Iso2Code = "US", Iso3Code = "USA", Name = "Estados Unidos",
        FullName = "Estados Unidos da América", CallingCode = 1, NumericIsoCode = 840, EnglishName = "United States",
        NativeName = "United States"
    },
    new Country
    {
        Id = Guid.Parse("bf7d0074-17ff-4f02-b171-b8726815b8bf"), Iso2Code = "UM", Iso3Code = "UMI",
        Name = "Ilhas Menores Distantes dos Estados Unidos", FullName = "Ilhas Menores Distantes dos Estados Unidos",
        CallingCode = 1, NumericIsoCode = 581, EnglishName = "United States minor outlying islands",
        NativeName = "United States Minor Outlying Islands"
    },
    new Country
    {
        Id = Guid.Parse("2ff9da9a-7bf1-4f20-bd12-05759138c0a0"), Iso2Code = "UY", Iso3Code = "URY", Name = "Uruguai",
        FullName = "República Oriental do Uruguai", CallingCode = 598, NumericIsoCode = 858, EnglishName = "Uruguay",
        NativeName = "Uruguay"
    },
    new Country
    {
        Id = Guid.Parse("b2a11413-3b4f-418c-8fbf-be3d4734a50a"), Iso2Code = "UZ", Iso3Code = "UZB", Name = "Uzbequistão",
        FullName = "República do Uzbequistão", CallingCode = 998, NumericIsoCode = 860, EnglishName = "Uzbekistan",
        NativeName = "O‘zbekiston"
    },
    new Country
    {
        Id = Guid.Parse("6b3a0073-4652-411d-b449-6da570d4739c"), Iso2Code = "VU", Iso3Code = "VUT", Name = "Vanuatu",
        FullName = "República de Vanuatu", CallingCode = 678, NumericIsoCode = 548, EnglishName = "Vanuatu", NativeName = "Vanuatu"
    },
    new Country
    {
        Id = Guid.Parse("55a6fbcd-4ab5-4987-afa4-10ead40d8b26"), Iso2Code = "VA", Iso3Code = "VAT", Name = "Vaticano",
        FullName = "Estado da Cidade do Vaticano", CallingCode = 39, NumericIsoCode = 336, EnglishName = "Vatican City State",
        NativeName = "Vaticano"
    },
    new Country
    {
        Id = Guid.Parse("b0679427-2f38-45de-8b22-ed4475958bcf"), Iso2Code = "VE", Iso3Code = "VEN", Name = "Venezuela",
        FullName = "República Bolivariana da Venezuela", CallingCode = 58, NumericIsoCode = 862, EnglishName = "Venezuela",
        NativeName = "Venezuela"
    },
    new Country
    {
        Id = Guid.Parse("2ea4358c-eff5-431d-9173-00f04e8e3e97"), Iso2Code = "VN", Iso3Code = "VNM", Name = "Vietnam",
        FullName = "República Socialista do Vietnam", CallingCode = 84, NumericIsoCode = 704, EnglishName = "Vietnam",
        NativeName = "Việt Nam"
    },
    new Country
    {
        Id = Guid.Parse("aff95ab9-da48-486e-9712-b71a64fa454e"), Iso2Code = "VG", Iso3Code = "VGB", Name = "Ilhas Virgens Inglesas",
        FullName = "Ilhas Virgens", CallingCode = 1284, NumericIsoCode = 92, EnglishName = "Virgin Islands (British",
        NativeName = "British Virgin Islands"
    },
    new Country
    {
        Id = Guid.Parse("06f280bd-5b91-42f3-ae49-6bb01e9ab8ed"), Iso2Code = "VI", Iso3Code = "VIR", Name = "Ilhas Virgens (USA",
        FullName = "Ilhas Virgens dos Estados Unidos", CallingCode = 1340, NumericIsoCode = 850,
        EnglishName = "Virgin Islands (U.S.", NativeName = "United States Virgin Islands"
    },
    new Country
    {
        Id = Guid.Parse("42a83c97-c785-495f-a46c-e5c7da3b3797"), Iso2Code = "WF", Iso3Code = "WLF", Name = "Wallis e Futuna",
        FullName = "Wallis e Futuna", CallingCode = 681, NumericIsoCode = 876, EnglishName = "Wallis and Futuna Islands",
        NativeName = "Wallis et Futuna"
    },
    new Country
    {
        Id = Guid.Parse("04c31c30-da78-4194-9a09-6e91c5f6722e"), Iso2Code = "EH", Iso3Code = "ESH", Name = "Saara Ocidental",
        FullName = "Saara Ocidental", CallingCode = 212, NumericIsoCode = 732, EnglishName = "Western Sahara",
        NativeName = "الصحراء الغربية"
    },
    new Country
    {
        Id = Guid.Parse("74f4a2c2-649f-4db4-ad55-bbbb5609738c"), Iso2Code = "YE", Iso3Code = "YEM", Name = "Iêmen",
        FullName = "República do Iêmen", CallingCode = 967, NumericIsoCode = 887, EnglishName = "Yemen", NativeName = "اليَمَن"
    },
    new Country
    {
        Id = Guid.Parse("f7f03fec-f390-4211-a716-9bb42019c075"), Iso2Code = "ZM", Iso3Code = "ZMB", Name = "Zâmbia",
        FullName = "República do Zâmbia", CallingCode = 260, NumericIsoCode = 894, EnglishName = "Zambia", NativeName = "Zambia"
    },
    new Country
    {
        Id = Guid.Parse("c637121b-c78b-41e8-8709-91f4e3c18051"), Iso2Code = "ZW", Iso3Code = "ZWE", Name = "Zimbábue",
        FullName = "República do Zimbábue", CallingCode = 263, NumericIsoCode = 716, EnglishName = "Zimbabwe",
        NativeName = "Zimbabwe"
    }
);
