namespace VumbaSoft.AdventureWorksAbp.Web.Menus;

public class AdventureWorksAbpMenus
{
    private const string Prefix = "AdventureWorksAbp";
    public const string Home = Prefix + ".Home";

    //Add your menu items here...
    #region Application Groups Menus
    public const string DemographicsGroup = Prefix + ".Demographics";
    public const string HumanRespurcesGroup = Prefix + ".HumanResources";
    public const string PersonGroup = Prefix + ".Person";
    public const string ProductionGroup = Prefix + ".Production";
    public const string PurchasingGroup = Prefix + ".Purchasing";
    public const string SalesGroup = Prefix + ".Sales";
    #endregion

    //Add your menu items here...
    #region Demographics Menus Content
    //public const string Demographics =
    public const string Continent = DemographicsGroup + ".Continent";
    public const string Subcontinent = DemographicsGroup + ".Subcontinent";
    public const string Country = DemographicsGroup + ".Country";
    public const string Region = DemographicsGroup + ".Region";
    public const string StateProvince = DemographicsGroup + ".StateProvince";
    public const string DistrictCity = DemographicsGroup + ".DistrictCity";
    public const string Locality = DemographicsGroup + ".Locality";

    ////Demographics Navigation Menu
    //public const string ContinentNavMenu = "l[\"Menu:Continent\"]," + "url: /Demographics/Continents/Continent," + " icon: \"fa fa-globe\"";
    //public const string SubcontinentNavMenu = "l[\"Menu:SubContinent\"]," + "url: /Demographics/Subcontinents/Subcontinent," + " icon: \"fa fa-globe\"";
    //public const string CountryNavMenu = "l[\"Menu:Country\"]," + "url: /Demographics/Countries/Country," + " icon: \"fa fa-globe\"";
    //public const string RegionNavMenu = "l[\"Menu:Region\"]," + "url: /Demographics/Regions/Region," + " icon: \"fa fa-globe\"";
    //public const string StateProvinceNavMenu = "l[\"Menu:StateProvince\"]," + "url: /Demographics/StateProvinces/StateProvince," + " icon: \"fa fa-globe\"";
    //public const string DistrictCityNavMenu = "l[\"Menu:DistrictCity\"]," + "url:  /Demographics/DistrictCities/DistrictCity," + " icon: \"fa fa-globe\"";
    //public const string LocalityNavMenu = "l[\"Menu:Locality\"]," + "url: /Demographics/Localities/Locality," + " icon: \"fa fa-globe\"";
    #endregion

    #region Humanresources Menus Content
    public const string Department = HumanRespurcesGroup + ".Department";
    public const string Employee = HumanRespurcesGroup + ".Employee";
    public const string EmployeeDepartmentHistory = HumanRespurcesGroup + ".EmployeeDepartmentHistory";
    public const string EmployeePayHistory = HumanRespurcesGroup + ".EmployeePayHistory";
    public const string JobCandidate = HumanRespurcesGroup + ".JobCandidate";
    public const string Shift = HumanRespurcesGroup + ".Shift";

    ////HumanRespurces Navigation Menu
    //public const string DepartmentNavMenu = "/HumanRespurces/Departments/Department, icon: \"fa fa-globe\"";
    //public const string EmployeeNavMenu = "/HumanRespurces/Employees/Employee, icon: \"fa fa-globe\"";
    //public const string EmployeeDepartmentHistoryNavMenu = "/HumanRespurces/EmployeesDepartmentHistory/EmployeeDepartmentHistory, icon: \"fa fa-globe\"";
    //public const string EmployeePayHistoryNavMenu = "/HumanRespurces/EmployeesPayHistory/EmployeePayHistory, icon: \"fa fa-globe\"";
    //public const string JobCandidateNavMenu = "/HumanRespurces/JobCandidates/JobCandidate, icon: \"fa fa-globe\"";
    //public const string ShiftNavMenu = "/HumanRespurces/Shifts/Shift, icon: \"fa fa-globe\"";
    #endregion

