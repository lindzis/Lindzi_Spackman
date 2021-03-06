using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    private float colorChangeTime = 5f;
    float yPos;
    [Range(0, 5)]
    public float yRange;
    public float floatSpeed;
    public bool isCorrect;
    public Color[] randomColor;
    Color newColor;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        objRenderer = GetComponent<Renderer>();
        timer += Time.deltaTime;

        if (timer >= colorChangeTime)
        {
            Color newColor = Random.ColorHSV();
            objRenderer.material.color = newColor;
            timer = 0;
        }
        yPos = Mathf.PingPong(Time.time * floatSpeed, 1) * yRange;
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
    private void OnMouseDown()
    {
        if (isCorrect)
        {
            Destroy(this.gameObject);
        }
    }
}  
