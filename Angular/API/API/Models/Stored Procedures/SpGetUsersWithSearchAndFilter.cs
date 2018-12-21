using ADMINAPI.DTO;
using API.Models.Stored_Procedures.ResultModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Stored_Procedures
{
   
    public class SpGetUsersWithSearchAndFilter
    {
        internal readonly AngularDbContext context;
        private const string ExecuteUspStatement = "EXECUTE SpGetUsersWithSearchAndFilter @SearchText, @PageSize, @PageNumber, @IsActive";

        public SpGetUsersWithSearchAndFilter()
        {
            context = new AngularDbContext();
        }

        private async Task<IList<SpGetUsersWithSearchAndFilterResultModels>> Execute(UserSearchFilterDTO dto)
        {
            var spParams = new List<SqlParameter>
            {
                new SqlParameter("@SearchText",string.IsNullOrEmpty(dto.SearchText)?DBNull.Value:(object)dto.SearchText),
                new SqlParameter("@PageSize",(dto.PageSize==null||dto.PageSize==0)?DBNull.Value:(object)dto.PageSize),
                new SqlParameter("@PageNumber",(dto.PageNumber==null||dto.PageNumber==0)?DBNull.Value:(object)dto.PageNumber),
                new SqlParameter("@IsActive", dto.IsActive==null?DBNull.Value:(object)dto.IsActive)
            };
            var product = await context.SpGetUsersWithSearchAndFilterResultModels
                                 .FromSql(ExecuteUspStatement, spParams.ToArray())
                                 .ToListAsync();
            return product;
        }
        public async Task<IList<SpGetUsersWithSearchAndFilterResultModels>> ExecuteSp(UserSearchFilterDTO dto)
        {
            return await Execute(dto);
        }

    }
}
