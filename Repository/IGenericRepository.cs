﻿namespace simple_blog_api_with_C_.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<T>? AddAsync(T entity);
        Task<T>? UpdateAsync(T entity);
        Task<T>? DeleteAsync(int id);
    }


}
