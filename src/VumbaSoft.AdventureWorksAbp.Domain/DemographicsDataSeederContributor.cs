using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Users;
using VumbaSoft.AdventureWorksAbp.Demographics.Continents;
using VumbaSoft.AdventureWorksAbp.Demographics.Countries;
using VumbaSoft.AdventureWorksAbp.Demographics.DistrictCities;
using VumbaSoft.AdventureWorksAbp.Demographics.Regions;
using VumbaSoft.AdventureWorksAbp.Demographics.StateProvinces;
using VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents;

namespace VumbaSoft.AdventureWorksAbp
{
    internal class DemographicsDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Continent, Guid> _continentRepository;
        private readonly IRepository<Country, Guid> _countryRepository;
        private readonly IRepository<Subcontinent, Guid> _subcontinentRepository;
        private readonly IRepository<Region, Guid> _regionRepository;
        private readonly IRepository<StateProvince, Guid> _stateProvinceRepository;
        private readonly IRepository<DistrictCity, Guid> _districtCityRepository;

        //private readonly IRepository<DistrictCity, Guid> _districtCityRepository;
        private readonly IGuidGenerator _GuidGenerator;
        private readonly ICurrentTenant _CurrentTenant;
        private readonly ICurrentUser _CurrentUser;

        //private readonly ContinentManager _ContinentManager;


