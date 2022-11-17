namespace Delegation
{
    public static class FilterProcess
    {
        //public delegate bool Criteria(int number);

        public static int[] Filter(int[] arrayParameter, Func<int, bool> criteriaForFilter)
        {
            var filteredResult = new List<int>();
            foreach (var item in arrayParameter)
            {
                if (criteriaForFilter(item))
                {
                    filteredResult.Add(item);
                }


            }
            return filteredResult.ToArray();
        }
    }
}
