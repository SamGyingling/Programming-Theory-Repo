using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text mytext;
    private void Awake()
    {
        //singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        GameManager.Instance.HitByMouse();

    }

    public void HitByMouse()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    Imyinterface iinter = hit.collider.gameObject.GetComponent<Imyinterface>();
                    if (iinter != null)
                    {
                        iinter.OnclickPrintInfo();

                    }
                   
                }
            }
        }
    }

    public void printInfo(string _text)
    {
            mytext.text = _text;
      
    }

}
