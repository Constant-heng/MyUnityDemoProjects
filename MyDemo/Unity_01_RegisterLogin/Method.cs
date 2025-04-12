using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Method : MonoBehaviour
{
    //提醒面板，文字
    public GameObject remindImage;
    public Text remindText;
    //注册方法
    public bool Register(string username, string password)
    {
        if(PlayerPrefs.HasKey(username))
        {
            remindText.text = "该账号已存在！！";
            ActiveRemind();
            //1s后关闭面板
            Invoke("CloseImage", 1.0f);
            return false;
        }
        //保存到系统当中
        PlayerPrefs.SetString(username, password);
        PlayerPrefs.Save();
        remindText.text = "注册成功！！";
        ActiveRemind();
        //1s后关闭面板
        Invoke("CloseImage", 1.0f);
        return true;
    }
    //登录方法
    public bool Login(string username, string password)
    {
        if(!PlayerPrefs.HasKey(username))
        {
            remindText.text = "账号未注册！！";
            ActiveRemind();
            //1s后关闭面板
            Invoke("CloseImage", 1.0f);
            return false;
        }
        //获取该账号的密码，并进行判断
        string storePassword = PlayerPrefs.GetString(username);
        if(password.Equals(storePassword))
        {
            //登陆成功后，进行场景跳转
            SceneManager.LoadScene("Your Scene Name");
            return true;
        }
        remindText.text = "密码错误！！";
        ActiveRemind();
        //1s后关闭面板
        Invoke("CloseImage", 1.0f);
        return false;
    }
    //打开提醒面板
    void ActiveRemind()
    {
        remindImage.SetActive(true);
    }
    //关闭面板
    void CloseImage()
    {
        remindImage.SetActive(false);
    }
}