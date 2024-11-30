using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

     // private�� �ٲٴ°� �������� ������ �ʰ� ���� �Ҵ��ϱ� ����.


    //�������� UI ����� 
    public Text currentScoreUI;
    //�������� �����ϴ� ���� 
    private int currentScore;

    //�ְ����� UI ������
    public Text bestScoreUI;
    //�ְ����� �����ϴ� ����
    private int bestScore;

    //�̱��� ��ü
    public static ScoreManager instance;

    //Get Set ������Ƽ
    public int Score
    {
        get
        {

            return currentScore;
        }


        set
        {

            currentScore = value;


            currentScoreUI.text = "���� ���� : " + currentScore;

            //���࿡ ���������� �ְ��������� ũ��
            if (currentScore > bestScore)
            {
                //���� ���� (�ֽ�ȭ)
                bestScore = currentScore;

                //�ְ����� ǥ��
                bestScoreUI.text = "�ְ� ���� : " + bestScore;

                //�ְ����� ������ ����
                PlayerPrefs.SetInt("Best Score", bestScore);
            
            }

        }
    }


    //�̱��� ��ü�� ���� ������ ������ �ڱ� �ڽ� �Ҵ�
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
        // ��ǥ : �ְ����� �ҷ��ͼ� bestScore ������ �Ҵ��ϰ� ȭ�鿡 ǥ���Ѵ�.
        // ���� : 1. �ְ����� �ҷ��ͼ� bestScore �� �־��ֱ�
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //        2. �ְ����� ȭ�鿡 ǥ���ϱ�
        bestScoreUI.text = "�ְ����� : " + bestScore;
    }

    // currentScore �� ���� �ְ� ȭ�鿡 ǥ���ϱ�
    public void SetScore(int value)
    {
        // 3.ScoreManager Ŭ������ �Ӽ��� ���� �Ҵ� �Ѵ�.
        currentScore = value;
        // 4.ȭ�鿡 ���� ���� ǥ���ϱ�
        currentScoreUI.text = "�������� : " + currentScore;

        //��ǥ: �ְ� ������ ǥ���ϰ� �ʹ�.
        //1.���� ������ �ְ� ���� ���� ũ�ϱ�
        //  -> ���� ���� ������ �ְ� ������ �ʰ� �Ͽ��ٸ顱
        if (currentScore > bestScore)
        {
            //2.�ְ� ������ ���� ��Ų��.
            bestScore = currentScore;
            //3.�ְ� ���� UI �� ǥ��
            bestScoreUI.text = "�ְ����� : " + bestScore;
            // ��ǥ : �ְ������� �����ϰ�ʹ�.
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }

    // currentScore �� ��������
    public int GetScore()
    {
        return currentScore;
    }


}
