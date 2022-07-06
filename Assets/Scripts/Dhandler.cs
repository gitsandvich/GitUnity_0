using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Dhandler : MonoBehaviour
{
    
    private void Awake()
    {
        Debug.Log("奇異果");
        
    }

    private void OnEnable()
    {
        Debug.Log("水果");
    }

    

    public float Color_random()
    {
        float color = 0;
        color = UnityEngine.Random.Range(0,255);
        //Debug.Log(color/255);
        return (color/255);
    }
    private void OnDisable()
    {
        Debug.Log("肉");
    }

    // Start is called before the first frame update
    
    public Canvas plain;
    void Start()
    {
        
        
    
    
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        float h = plain.GetComponent<RectTransform>().rect.height;
        float w = plain.GetComponent<RectTransform>().rect.width;
        Debug.Log(h);
        Debug.Log(w);
        this.gameObject.transform.localPosition = new Vector3(UnityEngine.Random.Range((-w/2),w/2), UnityEngine.Random.Range(-h/2,h/2), 1);
        
        Button b = this.GetComponent<Button>();
        ColorBlock cb = b.colors;
        float x = Color_random();
        float y = Color_random();
        float z = Color_random();
        //Debug.Log(x);
        cb.normalColor = new Vector4(Color_random(), Color_random(), Color_random(), 1);
        
        //b.colors = cb;
        cb.selectedColor = cb.normalColor;
        b.colors = cb;
    }
}
