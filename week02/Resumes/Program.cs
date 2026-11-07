using System;

class Program
{
    static void Main(string[] args)
    {   
        //
        Job job1 = new Job();
        //
        job1._jobTitle = "Elite Soldier";
        job1._company = "Frieza Force";
        job1._firstYear = 755;
        job1._endYear = 762;

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "HFIL";
        job2._firstYear = 762;
        job2._endYear = 870;
    
        //
        Resume myResume = new Resume();
        myResume._name = "Cui";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}