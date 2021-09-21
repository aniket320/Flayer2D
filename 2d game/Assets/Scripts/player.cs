using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isuppressed = false;
    public Text cs;
    public Text hs;
    int Score = 0;
    public GameObject startpanel;
    public float mh;
    public Toggle voltog;

    private void Start()
    {
        if ((PlayerPrefs.GetInt("vt")) == 1)
        {
            voltog.isOn = true;
        }
        else{
            voltog.isOn = false;
        }
        startpanel.SetActive(true);
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
        hs.text= PlayerPrefs.GetInt("hs", 0).ToString();
    }

    private void FixedUpdate()
    {
        
        Score++;
        cs.text = Score.ToString();
        if (Score > PlayerPrefs.GetInt("hs", 0))
        {
            PlayerPrefs.SetInt("hs", Score);
            hs.text = PlayerPrefs.GetInt("hs").ToString();
        }
       // transform.Translate(0,1 * moveSpeed,0);
    }

    private void Update()
    {
        if (voltog.isOn == true)
        {
            PlayerPrefs.SetInt("vt", 1);
        }
        else
        {
            PlayerPrefs.SetInt("vt", 0);
        }
    }
    public void stb()
    {
        startpanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void uppressed()
    {
        isuppressed = true;
        Debug.Log("");
        
        rb.velocity = Vector2.up * 5f;
    }
    public void Resetb()
    {
        PlayerPrefs.DeleteKey("hs");
        
    }
    public void upreleased()
    {
        isuppressed = false;
        Debug.Log("");

    }

    public void quitb()
    {
        Application.Quit();
    }
    
}
