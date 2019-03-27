using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    int count = 0;
    int count2 = 1;
    void Update()
    {
        count++;
        if (count == 500 * count2)
        {
            count2++;
            gameObject.SetActive(false);
        }
        else if (count == 1000 * count2)
        {
            count2++;
            gameObject.SetActive(true);
        }
    }
}
