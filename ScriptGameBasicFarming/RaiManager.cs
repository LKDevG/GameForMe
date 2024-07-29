using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RaiManager : MonoBehaviour, IPointerClickHandler
{
    public FarmManager manager;
    public GameObject[] show;

    public CustomCursor ccursor;
    public Texture2D change;


    private bool isHaveSeed,HaveGet;


    private int infomation;


    public int startint;
    public float growTime;

    public string SaveName;//Rai11
    private void Start()
    {
/*        if (startint != 0)
        {
            plantStart(startint, growTime);
            startint = 0;
        }*/

        //CheckSave Seed
        if (PlayerPrefs.HasKey(SaveName + "Seed"))//Rai11Seed
        {
            Debug.Log("I Have ");
        }
        else
        {
            PlayerPrefs.SetInt(SaveName + "Seed", 0);
            Debug.Log("Add " + SaveName + "Seed" + " = 0");
        }


        //CheckSave Grow
        if (PlayerPrefs.HasKey(SaveName + "Grow"))//Rai11Seed
        {
            Debug.Log("I Have ");
        }
        else
        {
            PlayerPrefs.SetFloat(SaveName + "Grow", 0);
            Debug.Log("Add " + SaveName + "Grow" + " = 0");
        }

        if (PlayerPrefs.GetInt(SaveName + "Seed") != 0)//Rai11Seed
        {
            plantStart(PlayerPrefs.GetInt(SaveName + "Seed"), PlayerPrefs.GetFloat(SaveName + "Grow"));
        }
    }

    public void Update()
    {
        if (growTime > 0)
        {
            growTime -= Time.deltaTime;
            PlayerPrefs.SetFloat(SaveName + "Grow", growTime);
        }
    }

    public void plantStart(int seed,float time)
    {
        switch (seed)
        {
            case 1:
                show[0].GetComponent<Image>().sprite = manager.Farm[0];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(1,time));
                break;

            case 2:
                show[0].GetComponent<Image>().sprite = manager.Farm[1];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(2, time));
                break;

            case 3:
                show[0].GetComponent<Image>().sprite = manager.Farm[2];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(3, time));
                break;

            case 4:
                show[0].GetComponent<Image>().sprite = manager.Farm[3];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(4, time));
                break;

            case 5:
                show[0].GetComponent<Image>().sprite = manager.Farm[4];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(5, time));
                break;
            case 6:
                show[0].GetComponent<Image>().sprite = manager.Farm[5];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(6, time));
                break;
            case 7:
                show[0].GetComponent<Image>().sprite = manager.Farm[6];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(7, time));
                break;
            case 8:
                show[0].GetComponent<Image>().sprite = manager.Farm[7];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(8, time));
                break;
            case 9:
                show[0].GetComponent<Image>().sprite = manager.Farm[8];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(9, time));
                break;
            case 10:
                show[0].GetComponent<Image>().sprite = manager.Farm[9];
                show[0].SetActive(true);
                ccursor.ChangeCursor(change);
                isHaveSeed = true;
                StartCoroutine(StartCooldownplantStart(10, time));
                break;
            default:
                break;
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isHaveSeed)
        {
            switch (manager._valClick)
            {
                case 1:
                    PlayerPrefs.SetInt(SaveName + "Seed", 1);
                    show[0].GetComponent<Image>().sprite = manager.Farm[0];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(1));
                    break;

                case 2:
                    PlayerPrefs.SetInt(SaveName + "Seed", 2);
                    show[0].GetComponent<Image>().sprite = manager.Farm[1];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(2));
                    break;

                case 3:
                    PlayerPrefs.SetInt(SaveName + "Seed", 3);
                    show[0].GetComponent<Image>().sprite = manager.Farm[2];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(3));
                    break;

                case 4:
                    PlayerPrefs.SetInt(SaveName + "Seed", 4);
                    show[0].GetComponent<Image>().sprite = manager.Farm[3];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(4));
                    break;

                case 5:
                    PlayerPrefs.SetInt(SaveName + "Seed", 5);
                    show[0].GetComponent<Image>().sprite = manager.Farm[4];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(5));
                    break;
                case 6:
                    PlayerPrefs.SetInt(SaveName + "Seed", 6);
                    show[0].GetComponent<Image>().sprite = manager.Farm[5];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(6));
                    break;
                case 7:
                    PlayerPrefs.SetInt(SaveName + "Seed", 7);
                    show[0].GetComponent<Image>().sprite = manager.Farm[6];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(7));
                    break;
                case 8:
                    PlayerPrefs.SetInt(SaveName + "Seed", 8);
                    show[0].GetComponent<Image>().sprite = manager.Farm[7];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(8));
                    break;
                case 9:
                    PlayerPrefs.SetInt(SaveName + "Seed", 9);
                    show[0].GetComponent<Image>().sprite = manager.Farm[8];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(9));
                    break;
                case 10:
                    PlayerPrefs.SetInt(SaveName + "Seed", 10);
                    show[0].GetComponent<Image>().sprite = manager.Farm[9];
                    show[0].SetActive(true);
                    ccursor.ChangeCursor(change);
                    isHaveSeed = true;
                    StartCoroutine(StartCooldown(10));
                    break;
                default:
                    break;
            }
            manager._valClick = 0;
        }

        if (infomation != 0)
        {
            switch (infomation)
            {
                case 1:
                    manager.Book[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 0, (PlayerPrefs.GetInt(manager.SaveName + 0)+1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 2://
                    manager.Book[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f); //
                    PlayerPrefs.SetInt(manager.SaveName + 1, (PlayerPrefs.GetInt(manager.SaveName + 1) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 3:
                    manager.Book[2].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 2, (PlayerPrefs.GetInt(manager.SaveName + 2) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 4:
                    manager.Book[3].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 3, (PlayerPrefs.GetInt(manager.SaveName + 3) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 5:
                    manager.Book[4].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 4, (PlayerPrefs.GetInt(manager.SaveName + 4) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 6:
                    manager.Book[5].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 5, (PlayerPrefs.GetInt(manager.SaveName + 5) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 7:
                    manager.Book[6].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 6, (PlayerPrefs.GetInt(manager.SaveName + 6) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 8:
                    manager.Book[7].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 7, (PlayerPrefs.GetInt(manager.SaveName + 7) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 9:
                    manager.Book[8].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 8, (PlayerPrefs.GetInt(manager.SaveName + 8) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                case 10:
                    manager.Book[9].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                    PlayerPrefs.SetInt(manager.SaveName + 9, (PlayerPrefs.GetInt(manager.SaveName + 9) + 1));
                    manager.UpdateAmountBook();
                    //คืนค่า
                    PlayerPrefs.SetInt(SaveName + "Seed", 0);
                    show[0].transform.localScale = new Vector3(1, 1, 1);
                    show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                    show[0].GetComponent<Image>().sprite = null;
                    show[0].SetActive(false);
                    infomation = 0;
                    isHaveSeed = false;
                    break;

                default:
                    break;
            }
        }
    }

    public IEnumerator StartCooldown(int envent)
    {
        switch (envent)
        {
            case 1:
                growTime = manager.isWait[0];
                yield return new WaitForSeconds(manager.isWait[0]);
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[0];
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 1;
                break;
            case 2: //
                growTime = manager.isWait[1];
                yield return new WaitForSeconds(manager.isWait[1]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[1]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 2; //
                break;
            case 3: //
                growTime = manager.isWait[2];
                yield return new WaitForSeconds(manager.isWait[2]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[2]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 3; //
                break;
            case 4: //
                growTime = manager.isWait[3];
                yield return new WaitForSeconds(manager.isWait[3]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[3]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 4; //
                break;
            case 5: //
                growTime = manager.isWait[4];
                yield return new WaitForSeconds(manager.isWait[4]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[4]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 5; //
                break;
            case 6: //
                growTime = manager.isWait[5];
                yield return new WaitForSeconds(manager.isWait[5]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[5]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 6; //
                break;
            case 7: //
                growTime = manager.isWait[6];
                yield return new WaitForSeconds(manager.isWait[6]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[6]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 7; //
                break;
            case 8: //
                growTime = manager.isWait[7];
                yield return new WaitForSeconds(manager.isWait[7]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[7]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 8; //
                break;
            case 9: //
                growTime = manager.isWait[8];
                yield return new WaitForSeconds(manager.isWait[8]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[8]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 9; //
                break;
            case 10: //
                growTime = manager.isWait[9];
                yield return new WaitForSeconds(manager.isWait[9]); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[9]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 10; //
                break;
            default:
                break;
        }

        
    }

    public IEnumerator StartCooldownplantStart(int envent,float time)
    {
        switch (envent)
        {
            case 1:
                growTime = time;
                yield return new WaitForSeconds(time);
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[0];
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 1;
                break;
            case 2: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[1]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 2; //
                break;
            case 3: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[2]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 3; //
                break;
            case 4: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[3]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 4; //
                break;
            case 5: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[4]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 5; //
                break;
            case 6: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[5]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 6; //
                break;
            case 7: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[6]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 7; //
                break;
            case 8: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[7]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 8; //
                break;
            case 9: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[8]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 9; //
                break;
            case 10: //
                growTime = time;
                yield return new WaitForSeconds(time); //
                show[0].transform.localScale = new Vector3(2, 2, 2);
                show[0].GetComponent<Image>().sprite = manager.FarmGrow[9]; //
                show[0].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
                infomation = 10; //
                break;
            default:
                break;
        }


    }

}
