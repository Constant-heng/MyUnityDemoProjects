using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class RandomSorting : MonoBehaviour
{
    /// <summary>
    /// 本脚本主要实现的功能是：
    /// 将0~9进行随机排序生成，并选择五个数留下，删掉五个数
    /// 并将这五个数在Text组件中进行显示，中间使用、进行隔开
    /// 增加按钮：删除最大值、最小值，升序、降序排序
    /// </summary>
     


    public Text ShowText;   //需要进行展示的Text文本组件
    List<int> value = new List<int>();  //存储0~9数字的整形列表
    ///<summary>
    ///实现功能：进行文本更新
    ///</summary>
    void UpdateText()
    {
        ShowText.text = string.Join("、", value);
    }
    /// <summary>
    /// 实现功能：生成数字并进行随机排序，并去掉5个数字,进行文本更新
    /// <summary>
    void Button_Generate()
    {
        value = Enumerable.Range(0,10).OrderBy(x => Random.value).ToList();
        value.RemoveRange(5, 5);
        UpdateText();
    }
    /// <summary>
    /// 实现功能：升序排序,进行文本更新
    /// </summary>
    void Button_Sort()
    {
        value.Sort();
        UpdateText();
    }
    /// <summary>
    /// 实现功能：降序排序,进行文本更新
    /// </summary>
    void Button_Reverse()
    {
        value.Sort();
        value.Reverse();
        UpdateText();
    }
    /// <summary>
    /// 实现功能：删除最大值,进行文本更新
    /// </summary>
    void Button_Max()
    {
        value.Remove(value.Max());
        UpdateText();
    }
    /// <summary>
    /// 实现功能：删除最小值,进行文本更新
    /// </summary>
    void Button_Min()
    {
        value.Remove(value.Min());
        UpdateText();
    }
}
