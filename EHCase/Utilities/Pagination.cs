using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHCase.Utilities
{
    public enum SortOrder
    {
        Asc,
        Desc
    }

    public class Pagination
    {
        private const int MaxItemsPerPageConst = 1000;
        private int page;
        public int Page
        {
            get
            {
                if (page <= 0)
                {
                    page = 1;
                }
                return page;
            }
            set
            {
                page = value;
            }
        }
        private int itemPerPage;
        public int ItemsPerPage
        {
            get
            {
                return itemPerPage;
            }
            set
            {
                itemPerPage = value > MaxItemsPerPageConst ? MaxItemsPerPageConst : value;
            }
        }

        public int Offset
        {
            get
            {
                return (this.Page - 1) * this.ItemsPerPage;
            }
        }
    }
}
