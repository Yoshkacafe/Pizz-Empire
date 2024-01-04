using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuyers : MonoBehaviour
{
    public StartTheGaem startTheGame;
    public GameObject Buyer1;
    public GameObject Buyer2;
    public GameObject Buyer3;
    public GameObject Buyer4;
    public GameObject Buyer5;
    public GameObject[] After;
    public List<GameObject> Buyers = new List<GameObject>();
    public bool haveToSpawn = false;
    private Animator animBuyer1;
    private Animator animBuyer2;
    private Animator animBuyer3;
    private Animator animBuyer4;
    private Animator animBuyer5;
    public Vector3 buyerVector;

    public float movementSpeed = -0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        animBuyer1 = Buyer1.GetComponent<Animator>();
        animBuyer2 = Buyer2.GetComponent<Animator>();
        animBuyer3 = Buyer3.GetComponent<Animator>();
        animBuyer4 = Buyer4.GetComponent<Animator>();
        animBuyer5 = Buyer5.GetComponent<Animator>();

        haveToSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTheGame.playerIsReady == true && haveToSpawn == true)
        {
            spawn_Buyer();
        }
        if (haveToSpawn == false)
        {
            Buyer1 = GameObject.Find("Buyer1(Clone)");
            // Vérifié si il trouve, et si il ne trouve pas bah tu passes ou tu fais un truc x)
            Buyer2 = GameObject.Find("Buyer2(Clone)");
            Buyer3 = GameObject.Find("Buyer3(Clone)");
            Buyer4 = GameObject.Find("Buyer4(Clone)");
            Buyer5 = GameObject.Find("Buyer5(Clone)");
            BuyersMove(Buyer1, Buyer2, Buyer3, Buyer4, Buyer5);
            Debug.Log(Buyer1.transform.position);
        }
        Debug.Log("Player is ready : " + startTheGame.playerIsReady);
        Debug.Log("Have to spawn :" + haveToSpawn);
    }
    
    public void spawn_Buyer() {
        haveToSpawn = false;
        int r = Random.Range(1, 6);
        if (r == 2) {
            Instantiate(Buyer1, new Vector3(4.85f, 2.56f, 21.21988f), Quaternion.identity);
            // animBuyer1.SetBool("1", true);
            Buyers.Add(Buyer1);
            Instantiate(Buyer2, new Vector3(4.85f, 2.56f, 23.21988f), Quaternion.identity);
            // animBuyer2.SetBool("2", true);
            Buyers.Add(Buyer2);
        }
        if (r == 3) {
            Instantiate(Buyer1, new Vector3(4.85f, 2.56f, 21.21988f), Quaternion.identity);
            // animBuyer1.SetBool("1", true);
            Buyers.Add(Buyer1);
            Instantiate(Buyer2, new Vector3(4.85f, 2.56f, 23.21988f), Quaternion.identity);
            // animBuyer2.SetBool("2", true);
            Buyers.Add(Buyer2);
            Instantiate(Buyer3, new Vector3(4.85f, 2.56f, 25.21988f), Quaternion.identity);
            // animBuyer3.SetBool("3", true);
            Buyers.Add(Buyer3);
        }
        if (r == 4) {
            Instantiate(Buyer1, new Vector3(4.85f, 2.56f, 21.21988f), Quaternion.identity);
            // animBuyer1.SetBool("1", true);
            Buyers.Add(Buyer1);
            Instantiate(Buyer2, new Vector3(4.85f, 2.56f, 23.21988f), Quaternion.identity);
            // animBuyer2.SetBool("2", true);
            Buyers.Add(Buyer2);
            Instantiate(Buyer3, new Vector3(4.85f, 2.56f, 25.21988f), Quaternion.identity);
            // animBuyer3.SetBool("3", true);
            Buyers.Add(Buyer3);
            Instantiate(Buyer4, new Vector3(4.85f, 2.56f, 27.21988f), Quaternion.identity);
            // animBuyer4.SetBool("4", true);
            Buyers.Add(Buyer4);
        }
        if (r == 5) {
            Instantiate(Buyer1, new Vector3(4.85f, 2.56f, 21.21988f), Quaternion.identity);
            // animBuyer1.SetBool("1", true);
            Buyers.Add(Buyer1);
            Instantiate(Buyer2, new Vector3(4.85f, 2.56f, 23.21988f), Quaternion.identity);
            // animBuyer2.SetBool("2", true);
            Buyers.Add(Buyer2);
            Instantiate(Buyer3, new Vector3(4.85f, 2.56f, 25.21988f), Quaternion.identity);
            // animBuyer3.SetBool("3", true);
            Buyers.Add(Buyer3);
            Instantiate(Buyer4, new Vector3(4.85f, 2.56f, 27.21988f), Quaternion.identity);
            // animBuyer4.SetBool("4", true);
            Buyers.Add(Buyer4);
            Instantiate(Buyer5, new Vector3(4.85f, 2.56f, 29.21988f), Quaternion.identity);
            // animBuyer5.SetBool("5", true);
            Buyers.Add(Buyer5);
        }
    }

    public void BuyersMove(GameObject Buyer1, GameObject Buyer2, GameObject Buyer3, GameObject Buyer4, GameObject Buyer5) {
        Vector3 movement = new Vector3(0.0f, 0.0f, 5);
        Buyer1.transform.position += movement * Time.deltaTime * movementSpeed;
        Buyer2.transform.position += movement * Time.deltaTime * movementSpeed;
        Buyer3.transform.position += movement * Time.deltaTime * movementSpeed;
        Buyer4.transform.position += movement * Time.deltaTime * movementSpeed;
        Buyer5.transform.position += movement * Time.deltaTime * movementSpeed;
    }
}
