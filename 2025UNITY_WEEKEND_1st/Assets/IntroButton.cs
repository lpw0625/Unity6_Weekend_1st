using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
   // 접근 지정자 public, private + 반환값의 타입 선언 void, int, string + 함수의 이름  + ()

    public void ButtonPlay()
    {
        Debug.Log("플레이 버튼이 실행되었습니다.");

        SceneManager.LoadScene(1); // LoadScene은 숫자 혹은 문자를 불러올수 잇는데 

    }

    public void ButtonLevelEditor()
    {
        Debug.Log("레벨에디터 버튼이 실행되었습니다.");
    }

    public void ButtonEdit()
    {
        Debug.Log("설정 버튼이 실행되었습니다.");
    }

    public void ButtonWishList()
    {
        Debug.Log("위시리스트 버튼이 실행되었습니다.");

    }

    public void ButtonDiscord()
    {
        Debug.Log("디스코드 버튼이 실행되었습니다.");
    }
}
