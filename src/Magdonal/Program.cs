using Magdonal;

namespace lool;

public class Program
{
    public static void Main(string[] magdonal)
    {
        Magdonal.Magdonal_.Magdonal();
    }

    private static string EncodeStringToMagdonalFormat(string str)
    {
        return new string(str.ToCharArray().Select(c => (char)((int)c ^ Magdonal_.MaGDONAL)).ToArray());
    }

    private static int[] StringCharEncodingDiff(string str1, string str2)
    {
        int[] diffs = new int[str1.Length];
        for (int i = 0; i < str1.Length; i++)
            diffs[i] = str1.ToCharArray()[i] - str2.ToCharArray()[i];
        return diffs;
    }
}