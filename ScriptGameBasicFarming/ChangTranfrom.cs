using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangTranfrom : MonoBehaviour
{
    public GameObject[] closerOBJ;

    public GameObject BGDatabook;

    public GameObject[] DataTextFarm1;
    public GameObject[] DataTextFarm2;
    public GameObject[] DataTextFarm3;
    public GameObject[] DataTextFarm4;


    public void OnTop(GameObject use)
    {
        use.GetComponent<RectTransform>().localPosition = new Vector3(0, -1500, 0);
        CloserAllBook();
        GameObject.Find("ChangTranfrom").GetComponent<ChangTranfrom>().CloserDataBook();
    }

    public void OnCenter(GameObject use)
    {
        use.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
    }

    public void CloserAllBook()
    {
        for (int i = 0; i < closerOBJ.Length; i++)
        {
            closerOBJ[i].SetActive(false);  
        }
    }


    public void CloserDataBook()
    {
        BGDatabook.SetActive(false);
        CloserDataTextAll();
    }

    public void OpenDataBook(int farm,int datashow)
    {
        BGDatabook.SetActive(true);
        CloserDataTextAll();
        switch (farm)
        {
            case 1:
                DataTextFarm1[datashow-1].SetActive(true);
                break;
            case 2:
                DataTextFarm2[datashow-1].SetActive(true);
                break;
            case 3:
                DataTextFarm3[datashow-1].SetActive(true);
                break;
            case 4:
                DataTextFarm4[datashow-1].SetActive(true);
                break;

            default:
                break;
        }
        
    }

    private void CloserDataTextAll()
    {
        for (int i = 0; i < DataTextFarm1.Length; i++)
        {
            DataTextFarm1[i].SetActive(false);
        }
        for (int i = 0; i < DataTextFarm2.Length; i++)
        {
            DataTextFarm2[i].SetActive(false);
        }
        for (int i = 0; i < DataTextFarm3.Length; i++)
        {
            DataTextFarm3[i].SetActive(false);
        }
        for (int i = 0; i < DataTextFarm4.Length; i++)
        {
            DataTextFarm4[i].SetActive(false);
        }

    }
}
