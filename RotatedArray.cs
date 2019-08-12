// https://www.interviewcake.com/question/csharp/find-rotation-point
public static int FindRotationPoint(String[] words)
{
	// Find the rotation point in the array
	var startPosition = 0;
	var finalPosition = words.Length;
	var middlePosition = 0;
	while ((startPosition + 1) < finalPosition)
	{
		middlePosition = (startPosition + finalPosition) / 2;
		if (string.Compare(words[middlePosition], words[startPosition]) > 0)
		{
			// search in the lower part
			startPosition = middlePosition;
		}
		else 
		{
			finalPosition = middlePosition;    
		}
	}

	return finalPosition;
}
