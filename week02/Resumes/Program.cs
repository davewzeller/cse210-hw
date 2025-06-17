using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //Console.WriteLine(job1._company);
     //   job1.Display();
     //   job2.Display();


        Resumes name1 = new Resumes();
        name1._name = "Allison Rose";

        name1._jobs.Add(job1);
        name1._jobs.Add(job2);

        name1.Display();

    }
}