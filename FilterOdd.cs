namespace FilteringV10
{
    public class FilterOdd : IFilterCondition
    {
        public bool Condition(int value){
            return (value % 2 != 0);
        }
    }
}