using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //���Ž� �ؽ�Ʈ �������ؼ� �ʿ�
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Text playerName;

 public void LoadMainScene()
    {
        //�÷��̾� �������� �̸� ����
        //����Ƽ���� �ؽ�Ʈĭ�� �ԷµǴ� �ڷḦ ��������
        //���ӸŴ����� �ν��Ͻ����� �÷��̾� �������� �̸��� ���� ���� p_data
        GameManager.Instance.p_data.name = playerName.text;

        // Main �� �ε�
        SceneManager.LoadScene("Main");

        // �α�
        Debug.Log(playerName.text);
        

    }
}
