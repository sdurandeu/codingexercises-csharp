// https://www.interviewcake.com/question/csharp/merging-ranges?course=fc1&section=array-and-string-manipulation
class Program
{
	static Meeting[] GetOverlappingMeetings(Meeting[] meetings)
	{
		meetings = meetings.OrderBy(t => t.StartTime).ToArray();

		List<Meeting> result = new List<Meeting>() { new Meeting(meetings[0].StartTime, meetings[0].EndTime) };
		for (int i = 1; i < meetings.Length; i++)
		{
			var lastMergedMeeting = result.Last();

			if (meetings[i].StartTime <= lastMergedMeeting.EndTime)
			{
				lastMergedMeeting.EndTime = Math.Max(lastMergedMeeting.EndTime, meetings[i].EndTime);
			}
			else
			{
				result.Add(new Meeting(meetings[i].StartTime, meetings[i].EndTime));
			}
		}

		return result.ToArray();
	}

	static void Main(string[] args)
	{
		//GetOverlappingMeetings(new Meeting[] { new Meeting(0, 1), new Meeting(3, 5), new Meeting(4, 8), new Meeting(10, 12), new Meeting(9, 10) });
		//GetOverlappingMeetings(new Meeting[] { new Meeting(1, 10), new Meeting(2, 6), new Meeting(3, 5), new Meeting(7, 9), new Meeting(12, 15) });
		GetOverlappingMeetings(new [] { new Meeting(1, 5), new Meeting(2, 3), new Meeting(6, 8) });
	}