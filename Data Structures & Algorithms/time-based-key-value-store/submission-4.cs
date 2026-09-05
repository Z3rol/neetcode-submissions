public class TimeMap
{
    private Dictionary<string, List<(int timestamp, string value)>> timeMap;

    public TimeMap()
    {
        timeMap = new Dictionary<string, List<(int timestamp, string value)>>();
    }
    
    public void Set(string key, string value, int timestamp)
    {
        if (!timeMap.ContainsKey(key))
            timeMap.Add(key, new List<(int timestamp, string value)>());

        timeMap[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp)
    {
        if (!timeMap.ContainsKey(key)) return "";

        var list = timeMap[key];

        int l = 0;
        int r = list.Count - 1;

        int latestTimestampIdx = 0;

        while (l <= r)
        {
            int m = l + (r - l) / 2;

            if (list[m].timestamp == timestamp)
            {
                return list[m].value;
            }
            else if (list[m].timestamp > timestamp)
            {
                r = m - 1;
            }
            else
            {
                latestTimestampIdx = m;
                l = m + 1;
            }
        }

        return list[latestTimestampIdx].timestamp <= timestamp ?
            list[latestTimestampIdx].value : "";
    }
}
