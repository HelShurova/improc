using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Filter
{
    public class FilterFactory
    {
        private static FilterFactory filterFactory;
        private Dictionary<int, IFilter> filterDictionary;
        public const int MORPHOLOGICAL = 1;

        private FilterFactory()
        {
            filterDictionary = new Dictionary<int, IFilter>();
            filterDictionary.Add(MORPHOLOGICAL, new MorphologicalFilter());
        }

        public static FilterFactory GetInstance()
        {
            if (filterFactory == null)
            {
                filterFactory = new FilterFactory();
            }
            return filterFactory;
        }

        public IFilter GetFilter(int filterType)
        {
            return filterDictionary[filterType];
        }

    }
}
