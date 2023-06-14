using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameBtn : MonoBehaviour
{
    public string objName;

    [SerializeField] Text mtText;
    [SerializeField] Toggle btn;

    void Start()
    {
        btn.group = btn.transform.parent.GetComponent<ToggleGroup>();
        btn.onValueChanged.AddListener(delegate { OnClickBtn(btn.isOn); });
    }

    // Update is called once per frame
    void OnClickBtn(bool value)
    {
        if (value)
        {
            UIManager.instance.transformGizmo.ClearTargets();
            UIManager.instance.transformGizmo.AddTarget(GameObject.Find(objName).transform);
        }
    }

    public void SetText(string name)
    {
        objName = name;
        mtText.text = name;
    }
}
