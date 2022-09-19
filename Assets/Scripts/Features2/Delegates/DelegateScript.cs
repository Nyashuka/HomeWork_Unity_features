using UnityEngine;

namespace Assets.Scripts.Features2.Delegates
{
    public class DelegateScript : MonoBehaviour
    {
        private delegate void MyDelegate(int num);
        private MyDelegate myDelegate;

        private void Start()
        {
            myDelegate = PrintNum;
            myDelegate(50);

            myDelegate = DoubleNum;
            myDelegate(50);
        }

        private void PrintNum(int num)
        {
            print("Print Num: " + num);
        }
        
        private void DoubleNum(int num)
        {
            print("Double Num: " + num * 2);
        }
    }
}
