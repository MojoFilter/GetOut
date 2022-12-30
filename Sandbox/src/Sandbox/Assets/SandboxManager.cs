using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SandboxManager : MonoBehaviour
{

    public string tittySize = "pretty big";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartRoom1() 
    {
        var routine = this.LoadScene("SampleScene");
        StartCoroutine(routine);
    }

    private IEnumerator LoadScene(string name)
    {
        var loadOperation = SceneManager.LoadSceneAsync(name);
        while (!loadOperation.isDone)
        {
            yield return null;
        }
    }
}
