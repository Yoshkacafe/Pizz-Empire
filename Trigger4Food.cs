using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trigger4Food : MonoBehaviour
{
    public GameObject newFood;
    public Image food_image_1;
    public Image food_image_2;
    public Image food_image_3;
    public Image food_image_4;
    public Image food_image_5;
    public Sprite Food1;
    public Sprite Food2;
    public Sprite Food3;
    public Sprite Food4;
    public Sprite Food5;
    public Sprite Food6;
    public bool making = false;
    public bool waiting_1 = false;
    public bool waiting_2 = false;
    public bool waiting_3 = false;
    public bool waiting_4 = false;
    public bool waiting_5 = false;
    public Animator anim;

    void Start()
    {
        newFood.SetActive(false);
    }

    void Update()
    {
        if (waiting_1 == true)
        {
            making = true;
            anim.SetBool("Food1", true);
            anim.SetBool("Food2", false);
            anim.SetBool("Food3", false);
            anim.SetBool("Food4", false);
            anim.SetBool("Food5", false);
        }
        else if (waiting_2 == true)
        {
            making = true;
            anim.SetBool("Food1", false);
            anim.SetBool("Food2", true);
            anim.SetBool("Food3", false);
            anim.SetBool("Food4", false);
            anim.SetBool("Food5", false);
        }
        else if (waiting_3 == true)
        {
            making = true;
            anim.SetBool("Food1", false);
            anim.SetBool("Food2", false);
            anim.SetBool("Food3", true);
            anim.SetBool("Food4", false);
            anim.SetBool("Food5", false);
        }
        else if (waiting_4 == true)
        {
            making = true;
            anim.SetBool("Food1", false);
            anim.SetBool("Food4", false);
            anim.SetBool("Food3", false);
            anim.SetBool("Food4", true);
            anim.SetBool("Food5", false);
        }
        else if (waiting_5 == true)
        {
            making = true;
            anim.SetBool("Food1", false);
            anim.SetBool("Food2", false);
            anim.SetBool("Food3", false);
            anim.SetBool("Food4", false);
            anim.SetBool("Food5", true);
        }
        else
        {
            making = false;
        }
        
    }

    public void SayHello()
    {
        Debug.Log("Hello");
    }

    void OnTriggerEnter(Collider other)
    {
        newFood.SetActive(true);
        if (other.CompareTag("Buyer1"))
        {
            waiting_1 = true;
            waiting_2 = false;
            waiting_3 = false;
            waiting_4 = false;
            waiting_5 = false;
            int number = Random.Range(1, 6);
            if (number == 1)
            {
                food_image_1.GetComponent<Image>().sprite = Food1;
            }
            else if (number == 2)
            {
                food_image_1.GetComponent<Image>().sprite = Food2;
            }
            else if (number == 3)
            {
                food_image_1.GetComponent<Image>().sprite = Food3;
            }
            else if (number == 4)
            {
                food_image_1.GetComponent<Image>().sprite = Food4;
            }
            else if (number == 5)
            {
                food_image_1.GetComponent<Image>().sprite = Food5;
            }
        } 
        else if (other.CompareTag("Buyer2") && waiting_1 == false)
        {
            waiting_1 = false;
            waiting_2 = true;
            waiting_3 = false;
            waiting_4 = false;
            waiting_5 = false;
            int number = Random.Range(1, 6);
            if (number == 1)
            {
                // Zarbi
                food_image_2.GetComponent<Image>().sprite = Food1;
            }
            else if (number == 2)
            {
                food_image_2.GetComponent<Image>().sprite = Food2;
            }
            else if (number == 3)
            {
                food_image_2.GetComponent<Image>().sprite = Food3;
            }
            else if (number == 4)
            {
                food_image_2.GetComponent<Image>().sprite = Food4;
            }
            else if (number == 5)
            {
                food_image_2.GetComponent<Image>().sprite = Food5;
            }
        } 
        else if (other.CompareTag("Buyer3") && waiting_2 == false)
        {
            waiting_1 = false;
            waiting_2 = false;
            waiting_3 = true;
            waiting_4 = false;
            waiting_5 = false;
            int number = Random.Range(1, 6);
            if (number == 1)
            {
                // Zarbi
                food_image_3.GetComponent<Image>().sprite = Food1;
            }
            else if (number == 2)
            {
                food_image_3.GetComponent<Image>().sprite = Food2;
            }
            else if (number == 3)
            {
                food_image_3.GetComponent<Image>().sprite = Food3;
            }
            else if (number == 4)
            {
                food_image_3.GetComponent<Image>().sprite = Food4;
            }
            else if (number == 5)
            {
                food_image_3.GetComponent<Image>().sprite = Food5;
            }
        } 
        else if (other.CompareTag("Buyer4") && waiting_3 == false)
        {
            waiting_1 = false;
            waiting_2 = false;
            waiting_3 = false;
            waiting_4 = true;
            waiting_5 = false;
            int number = Random.Range(1, 6);
            if (number == 1)
            {
                // Zarbi
                food_image_4.GetComponent<Image>().sprite = Food1;
            }
            else if (number == 2)
            {
                food_image_4.GetComponent<Image>().sprite = Food2;
            }
            else if (number == 3)
            {
                food_image_4.GetComponent<Image>().sprite = Food3;
            }
            else if (number == 4)
            {
                food_image_4.GetComponent<Image>().sprite = Food4;
            }
            else if (number == 5)
            {
                food_image_4.GetComponent<Image>().sprite = Food5;
            }
        } 
        else if (other.CompareTag("Buyer5") && waiting_4 == false)
        {
            waiting_1 = false;
            waiting_2 = false;
            waiting_3 = false;
            waiting_4 = false;
            waiting_5 = true;
            int number = Random.Range(1, 6);
            if (number == 1)
            {
                // Zarbi
                food_image_5.GetComponent<Image>().sprite = Food1;
            }
            else if (number == 2)
            {
                food_image_5.GetComponent<Image>().sprite = Food2;
            }
            else if (number == 3)
            {
                food_image_5.GetComponent<Image>().sprite = Food3;
            }
            else if (number == 4)
            {
                food_image_5.GetComponent<Image>().sprite = Food4;
            }
            else if (number == 5)
            {
                food_image_5.GetComponent<Image>().sprite = Food5;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        newFood.SetActive(false);
    }
}
