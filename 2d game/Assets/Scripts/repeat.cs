using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat : MonoBehaviour
{
    public float speed;
    public float xstart;
    public float xend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
            if(transform.position.x<=xend)
        {
            Vector2 pos = new Vector2(xstart, transform.position.y);
            transform.position = pos;
        }
    }
}
