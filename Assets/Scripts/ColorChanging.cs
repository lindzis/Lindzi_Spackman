using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    private float colorChangeTime = 5f;
    public Color[] randomColor;
    Color newColor;

    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ColorChange();
    }

   void ColorChange()
    {
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            int randomNum = Random.Range(0, randomColor.Length);
            newColor = randomColor[randomNum];
            objRenderer.material.color = newColor;
            timer = 0;
        }
    }
       
}