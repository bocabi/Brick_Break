using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    static public int Life = 3;
    // Start is called before the first frame update
    void Start()
    {
        Life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life == 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
