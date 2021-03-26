using UnityEngine;
using System.Collections;

public class characterselect1 : MonoBehaviour
{


    public GameObject[] character;
    private int index = 0;

    private GameObject[] charactershow;

    void Start()
    {

        charactershow = new GameObject[character.Length];
        instantiationcharacter();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            index += 1;

            if (index >= character.Length)
            {
                index = 0;
            }
            characterchange(index);
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            index -= 1;

            if (index < 0)
            {
                index = character.Length - 1;
            }
            characterchange(index);
        }


    }

    void characterchange(int indexxxx)
    {
        for (int i = 0; i < character.Length; i++)
        {
            if (i == indexxxx)
            {
                //show

                charactershow[i].SetActive(true);
            }
            else
                //unvisible
                //  charactershow[i].SetActive(false);
                charactershow[i].active = false;


        }

    }

    void instantiationcharacter()
    {
        for (int i = 0; i < character.Length; i++)
        {

            charactershow[i] = (GameObject)(Instantiate(character[i], transform.position, transform.rotation));

        }

        characterchange(index);
    }
}
