using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public new int i = 3;
    public GameObject ObjName;
    public Renderer rend;
    public int random;

    // Start is called before the first frame update
    void Start()
    {
         random = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        
        rend = GetComponent<Renderer>();
        i++;
        Debug.Log(ObjName.name +":" + i);

        if (ObjName.tag == ("Red") && i > 100)
        {
            ObjName.SetActive(false);
        }

        if (ObjName.tag == ("Blue") && i >= random)
        {
            rend.enabled = false;
        }
    }
}
