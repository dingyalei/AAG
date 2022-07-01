using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var t = new TestAtt();
        var t1 = new Test1();
        var t2 = new Test2();
        var t3 = new Test3();
        Debug.Log(t.FilePath);
        Debug.Log(t1.FilePath);
        Debug.Log(t2.FilePath);
        Debug.Log(t3.FilePath);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
