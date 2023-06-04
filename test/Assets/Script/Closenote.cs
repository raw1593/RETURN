using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Closenote : MonoBehaviour
{
    public GameObject note;

    public void closenote()
    {
        note.SetActive(false);
    }

}
