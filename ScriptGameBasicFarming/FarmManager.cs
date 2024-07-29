using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FarmManager : MonoBehaviour
{
    public int _valClick;

    public Sprite[] Farm;
    public Sprite[] FarmGrow;
    public GameObject[] Book;

    public int[] isWait;


    public int[] SaveBook;
    public string SaveName;


    public TMP_Text bookamtext;

    [System.Serializable]
    public struct MyBookElement
    {
        public GameObject fruit;
        public int amount;
        public TMP_Text bookamtext;
    }

    public MyBookElement[] FarmBook;

    // Start is called before the first frame update
    void Start()
    {
        //CheckSave
        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.HasKey(SaveName + i))
            {
                Debug.Log("I Have " + SaveName + i + " = " + PlayerPrefs.GetInt(SaveName + i));
                SaveBook[i] = PlayerPrefs.GetInt(SaveName + i);
                FarmBook[i].amount = PlayerPrefs.GetInt(SaveName + i);
            }
            else
            {
                PlayerPrefs.SetInt(SaveName + i, 0);
                Debug.Log("Add " + SaveName + i + " = 0");
            }
        }
        
        ShowDataBook();
        UpdateAmountBook();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Test();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            PlayerPrefs.SetInt("Farm10", 0);
        }
    }

    private void Test()
    {
        PlayerPrefs.SetInt("Farm10", (PlayerPrefs.GetInt("Farm10")+1));
        FarmBook[0].amount = PlayerPrefs.GetInt("Farm10");
        UpdateAmountBook();
    }


    private void ShowDataBook()
    {
        for (int i = 0; i < 10; i++)
        {
            if (PlayerPrefs.GetInt(SaveName + i) != 0)
            {
                Book[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
            }
        }
    }

    public void UpdateAmountBook()
    {
        for (int i = 0; i < 10; i++)
        {
            int numberfurit = PlayerPrefs.GetInt(SaveName + i); //0-20
            if (numberfurit >= 0 && numberfurit < 20)
            {
                FarmBook[i].amount = numberfurit;
                FarmBook[i].bookamtext.text = FarmBook[i].amount.ToString() + "/20";
            }
            else if (numberfurit >= 20 && numberfurit < 60) 
            {
                numberfurit = numberfurit - 20;
                FarmBook[i].amount = numberfurit;
                FarmBook[i].bookamtext.text = FarmBook[i].amount.ToString() + "/40";

                OpenUseDoubleClick(i);

            }
            else if (numberfurit >= 60 && numberfurit < 120)
            {
                numberfurit = numberfurit - 60;
                FarmBook[i].amount = numberfurit;
                FarmBook[i].bookamtext.text = FarmBook[i].amount.ToString() + "/60";
                OpenUseDoubleClick(i);
            }
            else if (numberfurit >= 120 && numberfurit < 200)
            {
                numberfurit = numberfurit - 120;
                FarmBook[i].amount = numberfurit;
                FarmBook[i].bookamtext.text = FarmBook[i].amount.ToString() + "/80";
                OpenUseDoubleClick(i);
            }
            else if (numberfurit >= 200 && numberfurit < 280)
            {
                numberfurit = numberfurit - 200;
                FarmBook[i].amount = numberfurit;
                FarmBook[i].bookamtext.text = FarmBook[i].amount.ToString() + "/100";
                OpenUseDoubleClick(i);
            }
            else if (numberfurit >= 280)
            {
                OpenUseDoubleClick(i);
                FarmBook[i].bookamtext.text = " ";
                //END
            }

        }
        //bookamtext.text = valbookamtext.ToString();
    }

    private void OpenUseDoubleClick(int x)
    {
        if (FarmBook[x].fruit.GetComponent<ImageClickHandler>().isUsedoubleClick == false)
        {
            FarmBook[x].fruit.GetComponent<ImageClickHandler>().isUsedoubleClick = true;
        }
    }
}
