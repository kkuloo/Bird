using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    static public GameManager Instance;

    public GameObject BarPrefab;
    public float spawnTerm = 4;

    public TextMeshProUGUI scoreLabel;
    public float score;

    float spawnTimer;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        score += Time.deltaTime;
        scoreLabel.text = ((int)score).ToString();

        if (spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;

            GameObject obj = Instantiate(BarPrefab);
            obj.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
        }
    }
}
