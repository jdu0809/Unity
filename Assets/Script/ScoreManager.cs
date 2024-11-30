using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

     // private로 바꾸는건 공적으로 보이지 않고 변수 할당하기 위함.


    //현재점수 UI 적어돈것 
    public Text currentScoreUI;
    //현재점수 저장하는 변수 
    private int currentScore;

    //최고점수 UI 적어논것
    public Text bestScoreUI;
    //최고점수 저장하는 변수
    private int bestScore;

    //싱글턴 객체
    public static ScoreManager instance;

    //Get Set 프로퍼티
    public int Score
    {
        get
        {

            return currentScore;
        }


        set
        {

            currentScore = value;


            currentScoreUI.text = "현재 점수 : " + currentScore;

            //만약에 현재점수가 최고점수보다 크면
            if (currentScore > bestScore)
            {
                //같게 만듬 (최신화)
                bestScore = currentScore;

                //최고점수 표시
                bestScoreUI.text = "최고 점수 : " + bestScore;

                //최고점수 변수에 저장
                PlayerPrefs.SetInt("Best Score", bestScore);
            
            }

        }
    }


    //싱글턴 객체에 값이 없으면 생성된 자기 자신 할당
    private void Awake()
    {
        if (instance == null)
        {

            instance = this;

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        // 목표 : 최고점수 불러와서 bestScore 변수에 할당하고 화면에 표시한다.
        // 순서 : 1. 최고점수 불러와서 bestScore 에 넣어주기
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //        2. 최고점수 화면에 표시하기
        bestScoreUI.text = "최고점수 : " + bestScore;
    }

    // currentScore 에 값을 넣고 화면에 표시하기
    public void SetScore(int value)
    {
        // 3.ScoreManager 클래스의 속성에 값을 할당 한다.
        currentScore = value;
        // 4.화면에 현재 점수 표시하기
        currentScoreUI.text = "현재점수 : " + currentScore;

        //목표: 최고 점수를 표시하고 싶다.
        //1.현재 점수가 최고 점수 보다 크니까
        //  -> 만약 현재 점수가 최고 점수를 초과 하였다면”
        if (currentScore > bestScore)
        {
            //2.최고 점수가 갱신 시킨다.
            bestScore = currentScore;
            //3.최고 점수 UI 에 표시
            bestScoreUI.text = "최고점수 : " + bestScore;
            // 목표 : 최고점수를 저장하고싶다.
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }

    // currentScore 값 가져오기
    public int GetScore()
    {
        return currentScore;
    }


}
