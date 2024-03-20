using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthbar : MonoBehaviour
{
    public Image hbar;
    public float healthamount = 100f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "arrow")
        {
            healthamount -= 10;
            hbar.fillAmount = healthamount / 100f;
        }
        if(healthamount == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
