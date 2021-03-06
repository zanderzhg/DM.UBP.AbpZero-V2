﻿//------------------------------------------------------------
// All Rights Reserved , Copyright (C)  
// 版本：1.0
/// <author>
///		<name></name>
///		<date>0001/1/1 0:00:00</date>
/// </author>
//------------------------------------------------------------

using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Domain.Services;
using DM.UBP.Domain.Entity.ReportManager;

namespace DM.UBP.Domain.Service.ReportManager.Categories
{
    /// <summary>
    /// 报表分类的Domain.Service.Interface
    /// <summary>
    public interface IReportCategoryManager : IDomainService
    {
        Task<List<ReportCategory>> GetAllCategoriesAsync();

        Task<ReportCategory> GetCategoryByIdAsync(long id);

        Task<bool> CreateCategoryAsync(ReportCategory category);

        Task<bool> UpdateCategoryAsync(ReportCategory category);

        Task DeleteCategoryAsync(ReportCategory category);

    }
}
