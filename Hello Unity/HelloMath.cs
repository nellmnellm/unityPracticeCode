using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float size = 3.0f;
        Debug.Log("원의 반지름은"+ GetRadius(size));
        int year = 2023;
        switch(year)
        {
            case 2022:
                Debug.Log("good");
                break;
            case 2023:
                Debug.Log("well");
                break;
            default:
                break;
        };
        int[] scores = new int[10];
        for (int i = 0; i < 10; i++)
        {
            scores[i] = year;
            Debug.Log(scores[i]);
        }
    }

   float GetRadius(float size)
   {
        float pi = 3.14f;
        return Mathf.Sqrt(size/pi);
   }
}
