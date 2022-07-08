using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Utils;

public class Student
{
   public int num;
   public string name;
   public int age;
   public float exp;
}

[CsvReader("student")]
public class StudentData : CsvDataBase
{
    public static readonly string STUDENT_KEY = "UUIDKey" + "STUDENT"; 
    private List<Student> dataList;

    public List<Student> Data
    {
        get
        {
            if (dataList == null)
            {
                return new List<Student>();
            }

            return dataList;
        }
        private set { dataList = value; }
    }

    public override void OnAllocated()
    {
        base.OnAllocated();
        dataList = GetDataObjects<Student>();
    }

    public override void DeAllocated()
    {
        base.DeAllocated();
        dataList.Clear();
    }
}