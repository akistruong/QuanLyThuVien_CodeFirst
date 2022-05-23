using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTV2._0.Helper
{
    public class PaggingService<T>:List<T>
    {
        public int count { get; set; }
        public int pageIndex;
        public int pageSize;

        public PaggingService(IEnumerable<T> collection, int count, int pageIndex, int pageSize) : base(collection)
        {
            this.count = count;
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
        }

        public static async Task<PaggingService<T>> CreateAsync(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            var count =  source.Count();
            var items =  source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaggingService<T>(items, count, pageIndex, pageSize);
        }
    }
}
