using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture16
{
    public class Interfaces
    {
    }
    public interface IRunnable
    {
      public  void Run();
    }

    public interface IJumpable
    {
       public void Jump();
    }
    public interface ISwimmable
    {
      public  void Swim();
    }

}