    #region Person Menus Content
    public const string BusinessEntity = PersonGroup + ".BusinessEntity";
    public const string BusinessEntityAddress = PersonGroup + ".BusinessEntityAddress";
    public const string BusinessEntityContact = PersonGroup + ".BusinessEntityContact";
    public const string ContactType = PersonGroup + ".ContactType";
    public const string CountryRegion = PersonGroup + ".CountryRegion";
    public const string EmailAddress = PersonGroup + ".EmailAddress";
    public const string Password = PersonGroup + ".Password";
    public const string Person = PersonGroup + ".Person";
    public const string PersonPhone = PersonGroup + ".PersonPhone";
    public const string PhoneNumberType = PersonGroup + ".PhoneNumberType";
    public const string PersonStateProvince = PersonGroup + ".PersonStateProvince";

    //public const string BusinessEntityNavMenu = "/Person/BusinessEntities/BusinessEntity, icon: \"fa fa-globe\"";
    //public const string BusinessEntityAddressNavMenu = "/Person/BusinessEntityAddresses/BusinessEntityAddress, icon: \"fa fa-globe\"";
    //public const string BusinessEntityContactNavMenu = "/Person/BusinessEntityContacts/BusinessEntityContact, icon: \"fa fa-globe\"";
    //public const string ContactTypeNavMenu = "/Person/ContactTypes/ContactType, icon: \"fa fa-globe\"";
    //public const string CountryRegionNavMenu = "/Person/CountryRegions/CountryRegion, icon: \"fa fa-globe\"";
    //public const string EmailAddressNavMenu = "/Person/EmailAddresses/EmailAddress, icon: \"fa fa-globe\"";
    //public const string PasswordNavMenu = "/Person/Passwords/Password, icon: \"fa fa-globe\"";
    //public const string PersonNavMenu = "/Person/Persons/Person, icon: \"fa fa-globe\"";
    //public const string PersonPhoneNavMenu = "/Person/PersonPhones/PersonPhone, icon: \"fa fa-globe\"";
    //public const string PhoneNumberTypeNavMenu = "/Person/PhoneNumberTypes/PhoneNumberType, icon: \"fa fa-globe\"";
    //public const string PersonStateProvinceNavMenu = "/Person/StateProvinces/PersonStateProvince, icon: \"fa fa-globe\"";
    #endregion

    #region Production Menus content
    public const string BillOfMaterials = ProductionGroup + ".BillOfMaterials";
    public const string Culture = ProductionGroup + ".Culture";
    public const string Document = ProductionGroup + ".Document";
    public const string lllustration = ProductionGroup + ".lllustration";
    public const string Location = ProductionGroup + ".Location";
    public const string Product = ProductionGroup + ".Product";
    public const string ProductCategory = ProductionGroup + ".ProductCategory";
    public const string ProductCostHistory = ProductionGroup + ".ProductCostHistory";
    public const string ProductDescription = ProductionGroup + ".ProductDescription";
    public const string ProductDocument = ProductionGroup + ".ProductDocument";
    public const string Productlnventory = ProductionGroup + ".Productlnventory";
    public const string ProductlistPriceHistory = ProductionGroup + ".ProductlistPriceHistory";
    public const string ProductModel = ProductionGroup + ".ProductModel";
    public const string ProductModellllustration = ProductionGroup + ".ProductModellllustration";
    public const string ProductModelProductDescriptionCulture = ProductionGroup + ".ProductModelProductDescriptionCulture";
    public const string ProductPhoto = ProductionGroup + ".ProductPhoto";
    public const string ProductProductPhoto = ProductionGroup + ".ProductProductPhoto";
    public const string ProductReview = ProductionGroup + ".ProductReview";
    public const string ProductSubcategory = ProductionGroup + ".ProductSubcategory";
    public const string ScrapReason = ProductionGroup + ".ScrapReason";
    public const string TransactionHistory = ProductionGroup + ".TransactionHistory";
    public const string TransactionHistoryArchive = ProductionGroup + ".TransactionHistoryArchive";
    public const string UnitMeasure = ProductionGroup + ".UnitMeasure";
    public const string WorkOrder = ProductionGroup + ".WorkOrder";
    public const string WorkOrderRouting = ProductionGroup + ".WorkOrderRouting";

