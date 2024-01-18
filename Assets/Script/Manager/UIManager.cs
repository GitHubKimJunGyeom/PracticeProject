using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    // DonDestroy Root -> Loading Bar(신 이동할 때마다 계속 나타 나야하므로 파괴시키지 않는다 )
    //GameObject SubRoot = null;

    // UI prefab 저장하는 dictionary
    Dictionary<UI_TYPE, GameObject> uiDictionary = new Dictionary<UI_TYPE, GameObject>();

    GameObject GetUI(UI_TYPE _uiType, bool isDontDestroy = false)
    {
        if (isDontDestroy == false)
        {
            if (uiDictionary.ContainsKey(_uiType) == true)
            {
                return uiDictionary[_uiType];
            }
        }


        GameObject makeUI = null;
        GameObject prefabUI = Resources.Load("Prefabs/UI/" + _uiType.ToString()) as GameObject;


        if (prefabUI != null)
        {
            if (isDontDestroy == false)
            {
                makeUI = Instantiate(prefabUI);
                makeUI.transform.SetParent(this.gameObject.transform);
                uiDictionary.Add(_uiType, makeUI);
            }

            makeUI.SetActive(false);
        }
        return makeUI;
    }

    public GameObject ShowUI(UI_TYPE _uiType, bool isSub = false)
    {
        GameObject showObject = GetUI(_uiType, isSub);
        if (showObject != null && showObject.activeSelf == false)
        {
            showObject.SetActive(true);
        }
        return showObject;
    }


    public void HideUI(UI_TYPE _uiType, bool isSub = false)
    {
        GameObject showObject = GetUI(_uiType, isSub);
        if (showObject != null && showObject.activeSelf == true)
        {
            showObject.SetActive(false);
        }
    }

    public void Clear()
    {
        foreach (KeyValuePair<UI_TYPE, GameObject> pair in uiDictionary)
        {
            Destroy(pair.Value);
        }
        uiDictionary.Clear();
    }
}

