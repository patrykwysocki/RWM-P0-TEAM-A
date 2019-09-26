public class CombinedFilter
{

    public static int[] combinedFilter(int[] xs)
    {
        return RunningTotalFilter.RunningTotals(DecrementIfLessThanFirst.answerList(xs));
    }

}