using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePanel : MonoBehaviour
{
    public List<GameObject> butList;//把Panel子层级所有Button加入List

    private void Awake()
    {
        for (int i = 0; i < butList.Count; ++i)
        {
            int index = i;
            butList[i].GetComponent<Button>().onClick.AddListener(() =>
            {
                Onclick(index);
            });
        }
    }
    protected virtual void Onclick(int index)
    {
    }
}
