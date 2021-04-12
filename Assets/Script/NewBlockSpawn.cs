using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlockSpawn : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
