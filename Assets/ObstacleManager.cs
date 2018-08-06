using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

    [SerializeField] private GameObject collisionWall;
    [SerializeField] private List<GameObject> wallObjects;
    [SerializeField] private GameObject wallParent;
    public List<GameObject> instantiatedObjects = new List<GameObject>();
    private Vector3[] originCoords;
    [SerializeField] private float SPAWN_DELAY = 2.30f;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;
    private float ticks = 0.0f;
    private bool gameStart = true;
    private bool gameOver = false;
    private float speed = 0.5f;
    private int previousNum = -1;
    private int currentNum;

    // Use this for initialization
    void Start () {
        this.StoreOriginPositions();
        EventBroadcaster.Instance.AddObserver(EventNames.ProjectEvents.TutorialEvents.STEP_THREE_DONE, this.OnStartGame);
        EventBroadcaster.Instance.AddObserver(EventNames.ProjectEvents.GameProperEvents.PLAYER_HIT, this.OnGameOver);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.ProjectEvents.TutorialEvents.STEP_THREE_DONE);
        EventBroadcaster.Instance.RemoveObserver(EventNames.ProjectEvents.GameProperEvents.PLAYER_HIT);
    }

    private void FixedUpdate()
    {
        //Debug.Log("ticks: " + this.ticks);
        //Debug.Log("spawn_delay: " + SPAWN_DELAY);
    }

    // Update is called once per frame
    void Update () {
        if (gameStart)
        {
            for (int i = 0; i < instantiatedObjects.Count; i++)
            {
                if (instantiatedObjects[i] == null)
                {
                    instantiatedObjects.RemoveAt(i);
                }
            }

            if (instantiatedObjects != null)
            {
                //for (int i = 0; i < instantiatedObjects.Count; i++)
                //{
                //    instantiatedObjects[i].transform.position = Vector3.MoveTowards(instantiatedObjects[i].transform.position, collisionWall.transform.position, speed * Time.deltaTime);
                //}
            }
            this.ticks += Time.deltaTime;

            if (speed <= 2.75f)
            {
                this.speed += (Time.deltaTime * 0.04f);

            }
            if (SPAWN_DELAY >= .75f)
            {
                SPAWN_DELAY -= (Time.deltaTime * 0.08f);
            }

            //Debug.Log("speed = " + speed);

            if (this.ticks >= SPAWN_DELAY)
            {
                this.ticks = 0.0f;

                GameObject newWall;

                do
                {
                    currentNum = Random.Range(0, wallObjects.Count);
                }
                while (currentNum == previousNum);

                newWall = Instantiate(wallObjects[currentNum], originCoords[0], Quaternion.identity);
                
                previousNum = currentNum;
                
                newWall.transform.parent = wallParent.transform;
                newWall.transform.localPosition = new Vector3(0.0f, Random.Range(minY, maxY), 0.0f);
                newWall.transform.localRotation = Quaternion.identity;
                float obstacleSize = Random.Range(minScale, maxScale);
                newWall.transform.localScale = new Vector3(obstacleSize, obstacleSize);
                newWall.SetActive(true);
                instantiatedObjects.Add(newWall);
            }
        }
        else if (gameOver)
        {
            if(speed >= 0.050f)
            {
                this.speed -= (Time.deltaTime * 0.50f);
            }

        }
    }

    private void StoreOriginPositions()
    {
        this.originCoords = new Vector3[this.wallObjects.Count];
        for (int i = 0; i < wallObjects.Count; i++)
        {
            this.originCoords[i] = this.wallObjects[i].transform.position;
        }
    }

    void OnStartGame()
    {
        gameStart = true;
    }

    void OnGameOver()
    {
        gameStart = false;
        gameOver = true;
    }
}
