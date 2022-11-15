using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fpsCounter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int samples = 10;
    private float totalTime;
    private int count;

    public void Start()
    {
        count = samples;
        totalTime = 0f;
    }

    public void Update()
    {
        count -= 1;
        totalTime += Time.deltaTime;

        if (count <= 0)
        {
            int fps = (int)(samples / totalTime);
            text.SetText(fps.ToString());
            totalTime = 0f;
            count = samples;
        }
    }
}
