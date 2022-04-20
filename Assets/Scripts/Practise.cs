using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class Practise : MonoBehaviour
{
   private void Start()
   {
       int[] arr =  SetArray(10);
        
        SecondSort(arr);
        WriteArray(arr);
   }

   private int[] SetArray(int Length)
    {
        int[] arr = new int[Length];
        Random random = new Random();

        for (int i = 0; i < Length; i++)
        {
            arr[i] = random.Next(-100, 101);
        }

        return arr; 
    }

    private void SecondSort(int[] arr)
    {
        int min = arr[0];
        int temp = 0;

        for (int k = 0; k < arr.Length; k++)
        {
            min = k;
            for (int i = k + 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }
            temp = arr[min];
            arr[min] = arr[k];
            arr[k] = temp;
        }
    }

    private void WriteArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Debug.Log(item);
        }
    }
}
