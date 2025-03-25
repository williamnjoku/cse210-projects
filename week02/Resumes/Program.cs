using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2022;
        job1._startYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._endYear = 2023;
        job2._startYear = 2021;

        Job job3 = new Job();
        job3._jobTitle = "Assistant";
        job3._company = "Tesla";
        job3._endYear = 2021;
        job3._startYear = 2015;

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);
        resume1._name = "Allison Rose";

        resume1.DisplayResume();
        


    }
}