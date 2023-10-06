using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Diplom.Domain;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Application.Interfaces
{
   public interface IDbContext
    {
         DbSet<Address> Addresses { get; set; }
         DbSet<AddressType> AddressTypes { get; set; }
         DbSet<AwbuildVersion> AwbuildVersions { get; set; }
         DbSet<BillOfMaterial> BillOfMaterials { get; set; }
         DbSet<BusinessEntity> BusinessEntities { get; set; }
         DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
         DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }
         DbSet<ContactType> ContactTypes { get; set; }
         DbSet<CountryRegion> CountryRegions { get; set; }
         DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
         DbSet<CreditCard> CreditCards { get; set; }
         DbSet<Culture> Cultures { get; set; }
         DbSet<Currency> Currencies { get; set; }
         DbSet<CurrencyRate> CurrencyRates { get; set; }
         DbSet<Customer> Customers { get; set; }
         DbSet<DatabaseLog> DatabaseLogs { get; set; }
         DbSet<Department> Departments { get; set; }
         DbSet<EmailAddress> EmailAddresses { get; set; }
         DbSet<Employee> Employees { get; set; }
         DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
         DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }
         DbSet<ErrorLog> ErrorLogs { get; set; }
         DbSet<Illustration> Illustrations { get; set; }
         DbSet<JobCandidate> JobCandidates { get; set; }
         DbSet<Location> Locations { get; set; }
         DbSet<Password> Passwords { get; set; }
         DbSet<Person> People { get; set; }
         DbSet<PersonCreditCard> PersonCreditCards { get; set; }
         DbSet<PersonPhone> PersonPhones { get; set; }
         DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
         DbSet<Product> Products { get; set; }
         DbSet<ProductCategory> ProductCategories { get; set; }
         DbSet<ProductCostHistory> ProductCostHistories { get; set; }
         DbSet<ProductDescription> ProductDescriptions { get; set; }
         DbSet<ProductInventory> ProductInventories { get; set; }
         DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
         DbSet<ProductModel> ProductModels { get; set; }
         DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }
         DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
         DbSet<ProductPhoto> ProductPhotos { get; set; }
         DbSet<ProductProductPhoto> ProductProductPhotos { get; set; }
         DbSet<ProductReview> ProductReviews { get; set; }
         DbSet<ProductSubcategory> ProductSubcategories { get; set; }
         DbSet<ProductVendor> ProductVendors { get; set; }
         DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
         DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
         DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
         DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
         DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
         DbSet<SalesPerson> SalesPeople { get; set; }
         DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
         DbSet<SalesReason> SalesReasons { get; set; }
         DbSet<SalesTaxRate> SalesTaxRates { get; set; }
         DbSet<SalesTerritory> SalesTerritories { get; set; }
         DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
         DbSet<ScrapReason> ScrapReasons { get; set; }
         DbSet<Shift> Shifts { get; set; }
         DbSet<ShipMethod> ShipMethods { get; set; }
         DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
         DbSet<SpecialOffer> SpecialOffers { get; set; }
         DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
         DbSet<StateProvince> StateProvinces { get; set; }
         DbSet<Store> Stores { get; set; }
         DbSet<TransactionHistory> TransactionHistories { get; set; }
         DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
         DbSet<UnitMeasure> UnitMeasures { get; set; }
         DbSet<VAdditionalContactInfo> VAdditionalContactInfos { get; set; }
         DbSet<VEmployee> VEmployees { get; set; }
         DbSet<VEmployeeDepartment> VEmployeeDepartments { get; set; }
         DbSet<VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; }
         DbSet<VIndividualCustomer> VIndividualCustomers { get; set; }
         DbSet<VJobCandidate> VJobCandidates { get; set; }
         DbSet<VJobCandidateEducation> VJobCandidateEducations { get; set; }
         DbSet<VJobCandidateEmployment> VJobCandidateEmployments { get; set; }
         DbSet<VPersonDemographic> VPersonDemographics { get; set; }
         DbSet<VProductAndDescription> VProductAndDescriptions { get; set; }
         DbSet<VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; }
         DbSet<VProductModelInstruction> VProductModelInstructions { get; set; }
         DbSet<VSalesPerson> VSalesPeople { get; set; }
         DbSet<VSalesPersonSalesByFiscalYear> VSalesPersonSalesByFiscalYears { get; set; }
         DbSet<VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; }
         DbSet<VStoreWithAddress> VStoreWithAddresses { get; set; }
         DbSet<VStoreWithContact> VStoreWithContacts { get; set; }
         DbSet<VStoreWithDemographic> VStoreWithDemographics { get; set; }
         DbSet<VVendorWithAddress> VVendorWithAddresses { get; set; }
         DbSet<VVendorWithContact> VVendorWithContacts { get; set; }
         DbSet<Vendor> Vendors { get; set; }
         DbSet<WorkOrder> WorkOrders { get; set; }
         DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
