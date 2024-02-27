using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starcontrol : MonoBehaviour
{
    public Image[] progressImages; // 여러 개의 이미지를 가진 배열
    public Sprite[] progressSprites; // 상황에 따른 이미지 배열

    // 완주 상황 및 진행 상황에 따라 이미지를 변경 및 보이게 하는 함수
    public void SetProgress(float completionPercentage)
    {
        int imageIndex;

        if (completionPercentage >= 100f)
        {
            imageIndex = 0; // 100% 완주
        }
        else if (completionPercentage >= 75f)
        {
            imageIndex = 4; // 75~99%
        }
        else if (completionPercentage >= 50f)
        {
            imageIndex = 3; // 50~74%
        }
        else if (completionPercentage >= 25f)
        {
            imageIndex = 2; // 25~49%
        }
        else if (completionPercentage >= 0f)
        {
            imageIndex = 1; // 0~24%
        }
        else
        {
            imageIndex = 5; // 탈락
        }

        // 이미지를 설정
        progressImages[imageIndex].sprite = progressSprites[imageIndex];

        // 모든 이미지를 비활성화
        for (int i = 0; i < progressImages.Length; i++)
        {
            progressImages[i].gameObject.SetActive(false);
        }

        // 조건에 따른 이미지를 활성화
        progressImages[imageIndex].gameObject.SetActive(true);
    }
}
}
