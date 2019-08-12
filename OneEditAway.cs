// Write a function to return if two words are exactly "one edit" away, where an edit is: 
// https://www.geeksforgeeks.org/check-if-two-given-strings-are-at-edit-distance-one/
// From FB interview email

public static bool IsSingleEditAway(string s1, string s2) // B A
{
    int pointerS1 = 0;
    int pointerS2 = 0;
    int edits = 0;

    if (Math.Abs(s1.Length - s2.Length) > 1)
    {
        return false;
    }

    while (edits < 2 && pointerS1 < s1.Length && pointerS2 < s2.Length)
    {
        if (s1[pointerS1] == s2[pointerS2])
        {
            pointerS1++;
            pointerS2++;
        }
        else
        {
            if (s1.Length == s2.Length)
            {
                // chars as different, and same length
                edits++; pointerS1++; pointerS2++;
            }
            else if (s1.Length > s2.Length)
            {
                // chars are different and one is larger
                edits++; pointerS1++;
            }
            else
            {
                edits++; pointerS2++;
            }
        }
    }

    return edits < 2;

}

static void Main(string[] args)
{
    Console.WriteLine(IsSingleEditAway("AAA", "ACAA"));
}