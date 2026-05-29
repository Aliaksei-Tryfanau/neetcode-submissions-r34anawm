public class TimeMap 
{
    private Dictionary<string, List<(int timestamp, string value)>> keyStore;

    public TimeMap() 
    {
        keyStore = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int timestamp) 
    {
        if (!keyStore.ContainsKey(key)) 
        {
            keyStore[key] = new List<(int, string)>();
        }

        keyStore[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp) 
    {
        if (!keyStore.ContainsKey(key)) 
        {
            return "";
        }

        var values = keyStore[key];
        int left = 0, right = values.Count - 1;
        string result = "";

        while (left <= right) 
        {
            int mid = left + (right - left) / 2;

            if (values[mid].timestamp <= timestamp) 
            {
                result = values[mid].value;
                left = mid + 1;
            } 
            else 
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
