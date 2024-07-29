using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSkipScene : MonoBehaviour
{
    public float isTimeSkip;

    public string NameScene;

    public GameObject FadeIn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCooldown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator StartCooldown()
    {
        yield return new WaitForSeconds(isTimeSkip);
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(NameScene);
    }
}
