using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ButtonÍ¼Æ¬µÄÇÐ»»£»ÊÂ¼þ¼àÌý£»
/// </summary>
public class UIPanel : BasePanel
{
    public List<Sprite> selectedList;
    public List<Sprite> unSelectedList;


    private List<bool> butState;
    public int interMode;

    private void Start()
    {
        butState = new List<bool>();
        for(int i = 0; i < butList.Count; ++i)
        {
            butState.Add(false);
        }
    }

    private void ChangeBut(int index)//½»»¥Âß¼­
    {
        switch (interMode)
        {
            case 0:
                butState[index] = !butState[index];
                //Debug.Log(butState[index]);
                ChangeButImg(index);
                break;
            case 1:
                for (int i = 0; i < butList.Count; ++i)
                {
                    butState[i] = (i == index);
                    Debug.Log(i + "," + butState[i]);
                    ChangeButImg(i);
                }
                break;
        }

    }


    private void ChangeButImg(int index)
    {
        if (butState[index])
            butList[index].GetComponent<Image>().sprite = selectedList[index];
        else
            butList[index].GetComponent<Image>().sprite = unSelectedList[index];
    }

    protected override void Onclick(int index)
    {
        ChangeBut(index);
    }

}
