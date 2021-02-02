﻿using System;

namespace EmpWageComputationProgram
{
    class EmpWageBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            //Constant
            int IS_PRESENT = 1;
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 0;
            int EMP_RATE_PER_HOUR = 20;

            //Variables  
            int empHrs;
            int empWage;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            int workingTime = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                switch (workingTime)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                }
            } 
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Daily Wage: " + empWage);
        }
    }
}