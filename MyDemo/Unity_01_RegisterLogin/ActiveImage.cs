using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveImage : MonoBehaviour
{
    //�ı���
    public InputField rightTitle;
    public string Name;
    //�����
    public GameObject NumberImage;
    //��InputField�����������Event Trigger���
    //�����Pointer Click������������ķ����󶨵�������
    public void OpenNumberImage()
    {
        rightTitle.text = Name;
        NumberImage.SetActive(true);
    }
}