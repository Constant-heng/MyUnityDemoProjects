using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class AccountMananger : MonoBehaviour
{
    //private void Start()
    //{
    //    PlayerPrefs.DeleteAll();
    //}
    //public UnityEvent a;
    public GameObject remindImage;
    public Text Remind;//提醒
    public bool Register(string username , string password)
    {
        if(PlayerPrefs.HasKey(username))
        {
            Remind.text = "该账号已存在!!!";
            RemindActive();
            Invoke("RemindFalse", 1.0f);
            return false;
        }
        PlayerPrefs.SetString(username, password);
        PlayerPrefs.Save();
        Remind.text = "注册成功!!!";
        RemindActive();
        Invoke("RemindFalse", 1.0f);
        return true;
    }
    public bool Login(string username, string password)
    {
        if(!PlayerPrefs.HasKey(username))
        {
            Remind.text = "该账号不存在！！！";
            RemindActive();
            Invoke("RemindFalse", 1.0f);
            return false;
        }
        string storedPassword = PlayerPrefs.GetString(username);
        if(storedPassword == password)
        {            
            SceneManager.LoadScene("Scenes01");
            return true;
        }
        Remind.text = "密码错误！！！";
        RemindActive();
        Invoke("RemindFalse", 1.0f);
        return false;
    }
    void ChangeScenes()
    {
        SceneManager.LoadScene("Scenes01");
    }
    void RemindActive()
    {
        remindImage.SetActive(true);
    }
    void RemindFalse()
    {
        remindImage.SetActive(false);
    }
}
