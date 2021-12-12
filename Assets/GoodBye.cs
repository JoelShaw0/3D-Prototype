using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBye : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject scene;
    GameObject Pause = GameObject.Find("PlayAgain");
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            StartCoroutine(delay());
            scene.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = false;
            Time.timeScale = 0f;
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
