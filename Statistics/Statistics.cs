﻿using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average = 0.0;
        public float min = float.MaxValue;
        public float max = float.MinValue;
        
        public Stats CalculateStatistics(List<float> numbers) {
            Stats numbers = new Stats();
            float sumOfValues = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                sumOfValues += numbers[i];
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                
            }
      
            averageValue = sumOfValues/numbers.Count;
            numbers.average = average;
            numbers.max = max;
            numbers.min = min;
            return Values;
            
        }
    }
}
