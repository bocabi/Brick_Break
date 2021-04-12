using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BlockSpawn : MonoBehaviour
{
    public GameObject SZ;
    public Transform Cam;
    public Transform[] SidePos = new Transform[4];

    public Transform[] SpawnPos = new Transform[4];
    public GameObject NomalBlock;
    public GameObject GreenBlock;
    public GameObject PinkBlock;
    public GameObject BlueBlock;
    public GameObject obj;
    bool BlueStart = false;
    private float size = 5;
    float r;
    private bool pinkStart;
    private float randSize;
    private bool GreenStart;
    private int Rand;
    bool fd;
    private bool YellowStop;
    public float BlueCurTime, BlueSpawnStart, GameTime, SetTime, Del, DelCurTime, CurTime, GreenSpawnTime, GreenCurTime, GreenStartSpawnTime, CamRotStart, CamRotCurTime, PinkStartSpawn, PinkCurTime, ShakeStartTime;
   
    public List<GameObject> GreenList = new List<GameObject>();
    public List<GameObject> BlueList = new List<GameObject>();
    public List<GameObject> _PinkList = new List<GameObject>();
    public List<GameObject> _ObjectList = new List<GameObject>();


    private float Camrot;
    // Start is called before the first frame update
    void Start()
    {

        CurTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DelCurTime += Time.deltaTime;
        BlueCurTime += Time.deltaTime;
        PinkCurTime += Time.deltaTime;
        GameTime += Time.deltaTime;
        CamRotCurTime += Time.deltaTime;
        GreenCurTime += Time.deltaTime;
        CurTime += Time.deltaTime;
        Rand = Random.Range(0, 4);
        r = Random.Range(60, 70);
        if (GameTime > 33 && GameTime < 36)
        {
            YellowStop = true;
        }
        if (GameTime > 36 && GameTime < 53)
        {
            pinkStart = true;
        }
        if (Camrot < 360)
        {
            if (CamRotCurTime > CamRotStart)
            {
                Camrot += 30 * Time.deltaTime;
                Cam.transform.rotation = Quaternion.EulerRotation(0, 0, Camrot * Mathf.Deg2Rad);
            }

        }
        if (GreenCurTime > GreenStartSpawnTime && GreenCurTime < GreenStartSpawnTime + 4)
        {
            GreenStart = true;
        }

        if (GreenStart)
        {
            if (GreenCurTime > GreenSpawnTime)
            {
                GreenCurTime = 0;

                GreenList.Add(Instantiate(GreenBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
            }
        }
        if (YellowStop != true)
            if (CurTime > SetTime)
            {

                _ObjectList.Add(Instantiate(NomalBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
                CurTime = 0;
            }
        if (pinkStart == true)
        {
            if (size < 7 && GameTime < 47)
            {
                size += 1 * Time.deltaTime;
            }

            Cam.GetComponent<Camera>().orthographicSize = size;
            if (PinkCurTime > PinkStartSpawn)
            {

                _PinkList.Add(Instantiate(PinkBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
                PinkCurTime = 0;
            }
        }
        if (GameTime < 46 && GameTime > 42)
        {
            randSize = Random.RandomRange(65f, 70f) / 10f;
            Cam.GetComponent<Camera>().orthographicSize = randSize;
        }
        if (GameTime >= 46 && GameTime <= 47)
        {
            GreenStart = false;
            pinkStart = false;
        }
        if (GameTime > 47 && GameTime < 48)
        {

            if (size > -5)
                size -= 13 * Time.deltaTime;
            Cam.GetComponent<Camera>().orthographicSize = size;

        }

        if (GameTime > 58 && GameTime < 59)
        {
            Cam.GetComponent<Camera>().orthographicSize = 5;

        }
        if (GameTime > 54 && GameTime < 59)
        {
            BlueStart = false;
            pinkStart = false;
            GreenStart = false;
            BlueStart = false;
            if (GameTime > 57)
                obj.SetActive(true);
        }
        else
            obj.SetActive(false);
        if (GameTime > 59 && GameTime < 61)
        {
            if (size > 7)

            {
                size += 5 * Time.deltaTime;
                Cam.GetComponent<Camera>().orthographicSize = size;
            }
        }
        if (GameTime > 62 && GameTime < 70)
        {

            BlueStart = true;

            if (BlueStart == true)
            {
                if (BlueCurTime > BlueSpawnStart)
                {
                    BlueList.Add(Instantiate(BlueBlock, SidePos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));

                    BlueCurTime = 0;
                }
            }
        }
        if (GameTime > 78 && GameTime < 82)
        {

            BlueStart = true;

            if (BlueStart == true)
            {
                if (BlueCurTime > BlueSpawnStart)
                {
                    BlueList.Add(Instantiate(BlueBlock, SidePos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));

                    BlueCurTime = 0;
                }
            }
        }
        if (GameTime > 78 && GameTime < 82)
        {
            if (size <= 7)
            {
                size += 7 * Time.deltaTime;
            }
            Cam.GetComponent<Camera>().orthographicSize = size;
        }
        if (GameTime > 86 && GameTime < 93)
        {
            Del += Time.deltaTime;
            if (DelCurTime > 0.2)
            {
                if (Del > 0.05)
                {
                    if (size == 7)
                    {
                        size = 6.5f;
                        Del = 0;
                    }
                    else if (size == 6.5)
                    {
                        size = 7;
                        Del = 0;
                        DelCurTime = 0;
                    }
                }

            }
            Cam.GetComponent<Camera>().orthographicSize = size;
        }
        if(GameTime> 94)
        {
            GreenStart = true;
            if (GreenStart)
            {
                if (GreenCurTime > GreenSpawnTime)
                {
                    GreenCurTime = 0;

                    GreenList.Add(Instantiate(GreenBlock, SpawnPos[Rand].transform.position, Quaternion.Euler(0, 0, (Rand * 90))));
                }
            }
            SZ.SetActive(true);
        }
        if(GameTime > 98)
        {
            SceneManager.LoadScene("EndScene");
        }


    }
}
