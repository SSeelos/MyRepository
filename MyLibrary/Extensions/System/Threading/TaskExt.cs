using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyLibrary_DotNETstd_2_1
{
    public static class TaskExt
    {
        public static async Task<IEnumerable<T>> WhenAll<T>(params Task<T>[] tasks)
        {
            var allTasks = Task.WhenAll(tasks);

            try
            {
                return await allTasks;
            }
            catch (Exception)
            {
                //ignore individual exceptions
            }

            //throw the aggregate exception, which should never be null
            //(for .net7 use the new UnreachableException)
            throw allTasks.Exception ?? throw new Exception("should never be thrown!");
        }
    }
}
