using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Method : MonoBehaviour
{
    //������壬����
    public GameObject remindImage;
    public Text remindText;
    //ע�᷽��
    public bool Register(string username, string password)
    {
        if(PlayerPrefs.HasKey(username))
        {
            remindText.text = "���˺��Ѵ��ڣ���";
            ActiveRemind();
            //1s��ر����
            Invoke("CloseImage", 1.0f);
            return false;
        }
        //���浽ϵͳ����
        PlayerPrefs.SetString(username, password);
        PlayerPrefs.Save();
        remindText.text = "ע��ɹ�����";
        ActiveRemind();
        //1s��ر����
        Invoke("CloseImage", 1.0f);
        return true;
    }
    //��¼����
    public bool Login(string username, string password)
    {
        if(!PlayerPrefs.HasKey(username))
        {
            remindText.text = "�˺�δע�ᣡ��";
            ActiveRemind();
            //1s��ر����
            Invoke("CloseImage", 1.0f);
            return false;
        }
        //��ȡ���˺ŵ����룬�������ж�
        string storePassword = PlayerPrefs.GetString(username);
        if(password.Equals(storePassword))
        {
            //��½�ɹ��󣬽��г�����ת
            SceneManager.LoadScene("Your Scene Name");
            return true;
        }
        remindText.text = "������󣡣�";
        ActiveRemind();
        //1s��ر����
        Invoke("CloseImage", 1.0f);
        return false;
    }
    //���������
    void ActiveRemind()
    {
        remindImage.SetActive(true);
    }
    //�ر����
    void CloseImage()
    {
        remindImage.SetActive(false);
    }
}