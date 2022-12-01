using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    //crear estados


    [SerializeField]
    GameObject canvasInterfaz, canvasCamara, canvasCrear, gridInterfaz, gridCrear, camara;

    bool movimiento = false;
    Vector3 oldPosition;

    // Start is called before the first frame update
    void Start()
    {
        canvasInterfaz.SetActive(true);
        canvasCamara.SetActive(false);
        canvasCrear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonCamara()
    {
        //cambiar estado a mover camara
        canvasInterfaz.SetActive(false);
        canvasCamara.SetActive(true);
        MoverCamara();
    }

    public void BotonCancelarCamara()
    {
        //cambiar estado
        canvasCamara.SetActive(false);
        canvasInterfaz.SetActive(true);
    }

    public void BotonCrear()
    {
        canvasCrear.SetActive(true);
        //canvasInterfaz.SetActive(false);
        LeanTween.moveLocalX(gridCrear, 1146.2f, 0f);
        LeanTween.moveLocalY(gridInterfaz, -658f, 1f);
        LeanTween.moveLocalX(gridCrear, 773.84f, 1f);
    }

    public void BotonCancelarCrear()
    {
        //canvasCrear.SetActive(false);
        //canvasInterfaz.SetActive(true);
        LeanTween.moveLocalX(gridCrear, 1146.2f, 1f);
        LeanTween.moveLocalY(gridInterfaz, -424.68f, 1f);        
    }

    public void BotonCrearPrefab(GameObject prefab)
    {
        //cambiar estado a esperarclick
        /*
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonUp(0))
            {                
                Instantiate(prefab, hit.point, Quaternion.identity);
            }
        }*/

        Instantiate(prefab, Vector3.zero, Quaternion.identity);
    }

    public void MoverCamara()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 deltaPos = oldPosition - Input.mousePosition;

            camara.transform.position += new Vector3(deltaPos.y, 0.0f, deltaPos.x);
        }

        oldPosition = Input.mousePosition;
        
        
    }
}