    //public const string BillOfMaterialsNavMenu = "/Production/BillsOfMaterials/BillOfMaterials, icon: \"fa fa-globe\"";
    //public const string CultureNavMenu = "/Production/Cultures/Culture, icon: \"fa fa-globe\"";
    //public const string DocumentNavMenu = "/Production/Documents/Document, icon: \"fa fa-globe\"";
    //public const string lllustrationNavMenu = "/Production/lllustrations/lllustration, icon: \"fa fa-globe\"";
    //public const string LocationNavMenu = "/Production/Locations/Location, icon: \"fa fa-globe\"";
    //public const string ProductNavMenu = "/Production/Products/Product, icon: \"fa fa-globe\"";
    //public const string ProductCategoryNavMenu = "/Production/ProductCategories/ProductCategory, icon: \"fa fa-globe\"";
    //public const string ProductCostHistoryNavMenu = "/Production/ProductCostHistories/ProductCostHistory, icon: \"fa fa-globe\"";
    //public const string ProductDescriptionNavMenu = "/Production/ProductDescriptions/ProductDescription, icon: \"fa fa-globe\"";
    //public const string ProductDocumentNavMenu = "/Production/ProductDocuments/ProductDocument, icon: \"fa fa-globe\"";
    //public const string ProductlnventoryNavMenu = "/Production/Productlnventories/Productlnventory, icon: \"fa fa-globe\"";
    //public const string ProductlistPriceHistoryNavMenu = "/Production/ProductlistPriceHistories/ProductlistPriceHistory, icon: \"fa fa-globe\"";
    //public const string ProductModelNavMenu = "/Production/ProductModels/ProductModel, icon: \"fa fa-globe\"";
    //public const string ProductModellllustrationNavMenu = "/Production/ProductModellllustrations/ProductModellllustration, icon: \"fa fa-globe\"";
    //public const string ProductModelProductDescriptionCultureNavMenu = "/Production/ProductModelProductDescriptionCultures/ProductModelProductDescriptionCulture, icon: \"fa fa-globe\"";
    //public const string ProductPhotoNavMenu = "/Production/ProductPhotos/ProductPhoto, icon: \"fa fa-globe\"";
    //public const string ProductProductPhotoNavMenu = "/Production/ProductProductPhotos/ProductProductPhoto, icon: \"fa fa-globe\"";
    //public const string ProductReviewNavMenu = "/Production/ProductReviews/ProductReview, icon: \"fa fa-globe\"";
    //public const string ProductSubcategoryNavMenu = "/Production/ProductSubcategories/ProductSubcategory, icon: \"fa fa-globe\"";
    //public const string ScrapReasonNavMenu = "/Production/ScrapReasons/ScrapReason, icon: \"fa fa-globe\"";
    //public const string TransactionHistoryNavMenu = "/Production/TransactionHistories/TransactionHistory, icon: \"fa fa-globe\"";
    //public const string TransactionHistoryArchiveNavMenu = "/Production/TransactionHistoryArchives/TransactionHistoryArchive, icon: \"fa fa-globe\"";
    //public const string UnitMeasureNavMenu = "/Production/UnitMeasures/UnitMeasure, icon: \"fa fa-globe\"";
    //public const string WorkOrderNavMenu = "/Production/WorkOrders/WorkOrder, icon: \"fa fa-globe\"";
    //public const string WorkOrderRoutingNavMenu = "/Production/WorkOrderRoutings/WorkOrderRouting, icon: \"fa fa-globe\"";


    #endregion

    #region Purchasing Menu Content
    public const string ProductVendor = PurchasingGroup + ".ProductVendor";
    public const string PurchaseOrderDetail = PurchasingGroup + ".PurchaseOrderDetail";
    public const string PurchaseOrderHeader = PurchasingGroup + ".PurchaseOrderHeader";
    public const string ShipMethod = PurchasingGroup + ".ShipMethod";
    public const string Vendor = PurchasingGroup + ".Vendor";

    //public const string ProductVendorNavMenu = "/Purchasing/ProductVendors/ProductVendor, icon: \"fa fa-globe\"";
    //public const string PurchaseOrderDetailNavMenu = "/Purchasing/PurchaseOrderDetails/PurchaseOrderDetail, icon: \"fa fa-globe\"";
    //public const string PurchaseOrderHeaderNavMenu = "/Purchasing/PurchaseOrderHeaders/PurchaseOrderHeader, icon: \"fa fa-globe\"";
    //public const string ShipMethodNavMenu = "/Purchasing/ShipMethods/ShipMethod, icon: \"fa fa-globe\"";
    //public const string VendorNavMenu = "/Purchasing/Vendors/Vendor, icon: \"fa fa-globe\"";

    #endregion

