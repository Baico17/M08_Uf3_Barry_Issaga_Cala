using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public string playerName,controlName = "GameControl";
    public float distance = 0.45f;
    public int currentPoints = 5;
    

    private GameObject player,theControl;
    public GameObject collectPoint;
    void Start()
    {
        player = GameObject.Find(playerName);
       
        theControl = GameObject.Find(controlName);
    }

    // Update is called once per frame
    void Update()
    {

        if(Vector3.Distance(transform.position,player.transform.position) < distance)
        {
            Instantiate(collectPoint,transform.position,transform.rotation);
            theControl.GetComponent<GameControl>().IncreaseScore(currentPoints);
            Destroy(gameObject);
        }
    }

  
}
