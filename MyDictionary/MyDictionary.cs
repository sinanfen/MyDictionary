using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<tK,tV>
    {
        tK[] keys; //TempKey array
        tV[] values; //TempValue array

        public MyDictionary()
        {
            keys = new tK[0];
            values = new tV[0];
        }

        public void Add(tK key, tV value)
        {
            tK[] tempKey = keys;
            tV[] tempValue = values;
            keys = new tK[keys.Length + 1];
            values = new tV[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public tK[] Keys
        {
            get { return keys; } //Set etmesini istemedik çünkü ReadOnly
        }
        public tV[] Values
        {
            get { return values; } //Set etmesini istemedik çünkü ReadOnly 
        }
    }
}

   
