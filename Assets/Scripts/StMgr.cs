using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StMgr : MonoBehaviour
{
    public int childCount;
    public GameObject god_father;
    public bool 不;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = god_father.transform;
        int childCount = this.transform.childCount;
        Debug.Log(childCount);
        for (int i = 0; i < childCount; i++)
        {
            Transform temp = this.transform.GetChild(i);
            if (temp.name == "Main Camera")
            {
                temp.GetComponent<Camera>().backgroundColor = new Vector4(120/256f, 120/256f, 120/256f, 1);
                Debug.Log("color");
            }
            Debug.Log(temp.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
