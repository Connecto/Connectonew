﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecto.BusinessObjects;

namespace Connecto.DataObjects.EntityFramework.ModelMapper
{
    public class Mapper
    {
        internal static Vendor Map(EntityVendor entity)
        {
            return new Vendor
            {
                VendorId = entity.VendorId,
                Name = entity.Name
            };
        }
        internal static EntityVendor Map(Vendor entity)
        {
            return new EntityVendor
            {
                VendorId = entity.VendorId,
                Name = entity.Name
            };
        }
        internal static Product Map(EntityProduct entity)
        {
            return new Product
            {
                ProductId = entity.ProductId,
                ProductGuid = entity.ProductGuid,
                Name = entity.Name,
                StockInHand = entity.StockInHand,
                Quantity = entity.Quantity,
                Reorderlevel = entity.Reorderlevel,
                ProductTypeId = entity.ProductTypeId,
                VendorId = entity.VendorId
            };
        }
        internal static EntityProduct Map(Product entity)
        {
            return new EntityProduct
            {
                ProductId = entity.ProductId,
                ProductGuid = entity.ProductGuid,
                Name = entity.Name,
                StockInHand = entity.StockInHand,
                Quantity = entity.Quantity,
                Reorderlevel = entity.Reorderlevel,
                ProductTypeId = entity.ProductTypeId,
                VendorId = entity.VendorId
            };
        }

        internal static CompanyLocation Map(EntityCompanyLocation entity)
        {
            return new CompanyLocation
            {
                CompanyLocationId = entity.CompanyLocationId,
                CompanyLocationGuid = entity.CompanyLocationGuid,
                Name = entity.Name,
                StratDate = entity.StratDate,
                AddressNo = entity.AddressNo,
                AddressStreet = entity.AddressStreet,
                City = entity.City,
                Province = entity.Province,
                CountryId = entity.CountryId,
                Timezone = entity.Timezone,
                WorkingHrs = entity.WorkingHrs,
                CompanyId = entity.CompanyId,
                CurrencyTypeId = entity.CurrencyTypeId,
                CompanyLogo = entity.CompanyLogo,
                CreatedOn = entity.CreatedOn,
                CreatedBy = entity.CreatedBy
            };
        }
        internal static EntityCompanyLocation Map(CompanyLocation entity)
        {
            return new EntityCompanyLocation
            {
                CompanyLocationId = entity.CompanyLocationId,
                CompanyLocationGuid = entity.CompanyLocationGuid,
                Name = entity.Name,
                StratDate = entity.StratDate,
                AddressNo = entity.AddressNo,
                AddressStreet = entity.AddressStreet,
                City = entity.City,
                Province = entity.Province,
                CountryId = entity.CountryId,
                Timezone = entity.Timezone,
                WorkingHrs = entity.WorkingHrs,
                CompanyId = entity.CompanyId,
                CurrencyTypeId = entity.CurrencyTypeId,
                CompanyLogo = entity.CompanyLogo,
                CreatedOn = entity.CreatedOn,
                CreatedBy = entity.CreatedBy
            };
        }
        internal static Company Map(EntityCompany entity)
        {
            return new Company
            {
                CompanyId = entity.CompanyId,
                CompanyGuid = entity.CompanyGuid,
                Name = entity.Name,
                Description = entity.Description,
                CompanyVatRegNo = entity.CompanyVatRegNo,
                CreatedOn = entity.CreatedOn,
                CreatedBy = entity.CreatedBy
            };
        }
        internal static EntityCompany Map(Company entity)
        {
            return new EntityCompany
            {
                CompanyId = entity.CompanyId,
                CompanyGuid = entity.CompanyGuid,
                Name = entity.Name,
                Description = entity.Description,
                CompanyVatRegNo = entity.CompanyVatRegNo,
                CreatedOn = entity.CreatedOn,
                CreatedBy = entity.CreatedBy
            };
        }
        
