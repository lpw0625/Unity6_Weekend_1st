using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
   // ���� ������ public, private + ��ȯ���� Ÿ�� ���� void, int, string + �Լ��� �̸�  + ()

    public void ButtonPlay()
    {
        Debug.Log("�÷��� ��ư�� ����Ǿ����ϴ�.");

        SceneManager.LoadScene(1); // LoadScene�� ���� Ȥ�� ���ڸ� �ҷ��ü� �մµ� 

    }

    public void ButtonLevelEditor()
    {
        Debug.Log("���������� ��ư�� ����Ǿ����ϴ�.");
    }

    public void ButtonEdit()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }

    public void ButtonWishList()
    {
        Debug.Log("���ø���Ʈ ��ư�� ����Ǿ����ϴ�.");

    }

    public void ButtonDiscord()
    {
        Debug.Log("���ڵ� ��ư�� ����Ǿ����ϴ�.");
    }
}
