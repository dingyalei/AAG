using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
public class CsvDataManager : Singleton<CsvDataManager>
{
    private Dictionary<string,CsvDataBase> csvDataList;
    
    public void Init()
    {
        csvDataList = new Dictionary<string,CsvDataBase>
        {
            {StudentData.STUDENT_KEY, new StudentData()}
            // add csv data
        };
        
        foreach (var data in csvDataList)
        {
            data.Value.OnAllocated();
        }
    }

    public T GetDataBase<T>(string key) where T : class
    {
        csvDataList.TryGetValue(key, out CsvDataBase data);
        return data as T;
    } 
    
    public void OnDestroy()
    {
        foreach (var data in csvDataList)
        {
            data.Value.DeAllocated();
        }
    }
}
