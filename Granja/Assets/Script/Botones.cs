using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public void HacerGrande()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.5f, 0.2f);
    }

    public void HacerPequeno()
    {
        LeanTween.scale(gameObject, Vector3.one, 0.2f);
    }
}
