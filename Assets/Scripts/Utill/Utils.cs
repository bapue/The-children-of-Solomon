using System;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    /// <summary>
    /// 중복되지 않는 랜덤 숫자 리스트 만들기 (minValue: 0)
    /// </summary>
    /// <param name="maxValue">최대값(제외)</param>
    /// <param name="count">반환 개수</param>
    /// <param name="isDuplicate">중복 숫자 여부</param>
    /// <param name="randomSeed">랜덤 씨드</param>
    /// <returns></returns>
    public static int[] MakeRandomNumbers(int maxValue, int randomSeed = 0)
    {
        return MakeRandomNumbers(0, maxValue, randomSeed);
    }

    /// <summary>
    /// 중복되지 않는 랜덤 숫자 리스트 만들기
    /// </summary>
    /// <param name="minValue">최소값(포함)</param>
    /// <param name="maxValue">최대값(제외)</param>
    /// <param name="count">반환 개수</param>
    /// <param name="isDuplicate">중복 숫자 여부</param>
    /// <param name="randomSeed">랜덤 씨드</param>
    /// <returns></returns>
    public static int[] MakeRandomNumbers(int minValue, int maxValue, int randomSeed = 0)
    {
        if (randomSeed == 0)
            randomSeed = (int)DateTime.Now.Ticks;

        List<int> values = new List<int>();
        for (int v = minValue; v < maxValue; v++)
        {
            values.Add(v);
        }

        int[] result = new int[maxValue - minValue];
        System.Random random = new System.Random(Seed: randomSeed);
        int i = 0;
        while (values.Count > 0)
        {
            int randomValue = values[random.Next(0, values.Count)];
            result[i++] = randomValue;

            if (!values.Remove(randomValue))
            {
                // Exception
                break;
            }
        }

        return result;
    }
}
