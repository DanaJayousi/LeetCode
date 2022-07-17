namespace LeetCode
{
    public class IsSubsequenceSol
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            //Console.WriteLine($"i={i} and j={j}");
            if (i < s.Length)
            {
                return false;
            }
            return true;
        }
    }
}