    #region Sales Menus Content
    public const string CountryRegionCurrency = SalesGroup + ".CountryRegionCurrency";
    public const string CreditCard = SalesGroup + ".CreditCard";
    public const string Currency = SalesGroup + ".Currency";
    public const string CurrencyRate = SalesGroup + ".CurrencyRate";
    public const string Customer = SalesGroup + ".Customer";
    public const string PersonCreditCard = SalesGroup + ".PersonCreditCard";
    public const string SalesOrderDetail = SalesGroup + ".SalesOrderDetail";
    public const string SalesOrderHeader = SalesGroup + ".SalesOrderHeader";
    public const string SalesOrderHeaderSalesReason = SalesGroup + ".SalesOrderHeaderSalesReason";
    public const string SalesPerson = SalesGroup + ".SalesPerson";
    public const string SalesPersonQuotaHistory = SalesGroup + ".SalesPersonQuotaHistory";
    public const string SalesReason = SalesGroup + ".SalesReason";
    public const string SalesTaxRate = SalesGroup + ".SalesTaxRate";
    public const string SalesTerritory = SalesGroup + ".SalesTerritory";
    public const string SalesTerritoryHistory = SalesGroup + ".SalesTerritoryHistory";
    public const string ShoppingCartltem = SalesGroup + ".ShoppingCartltem";
    public const string SpecialOffer = SalesGroup + ".SpecialOffer";
    public const string SpecialOfferProduct = SalesGroup + ".SpecialOfferProduct";
    public const string Store = SalesGroup + ".Store";

    //public const string CountryRegionCurrencyNavMenu = "/Sales/CountryRegionCurrencys/CountryRegionCurrency, icon: \"fa fa-globe\"";
    //public const string CreditCardNavMenu = "/Sales/CreditCards/CreditCard, icon: \"fa fa-globe\"";
    //public const string CurrencyNavMenu = "/Sales/Currencys/Currency, icon: \"fa fa-globe\"";
    //public const string CurrencyRateNavMenu = "/Sales/CurrencyRates/CurrencyRate, icon: \"fa fa-globe\"";
    //public const string CustomerNavMenu = "/Sales/Customers/Customer, icon: \"fa fa-globe\"";
    //public const string PersonCreditCardNavMenu = "/Sales/PersonCreditCards/PersonCreditCard, icon: \"fa fa-globe\"";
    //public const string SalesOrderDetailNavMenu = "/Sales/SalesOrderDetails/SalesOrderDetail, icon: \"fa fa-globe\"";
    //public const string SalesOrderHeaderNavMenu = "/Sales/SalesOrderHeaders/SalesOrderHeader, icon: \"fa fa-globe\"";
    //public const string SalesOrderHeaderSalesReasonNavMenu = "/Sales/SalesOrderHeaderSalesReasons/SalesOrderHeaderSalesReason, icon: \"fa fa-globe\"";
    //public const string SalesPersonNavMenu = "/Sales/SalesPersons/SalesPerson, icon: \"fa fa-globe\"";
    //public const string SalesPersonQuotaHistoryNavMenu = "/Sales/SalesPersonQuotaHistories/SalesPersonQuotaHistory, icon: \"fa fa-globe\"";
    //public const string SalesReasonNavMenu = "/Sales/SalesReasons/SalesReason, icon: \"fa fa-globe\"";
    //public const string SalesTaxRateNavMenu = "/Sales/SalesTaxRates/SalesTaxRate, icon: \"fa fa-globe\"";
    //public const string SalesTerritoryNavMenu = "/Sales/SalesTerritories/SalesTerritory, icon: \"fa fa-globe\"";
    //public const string SalesTerritoryHistoryNavMenu = "/Sales/SalesTerritoryHistories/SalesTerritoryHistory, icon: \"fa fa-globe\"";
    //public const string ShoppingCartltemNavMenu = "/Sales/ShoppingCartltems/ShoppingCartltem, icon: \"fa fa-globe\"";
    //public const string SpecialOfferNavMenu = "/Sales/SpecialOffers/SpecialOffer, icon: \"fa fa-globe\"";
    //public const string SpecialOfferProductNavMenu = "/Sales/SpecialOfferProducts/SpecialOfferProduct, icon: \"fa fa-globe\"";
    //public const string StoreNavMenu = "/Sales/Stores/Store, icon: \"fa fa-globe\"";

    #endregion
}
