using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Object;
    public AudioClip Clip;
    private AudioSource audioSource;
    Animator animator;
    private bool isAnim;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        animator = GetComponent<Animator>();

        audioSource.Stop();
        audioSource.clip = Clip;
        audioSource.loop = false;
        audioSource.time = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 44 + 270);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 44 + 90);


        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {


            transform.rotation = Quaternion.Euler(0, 0, 44 + 180);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 44);

        }
        if (Object.transform.GetComponent<BlockSpawn>().BlueList.Count != 0)
        {

            if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().BlueList[0].transform.position, transform.position) < 5)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Destroy(Object.transform.GetComponent<BlockSpawn>().BlueList[0].gameObject);
                    Object.transform.GetComponent<BlockSpawn>().BlueList.Remove(Object.transform.GetComponent<BlockSpawn>().BlueList[0]);
                    audioSource.Play();
                }
            }

        }

        if (Object.transform.GetComponent<BlockSpawn>()._ObjectList.Count != 0)
        {
            if (Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position.x == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position.y - transform.position.y > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position, transform.position) < 4)
                    {

                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>()._ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0]);
                            audioSource.Play();
                        }
                    }
                }
                else
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position, transform.position) < 4)
                    {
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>()._ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0]);
                            audioSource.Play();
                        }
                    }
                }
            }
            else if (Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position.y == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position.x - transform.position.x > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position, transform.position) < 4)
                    {
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>()._ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0]);
                            audioSource.Play();
                        }
                    }
                }
                else
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].transform.position, transform.position) < 4)
                    {
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>()._ObjectList.Remove(Object.transform.GetComponent<BlockSpawn>()._ObjectList[0]);
                            audioSource.Play();
                        }
                    }
                }

            }
        }
        //초록블럭
        if (Object.transform.GetComponent<BlockSpawn>().GreenList.Count != 0)
        {

            if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.x == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.y - transform.position.y > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, transform.position) < 4)
                    {
                        if (Object.transform.GetComponent<BlockSpawn>().GreenList[0] != null)
                        {
                            if (Input.GetKeyDown(KeyCode.UpArrow))
                            {

                                Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                                Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                                audioSource.Play();
                            }
                        }
                    }
                }
                else
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, transform.position) < 4)
                    {
                        if (Object.transform.GetComponent<BlockSpawn>().GreenList[0] != null)
                        {
                            if (Input.GetKeyDown(KeyCode.DownArrow))
                            {
                                Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                                Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                                audioSource.Play();
                            }
                        }
                    }
                }
            }
            else if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.y == 0)
            {
                if (Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position.x - transform.position.x > 0)
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, transform.position) < 4)
                    {
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                            audioSource.Play();
                        }
                    }
                }
                else
                {
                    if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>().GreenList[0].transform.position, transform.position) < 4)
                    {
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {
                            Destroy(Object.transform.GetComponent<BlockSpawn>().GreenList[0].gameObject);
                            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(Object.transform.GetComponent<BlockSpawn>().GreenList[0]);
                            audioSource.Play();
                        }
                    }
                }
            }


        }
        //핑크블럭
        if (Object.transform.GetComponent<BlockSpawn>()._PinkList.Count != 0)
            if (Object.transform.GetComponent<BlockSpawn>()._PinkList[0] != null)
            {
                {
                    if (Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position.x == 0)
                    {
                        if (Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position.y - transform.position.y > 0)
                        {
                            if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position, transform.position) < 4)
                            {
                                if (Input.GetKeyDown(KeyCode.UpArrow))
                                {
                                    Destroy(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].gameObject);
                                    Object.transform.GetComponent<BlockSpawn>()._PinkList.Remove(Object.transform.GetComponent<BlockSpawn>()._PinkList[0]);
                                    audioSource.Play();
                                }
                            }
                        }
                        else
                        {
                            if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position, transform.position) < 4)
                            {
                                if (Input.GetKeyDown(KeyCode.DownArrow))
                                {
                                    Destroy(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].gameObject);
                                    Object.transform.GetComponent<BlockSpawn>()._PinkList.Remove(Object.transform.GetComponent<BlockSpawn>()._PinkList[0]);
                                    audioSource.Play();
                                }
                            }
                        }
                    }
                    else if (Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position.y == 0)
                    {
                        if (Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position.x - transform.position.x > 0)
                        {
                            if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position, transform.position) < 4)
                            {
                                if (Input.GetKeyDown(KeyCode.RightArrow))
                                {
                                    Destroy(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].gameObject);
                                    Object.transform.GetComponent<BlockSpawn>()._PinkList.Remove(Object.transform.GetComponent<BlockSpawn>()._PinkList[0]);
                                    audioSource.Play();
                                }
                            }
                        }
                        else
                        {
                            if (Vector3.Distance(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].transform.position, transform.position) < 4)
                            {
                                if (Input.GetKeyDown(KeyCode.LeftArrow))
                                {
                                    Destroy(Object.transform.GetComponent<BlockSpawn>()._PinkList[0].gameObject);
                                    Object.transform.GetComponent<BlockSpawn>()._PinkList.Remove(Object.transform.GetComponent<BlockSpawn>()._PinkList[0]);
                                    audioSource.Play();
                                }
                            }
                        }
                    }
                }

            }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Block"))
        {
            GameManager.Life++;
            Destroy(other.gameObject);
            Object.transform.GetComponent<BlockSpawn>()._ObjectList.Remove(other.gameObject);
        }
        if (other.CompareTag("PinkBlock"))
        {

            GameManager.Life++;
            Destroy(other.gameObject);
            Object.transform.GetComponent<BlockSpawn>()._PinkList.Remove(other.gameObject);
        }
        if (other.CompareTag("GreenBlock"))
        {
            GameManager.Life++;
            Destroy(other.gameObject);
            Object.transform.GetComponent<BlockSpawn>().GreenList.Remove(other.gameObject);
        }
        if (other.CompareTag("BlueBlock"))
        {
            GameManager.Life++;
            Destroy(other.gameObject);
            Object.transform.GetComponent<BlockSpawn>().BlueList.Remove(other.gameObject);
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }
}

