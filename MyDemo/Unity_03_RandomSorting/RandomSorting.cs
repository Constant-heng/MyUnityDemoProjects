using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class RandomSorting : MonoBehaviour
{
    /// <summary>
    /// ���ű���Ҫʵ�ֵĹ����ǣ�
    /// ��0~9��������������ɣ���ѡ����������£�ɾ�������
    /// �������������Text����н�����ʾ���м�ʹ�á����и���
    /// ���Ӱ�ť��ɾ�����ֵ����Сֵ�����򡢽�������
    /// </summary>
     


    public Text ShowText;   //��Ҫ����չʾ��Text�ı����
    List<int> value = new List<int>();  //�洢0~9���ֵ������б�
    ///<summary>
    ///ʵ�ֹ��ܣ������ı�����
    ///</summary>
    void UpdateText()
    {
        ShowText.text = string.Join("��", value);
    }
    /// <summary>
    /// ʵ�ֹ��ܣ��������ֲ�����������򣬲�ȥ��5������,�����ı�����
    /// <summary>
    void Button_Generate()
    {
        value = Enumerable.Range(0,10).OrderBy(x => Random.value).ToList();
        value.RemoveRange(5, 5);
        UpdateText();
    }
    /// <summary>
    /// ʵ�ֹ��ܣ���������,�����ı�����
    /// </summary>
    void Button_Sort()
    {
        value.Sort();
        UpdateText();
    }
    /// <summary>
    /// ʵ�ֹ��ܣ���������,�����ı�����
    /// </summary>
    void Button_Reverse()
    {
        value.Sort();
        value.Reverse();
        UpdateText();
    }
    /// <summary>
    /// ʵ�ֹ��ܣ�ɾ�����ֵ,�����ı�����
    /// </summary>
    void Button_Max()
    {
        value.Remove(value.Max());
        UpdateText();
    }
    /// <summary>
    /// ʵ�ֹ��ܣ�ɾ����Сֵ,�����ı�����
    /// </summary>
    void Button_Min()
    {
        value.Remove(value.Min());
        UpdateText();
    }
}
