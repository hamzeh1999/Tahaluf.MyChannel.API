﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.MyChannel.core.common;
using Tahaluf.MyChannel.core.data;
using Tahaluf.MyChannel.Core.Repository;

namespace Tahaluf.MyChannel.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDBContext DBContext;
        public CategoryRepository(IDBContext _DBContext)
        {
            DBContext = _DBContext;
        }
        public bool CREATECATEGORY(Category_ category)
        {
            var p = new DynamicParameters();
            p.Add("@pCategoryName", category.CategoryName, dbType: DbType.String);
            p.Add("@pCategorydescription", category.CategoryDescription, dbType: DbType.String);
            p.Add("@pCategoryimage", category.CategoryImage, dbType: DbType.String);

            // dbContext.Connection.Query<ClassName>("PackageName.ProcedureName" ,[parameter] ,CommandType: CommandType.StoredProcedure);
            var result = DBContext.Connection.Query<Category_>("CATEGORY_PACKAGE.CREATECATEGORY", p, commandType: CommandType.StoredProcedure); // p is the dynamic parameter
            return true;
        }

        public bool DELETECATEGORY(int id)
        {
            var p = new DynamicParameters();
            p.Add("@pCategoryId", id, dbType: DbType.Int32);
            var result = DBContext.Connection.Query<Category_>("CATEGORY_PACKAGE.DELETECATEGORY", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Category_> GetAllbadreports()
        {
            // dbContext.Connection.Query<ClassName>("PackageName.ProcedureName" ,[parameter] ,CommandType: CommandType.StoredProcedure);
            //بستدعي البكج يلي بالداتابيز ك ليست
            IEnumerable<Category_> result = DBContext.Connection.Query<Category_>("CATEGORY_PACKAGE.GETALLCATEGORY", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UPDATECATEGORY(Category_ category)
        {
            var p = new DynamicParameters();
            p.Add("@pCategoryId", category.CategoryId, dbType: DbType.Int32);
            p.Add("@pCategoryName", category.CategoryName, dbType: DbType.String);
            p.Add("@pCategorydescription", category.CategoryDescription, dbType: DbType.String);
            p.Add("@pCategoryimage", category.CategoryImage, dbType: DbType.String);
            // dbContext.Connection.Query<ClassName>("PackageName.ProcedureName" ,[parameter] ,CommandType: CommandType.StoredProcedure);
            var result = DBContext.Connection.Query<Category_>("CATEGORY_PACKAGE.UPDATECATEGORY", p, commandType: CommandType.StoredProcedure); // p is the dynamic parameter
            return true;
        }
    }
}
