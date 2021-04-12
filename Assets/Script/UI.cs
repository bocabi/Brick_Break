using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject[] OBJ = new GameObject[3];
    public GameObject dfas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Life == 3)
        {
            OBJ[0].SetActive(true);
            OBJ[1].SetActive(true);
            OBJ[2].SetActive(true);
        }
        else
        {
            if (GameManager.Life == 2)
            {
                OBJ[0].SetActive(true);
                OBJ[1].SetActive(true);
            }
            else
            {
                OBJ[1].SetActive(false);

                if (GameManager.Life == 1)
                {
                    OBJ[0].SetActive(true);
                }
                else
                {
                    OBJ[2].SetActive(false);
                    OBJ[1].SetActive(false);

                }
            }

        }

    }
}
