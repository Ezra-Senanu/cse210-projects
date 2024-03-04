using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
        job1._jobTitle = "Missionary";
        job1._company = "LDS Church";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Tutor";
        job2._company = "BYU-I";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._jobTitle = "Accounts-Specialist";
        job3._company = "BYU-I";
        job3._startYear = 2023;
        job3._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Ezra Senanu";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();

         
    }
}