        internal static Measure Map(EntityMeasure entity)
        {
            return new Measure
            {
                MeasureId = entity.MeasureId,
                MeasureGuid = entity.MeasureGuid,
                Lower = entity.Lower,
                Volume = entity.Volume,
                Actual = entity.Actual
            };
        }
        internal static EntityMeasure Map(Measure entity)
        {
            return new EntityMeasure
            {
                MeasureId = entity.MeasureId,
                MeasureGuid = entity.MeasureGuid,
                Lower = entity.Lower,
                Volume = entity.Volume,
                Actual = entity.Actual
            };
        }
        internal static ProductType Map(EntityProductType entity)
        {
            return new ProductType
            {
                ProductTypeId = entity.ProductTypeId,
                ProductTypeGuid = entity.ProductTypeGuid,
                MeasureId = entity.MeasureId,
                Type = entity.Type,
                StockAs = entity.StockAs
            };
        }
        internal static EntityProductType Map(ProductType entity)
        {
            return new EntityProductType
            {
                ProductTypeId = entity.ProductTypeId,
                ProductTypeGuid = entity.ProductTypeGuid,
                MeasureId = entity.MeasureId,
                Type = entity.Type,
                StockAs = entity.StockAs
            };
        }
        internal static Supplier Map(EntitySupplier entity)
        {
            return new Supplier
            {
                SupplierId = entity.SupplierId,
                Name = entity.Name
            };
        }
        internal static EntitySupplier Map(Supplier entity)
        {
            return new EntitySupplier
            {
                SupplierId = entity.SupplierId,
                Name = entity.Name
            };
        }
        internal static Employee Map(EntityEmployee entity)
        {
            return new Employee
            {
                EmployeeId = entity.EmployeeId,
                EmployeeGuid = entity.EmployeeGuid,
                Description = entity.Description,
                Name = entity.Name
            };
        }
        internal static EntityEmployee Map(Employee entity)
        {
            return new EntityEmployee
            {
                EmployeeId = entity.EmployeeId,
                EmployeeGuid = entity.EmployeeGuid,
                Description = entity.Description,
                Name = entity.Name
            };
        }
        internal static Currency Map(EntityCurrency entity)
        {
            return new Currency
            {
                CurrencyId = entity.CurrencyId,
                CurrencyGuid = entity.CurrencyGuid,
                Description = entity.Description,
                Name = entity.Name
            };
        }
        internal static EntityCurrency Map(Currency entity)
        {
            return new EntityCurrency
            {
                CurrencyId = entity.CurrencyId,
                CurrencyGuid = entity.CurrencyGuid,
                Description = entity.Description,
                Name = entity.Name
            };
        }
        internal static ProductDetail Map(EntityProductDetail entity)
        {
            return new ProductDetail
            {
                ProductDetailId = entity.ProductDetailId,
                ProductDetailGuid = entity.ProductDetailGuid,
                ProductId = entity.ProductId,
                UnitPrice = entity.UnitPrice,
                Quantity = entity.Quantity,
                SellingPrice = entity.SellingPrice,
                DateReceived = entity.DateReceived
            };
        }
        internal static EntityProductDetail Map(ProductDetail entity)
        {
            return new EntityProductDetail
            {
                ProductDetailId = entity.ProductDetailId,
                ProductDetailGuid = entity.ProductDetailGuid,
                ProductId = entity.ProductId,
                UnitPrice = entity.UnitPrice,
                Quantity = entity.Quantity,
                SellingPrice = entity.SellingPrice,
                DateReceived = entity.DateReceived
            };
        }
        internal static ProductSupplier Map(EntityProductSupplier entity)
        {
            return new ProductSupplier
            {
                ProductSupplierId = entity.ProductSupplierId,
                ProductSupplierGuid = entity.ProductSupplierGuid,
                ProductId = entity.ProductId,
                SupplierId = entity.SupplierId
            };
        }
        internal static EntityProductSupplier Map(ProductSupplier entity)
        {
            return new EntityProductSupplier
            {
                ProductSupplierId = entity.ProductSupplierId,
                ProductSupplierGuid = entity.ProductSupplierGuid,
                ProductId = entity.ProductId,
                SupplierId = entity.SupplierId
            };
        }
        internal static Contact Map(EntityContact entity)
        {
            return new Contact
            {
                ContactId = entity.ContactId,
                ContactGuid = entity.ContactGuid,
                EmployeeId = entity.EmployeeId,
                LandNumber = entity.LandNumber,
                MobileNumber = entity.MobileNumber,
                AddressNo = entity.AddressNo,
                AddressStreet = entity.AddressStreet,
                City = entity.City,
                Province = entity.Province,
            };
        }
        internal static EntityContact Map(Contact entity)
        {
            return new EntityContact
            {
                ContactId = entity.ContactId,
                ContactGuid = entity.ContactGuid,
                EmployeeId = entity.EmployeeId,
                LandNumber = entity.LandNumber,
                MobileNumber = entity.MobileNumber,
                AddressNo = entity.AddressNo,
                AddressStreet = entity.AddressStreet,
                City = entity.City,
                Province = entity.Province,
            };
        }
    }
}
