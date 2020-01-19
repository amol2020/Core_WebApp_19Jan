using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_WebApp.Services
{
    public class CategoryRepository : IRepository<Category, int>
    {

        private CoreAppDBContext ctx;

        public CategoryRepository(CoreAppDBContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<Category> CreateAsync(Category entity)
        {
            var res = await ctx.categories.AddAsync(entity);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var res = await ctx.categories.FindAsync(id);
            if(res != null)
            {
                ctx.categories.Remove(res);
                await ctx.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Category>> GetAsync()
        {
            return await ctx.categories.ToListAsync();
        }

        public async Task<Category> GetAsync(int id)
        {
            return await ctx.categories.FindAsync(id);
        }

        public async Task<Category> UpdateAsync(int id, Category entity)
        {
            var res = await ctx.categories.FindAsync(id);
            if(res !=null)
            {
                res.CategoryId = entity.CategoryId;
                res.CategoryName = entity.CategoryName;
                res.BasePrice = entity.BasePrice;
                await ctx.SaveChangesAsync();
                return res; //updated
            }
            return res; //not updated or null
        }
    }
}
