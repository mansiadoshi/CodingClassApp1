﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingClassApp1
{
    /// <summary>
    /// CSharp Class details
    /// </summary>
    class CSharpClass
    {

        #region Properties
        private static int LastQRCode = 0;
        /// <summary>
        /// Generates QR code for the class
        /// </summary>
        public int QRCode { get; set; }
        /// <summary>
        /// Start date for the class
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// End date for the class
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Total students enrolled in the class
        /// </summary>
        private int TotalStudentsEnrolled { get; set; }
        /// <summary>
        /// Duration of the class
        /// </summary>
        public int DurationOfClass { get; set; }
        /// <summary>
        /// Minimum students for the class
        /// </summary>
        private int MinLimit{ get; set; }
        /// <summary>
        /// Maximum students for the class
        /// </summary>
        private int MaxLimit { get; set; }
        /// <summary>
        /// Class Tuition
        /// </summary>
        public double ClassFee { get; set; }

        #endregion
        #region Constructors
        public CSharpClass()
        {
            QRCode = ++LastQRCode;
            StartDate = DateTime.Now;
        }
        #endregion
        #region Methods
        /// <summary>
        /// This method generates Class ID
        /// </summary>
        /// <param name="TotalStudents">Student Count</param>
        /// <returns>Returns ID</returns>
        private void ClassID(int TotalStudents)
        {
            for (int i = 1; i <= TotalStudents; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Checks Fee is paid or not
        /// Not very sure about this method as I want to also check if fee is paid by every student
        /// </summary>
        /// <param name="ClassTuition"></param>
        private void ClassFeePaid(int ClassTuition)
        {
            if (ClassTuition == ClassFee)
                Console.WriteLine("Fee Paid");
            else
                Console.WriteLine("Fee not paid");
        }
        /// <summary>
        /// Cancels class if enrolled students don't meet the minimum class limit
        /// </summary>
        private void CancelClass()
        {
            if (TotalStudentsEnrolled <= 2)
            {
                Console.WriteLine("Class is cancelled");
            }
        }

        //public static implicit operator CSharpClass(CSharpClass v)
       /* {
            throw new NotImplementedException();
        }*/

        #endregion
    }
}
