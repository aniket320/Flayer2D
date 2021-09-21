using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class distroy : MonoBehaviour
{
    public GameObject retry;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            retry.SetActive(true);
            Time.timeScale = 0;
        }

       
    }
    
    public void retrybutton()
    {
        SceneManager.LoadScene("game");
        retry.SetActive(false);
        Time.timeScale = 1;
    }
}