        public DemographicsDataSeederContributor(
            IRepository<Continent, Guid> continentRepository,
            IRepository<Subcontinent, Guid> subcontinentRepository,
            IRepository<Country, Guid> countryRepository,

            IGuidGenerator guidGenerator,
            ICurrentTenant currentTenant,
            ICurrentUser currentUser
,
            IRepository<Region, Guid> regionRepository,
            IRepository<StateProvince, Guid> stateProvinceRepository)
        {
            _continentRepository = continentRepository;
            _subcontinentRepository = subcontinentRepository;
            _countryRepository = countryRepository;
            _regionRepository = regionRepository;

            _GuidGenerator = guidGenerator;
            _CurrentTenant = currentTenant;
            _CurrentUser = currentUser;
            _stateProvinceRepository = stateProvinceRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            #region Continents Variables
            var Africa = new Continent(id: _GuidGenerator.Create(),  name: "Africa",  population: 1367000000,  remarks: "African continente");
            var Americas = new Continent(id: _GuidGenerator.Create(), name: "Americas", population: 1029000000, remarks: "American continente");
            var Asia = new Continent(id: _GuidGenerator.Create(), name: "Asia", population: 4674000000, remarks: "Asian continente" );
            var Europe = new Continent(id: _GuidGenerator.Create(), name: "Europe", population: 743000000, remarks: "European continente");
            var Oceania = new Continent(id: _GuidGenerator.Create(), name: "Oceania", population: 44000000, remarks: "Oceanian continente");
            var Antartica = new Continent(id: _GuidGenerator.Create(), name: "Antartica", population: 5000, remarks: "Antartican continente");
            #endregion

            #region Subcontinent Variables
            var EasternAfrica = new Subcontinent(id: _GuidGenerator.Create(), name: "Eastern Africa", continentId: Africa.Id, population: 0, remarks: "Eastern Africa Sub Continent");
            var MiddleAfrica = new Subcontinent(id: _GuidGenerator.Create(), name: "Middle Africa", continentId: Africa.Id, population: 0, remarks: "Middle Africa Sub Continent");
            var NorthernAfrica = new Subcontinent(id: _GuidGenerator.Create(), name: "Northern Africa", continentId: Africa.Id, population: 0, remarks: "Northern Africa Sub Continent");
            var SouthernAfrica = new Subcontinent(id: _GuidGenerator.Create(), name: "Southern Africa", continentId: Africa.Id, population: 0, remarks: "Southern Africa Sub Continent");
            var WesternAfrica = new Subcontinent(id: _GuidGenerator.Create(), name: "Western Africa", continentId: Africa.Id, population: 0, remarks: "Western Africa Sub Continent");
            var Caribbean = new Subcontinent(id: _GuidGenerator.Create(), name: "Caribbean", continentId: Americas.Id, population: 0, remarks: "Caribbean Sub Continent");
            var CentralAmerica = new Subcontinent(id: _GuidGenerator.Create(), name: "Central America", continentId: Americas.Id, population: 0, remarks: "Central America Sub Continent");
            var NorthernAmerica = new Subcontinent(id: _GuidGenerator.Create(), name: "Northern America", continentId: Americas.Id, population: 0, remarks: "Northern America Sub Continent");
            var SouthAmerica = new Subcontinent(id: _GuidGenerator.Create(), name: "South America", continentId: Americas.Id, population: 0, remarks: "South America Sub Continent");
            var CentralAsia = new Subcontinent(id: _GuidGenerator.Create(), name: "Central Asia", continentId: Asia.Id, population: 0, remarks: "Central Asia Sub Continent");
            var EasternAsia = new Subcontinent(id: _GuidGenerator.Create(), name: "Eastern Asia", continentId: Asia.Id, population: 0, remarks: "Eastern Asia Sub Continent");
            var SouthEasternAsia = new Subcontinent(id: _GuidGenerator.Create(), name: "South Eastern Asia", continentId: Asia.Id, population: 0, remarks: "South-Eastern Asia Sub Continent");
            var SouthernAsia = new Subcontinent(id: _GuidGenerator.Create(), name: "Southern Asia", continentId: Asia.Id, population: 0, remarks: "Southern Asia Sub Continent");
            var WesternAsia = new Subcontinent(id: _GuidGenerator.Create(), name: "Western Asia", continentId: Asia.Id, population: 0, remarks: "Western Asia Sub Continent");
            var EasternEurope = new Subcontinent(id: _GuidGenerator.Create(), name: "Eastern Europe", continentId: Europe.Id, population: 0, remarks: "Eastern Europe Sub Continent");
            var NorthernEurope = new Subcontinent(id: _GuidGenerator.Create(), name: "Northern Europe", continentId: Europe.Id, population: 0, remarks: "Northern Europe Sub Continent");
            var SouthernEurope = new Subcontinent(id: _GuidGenerator.Create(), name: "Southern Europe", continentId: Europe.Id, population: 0, remarks: "Southern Europe Sub Continent");
            var WesternEurope = new Subcontinent(id: _GuidGenerator.Create(), name: "Western Europe", continentId: Europe.Id, population: 0, remarks: "Western Europe Sub Continent");
            var AustraliaAndNewZealand = new Subcontinent(id: _GuidGenerator.Create(), name: "Australia And New Zealand", continentId: Oceania.Id, population: 0, remarks: "Australia and New Zealand Sub Continent");
            var MelanesiaSubcontinent = new Subcontinent(id: _GuidGenerator.Create(), name: "Melanesia Subcontinent", continentId: Oceania.Id, population: 0, remarks: "Melanesia Sub Continent");
            var MicronesiaSubcontinent = new Subcontinent(id: _GuidGenerator.Create(), name: "Micronesia Subcontinent", continentId: Oceania.Id, population: 0, remarks: "Micronesia Sub Continent");
            var PolynesiaSubcontinent = new Subcontinent(id: _GuidGenerator.Create(), name: "Polynesia Subcontinent", continentId: Oceania.Id, population: 0, remarks: "Polynesia Sub Continent");
            var AntarticaSubcontinent = new Subcontinent(id: _GuidGenerator.Create(), name: "Antartica Subcontinent", continentId: Antartica.Id, population: 0, remarks: "Antartica Sub Continent");
            #endregion

            #region Country Variables

            var Burundi = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Burundi", formalName: "Republic of Burundi", nativeName: "Burundi", capital: "Bujumbura", isoTreeCode: "BDI", isoTwoCode: "BI", ccnTreeCode: "NULL", phoneCode: "257", currency: "BIF", population: 0, emoji: "🇧🇮", emojiU: "U+1F1E7 U+1F1EE", remarks: "Republic of Burundi");
            var Comoros = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Comoros", formalName: "Union of the Comoros", nativeName: "Komori", capital: "Moroni", isoTreeCode: "COM", isoTwoCode: "KM", ccnTreeCode: "NULL", phoneCode: "269", currency: "KMF", population: 0, emoji: "🇰🇲", emojiU: "U+1F1F0 U+1F1F2", remarks: "Union of the Comoros");
            var Djibouti = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Djibouti", formalName: "Republic of Djibouti", nativeName: "Djibouti", capital: "Djibouti", isoTreeCode: "DJI", isoTwoCode: "DJ", ccnTreeCode: "NULL", phoneCode: "253", currency: "DJF", population: 0, emoji: "🇩🇯", emojiU: "U+1F1E9 U+1F1EF", remarks: "Republic of Djibouti");
            var Eritrea = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Eritrea", formalName: "State of Eritrea", nativeName: "ኤርትራ", capital: "Asmara", isoTreeCode: "ERI", isoTwoCode: "ER", ccnTreeCode: "NULL", phoneCode: "291", currency: "ERN", population: 0, emoji: "🇪🇷", emojiU: "U+1F1EA U+1F1F7", remarks: "State of Eritrea");
            var Ethiopia = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Ethiopia", formalName: "Federal Democratic Republic of Ethiopia", nativeName: "ኢትዮጵያ", capital: "Addis Ababa", isoTreeCode: "ETH", isoTwoCode: "ET", ccnTreeCode: "NULL", phoneCode: "251", currency: "ETB", population: 0, emoji: "🇪🇹", emojiU: "U+1F1EA U+1F1F9", remarks: "Federal Democratic Republic of Ethiopia");
            var Kenya = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Kenya", formalName: "Republic of Kenya", nativeName: "Kenya", capital: "Nairobi", isoTreeCode: "KEN", isoTwoCode: "KE", ccnTreeCode: "NULL", phoneCode: "254", currency: "KES", population: 0, emoji: "🇰🇪", emojiU: "U+1F1F0 U+1F1EA", remarks: "Republic of Kenya");
            var Madagascar = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Madagascar", formalName: "Republic of Madagascar", nativeName: "Madagasikara", capital: "Antananarivo", isoTreeCode: "MDG", isoTwoCode: "MG", ccnTreeCode: "NULL", phoneCode: "261", currency: "MGA", population: 0, emoji: "🇲🇬", emojiU: "U+1F1F2 U+1F1EC", remarks: "Republic of Madagascar");
            var Malawi = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Malawi", formalName: "Republic of Malawi", nativeName: "Malawi", capital: "Lilongwe", isoTreeCode: "MWI", isoTwoCode: "MW", ccnTreeCode: "NULL", phoneCode: "265", currency: "MWK", population: 0, emoji: "🇲🇼", emojiU: "U+1F1F2 U+1F1FC", remarks: "Republic of Malawi");
            var Mauritius = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Mauritius", formalName: "Republic of Mauritius", nativeName: "Maurice", capital: "Port Louis", isoTreeCode: "MUS", isoTwoCode: "MU", ccnTreeCode: "NULL", phoneCode: "230", currency: "MUR", population: 0, emoji: "🇲🇺", emojiU: "U+1F1F2 U+1F1FA", remarks: "Republic of Mauritius");
            var Mozambique = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Mozambique", formalName: "Republic of Mozambique", nativeName: "Moçambique", capital: "Maputo", isoTreeCode: "MOZ", isoTwoCode: "MZ", ccnTreeCode: "NULL", phoneCode: "258", currency: "MZN", population: 0, emoji: "🇲🇿", emojiU: "U+1F1F2 U+1F1FF", remarks: "Republic of Mozambique");
            var Rwanda = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Rwanda", formalName: "Republic of Rwanda", nativeName: "Rwanda", capital: "Kigali", isoTreeCode: "RWA", isoTwoCode: "RW", ccnTreeCode: "NULL", phoneCode: "250", currency: "RWF", population: 0, emoji: "🇷🇼", emojiU: "U+1F1F7 U+1F1FC", remarks: "Republic of Rwanda");
            var Seychelles = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Seychelles", formalName: "Republic of Seychelles", nativeName: "Seychelles", capital: "Victoria", isoTreeCode: "SYC", isoTwoCode: "SC", ccnTreeCode: "NULL", phoneCode: "248", currency: "SCR", population: 0, emoji: "🇸🇨", emojiU: "U+1F1F8 U+1F1E8", remarks: "Republic of Seychelles");
            var Somalia = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Somalia", formalName: "Federal Republic of Somalia", nativeName: "Soomaaliya", capital: "Mogadishu", isoTreeCode: "SOM", isoTwoCode: "SO", ccnTreeCode: "NULL", phoneCode: "252", currency: "SOS", population: 0, emoji: "🇸🇴", emojiU: "U+1F1F8 U+1F1F4", remarks: "Federal Republic of Somalia");
            var Tanzania = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Tanzania", formalName: "United Republic of Tanzania", nativeName: "Tanzania", capital: "Dodoma", isoTreeCode: "TZA", isoTwoCode: "TZ", ccnTreeCode: "NULL", phoneCode: "255", currency: "TZS", population: 0, emoji: "🇹🇿", emojiU: "U+1F1F9 U+1F1FF", remarks: "United Republic of Tanzania");
            var Uganda = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Uganda", formalName: "Republic of Uganda", nativeName: "Uganda", capital: "Kampala", isoTreeCode: "UGA", isoTwoCode: "UG", ccnTreeCode: "NULL", phoneCode: "256", currency: "UGX", population: 0, emoji: "🇺🇬", emojiU: "U+1F1FA U+1F1EC", remarks: "Republic of Uganda");
            var Zambia = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Zambia", formalName: "Republic of Zambia", nativeName: "Zambia", capital: "Lusaka", isoTreeCode: "ZMB", isoTwoCode: "ZM", ccnTreeCode: "NULL", phoneCode: "260", currency: "ZMW", population: 0, emoji: "🇿🇲", emojiU: "U+1F1FF U+1F1F2", remarks: "Republic of Zambia");
            var Zimbabwe = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: EasternAfrica.Id, name: "Zimbabwe", formalName: "Republic of Zimbabwe", nativeName: "Zimbabwe", capital: "Harare", isoTreeCode: "ZWE", isoTwoCode: "ZW", ccnTreeCode: "NULL", phoneCode: "263", currency: "ZWL", population: 0, emoji: "🇿🇼", emojiU: "U+1F1FF U+1F1FC", remarks: "Republic of Zimbabwe");
            var Angola = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Angola", formalName: "People's Republic of Angola", nativeName: "Angola", capital: "Luanda", isoTreeCode: "AGO", isoTwoCode: "AO", ccnTreeCode: "NULL", phoneCode: "244", currency: "AOA", population: 0, emoji: "🇦🇴", emojiU: "U+1F1E6 U+1F1F4", remarks: "People's Republic of Angola");
            var Cameroon = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Cameroon", formalName: "Republic of Cameroon", nativeName: "Cameroon", capital: "Yaounde", isoTreeCode: "CMR", isoTwoCode: "CM", ccnTreeCode: "NULL", phoneCode: "237", currency: "XAF", population: 0, emoji: "🇨🇲", emojiU: "U+1F1E8 U+1F1F2", remarks: "Republic of Cameroon");
            var CentralAfricanRepublic = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Central African Republic", formalName: "Central African Republic", nativeName: "Ködörösêse tî Bêafrîka", capital: "Bangui", isoTreeCode: "CAF", isoTwoCode: "CF", ccnTreeCode: "NULL", phoneCode: "236", currency: "XAF", population: 0, emoji: "🇨🇫", emojiU: "U+1F1E8 U+1F1EB", remarks: "Central African Republic");
            var Chad = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Chad", formalName: "Republic of Chad", nativeName: "Tchad", capital: "N'Djamena", isoTreeCode: "TCD", isoTwoCode: "TD", ccnTreeCode: "NULL", phoneCode: "235", currency: "XAF", population: 0, emoji: "🇹🇩", emojiU: "U+1F1F9 U+1F1E9", remarks: "Republic of Chad");
            var CongoRepublicofthe = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Congo Republic of the", formalName: "Republic of Congo", nativeName: "République du Congo", capital: "Brazzaville", isoTreeCode: "COG", isoTwoCode: "CG", ccnTreeCode: "NULL", phoneCode: "242", currency: "XAF", population: 0, emoji: "🇨🇬", emojiU: "U+1F1E8 U+1F1EC", remarks: "Republic of Congo");
            var CongoTheDemocraticRepublicOfThe = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Congo The Democratic Republic Of The", formalName: "Democratic Republic of the Congo", nativeName: "République démocratique du Congo", capital: "Kinshasa", isoTreeCode: "COD", isoTwoCode: "CD", ccnTreeCode: "NULL", phoneCode: "243", currency: "CDF", population: 0, emoji: "🇨🇩", emojiU: "U+1F1E8 U+1F1E9", remarks: "Democratic Republic of the Congo");
            var EquatorialGuinea = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Equatorial Guinea", formalName: "Republic of Equatorial Guinea", nativeName: "Guinea Ecuatorial", capital: "Malabo", isoTreeCode: "GNQ", isoTwoCode: "GQ", ccnTreeCode: "NULL", phoneCode: "240", currency: "XAF", population: 0, emoji: "🇬🇶", emojiU: "U+1F1EC U+1F1F6", remarks: "Republic of Equatorial Guinea");
            var Gabon = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Gabon", formalName: "Gabonese Republic", nativeName: "Gabon", capital: "Libreville", isoTreeCode: "GAB", isoTwoCode: "GA", ccnTreeCode: "NULL", phoneCode: "241", currency: "XAF", population: 0, emoji: "🇬🇦", emojiU: "U+1F1EC U+1F1E6", remarks: "Gabonese Republic");
            var SaoTomeandPrincipe = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: MiddleAfrica.Id, name: "Sao Tome and Principe", formalName: "Democratic Republic of São Tomé and Principe", nativeName: "São Tomé e Príncipe", capital: "Sao Tome", isoTreeCode: "STP", isoTwoCode: "ST", ccnTreeCode: "NULL", phoneCode: "239", currency: "STD", population: 0, emoji: "🇸🇹", emojiU: "U+1F1F8 U+1F1F9", remarks: "Democratic Republic of São Tomé and Principe");
            var AkrotiriSovereignBaseArea = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Akrotiri Sovereign Base Area", formalName: "Akrotiri Sovereign Base Area", nativeName: "Akrotiri Sovereign Base Area", capital: "Episkopí", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Akrotiri Sovereign Base Area");
            var Algeria = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Algeria", formalName: "People's Democratic Republic of Algeria", nativeName: "الجزائر", capital: "Algiers", isoTreeCode: "DZA", isoTwoCode: "DZ", ccnTreeCode: "NULL", phoneCode: "213", currency: "DZD", population: 0, emoji: "🇩🇿", emojiU: "U+1F1E9 U+1F1FF", remarks: "People's Democratic Republic of Algeria");
            var AshmoreandCartierIslands = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Ashmore and Cartier Islands", formalName: "Ashmore and Cartier Islands", nativeName: "Ashmore and Cartier Islands", capital: "Canberra", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Ashmore and Cartier Islands");
            var BaykonurCosmodrome = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Baykonur Cosmodrome", formalName: "Baykonur Cosmodrome", nativeName: "Baykonur Cosmodrome", capital: "Baikonur", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Baykonur Cosmodrome");
            var CaboVerde = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Cabo Verde", formalName: "Cabo Verde", nativeName: "Cabo Verde", capital: "Praia", isoTreeCode: "CPV", isoTwoCode: "CV", ccnTreeCode: "NULL", phoneCode: "238", currency: "CVE", population: 0, emoji: "🇨🇻", emojiU: "U+1F1E8 U+1F1FB", remarks: "Cabo Verde");
            var CoralSeaIslands = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Coral Sea Islands", formalName: "Coral Sea Islands", nativeName: "Coral Sea Islands", capital: "Arrecife Lihou", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Coral Sea Islands");
            var CyprusNoMansArea = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Cyprus No Mans Area", formalName: "Cyprus No Mans Area", nativeName: "Cyprus No Mans Area", capital: "Nicosia", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Cyprus No Mans Area");
            var DhekeliaSovereignBaseArea = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Dhekelia Sovereign Base Area", formalName: "Dhekelia Sovereign Base Area", nativeName: "Dhekelia Sovereign Base Area", capital: "Dekelia", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Dhekelia Sovereign Base Area");
            var Egypt = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Egypt", formalName: "Arab Republic of Egypt", nativeName: "مصر‎", capital: "Cairo", isoTreeCode: "EGY", isoTwoCode: "EG", ccnTreeCode: "NULL", phoneCode: "20", currency: "EGP", population: 0, emoji: "🇪🇬", emojiU: "U+1F1EA U+1F1EC", remarks: "Arab Republic of Egypt");
            var Libya = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Libya", formalName: "Libya", nativeName: "‏ليبيا", capital: "Tripolis", isoTreeCode: "LBY", isoTwoCode: "LY", ccnTreeCode: "NULL", phoneCode: "218", currency: "LYD", population: 0, emoji: "🇱🇾", emojiU: "U+1F1F1 U+1F1FE", remarks: "Libya");
            var Morocco = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Morocco", formalName: "Kingdom of Morocco", nativeName: "المغرب", capital: "Rabat", isoTreeCode: "MAR", isoTwoCode: "MA", ccnTreeCode: "NULL", phoneCode: "212", currency: "MAD", population: 0, emoji: "🇲🇦", emojiU: "U+1F1F2 U+1F1E6", remarks: "Kingdom of Morocco");
            var NorthernCyprus = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Northern Cyprus", formalName: "Northern Cyprus", nativeName: "Northern Cyprus", capital: "Nicosia", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Northern Cyprus");
            var ScarboroughReef = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Scarborough Reef", formalName: "Scarborough Reef", nativeName: "Scarborough Reef", capital: "Scarborough Reef", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Scarborough Reef");
            var Somaliland = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Somaliland", formalName: "Somaliland", nativeName: "Somaliland", capital: "Hargeisa", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Somaliland");
            var SouthSudan = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "South Sudan", formalName: "South Sudan", nativeName: "South Sudan", capital: "Juba", isoTreeCode: "SSD", isoTwoCode: "SS", ccnTreeCode: "NULL", phoneCode: "211", currency: "SSP", population: 0, emoji: "🇸🇸", emojiU: "U+1F1F8 U+1F1F8", remarks: "South Sudan");
            var SpratlyIslands = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Spratly Islands", formalName: "Spratly Islands", nativeName: "Spratly Islands", capital: "Itu Aba", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Spratly Islands");
            var Sudan = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Sudan", formalName: "Republic of the Sudan", nativeName: "السودان", capital: "Khartoum", isoTreeCode: "SDN", isoTwoCode: "SD", ccnTreeCode: "NULL", phoneCode: "249", currency: "SDG", population: 0, emoji: "🇸🇩", emojiU: "U+1F1F8 U+1F1E9", remarks: "Republic of the Sudan");
            var Tunisia = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Tunisia", formalName: "Republic of Tunisia", nativeName: "تونس", capital: "Tunis", isoTreeCode: "TUN", isoTwoCode: "TN", ccnTreeCode: "NULL", phoneCode: "216", currency: "TND", population: 0, emoji: "🇹🇳", emojiU: "U+1F1F9 U+1F1F3", remarks: "Republic of Tunisia");
            var WesternSahara = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: NorthernAfrica.Id, name: "Western Sahara", formalName: "Western Sahara", nativeName: "الصحراء الغربية", capital: "El-Aaiun", isoTreeCode: "ESH", isoTwoCode: "EH", ccnTreeCode: "NULL", phoneCode: "212", currency: "MAD", population: 0, emoji: "🇪🇭", emojiU: "U+1F1EA U+1F1ED", remarks: "Western Sahara");
            var Botswana = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: SouthernAfrica.Id, name: "Botswana", formalName: "Republic of Botswana", nativeName: "Botswana", capital: "Gaborone", isoTreeCode: "BWA", isoTwoCode: "BW", ccnTreeCode: "NULL", phoneCode: "267", currency: "BWP", population: 0, emoji: "🇧🇼", emojiU: "U+1F1E7 U+1F1FC", remarks: "Republic of Botswana");
            var Lesotho = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: SouthernAfrica.Id, name: "Lesotho", formalName: "Kingdom of Lesotho", nativeName: "Lesotho", capital: "Maseru", isoTreeCode: "LSO", isoTwoCode: "LS", ccnTreeCode: "NULL", phoneCode: "266", currency: "LSL", population: 0, emoji: "🇱🇸", emojiU: "U+1F1F1 U+1F1F8", remarks: "Kingdom of Lesotho");
            var Namibia = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: SouthernAfrica.Id, name: "Namibia", formalName: "Republic of Namibia", nativeName: "Namibia", capital: "Windhoek", isoTreeCode: "NAM", isoTwoCode: "NA", ccnTreeCode: "NULL", phoneCode: "264", currency: "NAD", population: 0, emoji: "🇳🇦", emojiU: "U+1F1F3 U+1F1E6", remarks: "Republic of Namibia");
            var SouthAfrica = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: SouthernAfrica.Id, name: "South Africa", formalName: "Republic of South Africa", nativeName: "South Africa", capital: "Pretoria", isoTreeCode: "ZAF", isoTwoCode: "ZA", ccnTreeCode: "NULL", phoneCode: "27", currency: "ZAR", population: 0, emoji: "🇿🇦", emojiU: "U+1F1FF U+1F1E6", remarks: "Republic of South Africa");
            var Swaziland = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: SouthernAfrica.Id, name: "Swaziland", formalName: "Kingdom of Swaziland", nativeName: "Swaziland", capital: "Mbabane", isoTreeCode: "SWZ", isoTwoCode: "SZ", ccnTreeCode: "NULL", phoneCode: "268", currency: "SZL", population: 0, emoji: "🇸🇿", emojiU: "U+1F1F8 U+1F1FF", remarks: "Kingdom of Swaziland");
            var Benin = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Benin", formalName: "Republic of Benin", nativeName: "Bénin", capital: "Porto-Novo", isoTreeCode: "BEN", isoTwoCode: "BJ", ccnTreeCode: "NULL", phoneCode: "229", currency: "XOF", population: 0, emoji: "🇧🇯", emojiU: "U+1F1E7 U+1F1EF", remarks: "Republic of Benin");
            var BurkinaFaso = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Burkina Faso", formalName: "Burkina Faso", nativeName: "Burkina Faso", capital: "Ouagadougou", isoTreeCode: "BFA", isoTwoCode: "BF", ccnTreeCode: "NULL", phoneCode: "226", currency: "XOF", population: 0, emoji: "🇧🇫", emojiU: "U+1F1E7 U+1F1EB", remarks: "Burkina Faso");
            var CoteDIvoire = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Cote D Ivoire", formalName: "Republic of Ivory Coast", nativeName: "Cote D'Ivoire (Ivory Coast)", capital: "Yamoussoukro", isoTreeCode: "CIV", isoTwoCode: "CI", ccnTreeCode: "NULL", phoneCode: "225", currency: "XOF", population: 0, emoji: "🇨🇮", emojiU: "U+1F1E8 U+1F1EE", remarks: "Republic of Ivory Coast");
            var GambiaThe = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Gambia The", formalName: "Republic of the Gambia", nativeName: "Gambia", capital: "Banjul", isoTreeCode: "GMB", isoTwoCode: "GM", ccnTreeCode: "NULL", phoneCode: "220", currency: "GMD", population: 0, emoji: "🇬🇲", emojiU: "U+1F1EC U+1F1F2", remarks: "Republic of the Gambia");
            var Ghana = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Ghana", formalName: "Republic of Ghana", nativeName: "Ghana", capital: "Accra", isoTreeCode: "GHA", isoTwoCode: "GH", ccnTreeCode: "NULL", phoneCode: "233", currency: "GHS", population: 0, emoji: "🇬🇭", emojiU: "U+1F1EC U+1F1ED", remarks: "Republic of Ghana");
            var Guinea = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Guinea", formalName: "Republic of Guinea", nativeName: "Guinée", capital: "Conakry", isoTreeCode: "GIN", isoTwoCode: "GN", ccnTreeCode: "NULL", phoneCode: "224", currency: "GNF", population: 0, emoji: "🇬🇳", emojiU: "U+1F1EC U+1F1F3", remarks: "Republic of Guinea");
            var GuineaBissau = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Guinea Bissau", formalName: "Republic of Guinea-Bissau", nativeName: "Guiné-Bissau", capital: "Bissau", isoTreeCode: "GNB", isoTwoCode: "GW", ccnTreeCode: "NULL", phoneCode: "245", currency: "XOF", population: 0, emoji: "🇬🇼", emojiU: "U+1F1EC U+1F1FC", remarks: "Republic of Guinea-Bissau");
            var Liberia = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Liberia", formalName: "Republic of Liberia", nativeName: "Liberia", capital: "Monrovia", isoTreeCode: "LBR", isoTwoCode: "LR", ccnTreeCode: "NULL", phoneCode: "231", currency: "LRD", population: 0, emoji: "🇱🇷", emojiU: "U+1F1F1 U+1F1F7", remarks: "Republic of Liberia");
            var Mali = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Mali", formalName: "Republic of Mali", nativeName: "Mali", capital: "Bamako", isoTreeCode: "MLI", isoTwoCode: "ML", ccnTreeCode: "NULL", phoneCode: "223", currency: "XOF", population: 0, emoji: "🇲🇱", emojiU: "U+1F1F2 U+1F1F1", remarks: "Republic of Mali");
            var Mauritania = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Mauritania", formalName: "Islamic Republic of Mauritania", nativeName: "موريتانيا", capital: "Nouakchott", isoTreeCode: "MRT", isoTwoCode: "MR", ccnTreeCode: "NULL", phoneCode: "222", currency: "MRO", population: 0, emoji: "🇲🇷", emojiU: "U+1F1F2 U+1F1F7", remarks: "Islamic Republic of Mauritania");
            var Niger = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Niger", formalName: "Republic of Niger", nativeName: "Niger", capital: "Niamey", isoTreeCode: "NER", isoTwoCode: "NE", ccnTreeCode: "NULL", phoneCode: "227", currency: "XOF", population: 0, emoji: "🇳🇪", emojiU: "U+1F1F3 U+1F1EA", remarks: "Republic of Niger");
            var Nigeria = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Nigeria", formalName: "Federal Republic of Nigeria", nativeName: "Nigeria", capital: "Abuja", isoTreeCode: "NGA", isoTwoCode: "NG", ccnTreeCode: "NULL", phoneCode: "234", currency: "NGN", population: 0, emoji: "🇳🇬", emojiU: "U+1F1F3 U+1F1EC", remarks: "Federal Republic of Nigeria");
            var Senegal = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Senegal", formalName: "Republic of Senegal", nativeName: "Sénégal", capital: "Dakar", isoTreeCode: "SEN", isoTwoCode: "SN", ccnTreeCode: "NULL", phoneCode: "221", currency: "XOF", population: 0, emoji: "🇸🇳", emojiU: "U+1F1F8 U+1F1F3", remarks: "Republic of Senegal");
            var SierraLeone = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Sierra Leone", formalName: "Republic of Sierra Leone", nativeName: "Sierra Leone", capital: "Freetown", isoTreeCode: "SLE", isoTwoCode: "SL", ccnTreeCode: "NULL", phoneCode: "232", currency: "SLL", population: 0, emoji: "🇸🇱", emojiU: "U+1F1F8 U+1F1F1", remarks: "Republic of Sierra Leone");
            var Togo = new Country(id: _GuidGenerator.Create(), continentID: Africa.Id, subcontinentId: WesternAfrica.Id, name: "Togo", formalName: "Togolese Republic", nativeName: "Togo", capital: "Lome", isoTreeCode: "TGO", isoTwoCode: "TG", ccnTreeCode: "NULL", phoneCode: "228", currency: "XOF", population: 0, emoji: "🇹🇬", emojiU: "U+1F1F9 U+1F1EC", remarks: "Togolese Republic");
            var FrenchSouthernTerritories = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "French Southern Territories", formalName: "French Southern Territories", nativeName: "Territoire des Terres australes et antarctiques fr", capital: "Port-aux-Francais", isoTreeCode: "ATF", isoTwoCode: "TF", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "EUR", population: 0, emoji: "🇹🇫", emojiU: "U+1F1F9 U+1F1EB", remarks: "French Southern Territories");
            var HeardandMcDonaldIslands = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Heard and McDonald Islands", formalName: "Heard and McDonald Islands", nativeName: "Heard Island and McDonald Islands", capital: "", isoTreeCode: "HMD", isoTwoCode: "HM", ccnTreeCode: "NULL", phoneCode: " ", currency: "AUD", population: 0, emoji: "🇭🇲", emojiU: "U+1F1ED U+1F1F2", remarks: "Heard and McDonald Islands");
            var NetherlandsAntilles = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Netherlands Antilles", formalName: "Netherlands Antilles", nativeName: "NULL", capital: "NULL", isoTreeCode: "ANT", isoTwoCode: "AN", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "", population: 0, emoji: "", emojiU: "", remarks: "Netherlands Antilles");
            var SouthGeorgia = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "South Georgia", formalName: "South Georgia", nativeName: "South Georgia", capital: "Grytviken", isoTreeCode: "SGS", isoTwoCode: "GS", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "GBP", population: 0, emoji: "🇬🇸", emojiU: "U+1F1EC U+1F1F8", remarks: "South Georgia");
            var Anguilla = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Anguilla", formalName: "Anguilla", nativeName: "Anguilla", capital: "The Valley", isoTreeCode: "AIA", isoTwoCode: "AI", ccnTreeCode: "NULL", phoneCode: "1-264", currency: "XCD", population: 0, emoji: "🇦🇮", emojiU: "U+1F1E6 U+1F1EE", remarks: "Anguilla");
            var AntiguaAndBarbuda = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Antigua And Barbuda", formalName: "Antigua and Barbuda", nativeName: "Antigua and Barbuda", capital: "St. John's", isoTreeCode: "ATG", isoTwoCode: "AG", ccnTreeCode: "NULL", phoneCode: "1-268", currency: "XCD", population: 0, emoji: "🇦🇬", emojiU: "U+1F1E6 U+1F1EC", remarks: "Antigua and Barbuda");
            var Aruba = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Aruba", formalName: "Aruba", nativeName: "Aruba", capital: "Oranjestad", isoTreeCode: "ABW", isoTwoCode: "AW", ccnTreeCode: "NULL", phoneCode: "297", currency: "AWG", population: 0, emoji: "🇦🇼", emojiU: "U+1F1E6 U+1F1FC", remarks: "Aruba");
            var BahamasThe = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Bahamas The", formalName: "Commonwealth of the Bahamas", nativeName: "Bahamas", capital: "Nassau", isoTreeCode: "BHS", isoTwoCode: "BS", ccnTreeCode: "NULL", phoneCode: "1-242", currency: "BSD", population: 0, emoji: "🇧🇸", emojiU: "U+1F1E7 U+1F1F8", remarks: "Commonwealth of the Bahamas");
            var Barbados = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Barbados", formalName: "Barbados", nativeName: "Barbados", capital: "Bridgetown", isoTreeCode: "BRB", isoTwoCode: "BB", ccnTreeCode: "NULL", phoneCode: "1-246", currency: "BBD", population: 0, emoji: "🇧🇧", emojiU: "U+1F1E7 U+1F1E7", remarks: "Barbados");
            var Bermuda = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Bermuda", formalName: "Bermuda", nativeName: "Bermuda", capital: "Hamilton", isoTreeCode: "BMU", isoTwoCode: "BM", ccnTreeCode: "NULL", phoneCode: "1-441", currency: "BMD", population: 0, emoji: "🇧🇲", emojiU: "U+1F1E7 U+1F1F2", remarks: "Bermuda");
            var BouvetIsland = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Bouvet Island", formalName: "Bouvet Island", nativeName: "Bouvetøya", capital: "", isoTreeCode: "BVT", isoTwoCode: "BV", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NOK", population: 0, emoji: "🇧🇻", emojiU: "U+1F1E7 U+1F1FB", remarks: "Bouvet Island");
            var CaymanIslands = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Cayman Islands", formalName: "Cayman Islands", nativeName: "Cayman Islands", capital: "George Town", isoTreeCode: "CYM", isoTwoCode: "KY", ccnTreeCode: "NULL", phoneCode: "1-345", currency: "KYD", population: 0, emoji: "🇰🇾", emojiU: "U+1F1F0 U+1F1FE", remarks: "Cayman Islands");
            var CocosKeelingIslands = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Cocos Keeling Islands", formalName: "Cocos (Keeling) Islands", nativeName: "Cocos (Keeling) Islands", capital: "West Island", isoTreeCode: "CCK", isoTwoCode: "CC", ccnTreeCode: "NULL", phoneCode: "61", currency: "AUD", population: 0, emoji: "🇨🇨", emojiU: "U+1F1E8 U+1F1E8", remarks: "Cocos (Keeling) Islands");
            var Cuba = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Cuba", formalName: "Republic of Cuba", nativeName: "Cuba", capital: "Havana", isoTreeCode: "CUB", isoTwoCode: "CU", ccnTreeCode: "NULL", phoneCode: "53", currency: "CUP", population: 0, emoji: "🇨🇺", emojiU: "U+1F1E8 U+1F1FA", remarks: "Republic of Cuba");
            var Curaçao = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Curaçao", formalName: "Curaçao", nativeName: "Curaçao", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Curaçao");
            var Dominica = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Dominica", formalName: "Commonwealth of Dominica", nativeName: "Dominica", capital: "Roseau", isoTreeCode: "DMA", isoTwoCode: "DM", ccnTreeCode: "NULL", phoneCode: "1-767", currency: "XCD", population: 0, emoji: "🇩🇲", emojiU: "U+1F1E9 U+1F1F2", remarks: "Commonwealth of Dominica");
            var DominicanRepublic = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Dominican Republic", formalName: "Dominican Republic", nativeName: "República Dominicana", capital: "Santo Domingo", isoTreeCode: "DOM", isoTwoCode: "DO", ccnTreeCode: "NULL", phoneCode: "+1-809/1-829", currency: "DOP", population: 0, emoji: "🇩🇴", emojiU: "U+1F1E9 U+1F1F4", remarks: "Dominican Republic");
            var FalklandIslands = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Falkland Islands", formalName: "Falkland Islands", nativeName: "Falkland Islands", capital: "Stanley", isoTreeCode: "FLK", isoTwoCode: "FK", ccnTreeCode: "NULL", phoneCode: "500", currency: "FKP", population: 0, emoji: "🇫🇰", emojiU: "U+1F1EB U+1F1F0", remarks: "Falkland Islands");
            var FrenchGuiana = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "French Guiana", formalName: "French Guiana", nativeName: "Guyane française", capital: "Cayenne", isoTreeCode: "GUF", isoTwoCode: "GF", ccnTreeCode: "NULL", phoneCode: "594", currency: "EUR", population: 0, emoji: "🇬🇫", emojiU: "U+1F1EC U+1F1EB", remarks: "French Guiana");
            var Greenland = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Greenland", formalName: "Greenland", nativeName: "Kalaallit Nunaat", capital: "Nuuk", isoTreeCode: "GRL", isoTwoCode: "GL", ccnTreeCode: "NULL", phoneCode: "299", currency: "DKK", population: 0, emoji: "🇬🇱", emojiU: "U+1F1EC U+1F1F1", remarks: "Greenland");
            var Grenada = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Grenada", formalName: "Grenada", nativeName: "Grenada", capital: "St. George's", isoTreeCode: "GRD", isoTwoCode: "GD", ccnTreeCode: "NULL", phoneCode: "1-473", currency: "XCD", population: 0, emoji: "🇬🇩", emojiU: "U+1F1EC U+1F1E9", remarks: "Grenada");
            var Guadeloupe = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Guadeloupe", formalName: "Guadeloupe", nativeName: "Guadeloupe", capital: "Basse-Terre", isoTreeCode: "GLP", isoTwoCode: "GP", ccnTreeCode: "NULL", phoneCode: "590", currency: "EUR", population: 0, emoji: "🇬🇵", emojiU: "U+1F1EC U+1F1F5", remarks: "Guadeloupe");
            var Haiti = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Haiti", formalName: "Republic of Haiti", nativeName: "Haïti", capital: "Port-au-Prince", isoTreeCode: "HTI", isoTwoCode: "HT", ccnTreeCode: "NULL", phoneCode: "509", currency: "HTG", population: 0, emoji: "🇭🇹", emojiU: "U+1F1ED U+1F1F9", remarks: "Republic of Haiti");
            var Jamaica = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Jamaica", formalName: "Jamaica", nativeName: "Jamaica", capital: "Kingston", isoTreeCode: "JAM", isoTwoCode: "JM", ccnTreeCode: "NULL", phoneCode: "1-876", currency: "JMD", population: 0, emoji: "🇯🇲", emojiU: "U+1F1EF U+1F1F2", remarks: "Jamaica");
            var Martinique = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Martinique", formalName: "Martinique", nativeName: "Martinique", capital: "Fort-de-France", isoTreeCode: "MTQ", isoTwoCode: "MQ", ccnTreeCode: "NULL", phoneCode: "596", currency: "EUR", population: 0, emoji: "🇲🇶", emojiU: "U+1F1F2 U+1F1F6", remarks: "Martinique");
            var Mayotte = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Mayotte", formalName: "Mayotte", nativeName: "Mayotte", capital: "Mamoudzou", isoTreeCode: "MYT", isoTwoCode: "YT", ccnTreeCode: "NULL", phoneCode: "262", currency: "EUR", population: 0, emoji: "🇾🇹", emojiU: "U+1F1FE U+1F1F9", remarks: "Mayotte");
            var Montserrat = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Montserrat", formalName: "Montserrat", nativeName: "Montserrat", capital: "Plymouth", isoTreeCode: "MSR", isoTwoCode: "MS", ccnTreeCode: "NULL", phoneCode: "1-664", currency: "XCD", population: 0, emoji: "🇲🇸", emojiU: "U+1F1F2 U+1F1F8", remarks: "Montserrat");
            var PuertoRico = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Puerto Rico", formalName: "Puerto Rico", nativeName: "Puerto Rico", capital: "San Juan", isoTreeCode: "PRI", isoTwoCode: "PR", ccnTreeCode: "NULL", phoneCode: "+1-787/1-939", currency: "USD", population: 0, emoji: "🇵🇷", emojiU: "U+1F1F5 U+1F1F7", remarks: "Puerto Rico");
            var Reunion = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Reunion", formalName: "Reunion", nativeName: "La Réunion", capital: "Saint-Denis", isoTreeCode: "REU", isoTwoCode: "RE", ccnTreeCode: "NULL", phoneCode: "262", currency: "EUR", population: 0, emoji: "🇷🇪", emojiU: "U+1F1F7 U+1F1EA", remarks: "Reunion");
            var SaintBarthelemy = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Barthelemy", formalName: "Saint-Barthelemy", nativeName: "Saint-Barthélemy", capital: "Gustavia", isoTreeCode: "BLM", isoTwoCode: "BL", ccnTreeCode: "NULL", phoneCode: "590", currency: "EUR", population: 0, emoji: "🇧🇱", emojiU: "U+1F1E7 U+1F1F1", remarks: "Saint-Barthelemy");
            var SaintHelena = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Helena", formalName: "Saint Lucia", nativeName: "Saint Helena", capital: "Jamestown", isoTreeCode: "SHN", isoTwoCode: "SH", ccnTreeCode: "NULL", phoneCode: "290", currency: "SHP", population: 0, emoji: "🇸🇭", emojiU: "U+1F1F8 U+1F1ED", remarks: "Saint Lucia");
            var SaintKittsAndNevis = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Kitts And Nevis", formalName: "Federation of Saint Kitts and Nevis", nativeName: "Saint Kitts and Nevis", capital: "Basseterre", isoTreeCode: "KNA", isoTwoCode: "KN", ccnTreeCode: "NULL", phoneCode: "1-869", currency: "XCD", population: 0, emoji: "🇰🇳", emojiU: "U+1F1F0 U+1F1F3", remarks: "Federation of Saint Kitts and Nevis");
            var SaintLucia = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Lucia", formalName: "Saint Lucia", nativeName: "Saint Lucia", capital: "Castries", isoTreeCode: "LCA", isoTwoCode: "LC", ccnTreeCode: "NULL", phoneCode: "1-758", currency: "XCD", population: 0, emoji: "🇱🇨", emojiU: "U+1F1F1 U+1F1E8", remarks: "Saint Lucia");
            var SaintMartin = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Martin", formalName: "Saint Martin", nativeName: "Saint Martin", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Saint Martin");
            var SaintMartinFrenchpart = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Martin French part", formalName: "Saint-Martin (French part)", nativeName: "Saint-Martin", capital: "Marigot", isoTreeCode: "MAF", isoTwoCode: "MF", ccnTreeCode: "NULL", phoneCode: "590", currency: "EUR", population: 0, emoji: "🇲🇫", emojiU: "U+1F1F2 U+1F1EB", remarks: "Saint-Martin (French part)");
            var SaintPierreandMiquelon = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Pierre and Miquelon", formalName: "Saint Pierre and Miquelon", nativeName: "Saint-Pierre-et-Miquelon", capital: "Saint-Pierre", isoTreeCode: "SPM", isoTwoCode: "PM", ccnTreeCode: "NULL", phoneCode: "508", currency: "EUR", population: 0, emoji: "🇵🇲", emojiU: "U+1F1F5 U+1F1F2", remarks: "Saint Pierre and Miquelon");
            var SaintVincentAndTheGrenadines = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Saint Vincent And The Grenadines", formalName: "Saint Vincent and the Grenadines", nativeName: "Saint Vincent and the Grenadines", capital: "Kingstown", isoTreeCode: "VCT", isoTwoCode: "VC", ccnTreeCode: "NULL", phoneCode: "1-784", currency: "XCD", population: 0, emoji: "🇻🇨", emojiU: "U+1F1FB U+1F1E8", remarks: "Saint Vincent and the Grenadines");
            var SintMaarten = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Sint Maarten", formalName: "Sint Maarten", nativeName: "Sint Maarten", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Sint Maarten");
            var SvalbardAndJanMayenIslands = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Svalbard And Jan Mayen Islands", formalName: "Svalbard And Jan Mayen Islands", nativeName: "Svalbard og Jan Mayen", capital: "Longyearbyen", isoTreeCode: "SJM", isoTwoCode: "SJ", ccnTreeCode: "NULL", phoneCode: "47", currency: "NOK", population: 0, emoji: "🇸🇯", emojiU: "U+1F1F8 U+1F1EF", remarks: "Svalbard And Jan Mayen Islands");
            var Tokelau = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Tokelau", formalName: "Tokelau", nativeName: "Tokelau", capital: "", isoTreeCode: "TKL", isoTwoCode: "TK", ccnTreeCode: "NULL", phoneCode: "690", currency: "NZD", population: 0, emoji: "🇹🇰", emojiU: "U+1F1F9 U+1F1F0", remarks: "Tokelau");
            var TrinidadAndTobago = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Trinidad And Tobago", formalName: "Republic of Trinidad and Tobago", nativeName: "Trinidad and Tobago", capital: "Port of Spain", isoTreeCode: "TTO", isoTwoCode: "TT", ccnTreeCode: "NULL", phoneCode: "1-868", currency: "TTD", population: 0, emoji: "🇹🇹", emojiU: "U+1F1F9 U+1F1F9", remarks: "Republic of Trinidad and Tobago");
            var TurksAndCaicosIslands = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Turks And Caicos Islands", formalName: "Turks And Caicos Islands", nativeName: "Turks and Caicos Islands", capital: "Cockburn Town", isoTreeCode: "TCA", isoTwoCode: "TC", ccnTreeCode: "NULL", phoneCode: "1-649", currency: "USD", population: 0, emoji: "🇹🇨", emojiU: "U+1F1F9 U+1F1E8", remarks: "Turks And Caicos Islands");
            var VirginIslandsBritish = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Virgin Islands British", formalName: "Virgin Islands (British)", nativeName: "British Virgin Islands", capital: "Road Town", isoTreeCode: "VGB", isoTwoCode: "VG", ccnTreeCode: "NULL", phoneCode: "1-284", currency: "USD", population: 0, emoji: "🇻🇬", emojiU: "U+1F1FB U+1F1EC", remarks: "Virgin Islands (British)");
            var VirginIslandsUS = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: Caribbean.Id, name: "Virgin Islands US", formalName: "Virgin Islands (US)", nativeName: "United States Virgin Islands", capital: "Charlotte Amalie", isoTreeCode: "VIR", isoTwoCode: "VI", ccnTreeCode: "NULL", phoneCode: "1-340", currency: "USD", population: 0, emoji: "🇻🇮", emojiU: "U+1F1FB U+1F1EE", remarks: "Virgin Islands (US)");
            var Belize = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Belize", formalName: "Belize", nativeName: "Belize", capital: "Belmopan", isoTreeCode: "BLZ", isoTwoCode: "BZ", ccnTreeCode: "NULL", phoneCode: "501", currency: "BZD", population: 0, emoji: "🇧🇿", emojiU: "U+1F1E7 U+1F1FF", remarks: "Belize");
            var CostaRica = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Costa Rica", formalName: "Republic of Costa Rica", nativeName: "Costa Rica", capital: "San Jose", isoTreeCode: "CRI", isoTwoCode: "CR", ccnTreeCode: "NULL", phoneCode: "506", currency: "CRC", population: 0, emoji: "🇨🇷", emojiU: "U+1F1E8 U+1F1F7", remarks: "Republic of Costa Rica");
            var ElSalvador = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "El Salvador", formalName: "Republic of El Salvador", nativeName: "El Salvador", capital: "San Salvador", isoTreeCode: "SLV", isoTwoCode: "SV", ccnTreeCode: "NULL", phoneCode: "503", currency: "USD", population: 0, emoji: "🇸🇻", emojiU: "U+1F1F8 U+1F1FB", remarks: "Republic of El Salvador");
            var Guatemala = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Guatemala", formalName: "Republic of Guatemala", nativeName: "Guatemala", capital: "Guatemala City", isoTreeCode: "GTM", isoTwoCode: "GT", ccnTreeCode: "NULL", phoneCode: "502", currency: "GTQ", population: 0, emoji: "🇬🇹", emojiU: "U+1F1EC U+1F1F9", remarks: "Republic of Guatemala");
            var Honduras = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Honduras", formalName: "Republic of Honduras", nativeName: "Honduras", capital: "Tegucigalpa", isoTreeCode: "HND", isoTwoCode: "HN", ccnTreeCode: "NULL", phoneCode: "504", currency: "HNL", population: 0, emoji: "🇭🇳", emojiU: "U+1F1ED U+1F1F3", remarks: "Republic of Honduras");
            var Mexico = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Mexico", formalName: "United Mexican States", nativeName: "México", capital: "Mexico City", isoTreeCode: "MEX", isoTwoCode: "MX", ccnTreeCode: "NULL", phoneCode: "52", currency: "MXN", population: 0, emoji: "🇲🇽", emojiU: "U+1F1F2 U+1F1FD", remarks: "United Mexican States");
            var Nicaragua = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Nicaragua", formalName: "Republic of Nicaragua", nativeName: "Nicaragua", capital: "Managua", isoTreeCode: "NIC", isoTwoCode: "NI", ccnTreeCode: "NULL", phoneCode: "505", currency: "NIO", population: 0, emoji: "🇳🇮", emojiU: "U+1F1F3 U+1F1EE", remarks: "Republic of Nicaragua");
            var Panama = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: CentralAmerica.Id, name: "Panama", formalName: "Republic of Panama", nativeName: "Panamá", capital: "Panama City", isoTreeCode: "PAN", isoTwoCode: "PA", ccnTreeCode: "NULL", phoneCode: "507", currency: "PAB", population: 0, emoji: "🇵🇦", emojiU: "U+1F1F5 U+1F1E6", remarks: "Republic of Panama");
            var Canada = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: NorthernAmerica.Id, name: "Canada", formalName: "Canada", nativeName: "Canada", capital: "Ottawa", isoTreeCode: "CAN", isoTwoCode: "CA", ccnTreeCode: "NULL", phoneCode: "1", currency: "CAD", population: 0, emoji: "🇨🇦", emojiU: "U+1F1E8 U+1F1E6", remarks: "Canada");
            var UnitedStates = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: NorthernAmerica.Id, name: "United States", formalName: "United States of America", nativeName: "United States", capital: "Washington", isoTreeCode: "USA", isoTwoCode: "US", ccnTreeCode: "NULL", phoneCode: "1", currency: "USD", population: 0, emoji: "🇺🇸", emojiU: "U+1F1FA U+1F1F8", remarks: "United States of America");
            var Argentina = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Argentina", formalName: "Argentine Republic", nativeName: "Argentina", capital: "Buenos Aires", isoTreeCode: "ARG", isoTwoCode: "AR", ccnTreeCode: "NULL", phoneCode: "54", currency: "ARS", population: 0, emoji: "🇦🇷", emojiU: "U+1F1E6 U+1F1F7", remarks: "Argentine Republic");
            var Bolivia = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Bolivia", formalName: "Plurinational State of Bolivia", nativeName: "Bolivia", capital: "Sucre", isoTreeCode: "BOL", isoTwoCode: "BO", ccnTreeCode: "NULL", phoneCode: "591", currency: "BOB", population: 0, emoji: "🇧🇴", emojiU: "U+1F1E7 U+1F1F4", remarks: "Plurinational State of Bolivia");
            var Brazil = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Brazil", formalName: "Federative Republic of Brazil", nativeName: "Brasil", capital: "Brasilia", isoTreeCode: "BRA", isoTwoCode: "BR", ccnTreeCode: "NULL", phoneCode: "55", currency: "BRL", population: 0, emoji: "🇧🇷", emojiU: "U+1F1E7 U+1F1F7", remarks: "Federative Republic of Brazil");
            var Chile = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Chile", formalName: "Republic of Chile", nativeName: "Chile", capital: "Santiago", isoTreeCode: "CHL", isoTwoCode: "CL", ccnTreeCode: "NULL", phoneCode: "56", currency: "CLP", population: 0, emoji: "🇨🇱", emojiU: "U+1F1E8 U+1F1F1", remarks: "Republic of Chile");
            var Colombia = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Colombia", formalName: "Republic of Colombia", nativeName: "Colombia", capital: "Bogota", isoTreeCode: "COL", isoTwoCode: "CO", ccnTreeCode: "NULL", phoneCode: "57", currency: "COP", population: 0, emoji: "🇨🇴", emojiU: "U+1F1E8 U+1F1F4", remarks: "Republic of Colombia");
            var Ecuador = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Ecuador", formalName: "Republic of Ecuador", nativeName: "Ecuador", capital: "Quito", isoTreeCode: "ECU", isoTwoCode: "EC", ccnTreeCode: "NULL", phoneCode: "593", currency: "USD", population: 0, emoji: "🇪🇨", emojiU: "U+1F1EA U+1F1E8", remarks: "Republic of Ecuador");
            var Guyana = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Guyana", formalName: "Co-operative Republic of Guyana", nativeName: "Guyana", capital: "Georgetown", isoTreeCode: "GUY", isoTwoCode: "GY", ccnTreeCode: "NULL", phoneCode: "592", currency: "GYD", population: 0, emoji: "🇬🇾", emojiU: "U+1F1EC U+1F1FE", remarks: "Co-operative Republic of Guyana");
            var Paraguay = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Paraguay", formalName: "Republic of Paraguay", nativeName: "Paraguay", capital: "Asuncion", isoTreeCode: "PRY", isoTwoCode: "PY", ccnTreeCode: "NULL", phoneCode: "595", currency: "PYG", population: 0, emoji: "🇵🇾", emojiU: "U+1F1F5 U+1F1FE", remarks: "Republic of Paraguay");
            var Peru = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Peru", formalName: "Republic of Peru", nativeName: "Perú", capital: "Lima", isoTreeCode: "PER", isoTwoCode: "PE", ccnTreeCode: "NULL", phoneCode: "51", currency: "PEN", population: 0, emoji: "🇵🇪", emojiU: "U+1F1F5 U+1F1EA", remarks: "Republic of Peru");
            var Suriname = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Suriname", formalName: "Republic of Suriname", nativeName: "Suriname", capital: "Paramaribo", isoTreeCode: "SUR", isoTwoCode: "SR", ccnTreeCode: "NULL", phoneCode: "597", currency: "SRD", population: 0, emoji: "🇸🇷", emojiU: "U+1F1F8 U+1F1F7", remarks: "Republic of Suriname");
            var Uruguay = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Uruguay", formalName: "Oriental Republic of Uruguay", nativeName: "Uruguay", capital: "Montevideo", isoTreeCode: "URY", isoTwoCode: "UY", ccnTreeCode: "NULL", phoneCode: "598", currency: "UYU", population: 0, emoji: "🇺🇾", emojiU: "U+1F1FA U+1F1FE", remarks: "Oriental Republic of Uruguay");
            var Venezuela = new Country(id: _GuidGenerator.Create(), continentID: new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ).Id, subcontinentId: SouthAmerica.Id, name: "Venezuela", formalName: "Bolivarian Republic of Venezuela", nativeName: "Venezuela", capital: "Caracas", isoTreeCode: "VEN", isoTwoCode: "VE", ccnTreeCode: "NULL", phoneCode: "58", currency: "VEF", population: 0, emoji: "🇻🇪", emojiU: "U+1F1FB U+1F1EA", remarks: "Bolivarian Republic of Venezuela");
            var Antarctica = new Country(id: _GuidGenerator.Create(), continentID: Antartica.Id, subcontinentId: AntarticaSubcontinent.Id, name: "Antarctica", formalName: "Antarctica", nativeName: "Antarctica", capital: "NULL", isoTreeCode: "ATA", isoTwoCode: "AQ", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "🇦🇶", emojiU: "U+1F1E6 U+1F1F6", remarks: "Antarctica");
            var Kazakhstan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: CentralAsia.Id, name: "Kazakhstan", formalName: "Republic of Kazakhstan", nativeName: "Қазақстан", capital: "Astana", isoTreeCode: "KAZ", isoTwoCode: "KZ", ccnTreeCode: "NULL", phoneCode: "7", currency: "KZT", population: 0, emoji: "🇰🇿", emojiU: "U+1F1F0 U+1F1FF", remarks: "Republic of Kazakhstan");
            var Kyrgyzstan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: CentralAsia.Id, name: "Kyrgyzstan", formalName: "Kyrgyz Republic", nativeName: "Кыргызстан", capital: "Bishkek", isoTreeCode: "KGZ", isoTwoCode: "KG", ccnTreeCode: "NULL", phoneCode: "996", currency: "KGS", population: 0, emoji: "🇰🇬", emojiU: "U+1F1F0 U+1F1EC", remarks: "Kyrgyz Republic");
            var Tajikistan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: CentralAsia.Id, name: "Tajikistan", formalName: "Republic of Tajikistan", nativeName: "Тоҷикистон", capital: "Dushanbe", isoTreeCode: "TJK", isoTwoCode: "TJ", ccnTreeCode: "NULL", phoneCode: "992", currency: "TJS", population: 0, emoji: "🇹🇯", emojiU: "U+1F1F9 U+1F1EF", remarks: "Republic of Tajikistan");
            var Turkmenistan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: CentralAsia.Id, name: "Turkmenistan", formalName: "Turkmenistan", nativeName: "Türkmenistan", capital: "Ashgabat", isoTreeCode: "TKM", isoTwoCode: "TM", ccnTreeCode: "NULL", phoneCode: "993", currency: "TMT", population: 0, emoji: "🇹🇲", emojiU: "U+1F1F9 U+1F1F2", remarks: "Turkmenistan");
            var Uzbekistan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: CentralAsia.Id, name: "Uzbekistan", formalName: "Republic of Uzbekistan", nativeName: "O‘zbekiston", capital: "Tashkent", isoTreeCode: "UZB", isoTwoCode: "UZ", ccnTreeCode: "NULL", phoneCode: "998", currency: "UZS", population: 0, emoji: "🇺🇿", emojiU: "U+1F1FA U+1F1FF", remarks: "Republic of Uzbekistan");
            var China = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: EasternAsia.Id, name: "China", formalName: "People's Republic of China", nativeName: "中国", capital: "Beijing", isoTreeCode: "CHN", isoTwoCode: "CN", ccnTreeCode: "NULL", phoneCode: "86", currency: "CNY", population: 0, emoji: "🇨🇳", emojiU: "U+1F1E8 U+1F1F3", remarks: "People's Republic of China");
            var Japan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: EasternAsia.Id, name: "Japan", formalName: "Japan", nativeName: "日本", capital: "Tokyo", isoTreeCode: "JPN", isoTwoCode: "JP", ccnTreeCode: "NULL", phoneCode: "81", currency: "JPY", population: 0, emoji: "🇯🇵", emojiU: "U+1F1EF U+1F1F5", remarks: "Japan");
            var KoreaNorth = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: EasternAsia.Id, name: "Korea North", formalName: "Democratic People's Republic of Korea", nativeName: "북한", capital: "Pyongyang", isoTreeCode: "PRK", isoTwoCode: "KP", ccnTreeCode: "NULL", phoneCode: "850", currency: "KPW", population: 0, emoji: "🇰🇵", emojiU: "U+1F1F0 U+1F1F5", remarks: "Democratic People's Republic of Korea");
            var KoreaSouth = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: EasternAsia.Id, name: "Korea South", formalName: "Republic of Korea", nativeName: "대한민국", capital: "Seoul", isoTreeCode: "KOR", isoTwoCode: "KR", ccnTreeCode: "NULL", phoneCode: "82", currency: "KRW", population: 0, emoji: "🇰🇷", emojiU: "U+1F1F0 U+1F1F7", remarks: "Republic of Korea");
            var Mongolia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: EasternAsia.Id, name: "Mongolia", formalName: "Mongolia", nativeName: "Монгол улс", capital: "Ulan Bator", isoTreeCode: "MNG", isoTwoCode: "MN", ccnTreeCode: "NULL", phoneCode: "976", currency: "MNT", population: 0, emoji: "🇲🇳", emojiU: "U+1F1F2 U+1F1F3", remarks: "Mongolia");
            var Brunei = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Brunei", formalName: "Negara Brunei Darussalam", nativeName: "Negara Brunei Darussalam", capital: "Bandar Seri Begawan", isoTreeCode: "BRN", isoTwoCode: "BN", ccnTreeCode: "NULL", phoneCode: "673", currency: "BND", population: 0, emoji: "🇧🇳", emojiU: "U+1F1E7 U+1F1F3", remarks: "Negara Brunei Darussalam");
            var Cambodia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Cambodia", formalName: "Kingdom of Cambodia", nativeName: "Kâmpŭchéa", capital: "Phnom Penh", isoTreeCode: "KHM", isoTwoCode: "KH", ccnTreeCode: "NULL", phoneCode: "855", currency: "KHR", population: 0, emoji: "🇰🇭", emojiU: "U+1F1F0 U+1F1ED", remarks: "Kingdom of Cambodia");
            var Indonesia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Indonesia", formalName: "Republic of Indonesia", nativeName: "Indonesia", capital: "Jakarta", isoTreeCode: "IDN", isoTwoCode: "ID", ccnTreeCode: "NULL", phoneCode: "62", currency: "IDR", population: 0, emoji: "🇮🇩", emojiU: "U+1F1EE U+1F1E9", remarks: "Republic of Indonesia");
            var Laos = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Laos", formalName: "Lao People's Democratic Republic", nativeName: "ສປປລາວ", capital: "Vientiane", isoTreeCode: "LAO", isoTwoCode: "LA", ccnTreeCode: "NULL", phoneCode: "856", currency: "LAK", population: 0, emoji: "🇱🇦", emojiU: "U+1F1F1 U+1F1E6", remarks: "Lao People's Democratic Republic");
            var Malaysia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Malaysia", formalName: "Malaysia", nativeName: "Malaysia", capital: "Kuala Lumpur", isoTreeCode: "MYS", isoTwoCode: "MY", ccnTreeCode: "NULL", phoneCode: "60", currency: "MYR", population: 0, emoji: "🇲🇾", emojiU: "U+1F1F2 U+1F1FE", remarks: "Malaysia");
            var Myanmar = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Myanmar", formalName: "Republic of the Union of Myanmar", nativeName: "မြန်မာ", capital: "Nay Pyi Taw", isoTreeCode: "MMR", isoTwoCode: "MM", ccnTreeCode: "NULL", phoneCode: "95", currency: "MMK", population: 0, emoji: "🇲🇲", emojiU: "U+1F1F2 U+1F1F2", remarks: "Republic of the Union of Myanmar");
            var Philippines = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Philippines", formalName: "Republic of the Philippines", nativeName: "Pilipinas", capital: "Manila", isoTreeCode: "PHL", isoTwoCode: "PH", ccnTreeCode: "NULL", phoneCode: "63", currency: "PHP", population: 0, emoji: "🇵🇭", emojiU: "U+1F1F5 U+1F1ED", remarks: "Republic of the Philippines");
            var Singapore = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Singapore", formalName: "Republic of Singapore", nativeName: "Singapore", capital: "Singapur", isoTreeCode: "SGP", isoTwoCode: "SG", ccnTreeCode: "NULL", phoneCode: "65", currency: "SGD", population: 0, emoji: "🇸🇬", emojiU: "U+1F1F8 U+1F1EC", remarks: "Republic of Singapore");
            var Thailand = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Thailand", formalName: "Kingdom of Thailand", nativeName: "ประเทศไทย", capital: "Bangkok", isoTreeCode: "THA", isoTwoCode: "TH", ccnTreeCode: "NULL", phoneCode: "66", currency: "THB", population: 0, emoji: "🇹🇭", emojiU: "U+1F1F9 U+1F1ED", remarks: "Kingdom of Thailand");
            var TimorLeste = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Timor Leste", formalName: "Democratic Republic of Timor-Leste", nativeName: "Timor-Leste", capital: "Dili", isoTreeCode: "TLS", isoTwoCode: "TL", ccnTreeCode: "NULL", phoneCode: "670", currency: "USD", population: 0, emoji: "🇹🇱", emojiU: "U+1F1F9 U+1F1F1", remarks: "Democratic Republic of Timor-Leste");
            var Vietnam = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthEasternAsia.Id, name: "Vietnam", formalName: "Socialist Republic of Vietnam", nativeName: "Việt Nam", capital: "Hanoi", isoTreeCode: "VNM", isoTwoCode: "VN", ccnTreeCode: "NULL", phoneCode: "84", currency: "VND", population: 0, emoji: "🇻🇳", emojiU: "U+1F1FB U+1F1F3", remarks: "Socialist Republic of Vietnam");
            var Afghanistan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Afghanistan", formalName: "Islamic State of Afghanistan", nativeName: "افغانستان", capital: "Kabul", isoTreeCode: "AFG", isoTwoCode: "AF", ccnTreeCode: "NULL", phoneCode: "93", currency: "AFN", population: 0, emoji: "🇦🇫", emojiU: "U+1F1E6 U+1F1EB", remarks: "Islamic State of Afghanistan");
            var BajoNuevoBankPetrelIsland = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Bajo Nuevo Bank Petrel Island", formalName: "Bajo Nuevo Bank (Petrel Is.)", nativeName: "NULL", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Bajo Nuevo Bank (Petrel Is.)");
            var Bangladesh = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Bangladesh", formalName: "People's Republic of Bangladesh", nativeName: "Bangladesh", capital: "Dhaka", isoTreeCode: "BGD", isoTwoCode: "BD", ccnTreeCode: "NULL", phoneCode: "880", currency: "BDT", population: 0, emoji: "🇧🇩", emojiU: "U+1F1E7 U+1F1E9", remarks: "People's Republic of Bangladesh");
            var Bhutan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Bhutan", formalName: "Kingdom of Bhutan", nativeName: "ʼbrug-yul", capital: "Thimphu", isoTreeCode: "BTN", isoTwoCode: "BT", ccnTreeCode: "NULL", phoneCode: "975", currency: "BTN", population: 0, emoji: "🇧🇹", emojiU: "U+1F1E7 U+1F1F9", remarks: "Kingdom of Bhutan");
            var BritishIndianOceanTerritory = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "British Indian Ocean Territory", formalName: "British Indian Ocean Territory", nativeName: "British Indian Ocean Territory", capital: "Diego Garcia", isoTreeCode: "IOT", isoTwoCode: "IO", ccnTreeCode: "NULL", phoneCode: "246", currency: "USD", population: 0, emoji: "🇮🇴", emojiU: "U+1F1EE U+1F1F4", remarks: "British Indian Ocean Territory");
            var ChristmasIsland = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Christmas Island", formalName: "Christmas Island", nativeName: "Christmas Island", capital: "Flying Fish Cove", isoTreeCode: "CXR", isoTwoCode: "CX", ccnTreeCode: "NULL", phoneCode: "61", currency: "AUD", population: 0, emoji: "🇨🇽", emojiU: "U+1F1E8 U+1F1FD", remarks: "Christmas Island");
            var HongKongSAR = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Hong Kong SAR", formalName: "Hong Kong S.A.R.", nativeName: "香港", capital: "Hong Kong", isoTreeCode: "HKG", isoTwoCode: "HK", ccnTreeCode: "NULL", phoneCode: "852", currency: "HKD", population: 0, emoji: "🇭🇰", emojiU: "U+1F1ED U+1F1F0", remarks: "Hong Kong S.A.R.");
            var India = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "India", formalName: "Republic of India", nativeName: "भारत", capital: "New Delhi", isoTreeCode: "IND", isoTwoCode: "IN", ccnTreeCode: "NULL", phoneCode: "91", currency: "INR", population: 0, emoji: "🇮🇳", emojiU: "U+1F1EE U+1F1F3", remarks: "Republic of India");
            var IndianOceanTerritories = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Indian Ocean Territories", formalName: "Indian Ocean Territories", nativeName: "NULL", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Indian Ocean Territories");
            var Iran = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Iran", formalName: "Islamic Republic of Iran", nativeName: "ایران", capital: "Tehran", isoTreeCode: "IRN", isoTwoCode: "IR", ccnTreeCode: "NULL", phoneCode: "98", currency: "IRR", population: 0, emoji: "🇮🇷", emojiU: "U+1F1EE U+1F1F7", remarks: "Islamic Republic of Iran");
            var MacauSAR = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Macau SAR", formalName: "Macau S.A.R.", nativeName: "澳門", capital: "Macao", isoTreeCode: "MAC", isoTwoCode: "MO", ccnTreeCode: "NULL", phoneCode: "853", currency: "MOP", population: 0, emoji: "🇲🇴", emojiU: "U+1F1F2 U+1F1F4", remarks: "Macau S.A.R.");
            var Maldives = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Maldives", formalName: "Republic of Maldives", nativeName: "Maldives", capital: "Male", isoTreeCode: "MDV", isoTwoCode: "MV", ccnTreeCode: "NULL", phoneCode: "960", currency: "MVR", population: 0, emoji: "🇲🇻", emojiU: "U+1F1F2 U+1F1FB", remarks: "Republic of Maldives");
            var Nepal = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Nepal", formalName: "Nepal", nativeName: "नपल", capital: "Kathmandu", isoTreeCode: "NPL", isoTwoCode: "NP", ccnTreeCode: "NULL", phoneCode: "977", currency: "NPR", population: 0, emoji: "🇳🇵", emojiU: "U+1F1F3 U+1F1F5", remarks: "Nepal");
            var Pakistan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Pakistan", formalName: "Islamic Republic of Pakistan", nativeName: "Pakistan", capital: "Islamabad", isoTreeCode: "PAK", isoTwoCode: "PK", ccnTreeCode: "NULL", phoneCode: "92", currency: "PKR", population: 0, emoji: "🇵🇰", emojiU: "U+1F1F5 U+1F1F0", remarks: "Islamic Republic of Pakistan");
            var Palestine = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Palestine", formalName: "Palestine", nativeName: "فلسطين", capital: "East Jerusalem", isoTreeCode: "PSE", isoTwoCode: "PS", ccnTreeCode: "NULL", phoneCode: "970", currency: "ILS", population: 0, emoji: "🇵🇸", emojiU: "U+1F1F5 U+1F1F8", remarks: "Palestine");
            var SerranillaBank = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Serranilla Bank", formalName: "Serranilla Bank", nativeName: "NULL", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Serranilla Bank");
            var SiachenGlacier = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Siachen Glacier", formalName: "Siachen Glacier", nativeName: "NULL", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "Siachen Glacier");
            var SriLanka = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Sri Lanka", formalName: "Democratic Socialist Republic of Sri Lanka", nativeName: "śrī laṃkāva", capital: "Colombo", isoTreeCode: "LKA", isoTwoCode: "LK", ccnTreeCode: "NULL", phoneCode: "94", currency: "LKR", population: 0, emoji: "🇱🇰", emojiU: "U+1F1F1 U+1F1F0", remarks: "Democratic Socialist Republic of Sri Lanka");
            var Taiwan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "Taiwan", formalName: "Taiwan", nativeName: "臺灣", capital: "Taipei", isoTreeCode: "TWN", isoTwoCode: "TW", ccnTreeCode: "NULL", phoneCode: "886", currency: "TWD", population: 0, emoji: "🇹🇼", emojiU: "U+1F1F9 U+1F1FC", remarks: "Taiwan");
            var USNavalBaseGuantanamoBay = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: SouthernAsia.Id, name: "US Naval Base Guantanamo Bay", formalName: "US Naval Base Guantanamo Bay", nativeName: "NULL", capital: "NULL", isoTreeCode: "NULL", isoTwoCode: "NULL", ccnTreeCode: "NULL", phoneCode: "NULL", currency: "NULL", population: 0, emoji: "NULL", emojiU: "NULL", remarks: "US Naval Base Guantanamo Bay");
            var Armenia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Armenia", formalName: "Republic of Armenia", nativeName: "Հայաստան", capital: "Yerevan", isoTreeCode: "ARM", isoTwoCode: "AM", ccnTreeCode: "NULL", phoneCode: "374", currency: "AMD", population: 0, emoji: "🇦🇲", emojiU: "U+1F1E6 U+1F1F2", remarks: "Republic of Armenia");
            var Azerbaijan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Azerbaijan", formalName: "Republic of Azerbaijan", nativeName: "Azərbaycan", capital: "Baku", isoTreeCode: "AZE", isoTwoCode: "AZ", ccnTreeCode: "NULL", phoneCode: "994", currency: "AZN", population: 0, emoji: "🇦🇿", emojiU: "U+1F1E6 U+1F1FF", remarks: "Republic of Azerbaijan");
            var Bahrain = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Bahrain", formalName: "Kingdom of Bahrain", nativeName: "‏البحرين", capital: "Manama", isoTreeCode: "BHR", isoTwoCode: "BH", ccnTreeCode: "NULL", phoneCode: "973", currency: "BHD", population: 0, emoji: "🇧🇭", emojiU: "U+1F1E7 U+1F1ED", remarks: "Kingdom of Bahrain");
            var Cyprus = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Cyprus", formalName: "Republic of Cyprus", nativeName: "Κύπρος", capital: "Nicosia", isoTreeCode: "CYP", isoTwoCode: "CY", ccnTreeCode: "NULL", phoneCode: "357", currency: "EUR", population: 0, emoji: "🇨🇾", emojiU: "U+1F1E8 U+1F1FE", remarks: "Republic of Cyprus");
            var Georgia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Georgia", formalName: "Georgia", nativeName: "საქართველო", capital: "Tbilisi", isoTreeCode: "GEO", isoTwoCode: "GE", ccnTreeCode: "NULL", phoneCode: "995", currency: "GEL", population: 0, emoji: "🇬🇪", emojiU: "U+1F1EC U+1F1EA", remarks: "Georgia");
            var Iraq = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Iraq", formalName: "Republic of Iraq", nativeName: "العراق", capital: "Baghdad", isoTreeCode: "IRQ", isoTwoCode: "IQ", ccnTreeCode: "NULL", phoneCode: "964", currency: "IQD", population: 0, emoji: "🇮🇶", emojiU: "U+1F1EE U+1F1F6", remarks: "Republic of Iraq");
            var Israel = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Israel", formalName: "State of Israel", nativeName: "יִשְׂרָאֵל", capital: "Jerusalem", isoTreeCode: "ISR", isoTwoCode: "IL", ccnTreeCode: "NULL", phoneCode: "972", currency: "ILS", population: 0, emoji: "🇮🇱", emojiU: "U+1F1EE U+1F1F1", remarks: "State of Israel");
            var Jordan = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Jordan", formalName: "Hashemite Kingdom of Jordan", nativeName: "الأردن", capital: "Amman", isoTreeCode: "JOR", isoTwoCode: "JO", ccnTreeCode: "NULL", phoneCode: "962", currency: "JOD", population: 0, emoji: "🇯🇴", emojiU: "U+1F1EF U+1F1F4", remarks: "Hashemite Kingdom of Jordan");
            var Kuwait = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Kuwait", formalName: "State of Kuwait", nativeName: "الكويت", capital: "Kuwait City", isoTreeCode: "KWT", isoTwoCode: "KW", ccnTreeCode: "NULL", phoneCode: "965", currency: "KWD", population: 0, emoji: "🇰🇼", emojiU: "U+1F1F0 U+1F1FC", remarks: "State of Kuwait");
            var Lebanon = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Lebanon", formalName: "Lebanese Republic", nativeName: "لبنان", capital: "Beirut", isoTreeCode: "LBN", isoTwoCode: "LB", ccnTreeCode: "NULL", phoneCode: "961", currency: "LBP", population: 0, emoji: "🇱🇧", emojiU: "U+1F1F1 U+1F1E7", remarks: "Lebanese Republic");
            var Oman = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Oman", formalName: "Sultanate of Oman", nativeName: "عمان", capital: "Muscat", isoTreeCode: "OMN", isoTwoCode: "OM", ccnTreeCode: "NULL", phoneCode: "968", currency: "OMR", population: 0, emoji: "🇴🇲", emojiU: "U+1F1F4 U+1F1F2", remarks: "Sultanate of Oman");
            var Qatar = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Qatar", formalName: "State of Qatar", nativeName: "قطر", capital: "Doha", isoTreeCode: "QAT", isoTwoCode: "QA", ccnTreeCode: "NULL", phoneCode: "974", currency: "QAR", population: 0, emoji: "🇶🇦", emojiU: "U+1F1F6 U+1F1E6", remarks: "State of Qatar");
            var SaudiArabia = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Saudi Arabia", formalName: "Kingdom of Saudi Arabia", nativeName: "العربية السعودية", capital: "Riyadh", isoTreeCode: "SAU", isoTwoCode: "SA", ccnTreeCode: "NULL", phoneCode: "966", currency: "SAR", population: 0, emoji: "🇸🇦", emojiU: "U+1F1F8 U+1F1E6", remarks: "Kingdom of Saudi Arabia");
            var Syria = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Syria", formalName: "Syrian Arab Republic", nativeName: "سوريا", capital: "Damascus", isoTreeCode: "SYR", isoTwoCode: "SY", ccnTreeCode: "NULL", phoneCode: "963", currency: "SYP", population: 0, emoji: "🇸🇾", emojiU: "U+1F1F8 U+1F1FE", remarks: "Syrian Arab Republic");
            var Turkey = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Turkey", formalName: "Republic of Turkey", nativeName: "Türkiye", capital: "Ankara", isoTreeCode: "TUR", isoTwoCode: "TR", ccnTreeCode: "NULL", phoneCode: "90", currency: "TRY", population: 0, emoji: "🇹🇷", emojiU: "U+1F1F9 U+1F1F7", remarks: "Republic of Turkey");
            var UnitedArabEmirates = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "United Arab Emirates", formalName: "United Arab Emirates", nativeName: "دولة الإمارات العربية المتحدة", capital: "Abu Dhabi", isoTreeCode: "ARE", isoTwoCode: "AE", ccnTreeCode: "NULL", phoneCode: "971", currency: "AED", population: 0, emoji: "🇦🇪", emojiU: "U+1F1E6 U+1F1EA", remarks: "United Arab Emirates");
            var Yemen = new Country(id: _GuidGenerator.Create(), continentID: Asia.Id, subcontinentId: WesternAsia.Id, name: "Yemen", formalName: "Republic of Yemen", nativeName: "اليَمَن", capital: "Sanaa", isoTreeCode: "YEM", isoTwoCode: "YE", ccnTreeCode: "NULL", phoneCode: "967", currency: "YER", population: 0, emoji: "🇾🇪", emojiU: "U+1F1FE U+1F1EA", remarks: "Republic of Yemen");
            var Belarus = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Belarus", formalName: "Republic of Belarus", nativeName: "Белару́сь", capital: "Minsk", isoTreeCode: "BLR", isoTwoCode: "BY", ccnTreeCode: "NULL", phoneCode: "375", currency: "BYN", population: 0, emoji: "🇧🇾", emojiU: "U+1F1E7 U+1F1FE", remarks: "Republic of Belarus");
            var Bulgaria = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Bulgaria", formalName: "Republic of Bulgaria", nativeName: "България", capital: "Sofia", isoTreeCode: "BGR", isoTwoCode: "BG", ccnTreeCode: "NULL", phoneCode: "359", currency: "BGN", population: 0, emoji: "🇧🇬", emojiU: "U+1F1E7 U+1F1EC", remarks: "Republic of Bulgaria");
            var CzechRepublic = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Czech Republic", formalName: "Czech Republic", nativeName: "Česká republika", capital: "Prague", isoTreeCode: "CZE", isoTwoCode: "CZ", ccnTreeCode: "NULL", phoneCode: "420", currency: "CZK", population: 0, emoji: "🇨🇿", emojiU: "U+1F1E8 U+1F1FF", remarks: "Czech Republic");
            var Hungary = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Hungary", formalName: "Republic of Hungary", nativeName: "Magyarország", capital: "Budapest", isoTreeCode: "HUN", isoTwoCode: "HU", ccnTreeCode: "NULL", phoneCode: "36", currency: "HUF", population: 0, emoji: "🇭🇺", emojiU: "U+1F1ED U+1F1FA", remarks: "Republic of Hungary");
            var Kosovo = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Kosovo", formalName: "Republic of Kosovo", nativeName: "Republika e Kosovës", capital: "Pristina", isoTreeCode: "XKX", isoTwoCode: "XK", ccnTreeCode: "NULL", phoneCode: "383", currency: "EUR", population: 0, emoji: "🇽🇰", emojiU: "U+1F1FD U+1F1F0", remarks: "Republic of Kosovo");
            var Moldova = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Moldova", formalName: "Republic of Moldova", nativeName: "Moldova", capital: "Chisinau", isoTreeCode: "MDA", isoTwoCode: "MD", ccnTreeCode: "NULL", phoneCode: "373", currency: "MDL", population: 0, emoji: "🇲🇩", emojiU: "U+1F1F2 U+1F1E9", remarks: "Republic of Moldova");
            var Poland = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Poland", formalName: "Republic of Poland", nativeName: "Polska", capital: "Warsaw", isoTreeCode: "POL", isoTwoCode: "PL", ccnTreeCode: "NULL", phoneCode: "48", currency: "PLN", population: 0, emoji: "🇵🇱", emojiU: "U+1F1F5 U+1F1F1", remarks: "Republic of Poland");
            var Romania = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Romania", formalName: "Romania", nativeName: "România", capital: "Bucharest", isoTreeCode: "ROU", isoTwoCode: "RO", ccnTreeCode: "NULL", phoneCode: "40", currency: "RON", population: 0, emoji: "🇷🇴", emojiU: "U+1F1F7 U+1F1F4", remarks: "Romania");
            var Russia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Russia", formalName: "Russian Federation", nativeName: "Россия", capital: "Moscow", isoTreeCode: "RUS", isoTwoCode: "RU", ccnTreeCode: "NULL", phoneCode: "7", currency: "RUB", population: 0, emoji: "🇷🇺", emojiU: "U+1F1F7 U+1F1FA", remarks: "Russian Federation");
            var Slovakia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Slovakia", formalName: "Slovak Republic", nativeName: "Slovensko", capital: "Bratislava", isoTreeCode: "SVK", isoTwoCode: "SK", ccnTreeCode: "NULL", phoneCode: "421", currency: "EUR", population: 0, emoji: "🇸🇰", emojiU: "U+1F1F8 U+1F1F0", remarks: "Slovak Republic");
            var Ukraine = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: EasternEurope.Id, name: "Ukraine", formalName: "Ukraine", nativeName: "Україна", capital: "Kiev", isoTreeCode: "UKR", isoTwoCode: "UA", ccnTreeCode: "NULL", phoneCode: "380", currency: "UAH", population: 0, emoji: "🇺🇦", emojiU: "U+1F1FA U+1F1E6", remarks: "Ukraine");
            var AlandIslands = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Aland Islands", formalName: "Aland Islands", nativeName: "Åland", capital: "Mariehamn", isoTreeCode: "ALA", isoTwoCode: "AX", ccnTreeCode: "NULL", phoneCode: "340", currency: "EUR", population: 0, emoji: "🇦🇽", emojiU: "U+1F1E6 U+1F1FD", remarks: "Aland Islands");
            var Denmark = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Denmark", formalName: "Kingdom of Denmark", nativeName: "Danmark", capital: "Copenhagen", isoTreeCode: "DNK", isoTwoCode: "DK", ccnTreeCode: "NULL", phoneCode: "45", currency: "DKK", population: 0, emoji: "🇩🇰", emojiU: "U+1F1E9 U+1F1F0", remarks: "Kingdom of Denmark");
            var Estonia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Estonia", formalName: "Republic of Estonia", nativeName: "Eesti", capital: "Tallinn", isoTreeCode: "EST", isoTwoCode: "EE", ccnTreeCode: "NULL", phoneCode: "372", currency: "EUR", population: 0, emoji: "🇪🇪", emojiU: "U+1F1EA U+1F1EA", remarks: "Republic of Estonia");
            var FaroeIslands = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Faroe Islands", formalName: "Faroe Islands", nativeName: "Føroyar", capital: "Torshavn", isoTreeCode: "FRO", isoTwoCode: "FO", ccnTreeCode: "NULL", phoneCode: "298", currency: "DKK", population: 0, emoji: "🇫🇴", emojiU: "U+1F1EB U+1F1F4", remarks: "Faroe Islands");
            var Finland = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Finland", formalName: "Republic of Finland", nativeName: "Suomi", capital: "Helsinki", isoTreeCode: "FIN", isoTwoCode: "FI", ccnTreeCode: "NULL", phoneCode: "358", currency: "EUR", population: 0, emoji: "🇫🇮", emojiU: "U+1F1EB U+1F1EE", remarks: "Republic of Finland");
            var GuernseyandAlderney = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Guernsey and Alderney", formalName: "Guernsey and Alderney", nativeName: "Guernsey", capital: "St Peter Port", isoTreeCode: "GGY", isoTwoCode: "GG", ccnTreeCode: "NULL", phoneCode: "44-1481", currency: "GBP", population: 0, emoji: "🇬🇬", emojiU: "U+1F1EC U+1F1EC", remarks: "Guernsey and Alderney");
            var Iceland = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Iceland", formalName: "Republic of Iceland", nativeName: "Ísland", capital: "Reykjavik", isoTreeCode: "ISL", isoTwoCode: "IS", ccnTreeCode: "NULL", phoneCode: "354", currency: "ISK", population: 0, emoji: "🇮🇸", emojiU: "U+1F1EE U+1F1F8", remarks: "Republic of Iceland");
            var Ireland = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Ireland", formalName: "Ireland", nativeName: "Éire", capital: "Dublin", isoTreeCode: "IRL", isoTwoCode: "IE", ccnTreeCode: "NULL", phoneCode: "353", currency: "EUR", population: 0, emoji: "🇮🇪", emojiU: "U+1F1EE U+1F1EA", remarks: "Ireland");
            var Jersey = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Jersey", formalName: "Jersey", nativeName: "Jersey", capital: "Saint Helier", isoTreeCode: "JEY", isoTwoCode: "JE", ccnTreeCode: "NULL", phoneCode: "44-1534", currency: "GBP", population: 0, emoji: "🇯🇪", emojiU: "U+1F1EF U+1F1EA", remarks: "Jersey");
            var Latvia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Latvia", formalName: "Republic of Latvia", nativeName: "Latvija", capital: "Riga", isoTreeCode: "LVA", isoTwoCode: "LV", ccnTreeCode: "NULL", phoneCode: "371", currency: "EUR", population: 0, emoji: "🇱🇻", emojiU: "U+1F1F1 U+1F1FB", remarks: "Republic of Latvia");
            var Lithuania = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Lithuania", formalName: "Republic of Lithuania", nativeName: "Lietuva", capital: "Vilnius", isoTreeCode: "LTU", isoTwoCode: "LT", ccnTreeCode: "NULL", phoneCode: "370", currency: "EUR", population: 0, emoji: "🇱🇹", emojiU: "U+1F1F1 U+1F1F9", remarks: "Republic of Lithuania");
            var ManIsleof = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Man Isle of", formalName: "Man (Isle of)", nativeName: "Isle of Man", capital: "Douglas, Isle of Man", isoTreeCode: "IMN", isoTwoCode: "IM", ccnTreeCode: "NULL", phoneCode: "44-1624", currency: "GBP", population: 0, emoji: "🇮🇲", emojiU: "U+1F1EE U+1F1F2", remarks: "Man (Isle of)");
            var Norway = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Norway", formalName: "Kingdom of Norway", nativeName: "Norge", capital: "Oslo", isoTreeCode: "NOR", isoTwoCode: "NO", ccnTreeCode: "NULL", phoneCode: "47", currency: "NOK", population: 0, emoji: "🇳🇴", emojiU: "U+1F1F3 U+1F1F4", remarks: "Kingdom of Norway");
            var Sweden = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "Sweden", formalName: "Kingdom of Sweden", nativeName: "Sverige", capital: "Stockholm", isoTreeCode: "SWE", isoTwoCode: "SE", ccnTreeCode: "NULL", phoneCode: "46", currency: "SEK", population: 0, emoji: "🇸🇪", emojiU: "U+1F1F8 U+1F1EA", remarks: "Kingdom of Sweden");
            var UnitedKingdom = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: NorthernEurope.Id, name: "United Kingdom", formalName: "United Kingdom of Great Britain and Northern Ireland", nativeName: "United Kingdom", capital: "London", isoTreeCode: "GBR", isoTwoCode: "GB", ccnTreeCode: "NULL", phoneCode: "44", currency: "GBP", population: 0, emoji: "🇬🇧", emojiU: "U+1F1EC U+1F1E7", remarks: "United Kingdom of Great Britain and Northern Ireland");
            var Albania = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Albania", formalName: "Republic of Albania", nativeName: "Shqipëria", capital: "Tirana", isoTreeCode: "ALB", isoTwoCode: "AL", ccnTreeCode: "NULL", phoneCode: "355", currency: "ALL", population: 0, emoji: "🇦🇱", emojiU: "U+1F1E6 U+1F1F1", remarks: "Republic of Albania");
            var Andorra = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Andorra", formalName: "Principality of Andorra", nativeName: "Andorra", capital: "Andorra la Vella", isoTreeCode: "AND", isoTwoCode: "AD", ccnTreeCode: "NULL", phoneCode: "376", currency: "EUR", population: 0, emoji: "🇦🇩", emojiU: "U+1F1E6 U+1F1E9", remarks: "Principality of Andorra");
            var BosniaandHerzegovina = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Bosnia and Herzegovina", formalName: "Bosnia and Herzegovina", nativeName: "Bosna i Hercegovina", capital: "Sarajevo", isoTreeCode: "BIH", isoTwoCode: "BA", ccnTreeCode: "NULL", phoneCode: "387", currency: "BAM", population: 0, emoji: "🇧🇦", emojiU: "U+1F1E7 U+1F1E6", remarks: "Bosnia and Herzegovina");
            var CroatiaHrvatska = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Croatia Hrvatska", formalName: "Republic of Croatia", nativeName: "Hrvatska", capital: "Zagreb", isoTreeCode: "HRV", isoTwoCode: "HR", ccnTreeCode: "NULL", phoneCode: "385", currency: "HRK", population: 0, emoji: "🇭🇷", emojiU: "U+1F1ED U+1F1F7", remarks: "Republic of Croatia");
            var Gibraltar = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Gibraltar", formalName: "Gibraltar", nativeName: "Gibraltar", capital: "Gibraltar", isoTreeCode: "GIB", isoTwoCode: "GI", ccnTreeCode: "NULL", phoneCode: "350", currency: "GIP", population: 0, emoji: "🇬🇮", emojiU: "U+1F1EC U+1F1EE", remarks: "Gibraltar");
            var Greece = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Greece", formalName: "Hellenic Republic", nativeName: "Ελλάδα", capital: "Athens", isoTreeCode: "GRC", isoTwoCode: "GR", ccnTreeCode: "NULL", phoneCode: "30", currency: "EUR", population: 0, emoji: "🇬🇷", emojiU: "U+1F1EC U+1F1F7", remarks: "Hellenic Republic");
            var Italy = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Italy", formalName: "Italian Republic", nativeName: "Italia", capital: "Rome", isoTreeCode: "ITA", isoTwoCode: "IT", ccnTreeCode: "NULL", phoneCode: "39", currency: "EUR", population: 0, emoji: "🇮🇹", emojiU: "U+1F1EE U+1F1F9", remarks: "Italian Republic");
            var Macedonia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Macedonia", formalName: "Former Yugoslav Republic of Macedonia", nativeName: "Северна Македонија", capital: "Skopje", isoTreeCode: "MKD", isoTwoCode: "MK", ccnTreeCode: "NULL", phoneCode: "389", currency: "MKD", population: 0, emoji: "🇲🇰", emojiU: "U+1F1F2 U+1F1F0", remarks: "Former Yugoslav Republic of Macedonia");
            var Malta = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Malta", formalName: "Republic of Malta", nativeName: "Malta", capital: "Valletta", isoTreeCode: "MLT", isoTwoCode: "MT", ccnTreeCode: "NULL", phoneCode: "356", currency: "EUR", population: 0, emoji: "🇲🇹", emojiU: "U+1F1F2 U+1F1F9", remarks: "Republic of Malta");
            var Montenegro = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Montenegro", formalName: "Montenegro", nativeName: "Црна Гора", capital: "Podgorica", isoTreeCode: "MNE", isoTwoCode: "ME", ccnTreeCode: "NULL", phoneCode: "382", currency: "EUR", population: 0, emoji: "🇲🇪", emojiU: "U+1F1F2 U+1F1EA", remarks: "Montenegro");
            var Portugal = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Portugal", formalName: "Portuguese Republic", nativeName: "Portugal", capital: "Lisbon", isoTreeCode: "PRT", isoTwoCode: "PT", ccnTreeCode: "NULL", phoneCode: "351", currency: "EUR", population: 0, emoji: "🇵🇹", emojiU: "U+1F1F5 U+1F1F9", remarks: "Portuguese Republic");
            var SanMarino = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "San Marino", formalName: "Republic of San Marino", nativeName: "San Marino", capital: "San Marino", isoTreeCode: "SMR", isoTwoCode: "SM", ccnTreeCode: "NULL", phoneCode: "378", currency: "EUR", population: 0, emoji: "🇸🇲", emojiU: "U+1F1F8 U+1F1F2", remarks: "Republic of San Marino");
            var Serbia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Serbia", formalName: "Republic of Serbia", nativeName: "Србија", capital: "Belgrade", isoTreeCode: "SRB", isoTwoCode: "RS", ccnTreeCode: "NULL", phoneCode: "381", currency: "RSD", population: 0, emoji: "🇷🇸", emojiU: "U+1F1F7 U+1F1F8", remarks: "Republic of Serbia");
            var Slovenia = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Slovenia", formalName: "Republic of Slovenia", nativeName: "Slovenija", capital: "Ljubljana", isoTreeCode: "SVN", isoTwoCode: "SI", ccnTreeCode: "NULL", phoneCode: "386", currency: "EUR", population: 0, emoji: "🇸🇮", emojiU: "U+1F1F8 U+1F1EE", remarks: "Republic of Slovenia");
            var Spain = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Spain", formalName: "Kingdom of Spain", nativeName: "España", capital: "Madrid", isoTreeCode: "ESP", isoTwoCode: "ES", ccnTreeCode: "NULL", phoneCode: "34", currency: "EUR", population: 0, emoji: "🇪🇸", emojiU: "U+1F1EA U+1F1F8", remarks: "Kingdom of Spain");
            var VaticanCityStateHolySee = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: SouthernEurope.Id, name: "Vatican City State Holy See", formalName: "Vatican City State (Holy See)", nativeName: "Vaticano", capital: "Vatican City", isoTreeCode: "VAT", isoTwoCode: "VA", ccnTreeCode: "NULL", phoneCode: "379", currency: "EUR", population: 0, emoji: "🇻🇦", emojiU: "U+1F1FB U+1F1E6", remarks: "Vatican City State (Holy See)");
            var Austria = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Austria", formalName: "Republic of Austria", nativeName: "Österreich", capital: "Vienna", isoTreeCode: "AUT", isoTwoCode: "AT", ccnTreeCode: "NULL", phoneCode: "43", currency: "EUR", population: 0, emoji: "🇦🇹", emojiU: "U+1F1E6 U+1F1F9", remarks: "Republic of Austria");
            var Belgium = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Belgium", formalName: "Kingdom of Belgium", nativeName: "België", capital: "Brussels", isoTreeCode: "BEL", isoTwoCode: "BE", ccnTreeCode: "NULL", phoneCode: "32", currency: "EUR", population: 0, emoji: "🇧🇪", emojiU: "U+1F1E7 U+1F1EA", remarks: "Kingdom of Belgium");
            var France = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "France", formalName: "French Republic", nativeName: "France", capital: "Paris", isoTreeCode: "FRA", isoTwoCode: "FR", ccnTreeCode: "NULL", phoneCode: "33", currency: "EUR", population: 0, emoji: "🇫🇷", emojiU: "U+1F1EB U+1F1F7", remarks: "French Republic");
            var Germany = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Germany", formalName: "Federal Republic of Germany", nativeName: "Deutschland", capital: "Berlin", isoTreeCode: "DEU", isoTwoCode: "DE", ccnTreeCode: "NULL", phoneCode: "49", currency: "EUR", population: 0, emoji: "🇩🇪", emojiU: "U+1F1E9 U+1F1EA", remarks: "Federal Republic of Germany");
            var Liechtenstein = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Liechtenstein", formalName: "Principality of Liechtenstein", nativeName: "Liechtenstein", capital: "Vaduz", isoTreeCode: "LIE", isoTwoCode: "LI", ccnTreeCode: "NULL", phoneCode: "423", currency: "CHF", population: 0, emoji: "🇱🇮", emojiU: "U+1F1F1 U+1F1EE", remarks: "Principality of Liechtenstein");
            var Luxembourg = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Luxembourg", formalName: "Grand Duchy of Luxembourg", nativeName: "Luxembourg", capital: "Luxembourg", isoTreeCode: "LUX", isoTwoCode: "LU", ccnTreeCode: "NULL", phoneCode: "352", currency: "EUR", population: 0, emoji: "🇱🇺", emojiU: "U+1F1F1 U+1F1FA", remarks: "Grand Duchy of Luxembourg");
            var Monaco = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Monaco", formalName: "Principality of Monaco", nativeName: "Monaco", capital: "Monaco", isoTreeCode: "MCO", isoTwoCode: "MC", ccnTreeCode: "NULL", phoneCode: "377", currency: "EUR", population: 0, emoji: "🇲🇨", emojiU: "U+1F1F2 U+1F1E8", remarks: "Principality of Monaco");
            var NetherlandsThe = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Netherlands The", formalName: "Kingdom of the Netherlands", nativeName: "Nederland", capital: "Amsterdam", isoTreeCode: "NLD", isoTwoCode: "NL", ccnTreeCode: "NULL", phoneCode: "31", currency: "EUR", population: 0, emoji: "🇳🇱", emojiU: "U+1F1F3 U+1F1F1", remarks: "Kingdom of the Netherlands");
            var Switzerland = new Country(id: _GuidGenerator.Create(), continentID: Europe.Id, subcontinentId: WesternEurope.Id, name: "Switzerland", formalName: "Swiss Confederation", nativeName: "Schweiz", capital: "Berne", isoTreeCode: "CHE", isoTwoCode: "CH", ccnTreeCode: "NULL", phoneCode: "41", currency: "CHF", population: 0, emoji: "🇨🇭", emojiU: "U+1F1E8 U+1F1ED", remarks: "Swiss Confederation");
            var Australia = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: AustraliaAndNewZealand.Id, name: "Australia", formalName: "Commonwealth of Australia", nativeName: "Australia", capital: "Canberra", isoTreeCode: "AUS", isoTwoCode: "AU", ccnTreeCode: "NULL", phoneCode: "61", currency: "AUD", population: 0, emoji: "🇦🇺", emojiU: "U+1F1E6 U+1F1FA", remarks: "Commonwealth of Australia");
            var NewZealand = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: AustraliaAndNewZealand.Id, name: "New Zealand", formalName: "New Zealand", nativeName: "New Zealand", capital: "Wellington", isoTreeCode: "NZL", isoTwoCode: "NZ", ccnTreeCode: "NULL", phoneCode: "64", currency: "NZD", population: 0, emoji: "🇳🇿", emojiU: "U+1F1F3 U+1F1FF", remarks: "New Zealand");
            var AmericanSamoa = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "American Samoa", formalName: "American Samoa", nativeName: "American Samoa", capital: "Pago Pago", isoTreeCode: "ASM", isoTwoCode: "AS", ccnTreeCode: "NULL", phoneCode: "1-684", currency: "USD", population: 0, emoji: "🇦🇸", emojiU: "U+1F1E6 U+1F1F8", remarks: "American Samoa");
            var CookIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Cook Islands", formalName: "Cook Islands", nativeName: "Cook Islands", capital: "Avarua", isoTreeCode: "COK", isoTwoCode: "CK", ccnTreeCode: "NULL", phoneCode: "682", currency: "NZD", population: 0, emoji: "🇨🇰", emojiU: "U+1F1E8 U+1F1F0", remarks: "Cook Islands");
            var FijiIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Fiji Islands", formalName: "Republic of Fiji", nativeName: "Fiji", capital: "Suva", isoTreeCode: "FJI", isoTwoCode: "FJ", ccnTreeCode: "NULL", phoneCode: "679", currency: "FJD", population: 0, emoji: "🇫🇯", emojiU: "U+1F1EB U+1F1EF", remarks: "Republic of Fiji");
            var FrenchPolynesia = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "French Polynesia", formalName: "French Polynesia", nativeName: "Polynésie française", capital: "Papeete", isoTreeCode: "PYF", isoTwoCode: "PF", ccnTreeCode: "NULL", phoneCode: "689", currency: "XPF", population: 0, emoji: "🇵🇫", emojiU: "U+1F1F5 U+1F1EB", remarks: "French Polynesia");
            var Guam = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Guam", formalName: "Guam", nativeName: "Guam", capital: "Hagatna", isoTreeCode: "GUM", isoTwoCode: "GU", ccnTreeCode: "NULL", phoneCode: "1-671", currency: "USD", population: 0, emoji: "🇬🇺", emojiU: "U+1F1EC U+1F1FA", remarks: "Guam");
            var NewCaledonia = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "New Caledonia", formalName: "New Caledonia", nativeName: "Nouvelle-Calédonie", capital: "Noumea", isoTreeCode: "NCL", isoTwoCode: "NC", ccnTreeCode: "NULL", phoneCode: "687", currency: "XPF", population: 0, emoji: "🇳🇨", emojiU: "U+1F1F3 U+1F1E8", remarks: "New Caledonia");
            var Niue = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Niue", formalName: "Niue", nativeName: "Niuē", capital: "Alofi", isoTreeCode: "NIU", isoTwoCode: "NU", ccnTreeCode: "NULL", phoneCode: "683", currency: "NZD", population: 0, emoji: "🇳🇺", emojiU: "U+1F1F3 U+1F1FA", remarks: "Niue");
            var NorfolkIsland = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Norfolk Island", formalName: "Norfolk Island", nativeName: "Norfolk Island", capital: "Kingston", isoTreeCode: "NFK", isoTwoCode: "NF", ccnTreeCode: "NULL", phoneCode: "672", currency: "AUD", population: 0, emoji: "🇳🇫", emojiU: "U+1F1F3 U+1F1EB", remarks: "Norfolk Island");
            var NorthernMarianaIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Northern Mariana Islands", formalName: "Northern Mariana Islands", nativeName: "Northern Mariana Islands", capital: "Saipan", isoTreeCode: "MNP", isoTwoCode: "MP", ccnTreeCode: "NULL", phoneCode: "1-670", currency: "USD", population: 0, emoji: "🇲🇵", emojiU: "U+1F1F2 U+1F1F5", remarks: "Northern Mariana Islands");
            var PapuanewGuinea = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Papua new Guinea", formalName: "Independent State of Papua New Guinea", nativeName: "Papua Niugini", capital: "Port Moresby", isoTreeCode: "PNG", isoTwoCode: "PG", ccnTreeCode: "NULL", phoneCode: "675", currency: "PGK", population: 0, emoji: "🇵🇬", emojiU: "U+1F1F5 U+1F1EC", remarks: "Independent State of Papua New Guinea");
            var PitcairnIsland = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Pitcairn Island", formalName: "Pitcairn Island", nativeName: "Pitcairn Islands", capital: "Adamstown", isoTreeCode: "PCN", isoTwoCode: "PN", ccnTreeCode: "NULL", phoneCode: "870", currency: "NZD", population: 0, emoji: "🇵🇳", emojiU: "U+1F1F5 U+1F1F3", remarks: "Pitcairn Island");
            var SolomonIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Solomon Islands", formalName: "Solomon Is.", nativeName: "Solomon Islands", capital: "Honiara", isoTreeCode: "SLB", isoTwoCode: "SB", ccnTreeCode: "NULL", phoneCode: "677", currency: "SBD", population: 0, emoji: "🇸🇧", emojiU: "U+1F1F8 U+1F1E7", remarks: "Solomon Is.");
            var Tuvalu = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Tuvalu", formalName: "Tuvalu", nativeName: "Tuvalu", capital: "Funafuti", isoTreeCode: "TUV", isoTwoCode: "TV", ccnTreeCode: "NULL", phoneCode: "688", currency: "AUD", population: 0, emoji: "🇹🇻", emojiU: "U+1F1F9 U+1F1FB", remarks: "Tuvalu");
            var UnitedStatesMinorOutlyingIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "United States Minor Outlying Islands", formalName: "United States Minor Outlying Islands", nativeName: "United States Minor Outlying Islands", capital: "", isoTreeCode: "UMI", isoTwoCode: "UM", ccnTreeCode: "NULL", phoneCode: "1", currency: "USD", population: 0, emoji: "🇺🇲", emojiU: "U+1F1FA U+1F1F2", remarks: "United States Minor Outlying Islands");
            var Vanuatu = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Vanuatu", formalName: "Republic of Vanuatu", nativeName: "Vanuatu", capital: "Port Vila", isoTreeCode: "VUT", isoTwoCode: "VU", ccnTreeCode: "NULL", phoneCode: "678", currency: "VUV", population: 0, emoji: "🇻🇺", emojiU: "U+1F1FB U+1F1FA", remarks: "Republic of Vanuatu");
            var WallisAndFutunaIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MelanesiaSubcontinent.Id, name: "Wallis And Futuna Islands", formalName: "Wallis And Futuna Islands", nativeName: "Wallis et Futuna", capital: "Mata Utu", isoTreeCode: "WLF", isoTwoCode: "WF", ccnTreeCode: "NULL", phoneCode: "681", currency: "XPF", population: 0, emoji: "🇼🇫", emojiU: "U+1F1FC U+1F1EB", remarks: "Wallis And Futuna Islands");
            var Kiribati = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MicronesiaSubcontinent.Id, name: "Kiribati", formalName: "Republic of Kiribati", nativeName: "Kiribati", capital: "Tarawa", isoTreeCode: "KIR", isoTwoCode: "KI", ccnTreeCode: "NULL", phoneCode: "686", currency: "AUD", population: 0, emoji: "🇰🇮", emojiU: "U+1F1F0 U+1F1EE", remarks: "Republic of Kiribati");
            var MarshallIslands = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MicronesiaSubcontinent.Id, name: "Marshall Islands", formalName: "Republic of the Marshall Islands", nativeName: "M̧ajeļ", capital: "Majuro", isoTreeCode: "MHL", isoTwoCode: "MH", ccnTreeCode: "NULL", phoneCode: "692", currency: "USD", population: 0, emoji: "🇲🇭", emojiU: "U+1F1F2 U+1F1ED", remarks: "Republic of the Marshall Islands");
            var Micronesia = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MicronesiaSubcontinent.Id, name: "Micronesia", formalName: "Federated States of Micronesia", nativeName: "Micronesia", capital: "Palikir", isoTreeCode: "FSM", isoTwoCode: "FM", ccnTreeCode: "NULL", phoneCode: "691", currency: "USD", population: 0, emoji: "🇫🇲", emojiU: "U+1F1EB U+1F1F2", remarks: "Federated States of Micronesia");
            var Nauru = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MicronesiaSubcontinent.Id, name: "Nauru", formalName: "Republic of Nauru", nativeName: "Nauru", capital: "Yaren", isoTreeCode: "NRU", isoTwoCode: "NR", ccnTreeCode: "NULL", phoneCode: "674", currency: "AUD", population: 0, emoji: "🇳🇷", emojiU: "U+1F1F3 U+1F1F7", remarks: "Republic of Nauru");
            var Palau = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: MicronesiaSubcontinent.Id, name: "Palau", formalName: "Republic of Palau", nativeName: "Palau", capital: "Melekeok", isoTreeCode: "PLW", isoTwoCode: "PW", ccnTreeCode: "NULL", phoneCode: "680", currency: "USD", population: 0, emoji: "🇵🇼", emojiU: "U+1F1F5 U+1F1FC", remarks: "Republic of Palau");
            var Samoa = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: PolynesiaSubcontinent.Id, name: "Samoa", formalName: "Independent State of Samoa", nativeName: "Samoa", capital: "Apia", isoTreeCode: "WSM", isoTwoCode: "WS", ccnTreeCode: "NULL", phoneCode: "685", currency: "WST", population: 0, emoji: "🇼🇸", emojiU: "U+1F1FC U+1F1F8", remarks: "Independent State of Samoa");
            var Tonga = new Country(id: _GuidGenerator.Create(), continentID: Oceania.Id, subcontinentId: PolynesiaSubcontinent.Id, name: "Tonga", formalName: "Kingdom of Tonga", nativeName: "Tonga", capital: "Nuku'alofa", isoTreeCode: "TON", isoTwoCode: "TO", ccnTreeCode: "NULL", phoneCode: "676", currency: "TOP", population: 0, emoji: "🇹🇴", emojiU: "U+1F1F9 U+1F1F4", remarks: "Kingdom of Tonga");

            #endregion

            #region Insert Date to Database

            using (_CurrentTenant.Change(context?.TenantId))
            {
                if (await _continentRepository.GetCountAsync() <= 0)
                {
                    await _continentRepository.InsertAsync(Africa);
                    await _continentRepository.InsertAsync(new Continent(
                id: _GuidGenerator.Create(),
                name: "Americas",
                population: 1029000000,
                remarks: "American continente"
            ));
                    await _continentRepository.InsertAsync(Asia);
                    await _continentRepository.InsertAsync(Europe);
                    await _continentRepository.InsertAsync(Oceania);
                    await _continentRepository.InsertAsync(Antartica);
                }

                if (await _subcontinentRepository.GetCountAsync() <= 0)
                {
                    await _subcontinentRepository.InsertAsync(EasternAfrica);
                    await _subcontinentRepository.InsertAsync(MiddleAfrica);
                    await _subcontinentRepository.InsertAsync(NorthernAfrica);
                    await _subcontinentRepository.InsertAsync(SouthernAfrica);
                    await _subcontinentRepository.InsertAsync(WesternAfrica);
                    await _subcontinentRepository.InsertAsync(Caribbean);
                    await _subcontinentRepository.InsertAsync(CentralAmerica);
                    await _subcontinentRepository.InsertAsync(NorthernAmerica);
                    await _subcontinentRepository.InsertAsync(SouthAmerica);
                    await _subcontinentRepository.InsertAsync(CentralAsia);
                    await _subcontinentRepository.InsertAsync(EasternAsia);
                    await _subcontinentRepository.InsertAsync(SouthEasternAsia);
                    await _subcontinentRepository.InsertAsync(SouthernAsia);
                    await _subcontinentRepository.InsertAsync(WesternAsia);
                    await _subcontinentRepository.InsertAsync(EasternEurope);
                    await _subcontinentRepository.InsertAsync(NorthernEurope);
                    await _subcontinentRepository.InsertAsync(SouthernEurope);
                    await _subcontinentRepository.InsertAsync(WesternEurope);
                    await _subcontinentRepository.InsertAsync(AustraliaAndNewZealand);
                    await _subcontinentRepository.InsertAsync(MelanesiaSubcontinent);
                    await _subcontinentRepository.InsertAsync(MicronesiaSubcontinent);
                    await _subcontinentRepository.InsertAsync(PolynesiaSubcontinent);
                    await _subcontinentRepository.InsertAsync(AntarticaSubcontinent);
                }

                if (await _countryRepository.GetCountAsync() <= 0)
                {
                    await _countryRepository.InsertAsync(Burundi);
                    await _countryRepository.InsertAsync(Comoros);
                    await _countryRepository.InsertAsync(Djibouti);
                    await _countryRepository.InsertAsync(Eritrea);
                    await _countryRepository.InsertAsync(Ethiopia);
                    await _countryRepository.InsertAsync(Kenya);
                    await _countryRepository.InsertAsync(Madagascar);
                    await _countryRepository.InsertAsync(Malawi);
                    await _countryRepository.InsertAsync(Mauritius);
                    await _countryRepository.InsertAsync(Mozambique);
                    await _countryRepository.InsertAsync(Rwanda);
                    await _countryRepository.InsertAsync(Seychelles);
                    await _countryRepository.InsertAsync(Somalia);
                    await _countryRepository.InsertAsync(Tanzania);
                    await _countryRepository.InsertAsync(Uganda);
                    await _countryRepository.InsertAsync(Zambia);
                    await _countryRepository.InsertAsync(Zimbabwe);
                    await _countryRepository.InsertAsync(Angola);
                    await _countryRepository.InsertAsync(Cameroon);
                    await _countryRepository.InsertAsync(CentralAfricanRepublic);
                    await _countryRepository.InsertAsync(Chad);
                    await _countryRepository.InsertAsync(CongoRepublicofthe);
                    await _countryRepository.InsertAsync(CongoTheDemocraticRepublicOfThe);
                    await _countryRepository.InsertAsync(EquatorialGuinea);
                    await _countryRepository.InsertAsync(Gabon);
                    await _countryRepository.InsertAsync(SaoTomeandPrincipe);
                    await _countryRepository.InsertAsync(AkrotiriSovereignBaseArea);
                    await _countryRepository.InsertAsync(Algeria);
                    await _countryRepository.InsertAsync(AshmoreandCartierIslands);
                    await _countryRepository.InsertAsync(BaykonurCosmodrome);
                    await _countryRepository.InsertAsync(CaboVerde);
                    await _countryRepository.InsertAsync(CoralSeaIslands);
                    await _countryRepository.InsertAsync(CyprusNoMansArea);
                    await _countryRepository.InsertAsync(DhekeliaSovereignBaseArea);
                    await _countryRepository.InsertAsync(Egypt);
                    await _countryRepository.InsertAsync(Libya);
                    await _countryRepository.InsertAsync(Morocco);
                    await _countryRepository.InsertAsync(NorthernCyprus);
                    await _countryRepository.InsertAsync(ScarboroughReef);
                    await _countryRepository.InsertAsync(Somaliland);
                    await _countryRepository.InsertAsync(SouthSudan);
                    await _countryRepository.InsertAsync(SpratlyIslands);
                    await _countryRepository.InsertAsync(Sudan);
                    await _countryRepository.InsertAsync(Tunisia);
                    await _countryRepository.InsertAsync(WesternSahara);
                    await _countryRepository.InsertAsync(Botswana);
                    await _countryRepository.InsertAsync(Lesotho);
                    await _countryRepository.InsertAsync(Namibia);
                    await _countryRepository.InsertAsync(SouthAfrica);
                    await _countryRepository.InsertAsync(Swaziland);
                    await _countryRepository.InsertAsync(Benin);
                    await _countryRepository.InsertAsync(BurkinaFaso);
                    await _countryRepository.InsertAsync(CoteDIvoire);
                    await _countryRepository.InsertAsync(GambiaThe);
                    await _countryRepository.InsertAsync(Ghana);
                    await _countryRepository.InsertAsync(Guinea);
                    await _countryRepository.InsertAsync(GuineaBissau);
                    await _countryRepository.InsertAsync(Liberia);
                    await _countryRepository.InsertAsync(Mali);
                    await _countryRepository.InsertAsync(Mauritania);
                    await _countryRepository.InsertAsync(Niger);
                    await _countryRepository.InsertAsync(Nigeria);
                    await _countryRepository.InsertAsync(Senegal);
                    await _countryRepository.InsertAsync(SierraLeone);
                    await _countryRepository.InsertAsync(Togo);
                    await _countryRepository.InsertAsync(FrenchSouthernTerritories);
                    await _countryRepository.InsertAsync(HeardandMcDonaldIslands);
                    await _countryRepository.InsertAsync(NetherlandsAntilles);
                    await _countryRepository.InsertAsync(SouthGeorgia);
                    await _countryRepository.InsertAsync(Anguilla);
                    await _countryRepository.InsertAsync(AntiguaAndBarbuda);
                    await _countryRepository.InsertAsync(Aruba);
                    await _countryRepository.InsertAsync(BahamasThe);
                    await _countryRepository.InsertAsync(Barbados);
                    await _countryRepository.InsertAsync(Bermuda);
                    await _countryRepository.InsertAsync(BouvetIsland);
                    await _countryRepository.InsertAsync(CaymanIslands);
                    await _countryRepository.InsertAsync(CocosKeelingIslands);
                    await _countryRepository.InsertAsync(Cuba);
                    await _countryRepository.InsertAsync(Curaçao);
                    await _countryRepository.InsertAsync(Dominica);
                    await _countryRepository.InsertAsync(DominicanRepublic);
                    await _countryRepository.InsertAsync(FalklandIslands);
                    await _countryRepository.InsertAsync(FrenchGuiana);
                    await _countryRepository.InsertAsync(Greenland);
                    await _countryRepository.InsertAsync(Grenada);
                    await _countryRepository.InsertAsync(Guadeloupe);
                    await _countryRepository.InsertAsync(Haiti);
                    await _countryRepository.InsertAsync(Jamaica);
                    await _countryRepository.InsertAsync(Martinique);
                    await _countryRepository.InsertAsync(Mayotte);
                    await _countryRepository.InsertAsync(Montserrat);
                    await _countryRepository.InsertAsync(PuertoRico);
                    await _countryRepository.InsertAsync(Reunion);
                    await _countryRepository.InsertAsync(SaintBarthelemy);
                    await _countryRepository.InsertAsync(SaintHelena);
                    await _countryRepository.InsertAsync(SaintKittsAndNevis);
                    await _countryRepository.InsertAsync(SaintLucia);
                    await _countryRepository.InsertAsync(SaintMartin);
                    await _countryRepository.InsertAsync(SaintMartinFrenchpart);
                    await _countryRepository.InsertAsync(SaintPierreandMiquelon);
                    await _countryRepository.InsertAsync(SaintVincentAndTheGrenadines);
                    await _countryRepository.InsertAsync(SintMaarten);
                    await _countryRepository.InsertAsync(SvalbardAndJanMayenIslands);
                    await _countryRepository.InsertAsync(Tokelau);
                    await _countryRepository.InsertAsync(TrinidadAndTobago);
                    await _countryRepository.InsertAsync(TurksAndCaicosIslands);
                    await _countryRepository.InsertAsync(VirginIslandsBritish);
                    await _countryRepository.InsertAsync(VirginIslandsUS);
                    await _countryRepository.InsertAsync(Belize);
                    await _countryRepository.InsertAsync(CostaRica);
                    await _countryRepository.InsertAsync(ElSalvador);
                    await _countryRepository.InsertAsync(Guatemala);
                    await _countryRepository.InsertAsync(Honduras);
                    await _countryRepository.InsertAsync(Mexico);
                    await _countryRepository.InsertAsync(Nicaragua);
                    await _countryRepository.InsertAsync(Panama);
                    await _countryRepository.InsertAsync(Canada);
                    await _countryRepository.InsertAsync(UnitedStates);
                    await _countryRepository.InsertAsync(Argentina);
                    await _countryRepository.InsertAsync(Bolivia);
                    await _countryRepository.InsertAsync(Brazil);
                    await _countryRepository.InsertAsync(Chile);
                    await _countryRepository.InsertAsync(Colombia);
                    await _countryRepository.InsertAsync(Ecuador);
                    await _countryRepository.InsertAsync(Guyana);
                    await _countryRepository.InsertAsync(Paraguay);
                    await _countryRepository.InsertAsync(Peru);
                    await _countryRepository.InsertAsync(Suriname);
                    await _countryRepository.InsertAsync(Uruguay);
                    await _countryRepository.InsertAsync(Venezuela);
                    await _countryRepository.InsertAsync(Antarctica);
                    await _countryRepository.InsertAsync(Kazakhstan);
                    await _countryRepository.InsertAsync(Kyrgyzstan);
                    await _countryRepository.InsertAsync(Tajikistan);
                    await _countryRepository.InsertAsync(Turkmenistan);
                    await _countryRepository.InsertAsync(Uzbekistan);
                    await _countryRepository.InsertAsync(China);
                    await _countryRepository.InsertAsync(Japan);
                    await _countryRepository.InsertAsync(KoreaNorth);
                    await _countryRepository.InsertAsync(KoreaSouth);
                    await _countryRepository.InsertAsync(Mongolia);
                    await _countryRepository.InsertAsync(Brunei);
                    await _countryRepository.InsertAsync(Cambodia);
                    await _countryRepository.InsertAsync(Indonesia);
                    await _countryRepository.InsertAsync(Laos);
                    await _countryRepository.InsertAsync(Malaysia);
                    await _countryRepository.InsertAsync(Myanmar);
                    await _countryRepository.InsertAsync(Philippines);
                    await _countryRepository.InsertAsync(Singapore);
                    await _countryRepository.InsertAsync(Thailand);
                    await _countryRepository.InsertAsync(TimorLeste);
                    await _countryRepository.InsertAsync(Vietnam);
                    await _countryRepository.InsertAsync(Afghanistan);
                    await _countryRepository.InsertAsync(BajoNuevoBankPetrelIsland);
                    await _countryRepository.InsertAsync(Bangladesh);
                    await _countryRepository.InsertAsync(Bhutan);
                    await _countryRepository.InsertAsync(BritishIndianOceanTerritory);
                    await _countryRepository.InsertAsync(ChristmasIsland);
                    await _countryRepository.InsertAsync(HongKongSAR);
                    await _countryRepository.InsertAsync(India);
                    await _countryRepository.InsertAsync(IndianOceanTerritories);
                    await _countryRepository.InsertAsync(Iran);
                    await _countryRepository.InsertAsync(MacauSAR);
                    await _countryRepository.InsertAsync(Maldives);
                    await _countryRepository.InsertAsync(Nepal);
                    await _countryRepository.InsertAsync(Pakistan);
                    await _countryRepository.InsertAsync(Palestine);
                    await _countryRepository.InsertAsync(SerranillaBank);
                    await _countryRepository.InsertAsync(SiachenGlacier);
                    await _countryRepository.InsertAsync(SriLanka);
                    await _countryRepository.InsertAsync(Taiwan);
                    await _countryRepository.InsertAsync(USNavalBaseGuantanamoBay);
                    await _countryRepository.InsertAsync(Armenia);
                    await _countryRepository.InsertAsync(Azerbaijan);
                    await _countryRepository.InsertAsync(Bahrain);
                    await _countryRepository.InsertAsync(Cyprus);
                    await _countryRepository.InsertAsync(Georgia);
                    await _countryRepository.InsertAsync(Iraq);
                    await _countryRepository.InsertAsync(Israel);
                    await _countryRepository.InsertAsync(Jordan);
                    await _countryRepository.InsertAsync(Kuwait);
                    await _countryRepository.InsertAsync(Lebanon);
                    await _countryRepository.InsertAsync(Oman);
                    await _countryRepository.InsertAsync(Qatar);
                    await _countryRepository.InsertAsync(SaudiArabia);
                    await _countryRepository.InsertAsync(Syria);
                    await _countryRepository.InsertAsync(Turkey);
                    await _countryRepository.InsertAsync(UnitedArabEmirates);
                    await _countryRepository.InsertAsync(Yemen);
                    await _countryRepository.InsertAsync(Belarus);
                    await _countryRepository.InsertAsync(Bulgaria);
                    await _countryRepository.InsertAsync(CzechRepublic);
                    await _countryRepository.InsertAsync(Hungary);
                    await _countryRepository.InsertAsync(Kosovo);
                    await _countryRepository.InsertAsync(Moldova);
                    await _countryRepository.InsertAsync(Poland);
                    await _countryRepository.InsertAsync(Romania);
                    await _countryRepository.InsertAsync(Russia);
                    await _countryRepository.InsertAsync(Slovakia);
                    await _countryRepository.InsertAsync(Ukraine);
                    await _countryRepository.InsertAsync(AlandIslands);
                    await _countryRepository.InsertAsync(Denmark);
                    await _countryRepository.InsertAsync(Estonia);
                    await _countryRepository.InsertAsync(FaroeIslands);
                    await _countryRepository.InsertAsync(Finland);
                    await _countryRepository.InsertAsync(GuernseyandAlderney);
                    await _countryRepository.InsertAsync(Iceland);
                    await _countryRepository.InsertAsync(Ireland);
                    await _countryRepository.InsertAsync(Jersey);
                    await _countryRepository.InsertAsync(Latvia);
                    await _countryRepository.InsertAsync(Lithuania);
                    await _countryRepository.InsertAsync(ManIsleof);
                    await _countryRepository.InsertAsync(Norway);
                    await _countryRepository.InsertAsync(Sweden);
                    await _countryRepository.InsertAsync(UnitedKingdom);
                    await _countryRepository.InsertAsync(Albania);
                    await _countryRepository.InsertAsync(Andorra);
                    await _countryRepository.InsertAsync(BosniaandHerzegovina);
                    await _countryRepository.InsertAsync(CroatiaHrvatska);
                    await _countryRepository.InsertAsync(Gibraltar);
                    await _countryRepository.InsertAsync(Greece);
                    await _countryRepository.InsertAsync(Italy);
                    await _countryRepository.InsertAsync(Macedonia);
                    await _countryRepository.InsertAsync(Malta);
                    await _countryRepository.InsertAsync(Montenegro);
                    await _countryRepository.InsertAsync(Portugal);
                    await _countryRepository.InsertAsync(SanMarino);
                    await _countryRepository.InsertAsync(Serbia);
                    await _countryRepository.InsertAsync(Slovenia);
                    await _countryRepository.InsertAsync(Spain);
                    await _countryRepository.InsertAsync(VaticanCityStateHolySee);
                    await _countryRepository.InsertAsync(Austria);
                    await _countryRepository.InsertAsync(Belgium);
                    await _countryRepository.InsertAsync(France);
                    await _countryRepository.InsertAsync(Germany);
                    await _countryRepository.InsertAsync(Liechtenstein);
                    await _countryRepository.InsertAsync(Luxembourg);
                    await _countryRepository.InsertAsync(Monaco);
                    await _countryRepository.InsertAsync(NetherlandsThe);
                    await _countryRepository.InsertAsync(Switzerland);
                    await _countryRepository.InsertAsync(Australia);
                    await _countryRepository.InsertAsync(NewZealand);
                    await _countryRepository.InsertAsync(AmericanSamoa);
                    await _countryRepository.InsertAsync(CookIslands);
                    await _countryRepository.InsertAsync(FijiIslands);
                    await _countryRepository.InsertAsync(FrenchPolynesia);
                    await _countryRepository.InsertAsync(Guam);
                    await _countryRepository.InsertAsync(NewCaledonia);
                    await _countryRepository.InsertAsync(Niue);
                    await _countryRepository.InsertAsync(NorfolkIsland);
                    await _countryRepository.InsertAsync(NorthernMarianaIslands);
                    await _countryRepository.InsertAsync(PapuanewGuinea);
                    await _countryRepository.InsertAsync(PitcairnIsland);
                    await _countryRepository.InsertAsync(SolomonIslands);
                    await _countryRepository.InsertAsync(Tuvalu);
                    await _countryRepository.InsertAsync(UnitedStatesMinorOutlyingIslands);
                    await _countryRepository.InsertAsync(Vanuatu);
                    await _countryRepository.InsertAsync(WallisAndFutunaIslands);
                    await _countryRepository.InsertAsync(Kiribati);
                    await _countryRepository.InsertAsync(MarshallIslands);
                    await _countryRepository.InsertAsync(Micronesia);
                    await _countryRepository.InsertAsync(Nauru);
                    await _countryRepository.InsertAsync(Palau);
                    await _countryRepository.InsertAsync(Samoa);
                    await _countryRepository.InsertAsync(Tonga);
                }
            }
            #endregion
        }
    }
}
