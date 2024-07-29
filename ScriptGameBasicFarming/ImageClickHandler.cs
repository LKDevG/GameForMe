using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageClickHandler : MonoBehaviour, IPointerClickHandler
{
    public CustomCursor ccursor;
    public Texture2D change;
    public GameObject Closer;
    public int valim;
    public FarmManager manager;

    // Variables for click tracking
    private int clickCount = 0;
    private float lastClickTime = 0f;
    private const float doubleClickTime = 0.3f; // Time interval to detect double click

    public bool isUsedoubleClick;

    public int MeInFarm;

    void Update()
    {
        // Reset click count if time between clicks is too long
        if (Time.time - lastClickTime > doubleClickTime)
        {
            clickCount = 0;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isUsedoubleClick)
        {
            clickCount++;
            if (clickCount == 1)
            {
                // First click
                lastClickTime = Time.time;
                Invoke("SingleClick", doubleClickTime); // Invoke single click event after the double click time window
            }
            else if (clickCount == 2 && Time.time - lastClickTime <= doubleClickTime)
            {
                // Double click
                CancelInvoke("SingleClick"); // Cancel single click event if double click detected
                DoubleClick();
                clickCount = 0; // Reset click count
            }
        }
        else
        {
            SingleClick();
        }

    }

    void SingleClick()
    {
        GameObject.Find("ChangTranfrom").GetComponent<ChangTranfrom>().CloserDataBook();
        ccursor.ChangeCursor(change);
        Closer.SetActive(false);
        manager._valClick = valim;
    }

    void DoubleClick()
    {
        // Implement the double click event here
        Debug.Log("Double click detected!");
        GameObject.Find("ChangTranfrom").GetComponent<ChangTranfrom>().OpenDataBook(MeInFarm, valim);
    }
}
