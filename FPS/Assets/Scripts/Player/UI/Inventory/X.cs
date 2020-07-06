using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X : MonoBehaviour
{
    public GameObject StGinfo;
    public Button StGButton;

    // Update is called once per frame
    private void Update()
    {

        StGButton.onClick.AddListener(() => OnClick());


    }
    void OnClick()
    {
        StGinfo.SetActive(false);
    }

}
