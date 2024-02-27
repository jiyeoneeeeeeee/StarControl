using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starcontrol : MonoBehaviour
{
    public Image[] progressImages; // ���� ���� �̹����� ���� �迭
    public Sprite[] progressSprites; // ��Ȳ�� ���� �̹��� �迭

    // ���� ��Ȳ �� ���� ��Ȳ�� ���� �̹����� ���� �� ���̰� �ϴ� �Լ�
    public void SetProgress(float completionPercentage)
    {
        int imageIndex;

        if (completionPercentage >= 100f)
        {
            imageIndex = 0; // 100% ����
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
            imageIndex = 5; // Ż��
        }

        // �̹����� ����
        progressImages[imageIndex].sprite = progressSprites[imageIndex];

        // ��� �̹����� ��Ȱ��ȭ
        for (int i = 0; i < progressImages.Length; i++)
        {
            progressImages[i].gameObject.SetActive(false);
        }

        // ���ǿ� ���� �̹����� Ȱ��ȭ
        progressImages[imageIndex].gameObject.SetActive(true);
    }
}
}
