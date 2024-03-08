using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Animation : MonoBehaviour
{

    public Vector2 scrollSpeed = new Vector2(0.1f, 0.1f);
    private Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * scrollSpeed.x;
        float offsetY = Time.time * scrollSpeed.y;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }
}
