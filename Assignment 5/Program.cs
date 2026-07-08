using System;

namespace Assignment5_CustomException
{
    // Custom Exception
    class LateSubmissionException : Exception
    {
        public LateSubmissionException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void CheckSubmission(int submissionDay, int deadline)
        {
            if (submissionDay > deadline)
            {
                throw new LateSubmissionException("Exam form submitted after the deadline.");
            }

            Console.WriteLine("Exam form submitted successfully before the deadline.");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Submission Day: ");
            int submissionDay = Convert.ToInt32(Console.ReadLine());

            int deadline = 10;

            try
            {
                CheckSubmission(submissionDay, deadline);
            }
            catch (LateSubmissionException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}