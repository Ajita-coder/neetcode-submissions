public class TimeMap {

    private Dictionary<string,List<Tuple<int,string>>> timeMap;

    public TimeMap() {
        timeMap=new Dictionary<string,List<Tuple<int,string>>>();
    }
    
    public void Set(string key, string value, int timestamp) {

        if(!timeMap.ContainsKey(key))
        {
            timeMap[key]=new List<Tuple<int,string>>(); 
        }

        timeMap[key].Add(Tuple.Create(timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if(!timeMap.ContainsKey(key))
        {
            return "";
        }
        var values=timeMap[key];
        int left=0,right=values.Count-1;
        string result="";
        while(left<=right)
        {
            int mid=left+(right-left)/2;
            if(values[mid].Item1<=timestamp)
            {
                result = values[mid].Item2;
                left=mid+1;
            }
            else
            {
                right=mid-1;
            }
        }
        return result;
    }
}
