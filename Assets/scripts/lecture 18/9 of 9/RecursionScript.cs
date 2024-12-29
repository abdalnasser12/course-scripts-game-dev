using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    void Start()
    {
        int n1 = 10;
        int n2 = 30;

        Debug.Log($"Recursive Fibonacci for n1 = {FibonacciRecursive(n1)}");
        Debug.Log($"Iterative Fibonacci for n1 = {FibonacciIterative(n1)}");

        Debug.Log($"Recursive Fibonacci for n2 = {FibonacciRecursive(n2)}");
        Debug.Log($"Iterative Fibonacci for n2 = {FibonacciIterative(n2)}");
    }


    int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }


    int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int prev = 0, current = 1;
        for (int i = 2; i <= n; i++)
        {
            int next = prev + current;
            prev = current;
            current = next;
        }
        return current;
    }
}
