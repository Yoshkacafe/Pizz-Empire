using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTheGaem : MonoBehaviour
{
    public GameObject startUI;
    public GameObject player;
    public bool playerIsReady = false;

    // Start is called before the first frame update
    void Start()
    {
        startUI.SetActive(true);
        player.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!startUI.activeSelf ) {
            player.SetActive(true);
            playerIsReady = true;
        }
    }
}
